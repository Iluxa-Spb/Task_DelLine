USE CarService
GO

CREATE TABLE Repairman(
	RepairmanId int IDENTITY(1,1),
	FirstName nvarchar (50) NOT NULL,
	LastName nvarchar (50) NOT NULL,
	Patronymic nvarchar (50) NOT NULL,
	Phonenumber varchar (50) NOT NULL,
	DateOfEmployment DateTime NOT NULL,
	CONSTRAINT PK_Repairman_RepairmanId PRIMARY KEY CLUSTERED (RepairmanId),
	CONSTRAINT DF_Repairman_Name_Unique UNIQUE (FirstName, LastName, Patronymic),
	CONSTRAINT DF_Repairman_Phonenumber_Unique UNIQUE (Phonenumber)
)
GO

ALTER TABLE Repairman
ADD CONSTRAINT DF_Repairman_DateOfEmployment_Default DEFAULT (getdate()) FOR DateOfEmployment
GO