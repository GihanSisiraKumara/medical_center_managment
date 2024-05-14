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
    public partial class LabassistantDetails : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public LabassistantDetails()
        {
            InitializeComponent();
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
                    cmd.CommandText = "select * from Labassistant";
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

        private void LabassistantDetails_Load(object sender, EventArgs e)
        {
            display_data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("insertlabassitant", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@assisid", idtb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@firstname", firsttb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@secondname", secondb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@gender", gendertb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@qualification", specialtb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", emailtb.Text.Trim());
                   
                    sqlCmd.ExecuteNonQuery();
                    display_data();
                    idtb.Text = "";
                   
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
            idtb.Text = firsttb.Text = secondb.Text = gendertb.Text = specialtb.Text = emailtb.Text =  "";
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
                    cmd.CommandText = "UPDATE Labassistant SET FirstName = @firstname, SecondName = @secondname, Gender = @gender, Qualification = @qualification, Email = @email WHERE LabassistantID = @assisid";
                    cmd.Parameters.AddWithValue("@assisid", idtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@firstname", firsttb.Text.Trim());
                    cmd.Parameters.AddWithValue("@secondname", secondb.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", gendertb.Text.Trim());
                    cmd.Parameters.AddWithValue("@qualification", specialtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", emailtb.Text.Trim());
                   
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Labassistant WHERE LabassistantID = '" + idtb.Text + "'";

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Labassistant WHERE LabassistantID = @assisid ";
                    cmd.Parameters.AddWithValue("@assisid", idtb.Text.Trim());
                   
                    cmd.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idtb.Text = reader["LabassistantID"].ToString();
                        firsttb.Text = reader["FirstName"].ToString();
                        secondb.Text = reader["SecondName"].ToString();
                        gendertb.Text = reader["Gender"].ToString();
                        specialtb.Text = reader["Qualification"].ToString();
                        emailtb.Text = reader["Email"].ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
