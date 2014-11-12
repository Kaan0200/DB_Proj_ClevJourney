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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            string connectionString;
            SqlConnection cnn; // make the connection object
            SqlDataReader reader;
            List<String> UserList = new List<string>(); // list of strings to hold the names


            //"Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            connectionString = "Data Source=KAAN-HP\\SQLEXPRESS;Initial Catalog=JourneyGame_DBClass;User ID=Kaan;Password=admin";
            SqlCommand cmd = new SqlCommand();
            cnn = new SqlConnection(connectionString);

            cmd.CommandText = "SELECT Player_Name FROM Player";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            try
            {
                cnn.Open(); // start the connection
                reader = cmd.ExecuteReader();


                if (reader.HasRows) // validate that it returned something
                {
                    while (reader.Read()) // move to next row
                    {
                        UserList.Add(reader.GetString(0)); // grab the string of the first column
                    }
                }

                cnn.Close(); // close the connection, cannot access reader after this
            }
            catch(Exception ex)
            {
                // did not work
            }

            SelectPlayerComboBox.DataSource = UserList;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = NewPlayerTextBox.Text;

            //this.Hide();
            var GameScreen = new GameScreen(); // make a new game screen
            GameScreen.Show(); // open the other
        }
    }
}
