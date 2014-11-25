DB_Proj_ClevJourney
===================
#Cleveland Journey
Just a note about some of the backend stuff:

**Traveler**
- Name
- Warmth   (Nothing's been done with this yet)
- Hunger
- Health
- Illness Chance   (Nothing's been done with this yet)
- Status_Name
- Player_Name

**Items**
- Item Name (as Item_ID)
- Type of Item (as I_Effects)
- Value (Can contribute to either Health or Hunger)
- Cures (A Status_Name.  If you consume an item that has a 'Cures' field that matches the status of one of your travelers, it will make them healthy again)
- Average Price (as Price_avg)


##Procedures
*All procedures can be called using the following in the query tab: `begin EXEC Procedure_Name 'Parameter' end`*

**`Initial_DB_Setup`**

Creates all of the tables for the database- empty.  That is: Player, Traveler, Status, Items, Events, Inventory.

**`Initial_DB_Values`**

Inserts all of the initial values necessary for standard gameplay.  The major exception being insertions into the Traveler table.  That's next.

**`New_Player( @Player_Name )`**

Inserts the standard 10 Travelers into the Traveler table, at full health, under the new Player's name, and also creates a new instance in the Player table.

**`Reset`**

Used for testing by dropping all tables and recreating them, currently with arbitrary player name 'Joe'.

**`Testing commands`**

What it sounds like- just a file that runs to confirm functionality of new procedures.

**`Get Hungry`**

A Daily event- it decrements all of the Travelers hunger by .1, and if Hunger is less than 0, set it to 0 and reduces the health of that traveler.

**`Consume( @Item_Id )`**

The procedure that will eventually be called by the 'Use Item' button in the main interface.  Applies the effect of an item to every Traveler.  If it has I_Effect = 'FOOD', it will increase every traveler's Hunger stat.  If it is 'MEDICINE', it will check for 'Cures' to match a status name in your team and cure them.

**`Afflict( @Trav_Name, @Status_Name )`**

Afflicts the given Traveler with the given status.

Project for Databases class @ CWRU
