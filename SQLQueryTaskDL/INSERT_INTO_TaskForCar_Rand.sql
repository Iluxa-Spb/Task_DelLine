USE CarService
GO

DECLARE @i INT, @max INT
DECLARE @begin datetime, @end datetime;

SELECT @begin = '20200401 00:00:00', @end = '20201117 00:00:00';
SET @i = 0;
SET @max = 1000;

WHILE (@i <= @max)
BEGIN
	DECLARE @randDataStart datetime, @randDataEnd datetime, @randIdCar INT, @randIdRepairman INT, @randCost INT, @randText nvarchar(200)
	SET @randDataStart =  cast(cast(@begin as float) + (cast(@end as float) - cast(@begin as float)) * rand() as datetime);
	SET @randDataEnd =  cast(cast(@randDataStart as float) + (cast(@end as float) - cast(@randDataStart as float)) * rand() as datetime);
	SET @randIdCar = cast(1 + (rand(checksum(newid())) * 20) as int)
	SET @randIdRepairman = cast(25 + (rand(checksum(newid())) * 12) as int)
	SELECT @randText = t.WorkName, @randCost = t.Cost FROM WorkGenerator t WHERE Id = cast(1 + (rand(checksum(newid())) * 105) as int)
	--PRINT @randCost
	INSERT INTO TaskForCar (CarId, RepairmanId, VehicleMalfunction, Cost, StartDate, FinishDate) VALUES
		(@randIdCar,@randIdRepairman, @randText, @randCost, @randDataStart, @randDataEnd)
	SET @i += 1
END
GO