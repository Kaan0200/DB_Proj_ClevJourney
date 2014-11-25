DB_Proj_ClevJourney
===================
#Cleveland Journey
Just a note about some of the backend stuff:

**Traveler**
- Name
- Warmth   
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

**Status**
- Status_Name (which is the new Primary Key for this table)
- Effects   (Type of Effect: Health, Hunger, Warmth)
- Value     (How much it effects the stat that the Effect indicates)


##Procedures
*All procedures can be called using the following in the query tab: `begin EXEC Procedure_Name 'Parameter' end`*

<d1>
<dt><b>Initial_DB_Setup</b></dt>
<dd>
Creates all of the tables for the database- empty.  That is: Player, Traveler, Status, Items, Events, Inventory.
</dd>

<dt><b>Initial_DB_Values</b></dt>
<dd>
Inserts all of the initial values necessary for standard gameplay.  The major exception being insertions into the Traveler table.  That's next.
</dd>

<dt><b>New_Player( @Player_Name )</b></dt>
<dd>
Inserts the standard 10 Travelers into the Traveler table, at full health, under the new Player's name, and also creates a new instance in the Player table.
</dd>

<dt><b>Reset</b></dt>
<dd>
Used for testing by dropping all tables and recreating them, currently with arbitrary player name 'Joe'.
</dd>

<dt><b>Testing commands</b></dt>
<dd>
What it sounds like- just a file that runs to confirm functionality of new procedures.
</dd>

<dt><b>Daily_Update</b></dt>
<dd>
A Daily event- it decrements all of the Travelers hunger by .1, and if Hunger is less than 0, set it to 0 and reduces the health of that traveler.
Recently revamped.  Now, in addition, this procedure deducts from a Traveler's Health, Hunger, or Warmth according to the Status that they have.  For example, a Status with a Value = .3 and Effects = 'Warmth' will have their Warmth deducted by .3.  Then if Warmth <= 0, it will deal damage to the Traveler.
If Health <= 0, this procedure prints out a little message saying that that Traveler died and deletes them from the Traveler table.
**This procedure also contains a TSQL for each loop, if that would be useful for anyone in any other part of the back end.**
</dd>

<dt><b>Consume( @Item_Id )</b></dt>
<dd>
The procedure that will eventually be called by the 'Use Item' button in the main interface.  Applies the effect of an item to every Traveler.  If it has I_Effect = 'FOOD', it will increase every traveler's Hunger stat.  If it is 'MEDICINE', it will increase the traveler's Health stat.  If 'Warmth', add to Warmth stat.  Then, regardless of the type, check for 'Cures' to match a status name in your team and cure them.  There are Foods, for instance, which can cure statuses.
</dd>

<dt><b>Afflict( @Trav_Name, @Status_Name )</b></dt>
<dd>
Afflicts the given Traveler with the given status.
</dd>
</d1>



Project for Databases class @ CWRU
