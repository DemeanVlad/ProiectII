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
    public partial class FormLogin : Form
    {
        public static string firstName;
        public static string lastName;
        SqlConnection myCon = new SqlConnection();

        public FormLogin()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            myCon.ConnectionString = @"Data Source = BETAKA\SQLEXPRESS; Initial Catalog = Proiect_II_DB; Integrated Security = True";
            myCon.Open();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
                pictureBoxEye.Image = Properties.Resources.eyeh;
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                pictureBoxEye.Image = Properties.Resources.eye;
            }
        }

        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Extrageți numele de utilizator și parola introduse de utilizator
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Construiți interogarea SQL pentru a căuta utilizatorul și parola în baza de date
            string query = "SELECT COUNT(*) FROM Login WHERE username=@username AND password=@password";

            // Creare comandă SQL și setarea parametrilor
            using (SqlCommand command = new SqlCommand(query, myCon))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0 && GetUserId(username) < 5)
                {
                    string nameQuery = "SELECT u.first_name, u.last_name FROM [User] u INNER JOIN Login l ON u.username_Id = l.username_Id WHERE l.username=@username";
                    using (SqlCommand nameCommand = new SqlCommand(nameQuery, myCon))
                    {
                        nameCommand.Parameters.AddWithValue("@username", username);
                        SqlDataReader reader = nameCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            firstName = reader["first_name"].ToString();
                            lastName = reader["last_name"].ToString();
                        }
                        reader.Close();
                    }

                    FormManager form = new FormManager();
                    form.Show();
                    this.Hide();
                    return;
                }
                else
                     if (count > 0 && GetUserId(username) >= 5)
                {
                    string nameQuery = "SELECT u.first_name, u.last_name FROM [Owner] u INNER JOIN Login l ON u.username_Id = l.username_Id WHERE l.username=@username";
                    using (SqlCommand nameCommand = new SqlCommand(nameQuery, myCon))
                    {
                        nameCommand.Parameters.AddWithValue("@username", username);
                        SqlDataReader reader = nameCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            firstName = reader["first_name"].ToString();
                            lastName = reader["last_name"].ToString();
                        }
                        reader.Close();
                    }

                    FormUser form = new FormUser();
                    form.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }

        private int GetUserId(string username)
        {
            string getUserIdQuery = "SELECT username_Id FROM Login WHERE username=@username";
            using (SqlCommand getUserIdCommand = new SqlCommand(getUserIdQuery, myCon))
            {
                getUserIdCommand.Parameters.AddWithValue("@username", username);
                return (int)getUserIdCommand.ExecuteScalar();
            }
        }

    }
}
