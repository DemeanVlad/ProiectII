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
    public partial class FormUser : Form
    {
        SqlConnection myCon = new SqlConnection();
        public FormUser()
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


        private void FormUser_Load(object sender, EventArgs e)
        {
           
            labelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            labelWelcomeUser.Text = "Welcome, " + FormLogin.firstName + " " + FormLogin.lastName + "!";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

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

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            tabControlReservation.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MovePanel(buttonHome);
            tabControlReservation.Hide();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            tabControlReservation.Hide();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MovePanel(buttonAbout);
            tabControlReservation.Hide();
        }

    }
}
