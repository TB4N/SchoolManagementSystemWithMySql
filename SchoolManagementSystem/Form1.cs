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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingTime.Start();
        }

        private void loadingTime_Tick(object sender, EventArgs e)
        {
            if (loadingBar.Value < 100)
            {
                loadingBar.Value += 2;
                loadingLabel.Text = "Loading... " + loadingBar.Value.ToString() + "%";
            }
            else
            {
                loadingTime.Stop();
                LoginForm LogForm = new LoginForm();
                LogForm.Show();
                this.Hide();
            }
        }
    }
}
