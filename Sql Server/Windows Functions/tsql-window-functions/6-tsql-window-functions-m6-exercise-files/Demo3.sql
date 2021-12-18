/*
T-SQL Window Functions Class
Module 6
Demo 3
*/

USE PL_SampleData;
GO

--Step 1, view the data 
SELECT * FROM Subscription;




--Step 2, counts based on Dates
SELECT COUNT(*) AS NewSubCount, 
	DateJoined 
FROM Subscription
GROUP BY DateJoined;

SELECT COUNT(*) AS CancellationCount,
	DateLeft 
FROM Subscription
GROUP BY DateLeft;

--Step 3 join these two queries
WITH Joined AS (
	SELECT COUNT(*) AS NewSubCount, 
		DateJoined 
	FROM Subscription
	GROUP BY DateJoined),
Cancelled AS (
	SELECT COUNT(*) AS CancellationCount,
		DateLeft 
	FROM Subscription
	GROUP BY DateLeft)
SELECT DateJoined, NewSubCount, CancellationCount
FROM Joined 
LEFT JOIN Cancelled ON Joined.DateJoined = Cancelled.DateLeft;

--Step 4, running total
WITH Joined AS (
	SELECT COUNT(*) AS NewSubCount, 
		DateJoined 
	FROM Subscription
	GROUP BY DateJoined),
Cancelled AS (
	SELECT COUNT(*) AS CancellationCount,
		DateLeft 
	FROM Subscription
	GROUP BY DateLeft) 
SELECT DateJoined, NewSubCount, 
	CancellationCount,
	SUM(NewSubCount - ISNULL(CancellationCount,0)) 
	OVER(ORDER BY DateJoined 
		ROWS UNBOUNDED PRECEDING) AS CurrentSubscribers
FROM Joined 
LEFT JOIN Cancelled ON Joined.DateJoined = Cancelled.DateLeft;







WITH Joined AS (
	SELECT COUNT(*) AS NewSub, DateJoined 
	FROM Subscription 
	GROUP BY DateJoined),
 Cancelled AS
	(SELECT COUNT(*) AS Cancellation, DateLeft 
	FROM Subscription
	GROUP BY DateLeft)
SELECT DateJoined,	
	NewSub, Cancellation,
	SUM(NewSub - ISNULL(Cancellation,0)) OVER(ORDER BY DateJoined) 
FROM JOINED 
LEFT JOIN Cancelled ON Joined.DateJoined = Cancelled.DateLeft;


