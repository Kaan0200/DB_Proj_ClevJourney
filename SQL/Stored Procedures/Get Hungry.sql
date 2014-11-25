ALTER PROC Get_Hungry
AS

UPDATE Traveler
SET Hunger = ROUND(Hunger - .1,3)

UPDATE Traveler
SET Health = ROUND(Health - .3,3), Hunger = 0.0
WHERE Hunger <= 0

GO