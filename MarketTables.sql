create database Market
Use Market

create table Employees(
	Id int primary key identity,
	[Name] nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DutyId int references Duties(ID),
	Salary money
)
create table Duties(
	Id int primary key identity,
	[Name] nvarchar(50) not null
)
create table Filials(
	Id int primary key identity,
	[Name] nvarchar(50) not null
)

create table Products(
	Id int primary key identity,
	[Name] nvarchar(50) not null,
	BuyingPrice money,
	OrderPrice money
)

create table Orders(
	Id int primary key identity,
	ProductId int references Products(Id),
	EmployeeId int references Employees(Id),
	FilialId int references Filials(Id),
	OrderTime datetime default getdate()
)
