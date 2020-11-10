USE CarService
GO

CREATE TABLE Client(
	ClientId int IDENTITY(1,1),
	FirstName nvarchar (50) NOT NULL,
	LastName nvarchar (50) NOT NULL,
	Patronymic nvarchar (50) NOT NULL,
	Phonenumber varchar (50) NOT NULL,
	ResidentialAddress nvarchar (200) NOT NULL,
	PassportData nvarchar (200) NOT NULL,
	RegistrationDate DateTime NOT NULL,
	CONSTRAINT PK_Client_ClientId PRIMARY KEY CLUSTERED (ClientId),
	CONSTRAINT DF_Client_Name_Unique UNIQUE (FirstName, LastName, Patronymic),
	CONSTRAINT DF_Client_Phonenumber_Unique UNIQUE (Phonenumber)
)
GO

ALTER TABLE Client
ADD CONSTRAINT DF_Client_RegistrationDate_Default DEFAULT (getdate()) FOR RegistrationDate
GO