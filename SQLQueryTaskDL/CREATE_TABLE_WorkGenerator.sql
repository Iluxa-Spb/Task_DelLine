USE CarService
GO

CREATE TABLE WorkGenerator(
	Id INT IDENTITY(1,1),
	WorkName NVARCHAR(200) NOT NULL,
	Cost INT NOT NULL,
	CONSTRAINT PK_WorkGenerator_Id PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT DF_WorkGenerator_WorkNameCost_Unique UNIQUE (WorkName, Cost)
)
GO