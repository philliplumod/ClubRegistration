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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(@"Data Source=LAYOUT-PC;Initial Catalog=db_data;Integrated Security=True");



        private void btnRegister_Click(object sender, EventArgs e)
        {
            connect.Open();
            string dataInsert = "INSERT INTO ClubMembers (StudentID,FirstName,MiddleName,LastName,Age,Gender,Program) VALUES ('"+int.Parse(txtStudentId.Text)+ "', '"+txtFirstName.Text+"', '"+txtMiddleName.Text+"', '"+txtLastName.Text+"', '"+int.Parse(txtAge.Text) +"', '"+cbGender+"', '"+cbProgram+"') ";
            SqlDataAdapter adapter = new SqlDataAdapter(dataInsert, connect);
            bool save = true;

            if(adapter.SelectCommand.ExecuteNonQuery() > 0)
            {
                if (save)
                {
                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

            connect.Close();


         

        }
    }
}
