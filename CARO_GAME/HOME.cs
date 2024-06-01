using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_GAME
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            player1Form player1 = new player1Form();
            player1.Show();
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            string letterTitle = "A lovely goodbye";
            MessageBox.Show("Thank you for playing this game. See you again!", letterTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
