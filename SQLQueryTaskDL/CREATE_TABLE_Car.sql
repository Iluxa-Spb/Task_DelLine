USE CarService
GO

CREATE TABLE Car(
	CarId INT IDENTITY(1,1),
	ModelId INT NOT NULL REFERENCES CarModel(ModelId) ON DELETE CASCADE ON UPDATE CASCADE,
	ClientId INT NOT NULL REFERENCES Client(ClientId) ON DELETE CASCADE ON UPDATE CASCADE,
	LicensePlate NVARCHAR(15) NOT NULL,
	Mileage INT NOT NULL,
	EngineVolume FLOAT NOT NULL,
	RegistrationDate DATETIME NOT NULL DEFAULT(getdate()),
	CONSTRAINT PK_Car_CarId PRIMARY KEY CLUSTERED (CarId),
	CONSTRAINT DF_Car_Phonenumber_Unique UNIQUE (LicensePlate)
)
GO