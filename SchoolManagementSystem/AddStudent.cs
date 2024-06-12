using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddStudent : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\SQLDBCon.mdf;Integrated Security=True;Connect Timeout=30");
        public AddStudent()
        {
            InitializeComponent();
            studentDisplayData();
        }

        public void studentDisplayData()
        {
            StudentData addSD = new StudentData();
            student_gridData.DataSource = addSD.studentData();
        }

        private void student_Add_Click(object sender, EventArgs e)
        {


            if (
                student_ID.Text == ""
                || student_FName.Text == ""
                || student_MName.Text == ""
                || student_LName.Text == ""
                || student_gender.Text == ""
                || student_address.Text == ""
                || student_CsYr.Text == ""
                || student_section.Text == ""
                || student_status.Text == ""
                || student_image.Image == null
                || imagePaths == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // WE DON'T LIKE THE DUPLICATE STUDENT ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY TEACHER ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", student_ID.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID: " + student_ID.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO students" +
                                    "(student_id, " +
                                    "student_FName," +
                                    "student_MName," +
                                    "student_LName," +
                                    "student_gender, " +
                                    "student_address, " +
                                    "student_CsYr, " +
                                    "student_section," +
                                    "student_image, " +
                                    "student_status, " +
                                    "date_insert) " +
                                    "VALUES(@studentID, " +
                                    "@studentFName, " +
                                    "@studentMName, " +
                                    "@studentLName, " +
                                    "@studentGender, " +
                                    "@studentAddress, " +
                                    "@studentCsYr, " +
                                    "@studentSection, " +
                                    "@studentImage, " +
                                    "@studentStatus, " +
                                    "@dateInsert)";

                                // TO SAVE TO YOUR DIRECTORY
                                string path = Path.Combine(@"D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\Student_Directory\", student_ID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(imagePaths, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", student_ID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentFName", student_FName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentMName", student_MName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentLName", student_LName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentCsYr", student_CsYr.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentImage", path);
                                    cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    studentDisplayData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            student_ID.Text = "";
            student_FName.Text = "";
            student_MName.Text = "";
            student_LName.Text = "";
            student_gender.SelectedIndex = -1;
            student_address.Text = "";
            student_CsYr.SelectedIndex = -1;
            student_section.SelectedIndex = -1;
            student_status.SelectedIndex = -1;
            student_image.Image = null;
            imagePath = null;
        }
        private void student_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_gridData.Rows[e.RowIndex];
                student_ID.Text = row.Cells[1].Value.ToString();
                student_FName.Text = row.Cells[2].Value.ToString();
                student_MName.Text = row.Cells[3].Value.ToString();
                student_LName.Text = row.Cells[4].Value.ToString();
                student_gender.Text = row.Cells[5].Value.ToString();
                student_CsYr.Text = row.Cells[6].Value.ToString();
                student_section.Text = row.Cells[7].Value.ToString();
                student_status.Text = row.Cells[8].Value.ToString();
                student_address.Text = row.Cells[9].Value.ToString();
                imagePaths = row.Cells[10].Value.ToString();
                string imageData = row.Cells[10].Value.ToString();

                if (imageData != null && imageData.Length > 0)
                {
                    student_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    student_image.Image = null;
                }


            }
        }
        public string imagePaths;
        private void student_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePaths = open.FileName;
                student_image.ImageLocation = imagePaths;
            }
        }

        private void student_Update_Click(object sender, EventArgs e)
        {
            if (student_ID.Text == ""
                || student_FName.Text == ""
                || student_MName.Text == ""
                || student_LName.Text == ""
                || student_gender.Text == ""
                || student_address.Text == ""
                || student_CsYr.Text == ""
                || student_section.Text == ""
                || student_status.Text == ""
                || student_image.Image == null
                || imagePaths == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Student ID: "
                            + student_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE students SET student_FName = @studentFName, " +
                                "student_MName = @studentMName," +
                                "student_LName = @studentLName," +
                                "student_gender = @studentGender, " +
                                "student_address = @studentAddress, " +
                                "student_CsYr = @studentCsYr, " +
                                "student_section = @studentSection, " +
                                "student_status = @studentStatus, " +
                                "date_update = @dateUpdate " +
                                "WHERE student_id = @studentID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentFName", student_FName.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentMName", student_MName.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentLName", student_LName.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentCsYr", student_CsYr.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());
                                cmd.Parameters.AddWithValue("@studentID", student_ID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                studentDisplayData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void student_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void student_Delete_Click(object sender, EventArgs e)
        {
            if (student_ID.Text == "")
            {
                MessageBox.Show("Please select Student ID first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Student ID: "
                        + student_ID.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE students SET date_delete = @dateDelete " +
                                "WHERE student_ID = @studentID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@studentID", student_ID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                studentDisplayData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}

