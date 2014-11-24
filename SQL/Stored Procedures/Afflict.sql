CREATE PROC Afflict(@Trav_Name varchar(100), @Status_Name varchar(100)) AS
-- Created a procedure to afflict a certain traveler with a specific status
	UPDATE Traveler
	SET Status_Name = @Status_Name
	WHERE Name = @Trav_Name
Go