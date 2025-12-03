USE LibraryDB2;
GO

CREATE PROCEDURE sp_CreateLoan
    @ReaderId INT,
    @StaffId INT,
    @DueDate DATE,
    @CopyIds VARCHAR(MAX) -- Chuỗi các ID, ví dụ: '1,5,9'
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    BEGIN TRY
        -- 1. KIỂM TRA: Tất cả sách có 'Available' (Status=0) không?
        -- Nếu tìm thấy bất kỳ sách nào trong danh sách mà Status != 0 -> Lỗi
        IF EXISTS (
            SELECT 1 
            FROM BookCopy 
            WHERE CopyId IN (SELECT value FROM STRING_SPLIT(@CopyIds, ','))
              AND [Status] != 0
        )
        BEGIN
            THROW 51000, N'Một trong các cuốn sách không sẵn sàng để mượn.', 1;
        END

        -- 2. TẠO PHIẾU MƯỢN (LOAN)
        INSERT INTO Loan (ReaderId, StaffId, LoanDate, DueDate)
        VALUES (@ReaderId, @StaffId, SYSDATETIME(), @DueDate);

        -- Lấy ID vừa tạo
        DECLARE @NewLoanId INT = SCOPE_IDENTITY();

        -- 3. THÊM CHI TIẾT (LOAN DETAIL) & CẬP NHẬT TRẠNG THÁI (BOOK COPY)
        -- Chúng ta làm 1 lần cho tất cả các sách trong danh sách
        
        -- Bảng tạm chứa các ID cần xử lý
        SELECT CAST(value AS INT) AS CopyId 
        INTO #TempCopyIds 
        FROM STRING_SPLIT(@CopyIds, ',');

        -- Insert vào LoanDetail (Tính Deposit = BookMoney * 2)
        INSERT INTO LoanDetail (LoanId, CopyId, ReturnedDate, Deposit)
        SELECT 
            @NewLoanId, 
            t.CopyId, 
            NULL, 
            (ISNULL(bc.BookMoney, 0) * 2) -- Tính tiền cọc
        FROM #TempCopyIds t
        JOIN BookCopy bc ON t.CopyId = bc.CopyId;

        -- Update trạng thái sách thành 'OnLoan' (1)
        UPDATE BookCopy
        SET [Status] = 1
        WHERE CopyId IN (SELECT CopyId FROM #TempCopyIds);

        -- Dọn dẹp bảng tạm
        DROP TABLE #TempCopyIds;

        -- Chốt giao dịch
        COMMIT TRANSACTION;
        
        -- Trả về ID phiếu mượn để Python biết
        SELECT @NewLoanId AS NewLoanId;

    END TRY
    BEGIN CATCH
        -- Nếu có lỗi, hủy bỏ tất cả
        ROLLBACK TRANSACTION;
        
        -- Ném lỗi ra để Python bắt được
        THROW;
    END CATCH
END;
GO


CREATE PROCEDURE sp_AddReader
    @FullName NVARCHAR(255),
    @Phone NVARCHAR(255),
    @Address NVARCHAR(255)
AS
BEGIN
    -- 2. THÊM MỚI
    INSERT INTO Reader (FullName, Phone, [Address])
    VALUES (@FullName, @Phone, @Address);

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS NewReaderId;
END;
GO

--
CREATE PROCEDURE sp_AddBook
    @ISBN VARCHAR(255),
    @Title NVARCHAR(255),
    @CategoryName NVARCHAR(255),
    @BookAuthor NVARCHAR(255),
    @PublishYear SMALLINT
AS
BEGIN
    -- 2. THÊM MỚI
    INSERT INTO Book (ISBN, Title, CategoryName, BookAuthor, PublishYear) 
    VALUES (@ISBN, @Title, @CategoryName, @BookAuthor, @PublishYear)

END;
GO

--
CREATE sp_SearchBook
    @Keyword NVARCHAR(255)
AS
BEGIN
    DECLARE @SearchTerm NVARCHAR(257) = N'%' + @Keyword + N'%';

    SELECT 
        BookId, 
        ISBN, 
        Title, 
        CategoryName, 
        BookAuthor, 
        PublishYear
    FROM Book
    WHERE Title LIKE @SearchTerm 
       OR BookAuthor LIKE @SearchTerm;
END;

GO
EXEC sp_SearchBook @Keyword = N'Lập'