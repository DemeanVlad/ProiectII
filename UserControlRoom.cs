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
    public partial class UserControlRoom : UserControl
    {
        SqlConnection myCon = new SqlConnection();

        public UserControlRoom()
        {
            InitializeComponent();

            myCon.ConnectionString = @"Data Source=DELL-SPEK-T3R\SQLEXPRESS;Initial Catalog=Proiect_II_DB;Integrated Security=True";
            myCon.Open();
        }
    }
}
