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
    }
}
