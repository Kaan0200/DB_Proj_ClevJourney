ALTER PROC Consume (@Item_id varchar(100))
AS

IF (select I_Effects from Items where Item_id = @Item_id) = 'FOOD'
BEGIN
	UPDATE Traveler
	SET Hunger += (select Value from Items where Item_id = @Item_id)

	UPDATE Traveler
	SET Hunger = 1.0
	WHERE Hunger > 1.0
END

IF (select I_Effects from Items where Item_id = @Item_id) = 'MEDICINE'
BEGIN
	UPDATE Traveler 
	SET Status_id = 1
	WHERE (select i.Cures from Items i where i.Item_id = @Item_id) = (select s.Status_name from Status s where s.Status_id = t.Status_id)
END
GO