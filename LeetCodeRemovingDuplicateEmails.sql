--Setting the environment
--create table Person (Id int not null, Email varchar(200) not null)
--insert into Person values (1, 'john@example.com'), (2, 'bob@example.com'), (3, 'john@example.com')

--select x.id, x.email from (select ROW_NUMBER() over (partition by email order by Id asc) as row_number, id, email from Person) as x

select x.Id, x.Email from (select ROW_NUMBER() over (partition by email order by Id asc) as rn, Id, Email from Person) as x where x.rn = 1 order by x.Id