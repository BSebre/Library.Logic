CREATE TABLE Books(
Title NVARCHAR(50) NOT NULL,
Year DATETIME NOT NULL,
Author NVARCHAR(50) NOT NULL,
Copies INT NOT NULL
)
SELECT * FROM Books

INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('Harry Potter and the Deathly Hallows', '2007', 'J.K. Rowling', 3)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('The Hunger Games', '2008', 'Suzanne Collins', 2)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('Harry Potter and the Half-Blood Prince', '2006', 'J.K. Rowling', 1)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('Catching Fire ', '2009', 'Suzanne Collins', 5)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('The Alchemist', '1988', 'Paulo Coelho', 4)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('The Great Gatsby', '1925', 'F. Scott Fitzgerald', 1)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('Life of Pi', '2001', 'Yann Martel', 3)
INSERT INTO Books (Title, Year, Author, Copies)
VALUES ('The Little Prince', '2000', 'Antoine de Saint-Exupéry', 3)

