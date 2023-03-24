use Northwind
select * from Customers
select * from Categories

/*1. Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.*/

select CategoryName, Description from Categories order by CategoryName asc
select CategoryName, Description from Categories order by CategoryName desc

/*2. Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table
sorted by Phone.*/
select * from Customers

select ContactName, CompanyName, ContactTitle, Phone from Customers order by Phone asc

/*3. Create a report that shows the capitalized FirstName and capitalized LastName renamed as FirstName and Lastname
respectively and HireDate from the employees table sorted from the newest to the oldest employee.*/
select * from Employees
select upper(left(FirstName, 1)) + lower(right(FirstName, len(FirstName)-1)) as FirstName,
upper(left(LastName, 1)) + lower(right(LastName, len(LastName)-1)) as LastName ,
HireDate
from Employees order by HireDate desc

/*4. Create a report that shows the top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from the orders table sorted
by Freight in descending order*/
select * from Orders

select top 10 OrderId, OrderDate, ShippedDate, CustomerId, Freight  from Orders order by Freight desc

/*5. Create a report that shows all the CustomerID in lowercase letter and renamed as ID from the customers table*/
select * from Customers

select lower(CustomerId) as ID from Customers

/*6. Create a report that shows the CompanyName, Fax, Phone, Country, HomePage from the suppliers table sorted by the
Country in descending order then by CompanyName in ascending order.*/
select * from Suppliers

select CompanyName, Fax, Phone,Country, HomePage from Suppliers order by Country desc, CompanyName asc

/*7. Create a report that shows CompanyName, ContactName of all customers from ‘Buenos Aires' only.*/

select CompanyName, ContactName from Customers where city = 'Buenos Aires'

/*8. Create a report showing ProductName, UnitPrice, QuantityPerUnit of products that are out of stock.*/
select * from Products

select ProductName, UnitPrice, QuantityPerUnit from Products where UnitsInStock = 0

/*9. Create a report showing all the ContactName, Address, City of all customers not from Germany, Mexico, Spain.*/
select ContactName, Address, City from Customers where Country  not in('Germany', 'Mexico', 'Spain')

/*10. Create a report showing OrderDate, ShippedDate, CustomerID, Freight of all orders placed on 21 May 1996.*/
select * from Orders

select OrderDate, ShippedDate, CustomerId, Freight from Orders where OrderDate = '1996-05-21 00:00:00:000'

/*Create a report showing FirstName, LastName, Country from the employees not from United States.*/
select * from employees
select firstname,lastname,country from employees where country!='USA'
/*Create a report that shows the EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDate from all orders shipped later
than the required date.*/
select * from Orders
select employeeid,orderid,customerid,requireddate,shippeddate from orders where requireddate<shippeddate;
/*Create a report that shows the City, CompanyName, ContactName of customers from cities starting with A or B*/
SELECT City, CompanyName, ContactName
FROM Customers
WHERE City LIKE 'A%' OR City LIKE 'B%'
ORDER BY ContactName;

/*14. Create a report showing all the even numbers of OrderID from the orders table*/
SELECT OrderID
FROM Orders
WHERE OrderID % 2 = 0;

/*15. Create a report that shows all the orders where the freight cost more than $500.*/
SELECT *
FROM Orders
WHERE Freight > 500;
/*16. Create a report that shows the ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel of all products that are up for
reorder.*/

SELECT ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel
FROM Products
WHERE UnitsInStock < ReorderLevel;

/*17. Create a report that shows the CompanyName, ContactName number of all customer that have no fax number.
*/
SELECT CompanyName, ContactName, Phone
FROM Customers
WHERE Fax IS NULL;

/*18. Create a report that shows the FirstName, LastName of all employees that do not report to anybody*/
SELECT FirstName, LastName
FROM Employees
WHERE ReportsTo IS NULL;


/*19. Create a report showing all the odd numbers of OrderID from the orders table*/
SELECT OrderID
FROM Orders
WHERE OrderID % 2 = 1;

/*20. Create a report that shows the CompanyName, ContactName, Fax of all customers that do not have Fax number and sorted
by ContactName.*/

