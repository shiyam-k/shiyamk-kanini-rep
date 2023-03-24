CREATE TABLE voter (
  id INT PRIMARY KEY,
  name VARCHAR(255),
  age INT
);
INSERT INTO voter (id, name, age)
VALUES
  (1, 'John Smith', 25),
  (2, 'Jane Doe', 30),
  (3, 'Mark Johnson', 21),
  (4, 'Sarah Lee', 38),
  (5, 'David Kim', 42);

create function fn_setstatus (@a int)
returns varchar(10)
as
begin
	declare @result varchar(10)
	if @a>=18
		set @result='yes'
	else
		set @result='no'
	return @result
end

create or alter proc usp_fnset1
as 
begin 
select*,dbo.fn_setstatus(age)
from voter as eligible
end

exec usp_fnset
select dbo.fn_setstatus(10)