using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELife
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9HRRT6U\SQLEXPRESS;Initial Catalog=ELife;Integrated Security=True");


        private void labelBackBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string view_all = "SELECT * FROM Patients";
                SqlDataAdapter adapter = new SqlDataAdapter(view_all, con);

                //Fill Data to datagrid
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewDetails.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Insert Fields!");
            }
            else
            {
                try
                {
                    con.Open();
                    string view_IdName = "SELECT * FROM Patients WHERE ID=" + int.Parse(textBoxID.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(view_IdName, con);

                    //Fill Data to datagrid
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewDetails.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
