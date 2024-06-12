using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    internal class ProfessorData
    {
        
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\SQLDBCon.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string Professor_ID { set; get; }
        public string Professor_FName { set; get; }
        public string Professor_MName { set; get; }
        public string Professor_LName { set; get; }
        public string Professor_Gender { set; get; }
        public string Professor_Address { set; get; }
        public string Professor_Subject { set; get; }
        public string Professor_Image { set; get; }
        public string Status { set; get; }
        public string Date_Insert { set; get; }

        public List<ProfessorData> professorData()
        {
            List<ProfessorData> listData = new List<ProfessorData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM professor WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ProfessorData addPD = new ProfessorData();
                            addPD.ID = (int)reader["id"];
                            addPD.Professor_ID = reader["professor_id"].ToString();
                            addPD.Professor_FName = reader["professor_fname"].ToString();
                            addPD.Professor_MName = reader["professor_mname"].ToString();
                            addPD.Professor_LName = reader["professor_lname"].ToString();
                            addPD.Professor_Gender = reader["professor_gender"].ToString();
                            addPD.Professor_Address = reader["professor_address"].ToString();
                            addPD.Professor_Subject = reader["professor_subject"].ToString();
                            addPD.Professor_Image = reader["professor_image"].ToString();
                            addPD.Status = reader["professor_status"].ToString();
                            addPD.Date_Insert = reader["date_insert"].ToString();

                            listData.Add(addPD);
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
    }
}
