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

namespace medical_center_managment
{
    public partial class DoctarDetails : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public DoctarDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("insertDoctarData", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@doctorid", doctorTB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@firstname", firstTB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@secondname", secondTB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@hospital", hospitalTB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", emailTB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@specialization", specialTB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dotortype", typeTB.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Register is successfull !");
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        void Clear()
        {
            doctorTB.Text = firstTB.Text = secondTB.Text = hospitalTB.Text = emailTB.Text = specialTB.Text = typeTB.Text = "";
        }
    }
}
