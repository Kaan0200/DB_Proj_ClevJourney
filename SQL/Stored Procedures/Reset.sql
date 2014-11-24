CREATE PROC Reset AS
	drop table Traveler
	drop table Inventory
	drop table Items
	drop table Status
	drop table Player
	drop table Event
	begin EXEC Initial_DB_Setup end
	begin EXEC Initial_DB_Values end
	begin EXEC New_Player 'Joe' end
GO