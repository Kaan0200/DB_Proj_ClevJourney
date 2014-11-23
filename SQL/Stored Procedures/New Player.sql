CREATE PROC New_Player (@P_Name varchar(100))
AS
	INSERT INTO Player VALUES (
		@P_Name,
		250.00,
		12
		);
								--Name	   Warmth, Hunger, Health, Illness_Chance, Status_Id, Owner player
	Insert INTO Traveler VALUES ('Tommas'  , 1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Nicklmor', 1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Matteo',   1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Jameson',  1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Robert',   1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Marcos',   1.00, 1.00, 1.00, .1, 1, @P_Name );

	Insert INTO Traveler VALUES ('Janet',    1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Genetta',  1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Sharol',   1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Betheny',  1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Clarenta', 1.00, 1.00, 1.00, .1, 1, @P_Name );
	Insert INTO Traveler VALUES ('Judey',    1.00, 1.00, 1.00, .1, 1, @P_Name );

	--						Item_ID/name, Type, Value, Cures, Price_Avg
	Insert INTO Items VALUES('Beef','FOOD',.5,null,10);
	Insert INTO Items VALUES('Blueberries','FOOD',.1,null,3);
	Insert INTO Items VALUES('Cough Syrup','MEDICINE',.2,'Cough',5);
	Insert INTO Items VALUES('Penicilin','MEDICINE',.5,'Infection',15);
GO

-- Execute this stored procedure >  EXEC New_Player 'Name'
