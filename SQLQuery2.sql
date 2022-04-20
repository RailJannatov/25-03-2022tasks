CREATE DATABASE BP202

--DROP DATABASE BP202

CREATE DATABASE BDU

DROP DATABASE BDU
USE BP202
USE Library
CREATE TABLE Student(
 Id int,
 [Name] nvarchar(40),
 Surname nvarchar(40),
 Age int
 )

 DROP TABLE Student

 CREATE DATABASE BP201

 USE BP201

 CREATE TABLE Student(
 Id int,
 [Name] nvarchar(50),
 Surname nvarchar(50),
 Age int
 )
 
 CREATE TABLE [Group](
 Id int,
 [Name] nvarchar(50),
 Capacity int,
 [Type] nvarchar(40)
 )
  
 CREATE TABLE Teacher(
 Id int,
 [Name] nvarchar(50),
 Capacity int,
 Age int,
 ProfType nvarchar(40)
 )
   
 CREATE TABLE Computer(
 Id int,
 [Name] nvarchar(50),
 Ram int,
 MemoryCard  nvarchar(50)	
 )

 DROP TABLE Computer

 SELECT * FROM Student

 SELECT Surname FROM Student


 INSERT INTO Student(Surname,Age) 
 VALUES ('Balash',24)

 SELECT * FROM Student

 UPDATE Student
 Set Surname = 'Ebdulxaliq'
 WHERE Surname = 'Eliyev'
  ALTER TABLE Student
 ADD [Time] date
 ALTER TABLE [Group]
 ADD [Time] DateTime
 INSERT INTO Student([Time])
 VALUES(2015-12-21)






