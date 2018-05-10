--create database Emulator_ATM
--use Emulator_ATM
Create table tbl_Customer
(
	CustID int identity(1,1) primary key,
	Name nvarchar(100),
	Phone varchar(11),
	Email varchar(150),
	Addr nvarchar(200)
);
Create table tbl_OverDraft
(
	ODID int identity(1,1) primary key,
	value int
);
Create table tbl_WithDraft
(
	WDID int identity(1,1) primary key,
	value int
);
create table tbl_Account 
(
	AcountID int identity(1,1) primary key,
	Balance int,
	AccountNo varchar(21),
	CustID int foreign key references tbl_Customer(CustID),
	ODID int foreign key references tbl_OverDraft(ODID),
	WDID int foreign key references tbl_WithDraft(WDID),
);
create table tbl_Money
(
	MoneyID int identity(1,1) primary key,
	MoneyValuee int
);
create table tbl_Card
(
	CardNo int identity(1,1) primary key,
	AcountID int foreign key references tbl_Account(AcountID),
	PIN int,
	StartDate date,
	ExpiredDate date,
	Attempt int,
	Status int
);
create table tbl_LogType
(
	LogTypeID int identity(1,1) primary key,
	Description nvarchar(200)
);
Create table tbl_ATM
(
	ATMID int identity(1,1) primary key,
	Branch nvarchar(50),
	Addr nvarchar(200)
);
create table tbl_Log
(
	LogID int identity(1,1) primary key,
	LogTypeID int foreign key references tbl_LogType(LogTypeID),
	CardNo int foreign key references tbl_Card(CardNo),
	ATMID int foreign key references tbl_ATM(ATMID),
	LogDate datetime,
	Amount int,
	Details nvarchar(200),
	CardToNo int
);
create table tbl_Stock
(
	StockID int identity(1,1) primary key,
	MoneyID int foreign key references tbl_Money(MoneyID),
	ATMID int foreign key references tbl_ATM(ATMID),
	Quantily int
);
create table tbl_Config
(
	ID int identity(1,1) primary key,
	DateModified datetime,
	MinWithDraw int,
	MaxWithDraw int,
	NumPerPage int
);