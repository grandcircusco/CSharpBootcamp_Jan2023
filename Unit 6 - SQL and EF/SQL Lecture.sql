--CREATE DATABASE LectureDB;

--USE LectureDB;

--surround column names with [ ] to use keywords
--Primary key sets up Identifier
--IDENTITY(1,1) Auto Increments  (Starting, value to go up by)

--CREATE TABLE SuperHeros(
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	HeroName NVARCHAR(50),
--	[Name] NVARCHAR(50),
--	[Power] NVARCHAR(50),
--	Popularity Int
--);


--INSERT INTO SuperHeros(HeroName, [Name], [Power], Popularity)
--VALUES ('Hulk', 'Bruce Banner', 'Super Strength', 9),
--('Iron Man', 'Tony Stark', 'Money', 10),
--('Ant Man', 'Scott Lang', 'Shrink',3);

--first is column, second is table
--SELECT HeroName FROM SuperHeros;
--SELECT HeroName, Power FROM SuperHeros;
--SELECT * FROM SuperHeros;

--WHERE IS FOR FILTERING
--SELECT * FROM SuperHeros
--WHERE Popularity > 7;


--Order by is sorting
--SELECT * FROM SuperHeros
--ORDER BY Popularity DESC; --ASC


--Combine filter and sort
--SELECT * FROM SuperHeros
--WHERE Popularity > 7
--ORDER BY Popularity DESC;

--Accidental extra data for demo
--INSERT INTO SuperHeros(HeroName, [Name], [Power], Popularity)
--VALUES ('Spiderman', 'Peter Parker', 'Web Slinging', 10),
--('Spiderman', 'Peter Parker', 'Mouthing Off', 10),
--('Spiderman', 'Peter Parker', 'Not Killing', 10);

--SELECT * FROM SuperHeros;

--DELETE FROM. BE VERY CAREFUL
--DELETE FROM SuperHeros
--WHERE [Power]  = 'Mouthing Off' OR [Power] = 'Not Killing';

--SELECT * FROM SuperHeros;

--How to update a value
--UPDATE SuperHeros
--SET [Power] = 'Spider Sense'
--Where ID = 4;

--SELECT * FROM SuperHeros;

--CREATE TABLE Tickets(
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	Seat NVARCHAR(20),
--	Price REAL,
--	Num_sold int
--);

--INSERT INTO Tickets (Seat, Price, Num_sold)
--VALUES ('Box Level', 105, 4),
--('Dress Circle', 75,2),
--('Main Floor', 58,10),
--('Mid Balcony', 38, 0),
--('Upper Balcony', 19,3);

--SELECT * FROM Tickets;

--SELECT COUNT(*) FROM Tickets;
--SELECT COUNT(*) as 'Ticket Types Sold' FROM Tickets
--WHERE Num_sold <> 0;

--SELECT SUM(Num_sold) AS 'Total Tickets Sold' FROM Tickets;

---SELECT AVG(Price) AS 'Average Price' FROM Tickets;

--SELECT MAX(Num_sold) AS 'Most Sold' FROM Tickets;

--SELECT MIN(Price) AS 'Cheapest Ticket' FROM Tickets;

--SELECT SUM(Num_sold) As 'Total Sold', SUM(Price * Num_sold) AS 'Revenue' FROM Tickets;

--SELECT Seat FROM Tickets
--WHERE Num_sold = (SELECT MIN(Num_sold) FROM Tickets);

--CREATE TABLE Class (
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	Title NVARCHAR(255)
--);

--CREATE TABLE Student(
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(255),
--	Class_id INT FOREIGN KEY REFERENCES Class(ID)
--);

--INSERT INTO Class(Title)
--VALUES ('.NET'),
--('JAVA') ,
--('Front-End');
--SELECT * FROM Class;

--INSERT INTO Student(Name, Class_id)
--VALUES ('G. Washington', 1),
--('M. Gandhi',1),
--('N. Mandela', null),
--('Q. Victoria', 2);
--SELECT * From Student;

--SELECT * FROM Student
--JOIN Class ON Student.Class_id = Class.ID;

--SELECT * FROM Student
--LEFT JOIN Class ON Student.Class_id = Class.ID;

--SELECT * FROM Student
--RIGHT JOIN Class ON Student.Class_id = Class.ID;

--SELECT * FROM Student
--FULL JOIN Class ON Student.Class_id = Class.ID;

--SELECT * FROM Student
--CROSS JOIN Class;

SELECT Student.ID, Student.Name FROM Student
INNER JOIN Class ON Student.Class_id = Class.ID
WHERE Class.Title = '.NET'
ORDER BY Student.Name;