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

namespace Proiect_II
{
    public partial class FormHome : Form
    {
        SqlConnection myCon = new SqlConnection();
        public FormHome()
        {
            InitializeComponent();
            
            myCon.ConnectionString = @"Data Source = BETAKA\SQLEXPRESS; Initial Catalog = Proiect_II_DB; Integrated Security = True";
            myCon.Open();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

      

        private void FormHome_Load(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            labelWelcomeUser.Text = "Welcome, " + FormLogin.firstName + " " + FormLogin.lastName + "!";
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                FormLogin form = new FormLogin();
                form.Show();
                this.Close();
                return;
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
        }
    }
}
