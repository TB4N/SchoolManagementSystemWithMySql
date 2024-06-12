using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\SQLDBCon.mdf;Integrated Security=True;Connect Timeout=30");
        public dashboard()
        {
            InitializeComponent();

            displayTotalES();
            displayTotalTP();
            displayTotalGS();

            displayEnrolledToday();
        }

        public void displayEnrolledToday()
        {
            StudentData addSD = new StudentData();
            enrolledToday.DataSource = addSD.dashboardStudentData();
        }

        public void displayTotalES()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_status = 'Enrolled' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempES = 0;
                        if (reader.Read())
                        {
                            tempES = Convert.ToInt32(reader[0]);

                            total_ES.Text = tempES.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalTP()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM professor WHERE professor_status = 'Active' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempTP = 0;
                        if (reader.Read())
                        {
                            tempTP = Convert.ToInt32(reader[0]);

                            total_TP.Text = tempTP.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalGS()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_status = 'Graduated' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempGS = 0;
                        if (reader.Read())
                        {
                            tempGS = Convert.ToInt32(reader[0]);

                            total_GS.Text = tempGS.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

    }
}
