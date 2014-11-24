begin EXEC Reset end

begin EXEC Get_Hungry end
begin EXEC Get_Hungry end
begin EXEC Get_Hungry end
begin EXEC Get_Hungry end  -- Hunger -.4

begin EXEC Consume 'Blueberries' end -- Hunger + .1

begin EXEC Afflict 'Betheny','Cough' end -- Betheny and Janet get sick

begin EXEC Afflict 'Janet','Infection' end

--begin EXEC Consume 'Cough Syrup' end --Uncomment to cure Betheny

select * from Traveler