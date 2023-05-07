using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1
{
    public partial class VendettaLogin : Form
    {
        public VendettaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="Vendetta" && txtpassword.Text=="Vendetta123")
            {
                new VENDETTA().Show();
                this.Hide();

                }

                    else
                    {
                        MessageBox.Show("The username or password you entered is wrong.");
                        txtUsername.Clear();
                        txtpassword.Clear();
                        txtUsername.Focus();
                    }
                }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }    
}
