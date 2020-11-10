USE CarService
GO

DROP VIEW IF EXISTS Task_3
GO

CREATE VIEW Task_3 AS
SELECT r.LastName+' '+r.FirstName+' '+r.Patronymic RepairmanName
,car.Brand+' '+car.Model CarName
,t.StartDate [Date]
,g.pct_of_id pct
,SUM(t.Cost) Cost
FROM TaskForCar t
JOIN Car car ON car.CarId = t.CarId
JOIN Repairman r ON r.RepairmanId = t.RepairmanId
JOIN dbo.func_GetAllWorkload('20200501', '20200601') g ON g.id = t.RepairmanId
WHERE t.FinishDate IS NULL AND t.StartDate >= '20200501' AND t.StartDate < '20200601'
GROUP BY ROLLUP ((r.FirstName, r.LastName, r.Patronymic, g.pct_of_id),(car.Brand,car.Model, t.StartDate, t.TaskForCarId))
GO

SELECT * FROM dbo.Task_3
ORDER BY [Date] , RepairmanName, CarName