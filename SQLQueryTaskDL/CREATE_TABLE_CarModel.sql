USE CarService
GO

CREATE TABLE CarModel(
	ModelId int IDENTITY(1,1),
	BrandId int NOT NULL REFERENCES CarBrand (BrandId) ON DELETE CASCADE ON UPDATE CASCADE,
	Model varchar (50) NOT NULL,
	CONSTRAINT PK_CarModel_ModelId PRIMARY KEY CLUSTERED (ModelId),
	CONSTRAINT DF_CarModel_Model_Unique UNIQUE (BrandId, Model)
)
GO