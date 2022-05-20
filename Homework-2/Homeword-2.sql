USE AdventureWorks2019
GO

--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set
SELECT Person.CountryRegion.Name AS Country, Person.StateProvince.Name AS Province
FROM Person.CountryRegion
JOIN Person.StateProvince
ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode

--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
SELECT Person.CountryRegion.Name AS Country, Person.StateProvince.Name AS Province
FROM Person.CountryRegion
JOIN Person.StateProvince
ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode
WHERE Person.CountryRegion.Name IN ('Germany', 'Canada')
ORDER BY Person.CountryRegion.Name, Person.StateProvince.Name


--Using Northwind Database
USE Northwind
GO

--3. List all Products that has been sold at least once in last 25 years
SELECT DISTINCT Products.ProductName
FROM Products
JOIN [Order Details]
ON Products.ProductID = [Order Details].ProductID
RIGHT JOIN Orders
ON [Order Details].OrderID = dbo.Orders.OrderID
WHERE DATEDIFF(YEAR, GETDATE(), Orders.OrderDate) <= 25
ORDER BY Products.ProductName


--4. List top 5 locations (Zip Code) where the products sold most in last 25 years
SELECT TOP 5 ShipPostalCode, COUNT(ShipPostalCode) AS SoldTimes
FROM Orders
WHERE DATEDIFF(YEAR, GETDATE(), Orders.OrderDate) <= 25
GROUP BY ShipPostalCode
ORDER BY SoldTimes DESC

--5. List all city names and number of customers in that city
SELECT ShipCity, COUNT(DISTINCT CustomerID) AS CustomersInCity
FROM Orders
GROUP BY ShipCity
ORDER BY CustomersInCity DESC

--6.List city names which have more than 2 customers, and number of customers in that city
SELECT ShipCity, COUNT(DISTINCT CustomerID) AS CustomersInCity
FROM Orders
GROUP BY ShipCity 
HAVING COUNT(DISTINCT CustomerID) > 2
ORDER BY CustomersInCity DESC

--7. Display the names of all customers  along with the  count of products they bought
SELECT Customers.ContactName, SUM([Order Details].Quantity) AS NumberOfProducts
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
GROUP BY Customers.ContactName
ORDER BY Customers.ContactName

--8. Display the customer ids who bought more than 100 Products with count of products
SELECT Customers.CustomerID, SUM([Order Details].Quantity) AS NumberOfProducts
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
GROUP BY Customers.CustomerID
HAVING SUM([Order Details].Quantity) > 100
ORDER BY Customers.CustomerID

--9. List all of the possible ways that suppliers can ship their products
/*
SELECT * FROM Orders
SELECT * FROM [Order Details]
SELECT * FROM Products
SELECT * FROM Shippers
SELECT * FROM Suppliers
*/
SELECT DISTINCT Suppliers.CompanyName AS [Supplier Company Name], Shippers.CompanyName AS [Shipping Company Name]
FROM Suppliers 
JOIN Products ON Suppliers.SupplierID = Products.SupplierID
JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
JOIN Orders ON [Order Details].OrderID = Orders.OrderID
JOIN Shippers ON Shippers.ShipperID = Orders.ShipVia
ORDER BY Suppliers.CompanyName

--10. Display the products order each day. Show Order date and Product Name
SELECT Orders.OrderDate, Products.ProductName
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
ORDER BY Orders.OrderDate

--11. Displays pairs of employees who have the same job title
SELECT DISTINCT (e.FirstName + ' ' + e.LastName) AS FullName1, e.Title, (e2.FirstName + ' ' + e2.LastName) AS FullName2, e2.Title
FROM Employees e, Employees e2
WHERE e.Title = e2.Title AND e.EmployeeID != e2.EmployeeID

--12. Display all the Managers who have more than 2 employees reporting to them
--SELECT * FROM Employees
--SELECT * FROM EmployeeTerritories
--SELECT * FROM Territories
SELECT e.FirstName, COUNT(e2.ReportsTo) AS EmployeesReportTo
FROM Employees e
JOIN Employees e2
ON e.EmployeeID = e2.ReportsTo
GROUP BY e.FirstName
HAVING COUNT(e2.ReportsTo) > 2

--13. Display the customers and suppliers by city
--SELECT * FROM Customers
--SELECT * FROM Suppliers
SELECT CompanyName, City
FROM Customers
UNION ALL
SELECT CompanyName, City
FROM Suppliers
ORDER BY City

--14. List all cities that have both Employees and Customers
SELECT DISTINCT City
FROM Employees
WHERE City IN (SELECT City FROM Customers)

--15. List all cities that have Customers but no Employee
----a. Use Sub-query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (SELECT City FROM Employees)

----b. Not Use Sub-query
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e
ON c.City = e.City
WHERE e.City IS NULL

--16. List all products and their total order quantities throughout all orders
SELECT ProductName, SUM(Quantity) AS [Total Order Quantities]
FROM Products
JOIN [Order Details]
ON Products.ProductID = [Order Details].ProductID
JOIN Orders
ON [Order Details].OrderID = Orders.OrderID
GROUP BY ProductName
ORDER BY ProductName

--17. List all Customer Cities that have at least two customers
----a. Use union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(City) >= 2
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(City) >= 2

----b. Use Sub-query and No Union
SELECT DISTINCT c1.City
FROM Customers c1
WHERE c1.City IN (SELECT c2.City FROM Customers c2 WHERE c1.CustomerID != c2.customerID)

--18. List all Customer Cities that have ordered at least two different kinds of products
SELECT DISTINCT City
FROM Customers
JOIN Orders
ON Orders.CustomerID = Customers.CustomerID
JOIN [Order Details]
ON [Order Details].OrderID = Orders.OrderID
GROUP BY City
HAVING COUNT([Order Details].ProductID) >= 2
ORDER BY City

--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it
SELECT TOP 5 Products.ProductName, Orders.ShipCity, COUNT([Order Details].Quantity) AS NumberOfProducts, AVG([Order Details].UnitPrice) AS AvePrice
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY Products.ProductName, Orders.ShipCity
ORDER BY SUM([Order Details].Quantity) DESC

--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
SELECT TOP 1 COUNT([Order Details].OrderID) AS NumerOfOrders, Orders.ShipCity
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY Orders.ShipCity
ORDER BY COUNT([Order Details].OrderID) DESC

SELECT TOP 1 SUM([Order Details].Quantity) AS NumerOfOrders, Orders.ShipCity
FROM [Order Details]
JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY Orders.ShipCity
ORDER BY SUM([Order Details].Quantity) DESC

--21. How do you remove the duplicates record of a table?
--		use DISTINCT or UNION 
