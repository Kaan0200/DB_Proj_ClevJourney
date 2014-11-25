CREATE PROC Daily_Update
AS

UPDATE Traveler
SET Hunger = ROUND(Hunger - .1,3)

--Damage the Travelers according to the status they have.
UPDATE Traveler
SET Health = ROUND(Health - (select Value from Status s where Traveler.Status_Name = s.Status_Name),3)
WHERE (select Effects from Status where Traveler.Status_Name = Status_Name) = 'Health'

UPDATE Traveler
SET Hunger = ROUND(Hunger - (select Value from Status s where Traveler.Status_Name = s.Status_Name),3)
WHERE (select Effects from Status where Traveler.Status_Name = Status_Name) = 'Hunger'

UPDATE Traveler
SET Warmth = ROUND(Warmth - (select Value from Status s where Traveler.Status_Name = s.Status_Name),3)
WHERE (select Effects from Status where Traveler.Status_Name = Status_Name) = 'Warmth'

UPDATE Traveler
SET Health = ROUND(Health - .3,3), Hunger = 0.0
WHERE Hunger <= 0

UPDATE Traveler
SET Health = ROUND(Health - .3,3), Warmth = 0.0
WHERE Warmth <= 0


/* This next part is a bit of a doozy, but essentially all that's going on is a for each loop.
	The cursor 'cur' stores all of the results of the given query and each time fetch is called it
	fetches the next result and performs some execution on it.
*/
DECLARE @name varchar(100)
DECLARE cur CURSOR LOCAL for
	select Name from Traveler where Health <= 0
open cur
fetch next from cur into @name
while @@FETCH_STATUS = 0 BEGIN
	print(@name + ' has died!' + CHAR(10) + CHAR(13))
	fetch next from cur into @name
END
close cur
deallocate cur

--If their Health is 0...gotta kill them.
DELETE from Traveler
WHERE Health <= 0

UPDATE Player
SET Remaining_Travelers = (select count(*) from Traveler where Traveler.Player_Name = Player.Player_Name)


GO