USE [DN 4.0];

Create Table Products(
 ProductId INT Primary key,
 ProductName NVARCHAR(50),
 Category NVARCHAR(50),
 Price DECIMAL (10,2)
);

INSERT INTO Products VALUES (1,'Shirt','Clothing',400),
(2, 'Shoes', 'Clothing', 600),
(3, 'Table', 'Furniture', 1200),
(4, 'TV', 'Electronics',5000),
(5, 'Mouse', 'Electronics', 250),
(6, 'Trouser', 'Clothing', 300),
(7, 'Jwellery', 'Accessories', 1000),
(8, 'Sofa', 'Furniture', 2500),
(9, 'Phone', 'Electronics', 3000),
(10, 'Bookshelf', 'Furniture', 300);

SELECT  ProductName,Category,Price, 
ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;

SELECT ProductName,Category,Price,
RANK() OVER (PARTITION BY category ORDER BY Price DESC) AS RankNum
FROM Products;

SELECT ProductName,Category,Price,
DENSE_RANK() OVER (PARTITION BY category ORDER BY Price DESC) AS DenseRankNum
FROM Products;



