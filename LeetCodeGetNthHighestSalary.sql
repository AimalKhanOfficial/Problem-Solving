alter function getNthHighestSalary(@N int) returns int as 
begin
RETURN (
        /* Write your T-SQL query statement below. */
        select salary from (select ROW_NUMBER() OVER(order by salary asc) as salaryId, salary from Employee) as x
	where salaryId = @N
    );
end