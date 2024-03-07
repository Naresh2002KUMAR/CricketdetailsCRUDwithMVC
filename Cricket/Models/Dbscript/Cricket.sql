select * from CricketerDetail

--TO INSERT
go
Create PROCEDURE
InsertPlayer(
@CricketerName nvarchar(50), @TotalODI bigint,@TotalScore bigint ,@Fifties bigint,@Hundreds bigint)
as
begin
Insert into CricketerDetail values(@CricketerName, @TotalODI, @TotalScore, @Fifties, @Hundreds)
end
exec InsertPlayer 'Rohit',262,10709,55,31
exec InsertPlayer 'Virat',268,12789,55,50
exec InsertPlayer 'Dhoni',280,9788,45,20


select * from CricketerDetail


--TO UPDATE
go 
Create procedure UpdatePlayer(
@CricketerId bigint ,@CricketerName nvarchar(50), @TotalODI bigint,@TotalScore bigint ,@Fifties bigint,@Hundreds bigint)
as
begin
Update CricketerDetail set CricketerName=@CricketerName, TotalODI=@TotalODI, TotalScore=@TotalScore, Fifties=@Fifties,Hundreds=@Hundreds 
where CricketerId=@CricketerId
end
exec UpdatePlayer 3,'Dhoni',290,9876,30,21

select * from CricketerDetail

--TO READ
go
Create procedure ReadPlayer
as
begin
select * from CricketerDetail
end
exec ReadPlayer


--TO READ BY NUMBER
go
create procedure ReadPlayerById(@CricketerId bigint)
as
begin
select * from CricketerDetail where CricketerId=@CricketerId
end
exec ReadPlayerById 1

--TO DELETE
go
create procedure DeletePlayer(@CricketerId bigint)
as
begin
delete CricketerDetail  where CricketerId=@CricketerId
end
exec DeletePlayer 3
