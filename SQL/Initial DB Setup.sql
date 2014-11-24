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
	Status_id   int,   -- I'm wondering about this.  Maybe instead of showing the ID, we should display the name of their status?
	Player_Name varchar(100),
	CONSTRAINT PK_PlayerTraveler PRIMARY KEY (Player_Name, Name)
);

GO

CREATE TABLE Status (
	Status_Name varchar(100),
	Status_Id   int      PRIMARY KEY,
	Effects     varchar(100),  -- Types: Health, Hunger, 
	Value       float,
);

GO

CREATE TABLE Items (
	Item_ID		varchar(100)		PRIMARY KEY,
	I_Effects	varchar(100),  -- Types: Food, Medicine
	Value		float,
	Cures		varchar(100),  -- If it cures a specific disease, list here
	Price_avg	int,
);

GO

CREATE TABLE Inventory (
	Player_Name varchar(100) NOT NULL,
	Item_ID  varchar(100),
	Quantity int,
	CONSTRAINT FK_Player_Inventory FOREIGN KEY (Player_Name) REFERENCES Player (Player_Name),
	CONSTRAINT FK_Item_Inventory FOREIGN KEY (Item_ID) REFERENCES Items (Item_ID)
);

GO

CREATE TABLE Event (
	E_Id        int     PRIMARY KEY,
	Chance      float,   -- 
	Description varchar, -- the user viewed description
	Type        varchar, -- the type: weather, terrain, 
	Value       float
)
