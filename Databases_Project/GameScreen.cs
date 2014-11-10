using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databases_Project
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'journeyGame_DBClassDataSet.Crew' table. You can move, or remove it, as needed.
            this.crewTableAdapter.Fill(this.journeyGame_DBClassDataSet.Crew);
            SpecialButton.Enabled = false;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
