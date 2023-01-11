using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source = LAYOUT - PC; Initial Catalog = db_data; Integrated Security = True");

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
        }
    }
}
