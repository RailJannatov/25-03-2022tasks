CREATE DATABASE MARKET

USE MARKET


CREATE TABLE Position(
Id INT PRIMARY KEY IDENTITY,
[NAME] NVARCHAR(50)
)
CREATE TABLE Branche(
Id INT PRIMARY KEY IDENTITY,
[NAME] NVARCHAR(50)
)
CREATE TABLE Product(
Id INT PRIMARY KEY IDENTITY,
[NAME] NVARCHAR(100),
PurchasePrice FLOAT,
SellingPrice FLOAT
)

CREATE TABLE Employee(
Id INT PRIMARY KEY IDENTITY,
SAA NVARCHAR(100),
PositionId INT REFERENCES Position(Id),
Salary  MONEY
)
CREATE TABLE Sales(
Id INT PRIMARY KEY IDENTITY,
ProductId INT REFERENCES Product(Id),
EmployeeId INT REFERENCES Employee(Id),
BranchId INT REFERENCES Branche(Id),
SoldDATE DATE defAULT GETDATE()
)

SELECT
Employee.SAA,
Product.NAME as 'ProductName',
Branche.NAME as 'BranchName',
Product.SellingPrice as 'SatishQiymeti'
FROM Sales
JOIN Product
ON Sales.ProductId=Product.Id
JOIN Branche
ON Sales.BranchId=Branche.Id
JOIN Employee
ON Sales.EmployeeId = Employee.Id

SELECT SUM(Product.SellingPrice)
FROM Sales
JOIN Product
ON Sales.ProductId = Product.Id

SELECT SUM(Product.SellingPrice)
FROM Sales
JOIN Product
ON Sales.ProductId = Product.Id
WHERE MONTH(Sales.SoldDATE) = MONTH(getdate()) and YEAR(Sales.SoldDATE) = YEAR(getdate())








