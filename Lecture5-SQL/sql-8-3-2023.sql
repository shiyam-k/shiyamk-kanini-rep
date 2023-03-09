create table student_table_832023(rollno int identity(100, 1) not null, constraint pk_student_table primary key(rollno), age int, city varchar(20) default 'chennai')
insert into student_table_832023(age) values(25)
insert into student_table_832023(age) values(25)
insert into student_table_832023(age) values(25)
insert into student_table_832023(age) values(25)
select * from student_table_832023
drop  table student_table_832023

SELECT * FROM student_table_832023 WHERE rollno % 2 = 0


select * into new_student_table from student_table_832023

select * from new_student_table

create table stud_table(rollno int identity(100, 1) not null, constraint pk_stud_table primary key(rollno), sName varchar(20), address varchar(50))
create table enroll(rollno int , constraint fk_stud_table foreign key(rollno) references stud_table(rollno), courseName varchar(20))

insert into stud_table(sName, address) values( 'bhuvi', 'chennai')
insert into stud_table(sName, address) values( 'jeeva', 'chennai')
insert into stud_table(sName, address) values( 'sandy', 'banglore')
insert into stud_table(sName, address) values( 'alvin', 'chennai')


insert into enroll values(101, 'python')
insert into enroll values(101, '.net')
insert into enroll values(101, 'java')
insert into enroll values(102, 'webdev')
insert into enroll values(102, 'android')
insert into enroll values(100, 'java')
insert into enroll values(100, 'mssql')
insert into enroll values(100, '.net')

select * from stud_table

select * from enroll

select s.rollno, s.sName, e.courseName from stud_table as s inner join enroll as e on s.rollno = e.rollno
select s.rollno, s.sName, e.courseName from stud_table as s left join enroll as e on s.rollno = e.rollno
select s.rollno, s.sName, e.courseName from stud_table as s full join enroll as e on s.rollno = e.rollno


select isnull( (select age from student_table_832023 where rollno = 101), null) as age

create table Employee(fName varchar(20) not null, lName varchar(20), initial varchar(1))

insert into Employee(fName, initial) values('kanini', 'k')
insert into Employee values('kanmani',null,null)

select isNull(fName,lName) as notNullRecord from Employee where fName = 'kanini'

select coalesce(fName,lname) +  ' ' + coalesce(lName,initial) as notNullRecord from Employee where fName = 'kanini'

select * from EMployee
drop table employee
/*create table student_table_832023(gender varchar(1) check (gender in ('M' , 'F')))
insert into student_table_832023 values('L')
insert into student_table_832023 values('G')
insert into student_table_832023 values('B')
insert into student_table_832023 values('T')
insert into student_table_832023 values('Q')

insert into student_table_832023 values('F')
insert into student_table_832023 values('M')*/


CREATE TABLE Worker (
	WORKER_ID INT NOT NULL PRIMARY KEY identity(1,1) ,
	FIRST_NAME varCHAR(25),
	LAST_NAME varCHAR(25),
	SALARY INT,
	JOINING_DATE date,
	DEPARTMENT varCHAR(25)
);

INSERT INTO Worker 
	(FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT) VALUES
		('Monika', 'Arora', 100000, '07-03-2023', 'HR'),
		('Niharika', 'Verma', 80000, '07-03-2011', 'Admin'),
		('Vishal', 'Singhal', 300000, '02-02-2014', 'HR'),
		('Amitabh', 'Singh', 500000, '08-03-2015', 'Admin'),
		('Vivek', 'Bhati', 500000,'02-05-2011', 'Admin'),
		('Vipul', 'Diwan', 200000,'09-07-2012', 'Account'),
		('Satish', 'Kumar', 75000,'05-06-2010', 'Account'),
		('Geetika', 'Chauhan', 90000,'05-09-2009', 'Admin');