SELECT CompanyName, ContactName, Fax
FROM Customers
WHERE Fax IS NULL
ORDER BY ContactName asc;

/*21. Create a report that shows the City, CompanyName, ContactName of customers from cities that has letter L in the name
sorted by ContactName.*/

SELECT City, CompanyName, ContactName
FROM Customers
WHERE City LIKE '%L%'
ORDER BY ContactName;

/*22. Create a report that shows the FirstName, LastName, BirthDate of employees born in the 1950s*/

SELECT FirstName, LastName, BirthDate
FROM Employees
WHERE BirthDate BETWEEN '1950-01-01' AND '1959-12-31';

/*23. Create a report that shows the FirstName, LastName, the year of Birthdate as birth year from the employees table*/

SELECT FirstName, LastName, YEAR(BirthDate) AS BirthYear
FROM Employees;

/*
24. Create a report showing OrderID, total number of Order ID as NumberofOrders from the orderdetails table grouped by
OrderID and sorted by NumberofOrders in descending order. HINT: you will need to use a Groupby statement.*/
SELECT OrderID, COUNT(*) AS NumberofOrders
FROM OrderDetails
GROUP BY OrderID
ORDER BY NumberofOrders DESC;
/*
25. Create a report that shows the SupplierID, ProductName, CompanyName from all product Supplied by Exotic Liquids,
Specialty Biscuits, Ltd., Escargots Nouveaux sorted by the supplier ID*/
SELECT Products.SupplierID, Products.ProductName, Suppliers.CompanyName
FROM Products
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
WHERE Suppliers.CompanyName IN ('Exotic Liquids', 'Specialty Biscuits, Ltd.', 'Escargots Nouveaux')
ORDER BY Products.SupplierID;
/*
26. Create a report that shows the ShipPostalCode, OrderID, OrderDate, RequiredDate, ShippedDate, ShipAddress of all orders
with ShipPostalCode beginning with "98124".*/
SELECT ShipPostalCode, OrderID, OrderDate, RequiredDate, ShippedDate, ShipAddress
FROM Orders
WHERE ShipPostalCode LIKE '98124%';
/*
27. Create a report that shows the ContactName, ContactTitle, CompanyName of customers that the has no "Sales" in their
ContactTitle.*/
SELECT ContactName, ContactTitle, CompanyName
FROM Customers
WHERE ContactTitle NOT LIKE '%Sales%';
/*
28. Create a report that shows the LastName, FirstName, City of employees in cities other "Seattle";*/
SELECT LastName, FirstName, City
FROM Employees
WHERE City <> 'Seattle';
/*
29. Create a report that shows the CompanyName, ContactTitle, City, Country of all customers in any city in Mexico or other
cities in Spain other than Madrid.
*/
SELECT CompanyName, ContactTitle, City, Country
FROM Customers
WHERE Country = 'Mexico' OR (Country = 'Spain' AND City <> 'Madrid');






