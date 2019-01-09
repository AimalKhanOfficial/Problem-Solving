--Runtime: 1035 ms
--Accepted. Solution faster than 10.63% of total submissions! 

--Create table Weather (Id int, RecordDate date, Temperature int)
--Truncate table Weather
--insert into Weather (Id, RecordDate, Temperature) values ('1', '2015-01-01', '10')
--insert into Weather (Id, RecordDate, Temperature) values ('2', '2015-01-02', '25')
--insert into Weather (Id, RecordDate, Temperature) values ('3', '2015-01-03', '20')
--insert into Weather (Id, RecordDate, Temperature) values ('4', '2015-01-04', '30')
--insert into Weather (Id, RecordDate, Temperature) values ('5', '2015-01-03', '25')
select w.Id from Weather w where w.Temperature > (select top 1 sub.Temperature from Weather sub where DATEDIFF(DAY, sub.RecordDate, w.RecordDate) = 1 order by sub.RecordDate)