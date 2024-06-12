using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard dForm = new Dashboard();
            //dForm.displayEnrolledStudentToday();
            //dForm.displayTotalGS();
            //dForm.displayTotalTT();
            //dForm.displayTotalES();

            dashboard2.Visible = true;
            dashboard1.Update();
            addStudent1.Visible = false;
            addProfessor1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            dashboard2.Visible = false;
            addStudent1.Visible = true;
            addStudent1.Update();
            addProfessor1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            dashboard2.Visible=false;
            addStudent1.Visible = false;
            addProfessor1.Visible = true;
            addProfessor1.Update();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm LogForm = new LoginForm();
                LogForm.Show();
                this.Hide();
            }
        }
    }
}