/*31. Create a report that shows the ContactName of all customers that do not have letter A as the second alphabet in their
Contactname.*/
SELECT ContactName
FROM Customers
WHERE ContactName NOT LIKE '_A%'
/*
32. Create a report that shows the average UnitPrice rounded to the next whole number, total price of UnitsInStock and
maximum number of orders from the products table. All saved as AveragePrice, TotalStock and MaxOrder respectively.
*/
SELECT
CEILING(AVG(UnitPrice)) AS AveragePrice,
SUM(UnitPrice * UnitsInStock) AS TotalStock,
MAX(UnitsOnOrder) AS MaxOrder
FROM Products
/*
33. Create a report that shows the SupplierID, CompanyName, CategoryName, ProductName and UnitPrice from the products,
suppliers and categories table.*/
SELECT
Products.SupplierID,
Suppliers.CompanyName,
Categories.CategoryName,
Products.ProductName,
Products.UnitPrice
FROM Products
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
/*
34. Create a report that shows the CustomerID, sum of Freight, from the orders table with sum of freight greater $200, grouped
by CustomerID. HINT: you will need to use a Groupby and a Having statement.*/
SELECT
CustomerID,
SUM(Freight) AS TotalFreight
FROM Orders
GROUP BY CustomerID
HAVING SUM(Freight) > 200
/*
35. Create a report that shows the OrderID ContactName, UnitPrice, Quantity, Discount from the order details, orders and
customers table with discount given on every purchase.*/
SELECT
o.OrderID,
Customers.ContactName,
o.UnitPrice,
o.Quantity,
o.Discount
FROM [Order Details] o
INNER JOIN Orders ON o.OrderID = Orders.OrderID
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
/*
36. Create a report that shows the EmployeeID, the LastName and FirstName as employee, and the LastName and FirstName of
who they report to as manager from the employees table sorted by Employee ID. HINT: This is a SelfJoin.*/
SELECT
emp.EmployeeID,
emp.LastName AS EmployeeLastName,
emp.FirstName AS EmployeeFirstName,
mgr.LastName AS ManagerLastName,
mgr.FirstName AS ManagerFirstName
FROM Employees emp
INNER JOIN Employees mgr ON emp.ReportsTo = mgr.EmployeeID
ORDER BY emp.EmployeeID
/*
37. Create a report that shows the average, minimum and maximum UnitPrice of all products as AveragePrice, MinimumPrice
and MaximumPrice respectively.*/
 SELECT
AVG(UnitPrice) AS AveragePrice,
MIN(UnitPrice) AS MinimumPrice,
MAX(UnitPrice) AS MaximumPrice
FROM Products
/*
38. Create a view named CustomerInfo that shows the CustomerID, CompanyName, ContactName, ContactTitle, Address, City,
Country, Phone, OrderDate, RequiredDate, ShippedDate from the customers and orders table. HINT: Create a View.*/
CREATE VIEW CustomerInfo AS
SELECT
Customers.CustomerID,
Customers.CompanyName,
Customers.ContactName,
Customers.ContactTitle,
Customers.Address,
Customers.City,
Customers.Country,
Customers.Phone,
Orders.OrderDate,
Orders.RequiredDate,
Orders.ShippedDate
FROM Customers
INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID

/*
39. Change the name of the view you created from customerinfo to customer details.*/
EXEC sp_rename 'CustomerInfo', 'CustomerDetails';
/*
40. Create a view named ProductDetails that shows the ProductID, CompanyName, ProductName, CategoryName, Description,
QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued from the supplier, products and
categories tables. HINT: Create a View*/




/*
41. Drop the customer details view.*/





/*
42. Create a report that fetch the first 5 character of categoryName from the category tables and renamed as ShortInfo*/

select * from categories
select substring(categoryname,1,3) as ShortInfo from categories 

/*
43. Create a copy of the shipper table as shippers_duplicate. Then insert a copy of shippers data into the new table HINT: Create
a Table, use the LIKE Statement and INSERT INTO statement. */

CREATE TABLE shippers_duplicate (
    ShipperID INT PRIMARY KEY,
    CompanyName VARCHAR(40),
    Phone VARCHAR(24)
);

INSERT INTO shippers_duplicate
SELECT * FROM shippers;




create table selftab(empno int primary key,ename varchar(20),
role varchar(20),mgrno int references selftab(empno))

insert into selftab(empno,ename,role) values(103,'Abinav','Manager')
insert into selftab(empno,ename,role) values(104,'Raj','Manager')
insert into selftab(empno,ename,role) values(105,'Jeeva','Manager')

select * from selftab

insert into selftab values(107,'ashok','developer',103)
insert into selftab values(108,'Santhosh','developer',103)
insert into selftab values(109,'Bhuvi','HR',103)
insert into selftab values(110,'Safal','DeadLifter',103)
insert into selftab values(111,'Alvin','developer',103)
insert into selftab values(112,'Chaitanya','MMA Fighter',103)

update selfTab set mgrno = 105 where empno in (110,112) 

select * from selftab order by empno
select m.empno as ManagerNo,m.ename as MgrName,e.role as role, e.empno, e.ename as Ename from selftab as m inner join selftab as e on e.empno=m.mgrno 


