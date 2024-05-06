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
   
    public partial class SupplyerOrderDetails : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public SupplyerOrderDetails()
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
                    cmd.CommandText = "select * from SuplyOrder";
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

        private void SupplyerOrderDetails_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            SupplyerOrderDetails SupplyerOrderDetails = new SupplyerOrderDetails();

            // Display the target form
            SupplyerOrderDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
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
            DoctarDetails DoctarDetails = new DoctarDetails();

            // Display the target form
            DoctarDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            AppoinmentDetails AppoinmentDetails = new AppoinmentDetails();

            // Display the target form
            AppoinmentDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            PharmacyPayment PharmacyPayment = new PharmacyPayment();

            // Display the target form
            PharmacyPayment.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            DrugsDetails DrugsDetails = new DrugsDetails();

            // Display the target form
            DrugsDetails.Show();

            // Optionally, hide the current form if you don't need it anymore
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
