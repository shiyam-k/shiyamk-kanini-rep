create table empData(eId Integer, eName char(50))

EXEC sp_rename 'empData' , 'studentTable'

alter table empData add HTML integer
alter table empData add CSS integer
alter table empData add JS integer
alter table studentTable add total integer
alter table studentTable drop column total



update studentTable set eName = 'sitric' where CSS = 85
select * from studentTable

update studentTable set total = HTML + CSS + JS

select avg(CSS) as avgCSS from studentTable


create table employees(eid integer, ename varchar(30), designation varchar(30), wage integer, city varchar(20))

select * from employees

insert into employees values(1,'Denver','developer-junior',1000,'Mumbai')
insert into employees values(2,'Oliver','developer-mid',1500,'Tamilnadu')
insert into employees values(3,'Rover','developer-junior',1000,'Kerala')
insert into employees values(4,'Johar','developer-junior',1000,'Tamilnadu')
insert into employees values(5,'Mewar','developer-senior',2000,'Mumbai')
insert into employees values(6,'Sonar','developer-senior',2000,'Pune')
insert into employees values(7,'Dhiwaar','tech-writer',300,'Pune')
insert into employees values(8,'Aahaar','tech-writer',600,'Pune')
insert into employees values(9,'Saagar','developer-junior',1000,'Assam')
insert into employees values(10,'Saavarkar','tech-writer',600,'Bangalore')
insert into employees values(11,'Devar','tech-writer',700,'Bangalore')
insert into employees values(12,'Naadar','developer-senior',2000,'Andra')
insert into employees values(13,'Sudar','developer-mid',1200,'Andra')
insert into employees values(14,'Sundar','developer-mid',1500,'Andra')
insert into employees values(15,'Bhawar','developer-junior',1000,'Bengal')
insert into employees values(16,'Anaar','tech-writer',1200,'Bengal')
insert into employees values(17,'Juver','developer-mid',1100,'Bengal')
insert into employees values(18,'Domer','developer-mid',1100,'MP')
insert into employees values(19,'Nenar','developer-mid',1300,'MP')
insert into employees values(20,'Sikandar','developer-junior',900,'Calicut')


select avg(wage) as wage_of_junior_devs from employees where designation = 'developer-junior'

select avg(wage) as avg_wage from employees

select count(eid) as total_no_of_employees from employees

select count(eid) as count_from_mumbai from employees where city = 'Mumbai' 

select max(wage) as max_wage from employees

select max(wage) as max_wage_dev_junior from employees where designation = 'developer-junior'


select min(wage) as min_wage from employees

select min(wage) as min_wage_tech_writer from employees where designation = 'tech-writer'
 

select sum(wage) as sum_wage from employees

update employees set city = 'Madhya Pradesh' where city = 'MP'

select * from employees where city = 'calicut'

delete from employees where city= 'calicut'

select * from employees where city like '_____N%'

select * from employees where ename like 'd%'
select * from employees where ename like '%R'

update employees set wage = 1015 where ename = 'Denver'
update employees set wage = 1017 where ename = 'Rover'
select * from employees
select avg(wage ) from employees
update employees set city = null where ename = 'Oliver' and city like '_____n%'

select * from employees where city is not null


alter table employees drop column indian

select * from employees order by wage desc


SELECT CAST ( '514' AS VARCHAR(10) ) as junk

/*alter table employees add constraint eid_pk primary key CLUSTERED(eid)*/
select count(*) as NO_OF_EMPLOYEES,designation from employees group by designation order by NO_OF_EMPLOYEES desc
select count(*) as NO_OF_EMPLOYEES,designation from employees group by designation

select count(*) as no_of_wage, wage from employees group by wage order by no_of_wage desc

alter table employees alter column eid integer not null
alter table employees add constraint

select count(eid) as tech_writer_count from employees where designation = 'tech-writer'
select * from employees

select designation, avg(wage) as avg_wage from employees group by designation

select designation, avg(wage) as avg_wage from employees where designation = 'developer-senior' group by designation 

select * from employees where city = 'Bengal'

select  designation, count(designation) as count_designation from employees group by designation order by count_designation desc
select  designation, count(designation) as dev_senior from employees where designation = 'developer-senior' group by designation 

select designation, count(*) as count_designation, avg(wage) as avg_wage, sum(wage) as sum_wage from employees group by designation having avg(wage) > 700 order by sum_wage desc
