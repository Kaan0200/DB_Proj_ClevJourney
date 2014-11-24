CREATE PROC Afflict (@Trav_Name varchar(100), @Status_id int) AS
-- Created a procedure to afflict a certain traveler with a specific status
	UPDATE Traveler
	SET Status_id = @Status_id
	WHERE Name = @Trav_Name
Go