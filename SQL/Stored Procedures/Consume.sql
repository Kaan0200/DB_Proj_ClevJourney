ALTER PROC Consume (@Item_id varchar)
AS

IF (select I_Effects from Items where Item_id = @Item_id) = 'FOOD'
BEGIN
	UPDATE Traveler
	SET Hunger = Hunger + (select Value from Items where Item_id = @Item_id)

	UPDATE Traveler
	SET Hunger = 1.0
	WHERE Hunger > 1.0
END
GO