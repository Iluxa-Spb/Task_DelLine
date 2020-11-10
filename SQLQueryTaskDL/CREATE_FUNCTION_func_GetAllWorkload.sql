DROP FUNCTION IF EXISTS func_GetAllWorkload
GO

CREATE FUNCTION func_GetAllWorkload(@StartDate datetime, @EndDate datetime)
RETURNS TABLE
AS
RETURN SELECT t.RepairmanId id
,CAST(ROUND(100.0
* t.Repairman_count
/ (SELECT COUNT(*) FROM TaskForCar WHERE StartDate >= @StartDate AND StartDate <= @EndDate)
,2) AS decimal(16, 2)) pct_of_id
FROM(
	SELECT RepairmanId, COUNT(*) Repairman_count
	FROM TaskForCar
	GROUP BY RepairmanId
	) t
GO

SELECT * from dbo.func_GetAllWorkload('20200501', '20200601')
GO