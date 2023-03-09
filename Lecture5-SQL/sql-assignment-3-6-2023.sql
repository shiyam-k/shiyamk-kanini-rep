create table Employee(Empid int not null, constraint pk_Employee primary key(Empid), Empname varchar(20), Designation varchar(20), Dateofjoin date, Salary int)

create table Project(ProjectNo int not null, constraint pk_Project primary key(ProjectNo), Projectname varchar(20), Duration int, Budget int)

create table Emp_Proj(Empid int references Employee(Empid), Projectno int references Project(Projectno))

insert into Employee values(1001,'Jane','Senior Programmer','2009-04-06',100000);

insert into Employee values(1002,'Jenny','Junior Programmer','2010-08-13',75000); 

insert into Employee values(1003,'John','Professor','2012-09-16',80000); 

insert into Employee values(1004,'Jasper','Associate Professor','2013-11-02',60000);

insert into Employee values(1005,'Jansi','Assistant Professor','2013-09-16',60000); 

insert into Project values(401,'Storage Concepts',65,50000); 
insert into Project values(402,'Robotics',55,90000);
insert into Project values(403,'Deep Learning',50,80000); 
insert into Project values(404,'Machine Learning',69,99000); 
insert into Project values(405,'Networking',67,89000);

insert into EMP_PROJ values(1001,401); 
insert into EMP_PROJ values(1002,401); 
insert into EMP_PROJ values(1003,401); 
insert into EMP_PROJ values(1004,402); 
insert into EMP_PROJ values(1005,402); 
insert into EMP_PROJ values(1001,402); 
insert into EMP_PROJ values(1002,403); 
insert into EMP_PROJ values(1004,403);
insert into EMP_PROJ values(1005,403); 
insert into EMP_PROJ values(1003,404); 
insert into EMP_PROJ values(1002,404);
insert into EMP_PROJ values(1001,405); 
insert into EMP_PROJ values(1002,405); 
insert into EMP_PROJ values(1003,405); 
insert into EMP_PROJ values(1004,405); 

 
/*1.	DISPLAY THE PROJECT DETAILS OF PROJECT DONE BY JOHN */
select * from Project where ProjectNo in(select Projectno from EMP_PROJ where Empid in(select Empid from Employee where Empname = 'jane'))

/*join*/
select  Employee.Empname, Project.* from Project inner join EMP_PROJ on Project.Projectno = EMP_PROJ.Projectno inner join Employee on EMP_PROJ.Empid = Employee.Empid where Employee.Empname = 'jane';



/*2.	DISPLAY THE PROJECT NAME AND DURATION OF PROJECTS DONE BY JUNIOR PROGRAMMER*/
select Projectname, Duration from Project where ProjectNo in(select Projectno from EMP_PROJ where Empid in(select Empid from Employee where Designation = 'Junior Programmer'))

/*join*/
select p.Projectname, p.Duration, e.Empname from Project as p inner join EMP_Proj as ep on p.ProjectNo = ep.Projectno inner join Employee as e on ep.Empid = e. Empid where e.Designation = 'Junior Programmer'

/*3.	DISPLAY THE NAME OF EMPLOYEES WHO ARE WORKING UNDER ROBOTICS */
select Empname from Employee where Empid in(select Empid from EMP_PROJ where Projectno in(select Projectno from Project where Projectname = 'Robotics'))

/*join*/


/*4.	DISPLAY THE EMPLOYEE ID OF EMPLOYEES WHO ARE WORKING IN PROJECTS WITH DURATION 50 TO 75*/
select Empid from Employee where Empid in
(select Empid from EMP_PROJ where Projectno in
(select Projectno from Project where Duration between 50 and 75))

select Empid from Employee where Empid in
(select Empid from EMP_PROJ where Projectno in
(select Projectno from Project where Duration >= 50 and Duration <= 75))

select distinct(Empid) from Emp_Proj where Projectno in(select Projectno from Project where Duration between 50 and 75)


/*5.	DISPLAY THE NAME OF EMPLOYEES WHO ARE WORKING IN PROJECT NO 402 */

select Empname, Empid from Employee where Empid in(select Empid from EMP_PROJ where Projectno in(select distinct(Projectno) from Project where Projectno = 402))


/*6.	DISPLAY THE PROJECT NAME AND DURATION OF THE PROJECTS DONE BY EMPLOYEES WHO HAVE JOINED ON 02-11-2013*/
select Projectname, Duration from Project where Projectno in (select Projectno from Emp_Proj where Empid in(select Empid from Employee where Dateofjoin = '2013-11-02'))


select * from Emp_Proj
select * from employee
select * from project
select datediff(year, Dateofjoin, getDate()) as ExperienceAsYear from Employee

set nocount on
insert into Emp_Proj values(1002, 403)

alter table Emp_Proj drop FK__Emp_Proj__Projec__52793849


alter table Emp_Proj add constraint fk_Empid foreign key(Empid) references Employee(Empid) on delete cascade on update cascade
alter table Emp_Proj add constraint fk_Projectno foreign key(Projectno) references Project(Projectno) on delete cascade on update cascade

select * from employee
update Employee set Empid = 110 where Empname = 'John'
select * from employee
select * from Emp_Proj

alter table Emp_Proj drop fk_Empid

select * from Orders
select * from Product
select * from Customer

select cName, reverse(cName) as revName from Customer

alter table Orders drop FK__Orders__cId__4E88ABD4
alter table Orders drop FK__Orders__pId__4F7CD00D

alter table Orders add constraint fk_cId foreign key(cId) references Customer(cId) on delete cascade on update cascade
alter table Orders add constraint fk_pId foreign key(pId) references Product(pId) on delete cascade on update cascade

 
create database work_7_3_2023
use work_7_3_2023

create table Employee(Empid int not null, constraint pk_empid primary key(Empid), Empname varchar(20))

alter table Employee add Age int 

alter table Employee add constraint check_Age check(Age > 25 and Age < 50)

insert into Employee values(101, 'Maekar', 30)
insert into Employee values(102, 'Arton', 40)
insert into Employee values(103, 'Arthur', 60)

select * from Employee

create table Emp(Empid int not null, Empname varchar(20), Role varchar(20))

insert into Emp values(1, 'personA', 'HRM')
insert into Emp values(2, 'personB', 'TL')
insert into Emp values(3, 'personC', 'PL')
insert into Emp values(4, 'personD', 'TM')
insert into Emp values(5, 'personE', 'GM')

select * from Emp

SELECT Empname,
       CASE Empid
            WHEN 1 THEN 'HRM'
            WHEN 2 THEN 'TL'
            WHEN 3 THEN 'PL'
            WHEN 4 THEN 'TM'
            ELSE 'Other'
       END AS Designation
FROM Emp

alter table Emp add Location varchar(20)

alter table Emp add anotherId int

alter table Emp alter column anotherId int not null

alter table Emp add constraint default_location default 'chennai' for location


alter table emp add fName varchar(20) not null
alter table emp add sName varchar(20) not null
alter table emp drop constraint pk_empid_emp

alter table emp add constraint cpk_fname_sname primary key(fName, sName)


select * from Emp order by Empid asc
insert into Emp values(1,'none','name1','name2')
insert into Emp values(1,'nona','name3','name2')
insert into Emp values(1,'nonea','name2','name3')


declare @Empid int set @Empid = (select Empid from Emp where Empid = 1) print @Empid

create table mobile(m tinyint)
insert into mobile values(1111555522)


