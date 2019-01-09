--Create table Employee (Id int, Name varchar(255), Salary int, DepartmentId int)
--Create table Department (Id int, Name varchar(255))
--Truncate table Employee
--insert into Employee (Id, Name, Salary, DepartmentId) values ('1', 'Joe', '70000', '1')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('2', 'Henry', '80000', '2')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('3', 'Sam', '60000', '2')
--insert into Employee (Id, Name, Salary, DepartmentId) values ('4', 'Max', '90000', '1')
--Truncate table Department
--insert into Department (Id, Name) values ('1', 'IT')
--insert into Department (Id, Name) values ('2', 'Sales')

select d.Name as Department, e.Name as Employee, e.Salary from Employee e join Department d on e.DepartmentId = d.Id
--update Employee set Salary = 90000 where Name like '%Joe%'
--delete from employee where Id in (2, 3)

select resultSet.Department, resultSet.Employee, resultSet.Salary from (select d.Name as Department, e.Name as Employee, e.Salary, ROW_NUMBER() over(partition by d.Id order by e.salary desc) as rn from Employee e join Department d on e.DepartmentId = d.Id) as resultSet where rn = 1
