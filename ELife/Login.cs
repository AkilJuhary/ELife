using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELife
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {
            
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = textBoxUN.Text;
            String passWord = textBoxPW.Text;

            if (userName == "admin" && passWord == "admin")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Incorrect Password or Username!","Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
