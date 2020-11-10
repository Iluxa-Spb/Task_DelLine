DROP FUNCTION IF EXISTS func_GetTaskWithPct
GO

CREATE FUNCTION func_GetTaskWithPct(@StartDate datetime, @EndDate datetime)
RETURNS TABLE
AS
RETURN 
SELECT t.TaskForCarId Id
,r.LastName+' '+r.FirstName+' '+r.Patronymic RepairmanName
,car.Brand+' '+car.Model CarName
,t.StartDate [Date]
,g.pct_of_id pct
,SUM(t.Cost) Cost
FROM TaskForCar t
JOIN Car car ON car.CarId = t.CarId
JOIN Repairman r ON r.RepairmanId = t.RepairmanId
JOIN dbo.func_GetAllWorkload(@StartDate, @EndDate) g ON g.id = t.RepairmanId
WHERE t.FinishDate IS NULL AND t.StartDate >= @StartDate AND t.StartDate < @EndDate
GROUP BY ROLLUP ((r.FirstName, r.LastName, r.Patronymic, g.pct_of_id),(car.Brand,car.Model, t.StartDate,t.TaskForCarId))
GO

SELECT * from func_GetTaskWithPct('20200501', '20200701')
GO