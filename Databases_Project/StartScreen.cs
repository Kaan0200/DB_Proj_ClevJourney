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

        List<String> UserList = new List<String>(); // this is the list of database Users
        String connectionString; //  the connection string that will be used to access DB


        public StartScreen()
        {
            InitializeComponent();

            SqlConnection cnn; // make the connection object
            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand();
            cnn = new SqlConnection(Program.connectionString);

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

        private void NewPlayerButton_Click(object sender, EventArgs e)
        {
            var name = NewPlayerTextBox.Text; // hang onto the text from the input box to make life easier

            // this is a predicate, anonymous function, logically reads "In UserList return true if any thing in the
            // list equals name.
            if (UserList.Any(s => s.Equals(name))){
                throw new Exception("There already exists a player with that name");
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Must input a valid username");
            }
            
            // create a new command object
            SqlCommand cmd = new SqlCommand();
            // make the connection obj and get the connection string from the Program Class
            SqlConnection cnn = new SqlConnection(Program.connectionString); 

            cmd.CommandText = "EXEC New_Player '"+name+"'"; // create command
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close(); // open, do command, close

            //this.Hide();
            var GameScreen = new GameScreen(name); // make a new game screen
            GameScreen.Show(); // open the other
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            var selectedPlayer = SelectPlayerComboBox.SelectedValue;

            // create a new command object
            SqlCommand cmd = new SqlCommand();
            // make the connection obj and get the connection string from the Program Class
            SqlConnection cnn = new SqlConnection(Program.connectionString);

            cmd.CommandText = "EXEC Delete_Player " + selectedPlayer; // create command 
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close(); // open, do command, close
        }

        private void ResumePlayerButton_Click(object sender, EventArgs e)
        {
            var GameScreen = new GameScreen(SelectPlayerComboBox.SelectedItem.ToString()); 
            GameScreen.Show(); // open the other
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
