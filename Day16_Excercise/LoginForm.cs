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
using System.Configuration;

namespace Day16_Excercise
{
    public partial class LoginForm : Form
    {
        static int attempt = 3;
        private SqlConnection con = null;
        private SqlCommand cmd = null;
      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationDemo"].ConnectionString))
            {
                using (cmd = new SqlCommand("select count(*) as Count from RegistrationFormss where EmailId = @EmailId and Password = @Password", con))
                { 
                    if (attempt == 0)
                    {
                        MessageBox.Show("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                        return;
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@EmailId", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                    }
                    else
                    {
                        MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                        --attempt;
                        TxtEmail.Clear();
                        TxtPassword.Clear();
                    }
                }
            }
        }
    }
 }

