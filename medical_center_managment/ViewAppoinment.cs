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
    public partial class ViewAppoinment : Form
    {
        string connectionString = @"Data Source=LAPTOP-4VMD8P7I;Initial Catalog=medical_center;Integrated Security=True;";
        public ViewAppoinment()
        {
            InitializeComponent();
        }

        private void ViewAppoinment_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    // Open the connection
                    sqlCon.Open();

                    // Create a SqlDataAdapter to fetch data from the AppointmentDetailsView
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM AppointmentDetailsView", sqlCon);

                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();

                    // Fill the DataTable with data from the view
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void doctartb_TextChanged(object sender, EventArgs e)
        {
            appoinmenttb.Text = string.Empty;

        }

        private void appoinmenttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if DoctorID is provided
                if (!string.IsNullOrEmpty(doctartb.Text) && !string.IsNullOrEmpty(appodatetb.Text))
                {
                    int doctorID = int.Parse(doctartb.Text); // Parse the DoctorID from the textbox
                    DateTime appoinmentDate = DateTime.Parse(appodatetb.Text); // Parse the AppointmentDate from the textbox
                    // Call the SQL function to get total appointments for the doctor
                    int totalAppointments = GetTotalAppointmentsForDoctor(doctorID, appoinmentDate);

                    // Display the result in the textbox
                    appoinmenttb.Text = totalAppointments.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a Doctor ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private int GetTotalAppointmentsForDoctor(int doctorID, DateTime appoinmentDate)
        {
            int totalAppointments = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                // Open the connection
                sqlCon.Open();

                // Create a SqlCommand to execute the SQL function
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetTotalAppointmentsForDoctor(@DoctorID, @AppoinmentDate)", sqlCon))
                {
                    // Add parameter for DoctorID
                    cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                    cmd.Parameters.AddWithValue("@AppoinmentDate", appoinmentDate);

                    // Execute the command and get the result
                    totalAppointments = (int)cmd.ExecuteScalar();
                }
            }
            return totalAppointments;
        }

        private void appodatetb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
