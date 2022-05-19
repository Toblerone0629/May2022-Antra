USE AdventureWorks2019
GO

--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set
SELECT *
FROM Person.CountryRegion
ORDER BY CountryRegionCode

SELECT *
FROM Person.StateProvince
ORDER BY CountryRegionCode

SELECT Person.CountryRegion.Name AS Country, Person.StateProvince.Name AS Province
FROM Person.CountryRegion
LEFT JOIN Person.StateProvince
ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode

--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.

--Using Northwind Database
USE 