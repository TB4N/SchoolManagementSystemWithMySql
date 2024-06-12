using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddProfessor : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\SQLDBCon.mdf;Integrated Security=True;Connect Timeout=30");
        public AddProfessor()
        {
            InitializeComponent();
            professorDisplayData();
        }
        public void professorDisplayData()
        {
            ProfessorData addPD = new ProfessorData();
            professor_gridData.DataSource = addPD.professorData();
        }

        private void professor_addBtn_Click(object sender, EventArgs e)
        {
            if (professor_ID.Text == ""
                || professor_FName.Text == ""
                || professor_MName.Text == ""
                || professor_LName.Text == ""
                || professor_gender.Text == ""
                || professor_address.Text == ""
                || professor_status.Text == ""
                || professor_subject.Text == ""
                || professor_image.Image == null
                || imagePath == null)
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

                        // WE DON'T LIKE THE DUPLICATE professor ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY professor ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkprofessorID = "SELECT COUNT(*) FROM professor WHERE professor_ID = @professorID";

                        using (SqlCommand checkPID = new SqlCommand(checkprofessorID, connect))
                        {
                            checkPID.Parameters.AddWithValue("@professorID", professor_ID.Text.Trim());
                            int count = (int)checkPID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Professor ID: " + professor_ID.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO professor " +
                                    "(professor_id, " +
                                    "professor_fname, " +
                                    "professor_mname, " +
                                    "professor_lname, " +
                                    "professor_gender, " +
                                    "professor_address, " +
                                    "professor_image, " +
                                    "professor_status, " +
                                    "professor_subject, " +
                                    "date_insert) " +
                                    "VALUES(@professorID, " +
                                    "@professorFName," +
                                    "@professorMName, " +
                                    "@professorLName, " +
                                    "@professorGender, " +
                                    "@professorAddress," +
                                    "@professorImage, " +
                                    "@professorStatus, " +
                                    "@professorSubject, " +
                                    "@dateInsert)";

                                // TO SAVE TO YOUR DIRECTORY
                                string path = Path.Combine(@"D:\Visual Studio C# .NET C++\SchoolManagementSystem\SchoolManagementSystem\Professor_Directory\", professor_ID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(imagePath, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@professorID", professor_ID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorFName", professor_FName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorMName", professor_MName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorLName", professor_LName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorGender", professor_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorAddress", professor_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorImage", path);
                                    cmd.Parameters.AddWithValue("@professorStatus", professor_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@professorSubject", professor_subject.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    professorDisplayData();

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
            professor_ID.Text = "";
            professor_FName.Text = "";
            professor_MName.Text = "";
            professor_LName.Text = "";
            professor_gender.SelectedIndex = -1;
            professor_address.Text = "";
            professor_status.SelectedIndex = -1;
            professor_subject.SelectedIndex = -1;
            professor_image.Image = null;
            imagePath = null;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private string imagePath;
        private void professor_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                professor_image.ImageLocation = imagePath;
            }
        }

        private void professor_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void professor_updateBtn_Click(object sender, EventArgs e)
        {
            if (
                professor_ID.Text == ""
                || professor_FName.Text == ""
                || professor_MName.Text == ""
                || professor_LName.Text == ""
                || professor_gender.Text == ""
                || professor_address.Text == ""
                || professor_status.Text == ""
                || professor_subject.Text == ""
                || professor_image.Image == null)
            {
                MessageBox.Show("Please select Professor ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        DialogResult check = MessageBox.Show("Are you sure you want to Update Professor ID: "
                            + professor_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE professor SET " +
                                "professor_FName = @professorFName, " +
                                "professor_MName = @professorMName, " +
                                "professor_LName = @professorLName, " +
                                "professor_gender = @professorGender, " +
                                "professor_address = @professorAddress, " +
                                "professor_status = @professorStatus, " +
                                "professor_subject = @professorSubject, " +
                                "date_update = @dateUpdate WHERE professor_ID = @professorID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@professorFName", professor_FName.Text.Trim());
                                cmd.Parameters.AddWithValue("@professorMName", professor_MName.Text.Trim());
                                cmd.Parameters.AddWithValue("@professorLName", professor_LName.Text.Trim());
                                cmd.Parameters.AddWithValue("@professorGender", professor_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@professorAddress", professor_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@professorStatus", professor_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@professorSubject", professor_subject.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());
                                cmd.Parameters.AddWithValue("@professorID", professor_ID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                professorDisplayData();

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (professor_ID.Text == "")
            {
                MessageBox.Show("Please select Professor ID", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Professor ID: "
                        + professor_ID.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE professor SET date_delete = @dateDelete " +
                                "WHERE professor_ID = @professorID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@professorID", professor_ID.Text.Trim());
                                cmd.ExecuteNonQuery();
                                professorDisplayData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                          MessageBox.Show("Error  connecting Database: " + ex, "Error Message"
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

        private void professor_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = professor_gridData.Rows[e.RowIndex];
                professor_ID.Text = row.Cells[1].Value.ToString();
                professor_FName.Text = row.Cells[2].Value.ToString();
                professor_MName.Text = row.Cells[3].Value.ToString();
                professor_LName.Text = row.Cells[4].Value.ToString();
                professor_gender.Text = row.Cells[5].Value.ToString();
                professor_address.Text = row.Cells[6].Value.ToString();
                professor_subject.Text = row.Cells[7].Value.ToString();
                imagePath = row.Cells[8].Value.ToString();
                string imageData = row.Cells[8].Value.ToString();

                if (imageData != null && imageData.Length > 0)
                {
                    professor_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    professor_image.Image = null;
                }
                professor_status.Text = row.Cells[9].Value.ToString();
            }
        }

        private void professor_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
