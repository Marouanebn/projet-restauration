using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_restauration
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            pbar.Value = 0;

        }

        private void pbar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 4;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();

                // Create an instance of the mainmenu form
                mainmenu main = new mainmenu();

                // Show the mainmenu form
                main.Show();

            }
        }
    }
}
