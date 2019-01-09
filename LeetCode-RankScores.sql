--178. Rank Scores - Leet Code (https://leetcode.com/problems/rank-scores/)

--set based approach
--select ROW_NUMBER() over(order by s.score desc) as rank, s.score from Scores s 

select RANK() OVER (ORDER BY s.score DESC) AS Rank, s.score from Scores s 

--Iterative approach - THIS WORKS FINE
--declare @tmp table (rankCustom int not null, score decimal(3, 2))
--declare @counter int = 1
--declare @initValue bit = 0
--declare @score decimal(3, 2)
--declare @rank int = 1
--while @counter <= (select count(*) from Scores)
--begin
--	set @score = (select rn.score from (select rankC = ROW_NUMBER() over(order by score desc), score from Scores) rn where rn.rankC = @counter)
--	--here it could be two cases
--	--test a score does does not exist in tmp table and set the value as 1 IF ITS AN INITIAL ENTRY
--	--if not, get the last value and increment by one
--	if not exists (select * from @tmp where score = @score)
--	begin 
--		if @initValue = 0
--		begin 
--			set @rank = 1
--			set @initValue = 1
--		end
--		else 
--		begin 
--			set @rank = (select max(rankCustom) from @tmp) 
--			set @rank = @rank + 1	
--		end
--	end
--	--a score entry already exists so we need to fetch it and keep it as is
--	else 
--	begin 
--		print 'rank exist'
--		set @rank = (select rankCustom from @tmp where score = @score)
--	end
--	insert into @tmp (rankCustom, score)
--	values (@rank, @score)
--	set @counter = @counter + 1
--end
--
--select score as Score, rankCustom as Rank from @tmp