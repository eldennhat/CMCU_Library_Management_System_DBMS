go
use LibraryDB
go

--Index UQ__BookCopy__177800D35FB181E0
IF EXISTS (SELECT name FROM sys.indexes 
           WHERE name = 'PK__BookCopy__C26CCCC5081B8F3A'
           AND object_id = OBJECT_ID('BookCopy'))
BEGIN
   	ALTER TABLE BookCopy
    DROP CONSTRAINT PK__BookCopy__C26CCCC5081B8F3A;
END
GO
ALTER TABLE BookCopy
ADD CONSTRAINT PK__BookCopy__C26CCCC5081B8F3A
	--(có thể dổi tên khác)
PRIMARY KEY CLUSTERED (CopyId);
GO;


--Index PK__Reader__8E67A5E1AFC0F811
IF EXISTS (SELECT name FROM sys.indexes 
           WHERE name = 'PK__Reader__8E67A5E1AFC0F811'
           AND object_id = OBJECT_ID('Reader'))
BEGIN
  	ALTER TABLE Reader
    DROP CONSTRAINT PK__Reader__8E67A5E1AFC0F811;
END
GO
ALTER TABLE Reader
ADD CONSTRAINT PK__Reader__8E67A5E1AFC0F811 
--(có thể dổi tên khác)
PRIMARY KEY CLUSTERED (ReaderId);
GO