select m.empno as ManagerNo,m.ename as MgrName,e.role as role, e.empno, e.ename as Ename from selftab as m inner join selftab as e on m.empno=e.mgrno 

create proc p1
as 
begin 
select m.empno as ManagerNo,m.ename as MgrName,e.role as role, e.empno, e.ename as Ename from selftab as m inner join selftab as e on m.empno=e.mgrno 
end

create proc p2
as 
begin 
declare @n int, @m int
set @m = (select empno from selftab where ename = 'Abinav')
set @n = (select empno from selftab where ename = 'Raj')
print 'Abinav ' + str(@n)
print 'Raj '+ str(@m)
print @n + @m
end

drop proc p2

create table operation(op varchar(1) )
insert into operation values ('C')
insert into operation values ('R')
insert into operation values ('U')
insert into operation values ('D')

create table dataTable(Age int)
create proc crud
@op varchar(1),
@age int
as
begin
if @op = 'C'
insert into dataTable values(@age)
else if @op = 'R'
select * from dataTable

else if @op = 'U'
update dataTable set age = @age

else if @op = 'D'
delete dataTable
end

exec crud 'C', 25
exec crud 'R', null
exec crud 'U', 35
exec crud 'D', null


create table Customer(Custid int not null identity(1001,1), constraint pk_custid primary key(Custid), Custname varchar(20), Age int, phone bigint)
create table Loan(Loanid int not null identity(101,1), constraint pk_Loanid primary key(Loanid), Amount int, Custid int, constraint fk_custid_loan foreign key(Custid) references Customer(Custid), EMI int)
create table Account(Acno int not null identity(1,1), constraint pk_Acno primary key(Acno), Custid int, constraint fk_custid_Account foreign key(Custid) references Customer(Custid), Balance int)


INSERT INTO Customer ( custname, age, phone) VALUES
    ( 'John', 30, 123-456-7890),
    ( 'Jane', 25, 987-654-3210),
    ( 'Janes', 25, 987-6505-710),
    ( 'smith', 40, 555-555-5555);


INSERT INTO Loan ( amount, custid, emi) VALUES
(286760,1001,50000),
    ( 100000, 1001, 500),
    ( 5000, 1002, 250),
    ( 15000, 1003, 750);


INSERT INTO Account (custid, balance) VALUES
    (1001, 10000),
    (1002, 5000),
    (1003, 5000),
    (1004, 20000);

select * from Customer
select * from Loan
select * from Account

/*a) List the Loanid of Loans with EMI more than Rs.50,000.*/
select Loanid from Loan where Amount > 50000

/*b) List the EMI and number of loans with that loan amount.*/
select EMI, count(*) as num_loans from loan group by EMI

/*c) Create a view to list the total number of loans availed.*/
select count(*) as total_no_of_loans from loan

select c.Custname, count(Loanid) as no_of_loans from Customer c inner join loan l on c.custid = l.custid group by c.Custname order by no_of_loans desc


/*d) Display the EMI amount of Customer "Smith".*/
select EMI from Loan inner join Customer on Loan.Custid = Customer.Custid where Custname = 'smith'

/*e) Create a procedure to print the Amount and Custid of Loanid 1001.*/
create proc print_A_C_L
as
begin
declare @a int, @c int;
set @a = (select Amount from Loan where Loanid = 101)
set @c = (select Custid from Loan where Loanid = 101)
print 'Loan Amount ' + str(@a) + ' '+'Custid '+ str(@c)
end
exec print_A_C_L

/*f) Create a function to display the loan amount of customer with customerid 100.*/
create function get_loan_amount (@custid int)
returns int
as
begin
  declare @loan_amount int;
  set @loan_amount = (select Amount
  from Loan
  where Custid = @custid)
  return @loan_amount;
end

select dbo.get_loan_amount(1001) as get_loan_amt

create table age(age int identity(20, 1),name varchar(10))
insert into age(name) values('a')
select * from age

select *  from age 

declare @a int
set @a = 2
select * from age a1 where (@a-1) = (select count(age)from age a2  where a2.age > a1.age)


