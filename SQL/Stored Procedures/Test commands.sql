begin EXEC Reset end

begin EXEC Afflict 'Marcos', 'Munchies' end
begin EXEC Daily_Update end
begin EXEC Daily_Update end
begin EXEC Afflict 'Betheny','Cough' end -- Betheny and Janet get sick
begin EXEC Afflict 'Janet','Infection' end
begin EXEC Daily_Update end
begin EXEC Daily_Update end  -- Hunger -.4

begin EXEC Consume 'Blueberries' end -- Hunger + .1

begin EXEC Daily_Update end

--begin EXEC Consume 'Cough Syrup' end --Uncomment to cure Betheny

select * from Traveler