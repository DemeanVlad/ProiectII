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
    public partial class FormManager : Form
    {
        SqlConnection myCon = new SqlConnection();
        public FormManager()
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
            // TODO: This line of code loads data into the 'proiect_II_DBDataSet3.Pet' table. You can move, or remove it, as needed.
            this.petTableAdapter2.Fill(this.proiect_II_DBDataSet3.Pet);

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
            tabControlPet.Hide();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPet);
            tabControlPet.Show();
        }
        private void buttonOwner_Click(object sender, EventArgs e)
        {
            MovePanel(buttonOwner);
            tabControlPet.Hide();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            tabControlPet.Hide();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            tabControlPet.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

       
    }
}
