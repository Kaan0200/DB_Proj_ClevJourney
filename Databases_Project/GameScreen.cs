using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // need this for connection

namespace Databases_Project
{
    public partial class GameScreen : Form
    {
        private String currentPlayerName;
        private SqlConnection cnn;

        private DataTable travelersTable;
        private DataColumn nameColumn;
        private DataColumn hungerColumn;
        private DataColumn statusColumn;
        private DataColumn healthColumn;
		private DataColumn warmthColumn;
        
        private int numTravelers;
        private int dayNum;

        public GameScreen(String playerName)
        {
            this.currentPlayerName = playerName;
            InitializeComponent();
        }

        // this happens when this form is closing down
        private void GameScreen_Closed(object sender, System.EventArgs e)
        {
        }

        // this happens when this form is starting up
        private void GameScreen_Load(object sender, System.EventArgs e)
        {
            cnn = new SqlConnection(Program.connectionString); // initialize

            refreshTravelerTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Remaining_Travelers, DayNum FROM Player WHERE Player.Player_name = '" + currentPlayerName + "'";
            cmd.Connection = cnn;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                object[] o = new object[2];
                reader.GetValues(o);
                numTravelers = int.Parse(o[0].ToString());
                dayNum = (int)(float.Parse(o[1].ToString()) * 10 + 1);
                cnn.Close();
            }
            catch(Exception ex) {
            }

            this.ProgressBar.Value = (dayNum - 1) / 10;

            // TODO: This line of code loads data into the 'journeyGame_DBClassDataSet.Crew' table. You can move, or remove it, as needed.
            this.crewTableAdapter.Fill(this.journeyGame_DBClassDataSet.Crew);
            SpecialButton.Enabled = false;

        }

        private void refreshTravelerTable()
        {
            travelersTable = new DataTable("Travelers");
            travelersTable.Columns.Add(nameColumn = new DataColumn("Name"));
			travelersTable.Columns.Add(statusColumn = new DataColumn("Status"));
			travelersTable.Columns.Add(healthColumn = new DataColumn("Health"));
			travelersTable.Columns.Add(warmthColumn = new DataColumn("Warmth"));
            travelersTable.Columns.Add(hungerColumn = new DataColumn("Hunger"));


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Name,Status_Name,Health,Warmth,Hunger " +
                              "From traveler t, status s " +
                              "WHERE t.Player_Name like '" + currentPlayerName + "' and t.Status_id = s.Status_Id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataReader reader;
            try
            {
                cnn.Open(); // start the connection
                reader = cmd.ExecuteReader();

                if (reader.HasRows) // validate that it returned something
                {
                    while (reader.Read()) // move to next row
                    {
                        DataRow row = travelersTable.NewRow();
                        object[] val = new object[5];
                        reader.GetValues(val);

                        row[0] = val[0].ToString(); row[1] = val[1].ToString(); 
                        row[2] = val[2].ToString(); row[3] = val[3].ToString();
						row[4] = val[4].ToString();
                        travelersTable.Rows.Add(row);
                    }
                }

                cnn.Close(); // close the connection, cannot access reader after this
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            travelersDataView.DataSource = travelersTable;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            // create a new command object
            SqlCommand cmd = new SqlCommand();
            // make the connection obj and get the connection string from the Program Class
            SqlConnection cnn = new SqlConnection(Program.connectionString);

            cmd.CommandText = "EXEC Next_Day "; // create command 
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close(); // open, do command, close
            
            //Check win/loss conditions
            dayNum++; //This need not be obtained from the database. We only need to get the number of remaining travelers.

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Remaining_Travelers FROM Player WHERE Player.Player_name = '" + currentPlayerName + "'";
            cmd.Connection = cnn;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                object[] o = new object[1];
                reader.GetValues(o);
                numTravelers = int.Parse(o[0].ToString());
                cnn.Close();
            }
            catch (Exception ex){
            }

            if (numTravelers == 0)
                // This causes the player to lose the game. This may be a call to open a new window or put text in the game screen
                // indicating that they lost the game.
            ;
            else if (dayNum > 10)
               // This causes the player to win the game (i.e. they survived a full 10 days, and they go to the next day). Similar to the
               // last statement, this may be a call to create a new window or type the victory message in the game screen.
            ;
        }
    }
}
