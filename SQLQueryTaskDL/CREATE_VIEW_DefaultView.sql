CREATE VIEW DefaultView AS
SELECT t.TaskForCarId Id
, r.LastName+' '+r.FirstName+' '+r.Patronymic RepairmanName
, car.Brand+' '+car.Model CarName
, c.LastName+' '+c.FirstName+' '+c.Patronymic ClientName
, t.VehicleMalfunction
, t.StartDate
, t.FinishDate
, t.Cost Cost
FROM TaskForCar t
JOIN Car car ON car.CarId = t.CarId
JOIN Repairman r ON r.RepairmanId = t.RepairmanId
JOIN Client c ON c.ClientId = car.ClientId