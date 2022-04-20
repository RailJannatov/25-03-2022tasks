/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Title]
      ,[Description]
      ,[Tags]
      ,[Rate]
      ,[Price]
      ,[DiscountPercent]
      ,[Tax]
      ,[Brand]
      ,[Code]
      ,[IsDeleted]
  FROM [PractiseP318].[dbo].[Products]

  SELECT * FROM Categories

  INSERT INTO Categories values ('Acer','ddsdsds-1.jpg',1,0,0)