create table employee(eid int primary key,
ename varchar(30)not null,email varchar(50))

	insert into employee values(101,'Akil','akil@gmail.com')
	insert into employee values(102,'Gayu','gayu@gmail.com')

select*from employee

create table logtab(logid int primary key identity,
empid int not null,operation varchar(30),updated date)

create trigger trgEmployeeInsert
on employee
for insert
as
insert into logtab(empid,operation,updated)
select eid,'INSERT',getdate()from inserted


insert into employee values(105,'Udit Narayanan','udid@gmail.com')

select * from employee 

select * from logtab

disable trigger trgEmployeeInsert on employee

enable trigger trgEmployeeInsert on employee

insert into employee values(103,'Aadhit','aadhit@gmail.com')

drop trigger trgEmployeeInsert


create trigger trgEmployee
on employee
after insert
as
insert into logtab(empid,operation,updated)
select eid,'INSERT',getdate()from inserted
/* Trigger to display the total balance in the bank */

CREATE TABLE accounts (
  name VARCHAR(50),
  account_number INT,
  available_balance DECIMAL(10,2)
);


INSERT INTO accounts (name, account_number, available_balance) VALUES
('John Doe', 1234, 5000.00),
('Jane Smith', 9876, 2000.00),
('Bob Johnson', 2468, 10000.00),
('Alice Lee', 1357, 7500.00),
('Tom Davis', 8642, 3000.00),
('Sara Wilson', 1357, 9000.00),
('Mike Brown', 3692, 5500.00),
('Amy Chen', 9517, 4000.00),
('David Kim', 7777, 15000.00),
('Karen Wu', 8888, 12000.00);





set nocount on

/* ATM STARTS*/
create table transaction_log(transactID int not null identity(101,1), constraint pk_transact_log primary key(transactId), account_number int, action varchar(15), balance decimal(10,2), progress varchar(20))

create or alter trigger update_transaction_trigger
on accounts
after update
as begin
	declare @accntno varchar(10), @cb decimal(10,2), @name varchar(20)
	select @cb = available_balance from inserted
	select @accntno = account_number from inserted
	select @name = name from inserted
	print 'Transaction Complete'
	print 'Account Holder Name: ' + @name
	print 'Account Number: ' + str(@accntno)
	print 'Current Balance: ' + str(@cb)
end


create or alter proc from_atm
@action varchar(20), @acntno int, @bal int, @prgrss varchar(20)
	as begin
		insert into transaction_log(account_number, action, balance, progress) values(@acntno, @action, @bal, @prgrss)
	end

create or alter proc atm
@action varchar(20), @amount int, @n varchar(20)
as 
begin
	declare @current_balance decimal(10,2), @progress varchar(20)
	select @current_balance = available_balance from accounts where name = @n
	if @action = 'withdraw' and @current_balance - 1000 > @amount and @current_balance > 0
		begin
			update accounts set available_balance = available_balance - @amount where name = @n
			set @progress = 'SUCCESS'
		end
	else if @action = 'withdraw'
	begin
		print 'INSUFFICIENT BALANCE - Withdraw amount should not affect minimum balance'
		set @progress = 'FAILURE'
	end
	if @action = 'deposit'
		begin
			update accounts set available_balance = available_balance + @amount where name = @n
			set @progress = 'SUCCESS'
		end
	if @action = 'inquire balance'
		begin
			print 'Current Balance: ' + str(@current_balance)
			set @progress = 'SUCCESS'
		end
	declare @acntno int, @ab decimal(10,2)
	select @ab = available_balance from accounts where name = @n
	select @acntno = account_number from accounts where name = @n
	exec from_atm @action, @acntno, @ab, @progress
end

/* ATM ENDS*/

drop trigger update_transaction_trigger
exec atm 'withdraw', 10000, 'Bob Johnson'
exec atm 'withdraw', 1000, 'jane smith'
exec atm 'withdraw', 5000, 'jane smith'

select * from accounts
exec atm 'withdraw', 1000, 'jane smith'

select * from transaction_log

create table  shiyam (id int,name varchar(20));
drop table shiyam

insert into shiyam values(1,'shiyam');

select * from shiyam

alter table shiyam
drop column age varchar(20)




