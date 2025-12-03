if  db_id('LibraryDB') is null
	create database LibraryDB

go
use LibraryDB
go

-- Sách
create table Book
(
	BookId int identity(1,1) primary key,
	ISBN varchar(255) not null unique,
	Title nvarchar(255) not null,
	CategoryName nvarchar(255) not null,
	BookAuthor nvarchar(255) not null,
	PublishYear smallint null,
	
	constraint CK_Book_PublishYear check (PublishYear between 868 and year(getdate()))
)
go

-- Bản sao sách
create table BookCopy
(
	CopyId int identity(1,1) primary key,
	BookId int not null,
	Barcode varchar(255) not null unique, -- mã vạch
	StorageNote nvarchar(255) null, -- kệ của sách
	BookMoney decimal(20,0) null, -- tiền sách
	PublisherName nvarchar(255) not null,
	[Status] smallint NOT NULL default 0, -- -1: Lost, 0: Available, 1: OnLoan, 2: Damaged
    CONSTRAINT CK_Copy_Status check ([Status] IN (-1,0,1,2)),
	constraint FK_Copy_Book foreign key(BookId) references Book(BookId) on delete cascade
)
go

-- Độc giả
create table Reader
(
	ReaderId int identity(1,1) primary key,
	FullName nvarchar(255) not null,
	Phone nvarchar(255) not null,
	[Address] nvarchar(255) not null,
	CreateAt datetime2 not null default sysdatetime() -- lưu thời điểm bản ghi được tạo
)
go

-- Nhân viên
create table Staff
(
	StaffId int identity(1,1) primary key,
	FullName nvarchar(255) not null,
	Phone nvarchar(255) not null,
	DefaultStart time(0) null,  -- giờ vào ca mặc định (vd 08:00)
    DefaultEnd time(0) null, -- giờ hết ca mặc định (vd 17:00)
)
go

-- Phiếu mượn
create table Loan
(
	LoanId int identity(1,1) primary key,
	ReaderId int not null,
	StaffId int not null,
	LoanDate datetime2 not null default sysdatetime(),
	DueDate datetime2 not null,
	Note nvarchar(255) null,

	constraint FK_Loan_Reader foreign key(ReaderId) references Reader(ReaderId),
	constraint FK_Loan_Staff foreign key(StaffId) references Staff(StaffId),
	constraint CK_Loan_Due check (DueDate >= LoanDate)
)
go
go

-- Chi tiết phiếu mượn
create table LoanDetail
(
	LoanDetailId int identity(1,1) primary key,
	LoanId int not null,
	CopyId int not null,
	ReturnedDate datetime2 null,
	Fine decimal(20,0) null, -- tiền phạt (nếu ReturnDate sau DueDate thì Fine tự động + 20000/1 ngày trả muộn, nếu sau 10 ngày ReturnedDate vẫn chưa trả thì Fine gấp đôi tiền sách. Bắt đầu tính từ LoanDate)
	Deposit decimal(20, 0) null, -- tiền cọc (gấp đôi tiền sách) 

	constraint UQ_LoanDetail_Copy unique (CopyId, LoanId),
	constraint FK_LoanDetail_Loan foreign key(LoanId) references Loan(LoanId) on delete cascade,
	constraint FK_LoanDetail_Copy foreign key(CopyId) references BookCopy(CopyId)
)
go

-- Tài khoản đăng nhập
create table Account
(
	AccountId int primary key identity(1,1),
	Username varchar(50) not null unique,
	PasswordHash varchar(255) not null,
	[Role] nvarchar(50) not null, -- 'Admin' hoặc 'Librarian'
	StaffId int null, -- liên kết với nhân viên (có thể null cho admin hệ thống)

	constraint CK_Account_Role check (Role in (N'Admin', N'Librarian')),
	constraint FK_Account_Staff foreign key(StaffId) references Staff(StaffId)
)
go

insert into Staff (FullName, Phone, DefaultStart, DefaultEnd)
values 
	(N'Nguyễn Thành An', N'0123456789', '07:00', '10:00'),
	(N'Nguyễn Nhật Minh Quang', N'0123456789', '11:00', '14:00'),
	(N'Đinh Nguyên Hoàng', N'9876543210', '08:00', '16:00'),
	(N'Phạm Tuấn Hưng', N'9876543210', '16:00', '19:00')
go

-- Mặc định 2 tài khoản đăng nhập được cấp phát bởi dev
insert into Account (Username, PasswordHash, [Role], StaffId)
values 
	('admin', '123', N'Admin', null), --username: admin, password: admin123
	('librarian1', '123', N'Librarian', 1),
	('librarian2', '123', N'Librarian', 2),
	('librarian3', '123', N'Librarian', 3),
	('librarian4', '123', N'Librarian', 4)
go









