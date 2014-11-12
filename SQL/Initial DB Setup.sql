CREATE TABLE Player (
	Player_Name varchar(100)  PRIMARY KEY, -- the user playing the game
	Money       float(3),  -- the ingame money
	Remaining_Travelers int -- how many people they still have alive, game is over at 0
);

GO

CREATE TABLE Traveler (
	Name        varchar(100),
	Warmth      float(3), -- 00.0 float
	Hunger      float(3), -- 00.0 float
	Health      float(3), -- 00.0 float
	Illness_Chance float,
	Status_id   int, 
	Player_Name varchar(100),
	CONSTRAINT PK_PlayerTraveler PRIMARY KEY (Player_Name, Name)
);

GO

CREATE TABLE Status (
	Status_Name varchar,
	Status_Id   int      PRIMARY KEY,
	Effects     varchar,  -- Types: Health, Hunger, 
	Value       float,
);

GO

CREATE TABLE Inventory (
	Player_Name varchar(100) NOT NULL,
	Item_ID  varchar,
	Quantity int,
	CONSTRAINT FK_Player_Inventory FOREIGN KEY (Player_Name) REFERENCES Player (Player_Name)
);

GO

CREATE TABLE Event (
	E_Id        int     PRIMARY KEY,
	Chance      float,   -- 
	Description varchar, -- the user viewed description
	Type        varchar, -- the type: weather, terrain, 
	Value       float
)