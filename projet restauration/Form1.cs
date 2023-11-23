using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet_restauration
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=restauration;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnlogin;


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) from login where username='" + txtiduser.Text + "' and password = '" + txtpassword.Text + "'",con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                loading main = new loading();
                main.Show();
            }
            else
            {
                MessageBox.Show("username or password is incorect");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            newacc nwac = new newacc();
            nwac.Show();
        }
    }
}
