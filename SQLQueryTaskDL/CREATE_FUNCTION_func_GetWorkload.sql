DROP FUNCTION IF EXISTS func_GetWorkload
GO

CREATE FUNCTION func_GetWorkload(@Id int, @StartDate datetime, @EndDate datetime)
RETURNS FLOAT
AS
BEGIN
	DECLARE @Perc float

	SELECT @Perc = ROUND(100.0
	* (SELECT COUNT(*) FROM TaskForCar WHERE StartDate >= @StartDate AND StartDate <= @EndDate AND RepairmanId = @Id)
	/ (SELECT COUNT(*) FROM TaskForCar WHERE StartDate >= @StartDate AND StartDate <= @EndDate)
	,2)
	FROM TaskForCar

	RETURN @Perc
END
GO

SELECT dbo.func_GetWorkload('30', '20200501', '20200601')
GO

--SELECT @EndDate = DATEADD(month, 1, @StartDate)