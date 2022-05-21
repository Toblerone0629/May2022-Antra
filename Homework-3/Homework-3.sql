USE Northwind
GO

--1. Create a view named ¡°view_product_order_[your_last_name]¡±, 
--			list all products and total ordered quantity for that product.
--SELECT * FROM Products
CREATE VIEW view_product_order_liu
AS
SELECT DISTINCT ProductName, SUM([Order Details].Quantity) AS Total_Ordered_Quantity
FROM Products
JOIN [Order Details]
ON Products.ProductID = [Order Details].ProductID
GROUP BY ProductName

GO
DROP VIEW view_product_order_liu

GO
SELECT * FROM view_product_order_liu

--2. Create a stored procedure ¡°sp_product_order_quantity_[your_last_name]¡± 
--			that accept product id as an input and total quantities of order as output parameter
GO
CREATE PROC sp_product_order_quantity_liu
@Pid int,
@Total varchar(20) out
AS
BEGIN
SELECT @Total = SUM([Order Details].Quantity)
FROM Products
JOIN [Order Details]
ON Products.ProductID = [Order Details].ProductID
WHERE Products.ProductID = @Pid
GROUP BY Products.ProductID
END

BEGIN
DECLARE @result varchar(20)
EXEC sp_product_order_quantity_liu 1, @result OUT
PRINT @result
END

DROP PROCEDURE sp_product_order_quantity_liu

--3. Create a stored procedure ¡°sp_product_order_city_[your_last_name]¡± 
--			that accept product name as an input and top 5 cities that ordered most that product 
--			combined with the total quantity of that product ordered from that city as output
SELECT * FROM Products

GO
CREATE PROC sp_product_order_city_liu
@Pname varchar(20),
@Cities varchar(20) out,
@quantities varchar(20) out
AS
BEGIN
SELECT TOP 1 @Cities = ShipCity, @quantities = SUM([Order Details].Quantity)
FROM Orders
JOIN [Order Details]
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
WHERE @Pname = ProductName
GROUP BY ProductName, ShipCity
ORDER BY SUM([Order Details].Quantity) DESC
END

BEGIN
DECLARE @city varchar(20), @quan varchar(20)
EXEC sp_product_order_city_liu 'Chai', @city OUT, @quan OUT
PRINT @city + ' ' + @quan
END

DROP PROCEDURE sp_product_order_city_liu

--4. Create 2 new tables ¡°people_your_last_name¡± ¡°city_your_last_name¡±. 
--			City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--			People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, 
--				{Id: 3, Name: Jody Nelson, City:2}. 
--			Remove city of Seattle. If there was anyone from Seattle, put them into a new city ¡°Madison¡±. 
--			Create a view ¡°Packers_your_name¡± lists all people from Green Bay. 
--			If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
GO
CREATE TABLE people_your_last_name(Id int, FName varchar(20), CityId int)
INSERT INTO people_your_last_name VALUES(1, 'Aaron Rodgers', 2)
INSERT INTO people_your_last_name VALUES(2, 'Russel Wilson', 1)
INSERT INTO people_your_last_name VALUES(3, 'Jody Nelson', 2)

GO
CREATE TABLE city_your_last_name(CityId int, CityName varchar(20))
INSERT INTO city_your_last_name VALUES(1, 'Seattle')
INSERT INTO city_your_last_name VALUES(2, 'Green Bay')

SELECT * FROM people_your_last_name
SELECT * FROM city_your_last_name

UPDATE city_your_last_name
SET CityName = 'Madison'
WHERE CityId = 1

SELECT * FROM people_your_last_name
SELECT * FROM city_your_last_name

GO
CREATE VIEW Packers_your_name
AS
SELECT people_your_last_name.FName
FROM people_your_last_name
JOIN city_your_last_name
ON people_your_last_name.CityId = city_your_last_name.CityId
WHERE CityName = 'Green Bay'

GO
SELECT * FROM Packers_your_name

GO
DROP TABLE people_your_last_name
DROP TABLE city_your_last_name


--5. Create a stored procedure ¡°sp_birthday_employees_[you_last_name]¡± 
--			that creates a new table ¡°birthday_employees_your_last_name¡± 
--			and fill it with all employees that have a birthday on Feb. 
--			(Make a screen shot) drop the table. 
--			Employee table should not be affected
GO
CREATE PROC sp_birthday_employees_liu
AS
BEGIN
SELECT EmployeeID, LastName, FirstName, BirthDate
FROM Employees
WHERE MONTH(BirthDate) = 2
END

EXEC sp_birthday_employees_liu

SELECT * FROM Employees

--6. How do you make sure two tables have the same data?
--		use TableDiff() function which would compare two tables and return 0 if they are the same, return 1 for error
--			and return 2 for two tables are different.
--		use (Table A minus Table B) UNION (Table B minus Table A), it will return empty because nothing will exist in
--			A but not exist in B and exist in B but not exist in A when A and B are have same data