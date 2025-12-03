-- Trigger tự động tính Fine khi cập nhật ReturnedDate
if object_id('TRG_CalculateFine', 'TR') is not null
    drop trigger TRG_CalculateFine
go

create trigger TRG_CalculateFine
on LoanDetail
after insert, update
as
begin
    -- Chỉ chạy khi ReturnedDate được cập nhật
    if update(ReturnedDate)
    begin
        update ld
        set Fine = 
            case
                -- Chưa trả sách
                when i.ReturnedDate IS NULL then NULL
                
                -- Trả đúng hạn hoặc sớm
                when i.ReturnedDate <= l.DueDate then 0
                
                -- Trả trễ nhưng <= 10 ngày kể từ LoanDate
                when i.ReturnedDate > l.DueDate 
                     and datediff(day, l.LoanDate, i.ReturnedDate) <= 10
                then datediff(day, l.DueDate, i.ReturnedDate) * 20000
                
                -- Quá 10 ngày kể từ LoanDate -> phạt gấp đôi tiền sách
                else bc.BookMoney * 2
            end
        from LoanDetail ld
        inner join inserted i on ld.LoanDetailId = i.LoanDetailId
        inner join Loan l on ld.LoanId = l.LoanId
        inner join BookCopy bc on ld.CopyId = bc.CopyId;
    end
end
go
