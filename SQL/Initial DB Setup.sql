CREATE PROC Initial_DB_Setup AS

CREATE TABLE Player (
	Player_Name varchar(100)  PRIMARY KEY, -- the user playing the game
	Money       float(3),  -- the ingame money
	Remaining_Travelers int, -- how many people they still have alive, game is over at 0
	DayNum float(3) -- number of the ingame day, from 0.0 to 1.0; increases by 0.1 each "day"
);

CREATE TABLE Status (
	Status_Name varchar(100)     PRIMARY KEY,
	Effects     varchar(100),  -- Types: Health, Hunger, 
	Value       float
);

CREATE TABLE Traveler (
	Name        varchar(100),
	Warmth      float(3), -- 00.0 float
	Hunger      float(3), -- 00.0 float
	Health      float(3), -- 00.0 float
	Illness_Chance float,
	Status_Name   varchar(100), 
	Player_Name varchar(100),
	CONSTRAINT PK_PlayerTraveler PRIMARY KEY (Player_Name, Name),
	CONSTRAINT FK_StatusName FOREIGN KEY (Status_Name) REFERENCES Status (Status_Name)
);

CREATE TABLE Items (
	Item_ID		varchar(100)		PRIMARY KEY,
	I_Effects	varchar(100),  -- Types: Food, Medicine
	Value		float,
	Cures		varchar(100),  -- If it cures a specific disease, list here
	Price_avg	int,
	CONSTRAINT FK_Cures FOREIGN KEY (Cures) REFERENCES Status (Status_Name)
);

CREATE TABLE Inventory (
	Player_Name varchar(100) NOT NULL,
	Item_ID  varchar(100),
	Quantity int,
	CONSTRAINT FK_Player_Inventory FOREIGN KEY (Player_Name) REFERENCES Player (Player_Name),
	CONSTRAINT FK_Item_Inventory FOREIGN KEY (Item_ID) REFERENCES Items (Item_ID)
);

CREATE TABLE Event (
	E_Id        int     PRIMARY KEY,
	Chance      float,   -- 
	Description varchar, -- the user viewed description
	Type        varchar, -- the type: weather, terrain, 
	Value       float
);

GO