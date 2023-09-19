CREATE TABLE Products
(
    ID INT PRIMARY KEY IDENTITY(1, 1), 
    NAME nvarchar(128) NOT NULL
);
 
CREATE TABLE Categories
(
    ID INT PRIMARY KEY IDENTITY(1, 1), 
    NAME nvarchar(128) NOT NULL
);
 
CREATE TABLE ProductCategories
(
    ID INT PRIMARY KEY IDENTITY (1, 1), 
    ProductId INT,
    CategoryId INT
);
 
INSERT INTO Products
    ([name])
VALUES
    ('Concrete'),
    ('Microwave'),
    ('Bacon'),
    ('Broth'),
	('Elephant');
 
INSERT INTO Categories
    ([name])
VALUES
    ('Building materials'),
    ('Electronics'),
	('Household Goods'),
    ('Food')
;
 
INSERT INTO ProductCategories
  ([ProductId],[CategoryId])
VALUES
  (1,1),
  (2,2),
  (2,3),
  (3,4),
  (4,4) 
;
 
 
SELECT p.name AS Product,c.name AS Category FROM Products p 
LEFT JOIN ProductCategories pc ON p.id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id