CREATE PROC New_Player (@P_Name varchar(100))
AS
	INSERT INTO Player VALUES (
		@P_Name,
		250.00,
		12
		);
GO

-- Execute this stored procedure >  EXEC New_Player "Name"
