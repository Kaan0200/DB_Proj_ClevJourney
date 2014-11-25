CREATE PROC Consume (@Item_id varchar(100))
AS

IF (select I_Effects from Items where Item_id = @Item_id) = 'FOOD'
BEGIN
	UPDATE Traveler
	SET Hunger = ROUND(Hunger + (select Value from Items where Item_id = @Item_id),3)

	UPDATE Traveler
	SET Hunger = 1.0
	WHERE Hunger > 1.0
END

IF (select I_Effects from Items where Item_id = @Item_id) = 'MEDICINE'
BEGIN
	UPDATE Traveler
	SET Health = ROUND(Health + (select Value from Items where Item_id = @Item_id),3)

	UPDATE Traveler
	SET Health = 1.0
	WHERE Health > 1.0
END

--Cures can apply to both Food and Medicine, so it's outside
UPDATE Traveler 
SET Status_Name = ' '
WHERE Status_Name = (select i.Cures from Items i where i.Item_id = @Item_id)

IF (@Item_id = 'Elixir')
BEGIN
	UPDATE Traveler
	SET Status_Name = ' '
END

GO