USE CarService
GO

CREATE TABLE CarBrand(
	BrandId int IDENTITY(1,1),
	Brand varchar (50) NOT NULL,
	CONSTRAINT PK_CarBrand_BrandId PRIMARY KEY CLUSTERED (BrandId),
	CONSTRAINT DF_CarBrand_Brand_Unique UNIQUE (Brand)
)
GO
