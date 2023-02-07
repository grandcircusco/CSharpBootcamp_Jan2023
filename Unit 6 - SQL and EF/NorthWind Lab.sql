--Use Northwind;

--1
--SELECT * FROM Customers;

--2
--SELECT DISTINCT Country FROM Customers;

--3
--SELECT * FROM Customers
--WHERE CustomerID LIKE 'BL%';
--WHERE CHARINDEX('ON', CustomerID)>0; --Alt command

--4
--SELECT TOP 100 * FROM Orders;

--5
--SELECT * FROM Customers
--WHERE PostalCode = '1010' OR PostalCode = '3012' OR PostalCode = '12209' OR PostalCode = '05023';

--6
--SELECT * FROM Orders
--WHERE ShipRegion IS NOT NULL;

--7
--SELECT * FROM Customers
--ORDER BY Country, City;

--8
--INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
--VALUES ('THJKR','Jokes on You', 'The Joker', 'Chief Entertainment Officer', 'P.O Box HAHAHA', 'Detroit', 'MI', '48825', 'USA', '(313)-555-3333', '313-555-4444');
--SELECT * FROM Customers;

--9
--UPDATE Orders 
--SET ShipRegion = 'EuroZone'
--WHERE ShipCountry = 'France';
--SELECT * FROM Orders;

--10
--SELECT * FROM [Order Details]
--WHERE Quantity = 1;
--DELETE FROM [Order Details]
--WHERE Quantity = 1;

--11
--SELECT CustomerId FROM Orders
--WHERE OrderID = '10290';

--12
--SELECT * FROM Orders
--JOIN Customers ON Orders.customerid = Customers.CustomerID;

--13
--SELECT * FROM Employees;
--SELECT FirstName FROM Employees
--WHERE ReportsTo IS NULL;

--14
--SELECT FirstName FROM Employees
--WHERE ReportsTo = 2;


-------------------------------------------------------------------------------------------

--1
--SELECT AVG(Quantity) AS 'Avg', MAX(Quantity) AS 'MAX', MIN(Quantity) AS 'Min' FROM [Order Details]
--GROUP BY OrderID;

--2
--SELECT AVG(Quantity) AS 'Avg', MAX(Quantity) AS 'MAX', MIN(Quantity) AS 'Min' FROM [Order Details];

--3
--SELECT * FROM Customers
--WHERE City = 'London' OR City = 'Paris';

--4
--SELECT * FROM Orders
--INNER JOIN Customers ON Orders.customerid = Customers.CustomerID;
--SELECT * FROM Orders
--LEFT JOIN Customers ON Orders.customerid = Customers.CustomerID;
--SELECT * FROM Orders
--RIGHT JOIN Customers ON Orders.customerid = Customers.CustomerID;

--5
--SELECT DISTINCT City FROM Customers
--WHERE City IS NOT NULL;

--6
--SELECT FirstName FROM Employees
--ORDER BY FirstName;

--7
--SELECT SUM(UnitPrice * Quantity) AS 'Total', SUM((UnitPrice * Quantity) * (1 - Discount)) AS 'Discounted Total' FROM [Order Details]
--GROUP BY OrderID;

--8
--SELECT * FROM Employees
--WHERE HireDate >= '1/1/1994';

--9
--SELECT  SUM(2023 - YEAR(HireDate)) AS 'Years' FROM Employees
--Group BY EmployeeID;

--10
--SELECT * FROM Products
--ORDER BY UnitsInStock ASC;
--SELECT * FROM Products
--ORDER BY UnitsInStock DESC;

--11
--SELECT * FROM Products
--WHERE UnitsInStock < 6;

--12
--SELECT * FROM Products
--WHERE Discontinued = 1;

--13
--SELECT * FROM Products
--WHERE ProductName LIKE '%Tofu%';

--14
--SELECT ProductName FROM Products
--WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products);

--15
--SELECT * FROM Employees
--WHERE HireDate > '1/1/1993';

--16
--SELECT * FROM Employees
--WHERE TitleOfCourtesy = 'Ms.' OR TitleOfCourtesy = 'Mrs.';

--17
SELECT * FROM Employees
WHERE HomePhone LIKE '(206)%';