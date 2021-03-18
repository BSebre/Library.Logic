SELECT LastName, FirstName FROM Users

SELECT * FROM Users

INSERT INTO Users (Id, LastName, FirstName, RegisteredOn)
VALUES (1, 'Smith', 'John', '2021-02-27')
INSERT INTO Users (Id, LastName, FirstName, RegisteredOn)
VALUES (2, 'Adams', 'Ann', '2021-02-20')

SELECT * FROM Users ORDER BY LastName ASC, FirstName ASC

SELECT MAX(Id) FROM Users