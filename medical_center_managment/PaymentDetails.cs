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
    public partial class PaymentDetails : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public PaymentDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("insertPatientPayment", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@paymenttype", paytypetb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@paymentdate", paydatetb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@amount", amounttb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@patientid", patienttb.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@appoinmentID", appointb.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    patienttb.Text = "";
                    appointb.Text = "";
                    display_data();
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
            paytypetb.Text = paydatetb.Text = amounttb.Text = patienttb.Text = appointb.Text = "";
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
                    cmd.CommandText = "select * from PatentPayments";
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

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            DoctarDetails DoctarDetails = new DoctarDetails();

            // Display the target form
            DoctarDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            ParentDetails ParentDetails = new ParentDetails();

            // Display the target form
            ParentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the target form
            AppoinmentDetails AppoinmentDetails = new AppoinmentDetails();

            // Display the target form
            AppoinmentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PatientHistoryDetails PatientHistoryDetails = new PatientHistoryDetails();

            // Display the target form
            PatientHistoryDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
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
                    cmd.CommandText = "SELECT * FROM PatentPayments WHERE PatientID = @patientid OR AppoinmentID = @appoinmentID";
                    cmd.Parameters.AddWithValue("@patientid", patienttb.Text.Trim());
                    cmd.Parameters.AddWithValue("@appoinmentID", appointb.Text.Trim());
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

        private void button7_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PaymentDetails PaymentDetails = new PaymentDetails();

            // Display the target form
            PaymentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PharmacyPayment PharmacyPayment = new PharmacyPayment();

            // Display the target form
            PharmacyPayment.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            DrugsDetails DrugsDetails = new DrugsDetails();

            // Display the target form
            DrugsDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PatientDrudOrders PatientDrudOrders = new PatientDrudOrders();

            // Display the target form
            PatientDrudOrders.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void Test_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            LabTest LabTest = new LabTest();

            // Display the target form
            LabTest.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            LabassistantDetails LabassistantDetails = new LabassistantDetails();

            // Display the target form
            LabassistantDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }
    }
}
