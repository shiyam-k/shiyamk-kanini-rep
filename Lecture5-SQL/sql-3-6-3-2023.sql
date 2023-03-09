use master
create table student(Rollno int,Name varchar(20),DOB date,Mark1 int,Mark2 int,Mark3 int);


insert into student values(101,'ALINA','2000-01-07',100,98,89); 
insert into student values(102,'ALISHA','2002-07-07',80,68,79); 
insert into student values(103,'BELLA','2001-08-11',100,98,99); 
insert into student values(104,'CHARLIE','2004-12-30',80,88,94);
insert into student values(105,'DAVIS','2003-04-12',78,98,88);

select * from student

alter table student add total int

update student set total = Mark1 + Mark2 + Mark3

select * from student

update student set Mark1 = 98 where Rollno = 104

select Rollno as Mark1GreaterThan80 from student where Mark1 > 80

select Name as Mark1G60AndL80 from student where Mark1 > 60 and Mark1 <= 80

update student set Name = 'SHIYAM K' where Rollno = 105 

select Name as Scored100 from student where Mark1 = 100 or Mark2 = 100 or Mark3 = 100

select Name as StartsWithA from student where Name like 'A%'

select Name as EndsWithA from student where Name like '%A'

select min(Mark1) as MinMark1 from student 


select max(Mark1) as MaxMark1 from student

select avg(Mark1) as AvgMark1 from student

select sum(Mark1) as SumMark1 from student

select * from student order by Name asc

select count(*) as countData from student

select * from student order by Name desc

delete from student where Rollno = 105


select Name, min(Mark1) from student group by Name having min(Mark1) > 80 

select * from student

SELECT max(Mark1) 
FROM student
WHERE Mark1 NOT IN (SELECT max(Mark1) FROM student)

update student set Mark1 += 2

select s.Name from student s where s.Name like 'a%' or s.Name like '%a'

select * from student where Rollno in(select Rollno from student where Rollno > 102)

select * from student where exists (select Rollno from student where Rollno > 102)


select Name, Mark1 as mark1mark2 from student where Mark1 > 100 
union all
select Name, Mark2 from student where Mark2 > 80

create table tableA(Rollno int, Name varchar(20),Job varchar(10))

create table tableB(Rollno int, Name varchar(20),Job varchar(10))

insert into tableA values(1, 'xyz', 'PL')
insert into tableA values(2, 'abc', 'TL')
insert into tableA values(3, 'def', 'HR')

insert into tableB values(1, 'xyz', 'PL')
insert into tableB values(4, 'rst', 'PM')
insert into tableB values(5, 'qr', 'TL')

select * from tableA

select * from tableB

select * from tableA
union 
select * from tableB

select * from tableA
union all
select * from tableB

select * from tableA
intersect 
select * from tableB

create table tableC(Rollno int, EmpName varchar(20),Job varchar(10))

insert into tableC values(1, 'xyz', 'PL')
insert into tableC values(4, 'rst', 'PM')
insert into tableC values(5, 'qr', 'TL')

select * from tableB
intersect
select * from tableC

create database amazon 
use amazon
create table Customer(cId int  not null, constraint pk_cust_id primary key(cId), cName varchar(20) not null, cAddress varchar(50), cMobile bigint)
create table Product(pId int not null, constraint pk_prod_id primary key(pId), pName varchar(20) not null, pPrice decimal(5,2), pQty int)
create table Orders(oId int not null, constraint pk_ord_id primary key(oId), cId int references Customer(cId), pId int references Product(pId))





select * from Customer
select * from Product
select * from Orders


select * from Customer where cId in (select cId from Orders)
select * from Product where pId in (select pId from Orders)


delete from Customer
delete from Product
delete from Orders

insert into customer values(1,'Ashok','Andra',7810808191)
insert into customer values(2,'Abinav','Andra',7810808101)
insert into customer values(3,'Dhyan','KGF',7810809191)
insert into customer values(4,'Chhagan','Maharastra',7710808191)
insert into customer values(5,'Safal','Nagpur',7810908191)

insert into product values(901,'Twilight',100.00,20)
insert into product values(902,'Harry Potter',200.00,25)
insert into product values(903,'Twiligh',100.00,30)
insert into product values(904,'Munch',50.00,50)
insert into product values(905,'Dairy Milk',50.00,100)

insert into Orders values(9001,1,901)
insert into Orders values(9002,1,902)
insert into Orders values(9003,1,903)
insert into Orders values(9004,2,901)
insert into Orders values(9005,2,902)
insert into Orders values(9006,2,903)
insert into Orders values(9007,3,901)
insert into Orders values(9008,3,904)
insert into Orders values(9009,3,905)
insert into Orders values(9010,4,905)
insert into Orders values(9011,4,904)
insert into Orders values(9012,5,903)
insert into Orders values(9013,5,905)

select count(*) as noofproducts from Product
select count(*) as noofcustomers from Customer
select count(*) as nooforders from Orders

/* display the customer id and no of products bought by each customers*/

select cId as CustomerId, count(pId) as CountOfProduct from Orders group by cId
select pId as ProductId, count(cId) as CountOfCustomers from Orders group by pId


select cName , cId from Customer where Customer.cId in( select cId from orders)
select pName as orderedProduct , pId from Product where Product.pId in( select pId from orders)

/* display the customer id who has bought more than 2 products*/
select cId, count(pId) as CountOfProduct2 from Orders group by cId having count(pId) > 2
select distinct(cId) from Orders