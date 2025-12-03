-- Danh sách các độc giả đang mượn sách.(An) 
USE LibraryDB2
GO


SELECT DISTINCT r.ReaderId, r.FullName AS TenDocGia, r.Phone AS SoDienThoai, ld.ReturnedDate
FROM Reader r 
JOIN Loan l ON r.ReaderId = l.ReaderId
JOIN LoanDetail ld ON ld.LoanId = l.LoanId
WHERE ld.ReturnedDate IS NULL
GO

-- Danh mục các bản sao sách đang được mượn.(An)
SELECT b.Title, bc.BookId, b.CategoryName, b.CategoryName, bc.Status
FROM Book b 
JOIN BookCopy bc ON b.BookId = bc.BookId
WHERE bc.Status = 1
GO

-- Đưa ra 5 người mượn sách nhiều nhất
SELECT TOP 5 r.ReaderId, r.FullName, r.Phone, COUNT(l.LoanId) AS [Số lượng mượn]
FROM Reader r 
JOIN Loan l ON r.ReaderId = l.ReaderId
GROUP BY r.ReaderId, r.FullName, r.Phone
ORDER BY COUNT(l.LoanId)  DESC

--Thống kê các đầu sách được quản lý tại thư viện theo năm xuất bản.(An) 
SELECT *
FROM Book b 
WHERE b.PublishYear < 2000
ORDER BY b.PublishYear ASC
GO

--Thống kê tổng số tiền phạt từ trước đến giờ của thư viện.(An) 
SELECT SUM(ld.Fine) AS [Tổng số tiền phạt]
FROM LoanDetail ld




