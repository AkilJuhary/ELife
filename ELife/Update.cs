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
    public partial class Update : Form
    {
        public Update()
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

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSearchID.Text))
            {
                MessageBox.Show("Insert Fields!");
            }
            else
            {
                try
                {
                    con.Open();
                    string view_IdName = "SELECT * FROM Patients WHERE ID=" + int.Parse(textBoxSearchID.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(view_IdName, con);

                    //Fill Data to datagrid
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewUpdate.DataSource = dt;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string update_query = "UPDATE Patients SET ID='"+ textBoxID.Text + "',Name='" + textBoxName.Text + "',Address='" + textBoxAddress.Text + "',Gender='" + comboBoxGender.Text + "',Diagnosis='" + textBoxDiagnosis.Text + "',Department='" + comboBoxDepartment.Text + "' WHERE ID='"+ textBoxSearchID.Text + "'";
                SqlDataAdapter adapter= new SqlDataAdapter(update_query, con);

                //Fill Data to Grid
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUpdate.DataSource = dt;

                //Confirm update
                MessageBox.Show("Successfully Updated");
            }
            catch (Exception ex)
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
