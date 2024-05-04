﻿using System;
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
    public partial class AppoinmentDetails : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public AppoinmentDetails()
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
                    SqlCommand sqlCmd = new SqlCommand("insertAppoinment", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;                
                    sqlCmd.Parameters.AddWithValue("@appoinmentnumber", apponumbertb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@appoinmenttime", appotimetb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@appoinmentdate", appodatetb.Text.Trim());
                   sqlCmd.Parameters.AddWithValue("@patientid", PatientIDtb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@doctorid", doctorTB.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    display_data();
                    apponumbertb.Text = "";
                    PatientIDtb.Text = "";
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
            apponumbertb.Text = appotimetb.Text = appodatetb.Text = PatientIDtb.Text = doctorTB.Text =  "";
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
                    cmd.CommandText = "select * from Appoinments";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Appoinments WHERE AppoinmentNumber = '" + apponumbertb.Text + "'";
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

        private void AppoinmentDetails_Load(object sender, EventArgs e)
        {
            display_data();
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
                    cmd.CommandText = "SELECT * FROM Appoinments WHERE AppoinmentNumber =@appoinmentnumber OR PatientID = @patientid";
                    cmd.Parameters.AddWithValue("@appoinmentnumber", apponumbertb.Text.Trim());
                    cmd.Parameters.AddWithValue("@patientid", PatientIDtb.Text.Trim());
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
                    cmd.CommandText = "UPDATE Appoinments SET AppoinmentNumber = @appoinmentnumber, AppoinmentTime = @appoinmenttime, AppoinmentDate =@appoinmentdate, PatientID = @patientid, DoctarID = @doctorid";
                    cmd.Parameters.AddWithValue("@appoinmentnumber", apponumbertb.Text.Trim());
                    cmd.Parameters.AddWithValue("@appoinmenttime", appotimetb.Text.Trim());
                    cmd.Parameters.AddWithValue("@appoinmentdate", appodatetb.Text.Trim());
                    cmd.Parameters.AddWithValue("@patientid", PatientIDtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@doctorid", doctorTB.Text.Trim());

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

        private void button7_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            DoctarDetails DoctarDetails = new DoctarDetails();

            // Display the target form
            DoctarDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            ParentDetails ParentDetails = new ParentDetails();

            // Display the target form
            ParentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            AppoinmentDetails AppoinmentDetails = new AppoinmentDetails();

            // Display the target form
            AppoinmentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PatientHistoryDetails PatientHistoryDetails = new PatientHistoryDetails();

            // Display the target form
            PatientHistoryDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PaymentDetails PaymentDetails = new PaymentDetails();

            // Display the target form
            PaymentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }
    }
}
