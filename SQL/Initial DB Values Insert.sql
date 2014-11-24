CREATE PROC Initial_DB_Values AS

INSERT INTO Status VALUES (' ', null, null); --No status defect - Healthy.  Blank to make the other statuses stand out.
INSERT INTO Status VALUES ('Cough', 'Health', .1);
INSERT INTO Status VALUES ('Infection', 'Health', .4); 
--						Item_ID/name, Type, Value, Cures, Price_Avg
	Insert INTO Items VALUES('Beef','FOOD',.5,null,10);
	Insert INTO Items VALUES('Blueberries','FOOD',.1,null,3);
	Insert INTO Items VALUES('Cough Syrup','MEDICINE',.2,'Cough',5);
	Insert INTO Items VALUES('Penicilin','MEDICINE',.5,'Infection',15);


GO