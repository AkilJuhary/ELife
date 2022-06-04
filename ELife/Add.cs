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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9HRRT6U\SQLEXPRESS;Initial Catalog=ELife;Integrated Security=True");
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string insert_query = "INSERT INTO Patients(Name,ID,Address,Gender,Diagnosis,Department) VALUES('"+ textBoxName.Text + "','"+ textBoxID.Text + "','" + textBoxAddress.Text + "','" + comboBoxGender.Text + "','" + textBoxDiagnosis.Text + "','" + comboBoxDepartment.Text + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(insert_query,con);
                adapter.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Submitted Successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            finally
            {
                con.Close();
            }
        }   
    }
}
