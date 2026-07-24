INSERT INTO Customers VALUES
(1,'John','North'),
(2,'Alice','South'),
(3,'David','North'),
(4,'Emma','East');

INSERT INTO Products VALUES
(101,'Laptop','Electronics'),
(102,'Phone','Electronics'),
(103,'Shoes','Fashion'),
(104,'Watch','Accessories');

INSERT INTO Orders VALUES
(1001,1,'2024-01-10'),
(1002,2,'2024-01-12'),
(1003,3,'2024-01-15'),
(1004,4,'2024-01-20');

INSERT INTO OrderDetails VALUES
(1,1001,101,5),
(2,1001,103,3),
(3,1002,102,4),
(4,1002,104,2),
(5,1003,101,6),
(6,1004,103,7);