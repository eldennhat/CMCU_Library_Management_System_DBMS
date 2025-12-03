go
use LibraryDB
go
--Danh sách các độc giả mượn sách quá hạn. (Hoàng)
SELECT 
	r.ReaderId, r.FullName, r.Phone, l.LoanId,
	ld.CopyId, bc.Barcode, l.LoanDate, l.DueDate,
	DATEDIFF (DAY, l.DueDate, GETDATE() ) AS [Số ngày quá hạn]
FROM LoanDetail ld
JOIN Loan l ON ld.LoanId = l.LoanId
JOIN Reader R ON l.ReaderId = r.ReaderId
JOIN BookCopy bc ON ld.CopyId = bc.CopyId
WHERE 
    ld.ReturnedDate IS NULL
    AND l.DueDate < GETDATE();


--Danh sách độc giả mượn từ 2 lần trở lên trong tháng. (Hoàng)
SELECT 
	r.ReaderId, 
	r.FullName, 
	r.Phone, 
	YEAR(l.LoanDate) AS [Năm mượn], 
	MONTH(l.LoanDate) AS [Tháng mượn], 
	COUNT(l.LoanId) AS [Số lần mượn] 
FROM Loan AS l 
JOIN Reader r ON l.ReaderId = r.ReaderId 
GROUP BY 
	r.ReaderId, 
	r.FullName, 
	r.Phone, 
	YEAR(l.LoanDate), 
	MONTH(l.LoanDate) 
HAVING COUNT(l.LoanId) >= 2 
ORDER BY [Năm mượn] DESC, [Tháng mượn] DESC, [Số lần mượn] DESC;

--Đưa ra 3 đầu sách được mượn nhiều nhất. (Hoàng)
SELECT TOP 3 
	B.BookId, 
	B.Title, 
	B.BookAuthor, 
	COUNT(ld.LoanDetailId) AS [Số lần được mượn]
FROM LoanDetail ld
JOIN BookCopy bc ON ld.CopyId = bc.CopyId
JOIN Book b ON bc.BookId = b.BookId
GROUP BY b.BookId, b.Title, b.BookAuthor
ORDER BY COUNT(ld.LoanDetailId) DESC;

--Đếm số đầu sách đang quản lý tại thư viện  theo năm xuất bản. (Hoàng)
SELECT 
    PublishYear,
    COUNT(*) AS [Tổng số sách]
FROM Book
GROUP BY PublishYear
ORDER BY COUNT(*) DESC;

--Thông tin số lượng tồn kho của sách bao gồm số lượng sách tồn kho (Theo trạng thái có sẵn). (Hoàng)

SELECT
    b.BookId,
    b.Title,
    b.BookAuthor,
    COUNT(bc.CopyId) AS [Bản sao có sẵn]
FROM Book AS b
LEFT JOIN BookCopy bc 
    ON b.BookId = bc.BookId
    AND bc.Status = 0 
GROUP BY b.BookId, b.Title, b.BookAuthor
HAVING COUNT(bc.CopyId) >= 1
ORDER BY [Bản sao có sẵn] DESC;

