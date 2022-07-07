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
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationDemo"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_RegistrationFormss", con))
                {
                    
                    if (TxtEmail.Text == "" && TxtPassword.Text == "" && TxtConfirmPass.Text == "")
                    {
                        MessageBox.Show("Email and Password fields are empty", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    else if (TxtPassword.Text == TxtConfirmPass.Text)
                    {
                        try
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                            cmd.Parameters.AddWithValue("@LastName", TxtLastName.Text);
                            cmd.Parameters.AddWithValue("@BirthDate", DtpBirthDate.Text);
                            cmd.Parameters.AddWithValue("@Gender", ComboGender.Text);
                            cmd.Parameters.AddWithValue("@EmailId", TxtEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                            cmd.Parameters.AddWithValue("@ConfirmPassword", TxtConfirmPass.Text);
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            cmd.ExecuteNonQuery();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                        MessageBox.Show("New Sign In Record Created!!");
                        LoginForm obj = new LoginForm();
                        obj.Show();
                    }
                   
                    else
                    {
                        MessageBox.Show("Passwords does not match, Please Re-enter", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtConfirmPass.Text = "";
                        TxtPassword.Text = "";
                        TxtPassword.Focus();
                    }
                }
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            DtpBirthDate.Text = "";
            ComboGender.Text = "";
            TxtEmail.Text = "";
            TxtPassword.Text = "";
            TxtConfirmPass.Text = "";
            TxtFirstName.Focus();
        }
    }
}