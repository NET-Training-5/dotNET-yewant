
create table Employee
(
	Id int,
	Name nvarchar(200),
	Address nvarchar(300),
	Gender char(1),
	Dob datetime
)

drop table Employee
create table Employee
(
	Id int not null identity primary key,
	Name nvarchar(200) not null,
	Address nvarchar(300),
	Gender char(1) not null,
	Dob datetime
)

insert into Employee
values ('Yewant Karki', 'Bhaktapur', 'M', '2000/03/01')

select * from Employee
