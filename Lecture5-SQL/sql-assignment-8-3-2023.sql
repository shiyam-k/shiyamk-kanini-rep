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
(286760,1004,50000),
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