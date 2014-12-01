CREATE PROC Initial_DB_Values AS
--						Status_Name, Effects, Value							
INSERT INTO Status VALUES ('Healthy', null, 0);
INSERT INTO Status VALUES('Nasal Drip', 'Health', .1);
INSERT INTO Status VALUES ('Cough', 'Health', .1);
INSERT INTO Status VALUES ('Infection', 'Health', .4);
INSERT INTO Status VALUES ('Munchies', 'Hunger', .3);
INSERT INTO Status VALUES ('Extreme Munchies', 'Hunger', .7);
INSERT INTO Status VALUES ('Chills', 'Warmth', .3);
INSERT INTO Status VALUES ('Dysentry', 'Health', .6); --The truly deadly...dysentry. 
--						Item_ID/name, Type, Value, Cures, Price_Avg
	Insert INTO Items VALUES('Beef','FOOD',.5,null,15);
	Insert INTO Items VALUES('Blueberries','FOOD',.1,null,3);
	Insert INTO Items VALUES('Bubble Tea','FOOD',.2,null,5);
	Insert INTO Items VALUES('Stew','FOOD',.4,'Chills',12);
	Insert INTO Items VALUES('Doritos', 'FOOD',0.05,'Munchies',2);
	Insert INTO Items VALUES('Orange Juice', 'FOOD', .1, 'Nasal Drip', 4);
	Insert INTO Items VALUES('Cough Syrup','MEDICINE',.2,'Cough',5);
	Insert INTO Items VALUES('Penicilin','MEDICINE',.5,'Infection',15);
	Insert INTO Items VALUES('Elixir', 'MEDICINE', 0, null, 100); --Cures all Status effects


GO