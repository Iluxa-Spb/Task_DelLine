USE CarService
GO

CREATE VIEW Task_2 AS
SELECT r.LastName+' '+r.FirstName+' '+r.Patronymic RepairmanName
,car.Brand+' '+car.Model CarName
,t.StartDate [Date]
,SUM(t.Cost) Cost
FROM TaskForCar t
JOIN Car car ON car.CarId = t.CarId
JOIN Repairman r ON r.RepairmanId = t.RepairmanId
WHERE t.FinishDate IS NULL AND t.StartDate >= '20200501' AND t.StartDate < '20200601'
GROUP BY ROLLUP ((r.FirstName, r.LastName, r.Patronymic),(car.Brand,car.Model, t.StartDate, t.TaskForCarId))