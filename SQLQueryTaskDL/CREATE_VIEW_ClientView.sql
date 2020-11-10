CREATE VIEW ClientView AS
SELECT c.ClientId Id
, c.LastName
, c.FirstName
, c.Patronymic
, c.Phonenumber
, c.ResidentialAddress
, c.PassportData
, c.RegistrationDate
FROM Client c