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
    public partial class ParentDetails : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public ParentDetails()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("insertParentData", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@patientid", PatientIDtb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@firstname", Fnametb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@secondname", Snametb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@patientaddress", Paddresstb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@age", Agetb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@gender", Gendertb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@patientstatus", Statustb.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    display_data();
                    PatientIDtb.Text = "";
                    Fnametb.Text = "";
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
            PatientIDtb.Text = Fnametb.Text = Snametb.Text = Paddresstb.Text = Agetb.Text = Gendertb.Text = Statustb.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display_data()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Patient";
                    cmd.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void ParentDetails_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Patient WHERE PatientID = '" + PatientIDtb.Text + "'";

                    cmd.ExecuteNonQuery();
                    connectionString.Clone();
                    display_data();
                    MessageBox.Show("Delect is succesfull !");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Patient WHERE PatientID = @patientid OR FirstName = @firstname";
                    cmd.Parameters.AddWithValue("@patientid", PatientIDtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@firstname", Fnametb.Text.Trim());
                    cmd.ExecuteNonQuery();

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Patient SET FirstName = @firstname, SecondName = @secondname, PatientAddress = @patientaddress, Age = @age, Gender = @gender, PatientStatus = @patientstatus WHERE PatientID = @patientid";
                    cmd.Parameters.AddWithValue("@patientid", PatientIDtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@firstname", Fnametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@secondname", Snametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@patientaddress", Paddresstb.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", Agetb.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", Gendertb.Text.Trim());
                    cmd.Parameters.AddWithValue("@patientstatus", Statustb.Text.Trim());
                    cmd.ExecuteNonQuery();
                    display_data();
                    MessageBox.Show("Update is successful!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}