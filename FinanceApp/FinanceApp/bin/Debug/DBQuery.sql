/*Create database FinanceApp



CREATE FUNCTION dbo.chekcTableExist
(
 @tableval nvarchar(50)
)
Returns bit
AS
Begin
	Declare @value bit
	Declare @tablename nvarchar(50)
	set @value = 0
	select @tablename = Table_name from Information_schema.Tables where	Table_name = @tableval
	if (@tablename is not null)
	Begin
		set @value = 1
	End
	Return @value
End
*/ 

if( dbo.chekcTableExist('Address') != 1)
Begin
Create table Address(
id int identity(1,1)  primary key not null,
street nvarchar(50) null,
city nvarchar(50) null,
state nvarchar(50) null,
zip int null)
End

if( dbo.chekcTableExist('Users') != 1)
Begin
Create table Users(
id int identity(1,1)  primary key not null,
name nvarchar(50) not null,
permenentaddr int foreign key references Address(id) not null,
presentaddr int foreign key references Address(id) not null,
email nvarchar(250) null,
phone int null,
occupation nvarchar(100) null,
income int null,
limit int null,
role nvarchar(50) not null,
image image null)
End

if( dbo.chekcTableExist('LoanType') != 1)
Begin
Create table LoanType(
id int identity(1,1)  primary key not null,
typename nvarchar(50) not null)
End

if( dbo.chekcTableExist('Loan') != 1)
Begin
Create table Loan(
id int identity(1,1)  primary key not null,
user_id int foreign key references users(id) not null,
loantype_id int foreign key references LoanType(id) not null,
amoutn int not null,
intrest int default(36) not null,
status bit not null,
startdate datetime not null,
enddate datetime not null,
approved int foreign key references users(id))
End

if( dbo.chekcTableExist('DailyIntrest') != 1)
Begin
Create table DailyIntrest(
id int identity(1,1)  primary key not null,
loan_id int foreign key references users(id) not null,
surety int foreign key references users(id))
End

if( dbo.chekcTableExist('Finance') != 1)
Begin
Create table Finance(
id int identity(1,1)  primary key not null,
loan_id int foreign key references Loan(id) not null,
duedate datetime not null,
period int not null)
End

if( dbo.chekcTableExist('collection') != 1)
Begin
Create table collection( 
id int identity(1,1)  primary key not null,
loan_id int foreign key references Loan(id) not null,
collectiondate datetime  not null,
amoutn int not null)
End

if( dbo.chekcTableExist('LoanExtantion') != 1)
Begin
Create table LoanExtantion(
id int identity(1,1)  primary key not null,
loan_id int foreign key references Loan(id) not null,
extendeddate datetime not null,
description nvarchar(500) not null,
extracharge int not null)
End

