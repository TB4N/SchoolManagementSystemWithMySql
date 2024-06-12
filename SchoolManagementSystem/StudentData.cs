using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace SchoolManagementSystem
{
    internal class StudentData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\SQLDBCon.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string StudentID { set; get; }
        public string StudentFName { set; get; }
        public string StudentMName { set; get; }
        public string StudentLName { set; get; }
        public string StudentGender { set; get; }
        public string StudentCsYr { set; get; }
        public string StudentSection { set; get; }
        public string Status { set; get; }
        public string StudentAddress { set; get; }
        public string StudentImage { set; get; }
        public string DateInsert { set; get; }

        public List<StudentData> studentData()
        {
            List<StudentData> listData = new List<StudentData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StudentData addSD = new StudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_ID"].ToString();
                            addSD.StudentFName = reader["student_FName"].ToString();
                            addSD.StudentMName = reader["student_MName"].ToString();
                            addSD.StudentLName = reader["student_LName"].ToString();
                            addSD.StudentGender = reader["student_gender"].ToString();
                            addSD.StudentAddress = reader["student_address"].ToString();
                            addSD.StudentCsYr = reader["student_CsYr"].ToString();
                            addSD.StudentSection = reader["student_section"].ToString();
                            addSD.StudentImage = reader["student_image"].ToString();
                            addSD.Status = reader["student_status"].ToString();
                            addSD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }

        
        public List<StudentData> dashboardStudentData()
        {
            List<StudentData> listData = new List<StudentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM students WHERE date_insert = @dateInsert " +
                    "AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StudentData addSD = new StudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_ID"].ToString();
                            addSD.StudentFName = reader["student_FName"].ToString();
                            addSD.StudentMName = reader["student_MName"].ToString();
                            addSD.StudentLName = reader["student_LName"].ToString();
                            addSD.StudentGender = reader["student_gender"].ToString();
                            addSD.StudentAddress = reader["student_address"].ToString();
                            addSD.StudentCsYr = reader["student_CsYr"].ToString();
                            addSD.StudentSection = reader["student_section"].ToString();
                            addSD.StudentImage = reader["student_image"].ToString();
                            addSD.Status = reader["student_status"].ToString();
                            addSD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