drop table bonus
		CREATE TABLE Bonus (
	WORKER_REF_ID int,
	BONUS_AMOUNT int,
	BONUS_DATE date,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Bonus 
	(WORKER_REF_ID,BONUS_AMOUNT,BONUS_DATE) VALUES
		(1,5000,'2011-03-21'),
		(2,3000,'2011-04-07'),
		(3,4000,'2009-02-16'),
		(1,4500,'2010-09-13'),
		(2,3500,'2023-11-11');
	CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE varCHAR(25),
	AFFECTED_FROM date,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Title 
	(WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM) VALUES
 (1, 'Manager', '2016-02-20'),
 (2, 'Executive', '2016-06-11'),
 (8, 'Executive', '2016-06-11'),
 (5, 'Manager', '2016-06-11'),
 (4, 'Asst. Manager', '2016-06-11'),
 (7, 'Executive', '2016-06-11'),
 (6, 'Lead', '2016-06-11'),
 (3, 'Lead', '2016-06-11');


 
 select * from worker
 select * from bonus
 select * from Title


 /*1. 	Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.*/

 select FIRST_NAME as WORKER_NAME from worker 

 /*2.	Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.*/

 select upper(FIRST_NAME) as WORKER_NAME_UPPER from worker

 /*3.	 Write an SQL query to fetch unique values of DEPARTMENT from Worker table.*/

 select distinct(DEPARTMENT) from worker 

 /*4.	Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.*/

 select substring(FIRST_NAME, 1,3) as FIRST_THREE_CHARS_OF_FNAME from worker

 /*5.	Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.*/

 select charindex('a', FIRST_NAME) as pos from worker where FIRST_NAME = 'amitabh'

 /*6.	Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.*/

 select rtrim(FIRST_NAME) as RTRIM_FIRST_NAME from worker

 /*7.	Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.*/

 select ltrim(DEPARTMENT) as LTRIM_DEPARTMENT from worker
 
/*8.	Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.*/

 /*select distinct(DEPARTMENT) from worker*/
select distinct(len(DEPARTMENT)) as lengthOfDistinctRoles from worker

/*9.	Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.*/

Select replace(FIRST_NAME,'a','A') as REPLACE_a_WITH_A from Worker

/*10.	Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.*/

select FIRST_NAME +' '+ LAST_NAME as FULL_NAME from worker

/*11.	Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.*/

select * from worker order by FIRST_NAME asc

/*
12.	Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.*/

select * from worker order by FIRST_NAME asc, DEPARTMENT desc

/*13.	Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.*/

select * from worker where FIRST_NAME in ('vipul', 'satish')

/*14.	Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.*/

select * from worker where FIRST_NAME not in ('vipul', 'satish')

/*15.	Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.*/

select * from worker where DEPARTMENT in ('Admin')


/*16.	Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.*/

 select *from worker where FIRST_NAME like '%a%'

/*17.	Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.*/

 select *from worker where FIRST_NAME like '%a'

/*18.	Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.*/

 select *from worker where FIRST_NAME like '_____h'

/*19.	Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.*/

select * from worker where salary between 100000 and 500000

/*20.	Write an SQL query to print details of the Workers who have joined in Feb’2014.*/

Select * from Worker where year(JOINING_DATE) = 2014 and month(JOINING_DATE) = 2;

/*21.	Write an SQL query to fetch the count of employees working in the department ‘Admin’.*/

select count(*) as COUNT_OF_ADMIN from worker where DEPARTMENT in ('Admin')

/*22.	 Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.*/

select * from worker where salary between 50000 and 100000

/*23.	Write an SQL query to fetch the no. of workers for each department in the descending order.*/

select DEPARTMENT, count(*) as COUNT_OF_ROLES from worker group by DEPARTMENT

/*24.	Write an SQL query to print details of the Workers who are also Managers.*/

select * from Title where WORKER_TITLE = 'Manager'

/*25.	 Write an SQL query to fetch duplicate records having matching data in some fields of a table.*/

select DEPARTMENT, count(DEPARTMENT) as COUNT_DE_PERSONAS from Worker group by DEPARTMENT having count(DEPARTMENT) > 1