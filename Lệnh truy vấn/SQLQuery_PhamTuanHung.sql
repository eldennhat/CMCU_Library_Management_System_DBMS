go
use LibraryDB
go

-- Danh m?c các ??u sách còn trong th? vi?n
SELECT 
	bc.BookId, 
	bc.CopyId, 
	b.Title,	 
	bc.Status 
FROM dbo.BookCopy bc JOIN dbo.Book b ON b.BookId = bc.BookId 
WHERE bc.Status = 1

-- Danh sách ??u sách sách ???c m??n ít nh?t
SELECT  
  	b.Title,  
  	b.BookAuthor,  
	b.PublishYear, 
	COUNT(ld.LoanDetailId) [S? l?n m??n] 
FROM dbo.Book b  
LEFT JOIN dbo.BookCopy bc ON bc.BookId = b.BookId  
LEFT JOIN dbo.LoanDetail ld ON ld.CopyId = bc.CopyId  
GROUP BY b.Title, b.BookAuthor, b.PublishYear 
HAVING COUNT(ld.LoanDetailId) = 1 

-- Top 2 ngày có nhi?u phi?u m??n nh?t
SELECT TOP 2 
	CAST(l.LoanDate AS DATE) AS [Ngày m??n],  
	COUNT(l.LoanId) AS [S? l??ng phi?u m??n]  
FROM dbo.Loan l  
GROUP BY CAST(l.LoanDate AS DATE)  
ORDER BY [S? l??ng phi?u m??n] DESC 

-- ??a ra nhân viên t?o nhi?u phi?u m??n nh?t
SELECT TOP 1
	s.StaffId, 
	s.FullName, 
	COUNT(l.LoanId) AS [S? l?n t?o l?n m??n] 
FROM dbo.Staff s 
JOIN dbo.Loan l ON l.StaffId = s.StaffId 
GROUP BY s.StaffId, s.FullName 
ORDER BY [S? l?n t?o l?n m??n] DESC 

-- Th?ng kê Top 3 ??c gi? có t?ng ti?n ph?t nhi?u nh?t
SELECT TOP 3 with TIES
	r.ReaderId,
	r.FullName,
	SUM(ld.Fine) [T?ng ti?n ph?t]
FROM dbo.Reader r
join dbo.Loan l on l.ReaderId = r.ReaderId
join dbo.LoanDetail ld on ld.LoanId = l.LoanId
WHERE ld.Fine IS NOT NULL AND ld.Fine > 0
GROUP BY r.ReaderId, r.FullName
ORDER BY [T?ng ti?n ph?t] DESC
