CREATE PROC Delete_Player (@P_Name varchar(100))
AS
	DELETE FROM Traveler
	WHERE Player_Name = @P_Name;

	Delete From Player 
	Where Player_Name = @P_Name;
GO