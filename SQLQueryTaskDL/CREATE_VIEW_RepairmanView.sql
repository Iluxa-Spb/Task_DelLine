CREATE VIEW RepairmanView AS
SELECT t.RepairmanId Id
, t.LastName
, t.FirstName
, t.Patronymic
, t.Phonenumber
, t.DateOfEmployment
, DATEDIFF ( YEAR , t.DateOfEmployment , GETDATE() )  Experience
FROM Repairman t