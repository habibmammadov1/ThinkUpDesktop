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
using ThinkUpProject.Repetitions;

namespace ThinkUpProject
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=true";
        bool isRight = false;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterLeftSide.BackColor = Utilities.PanelColor;

             txtPassword.PasswordChar = '*';
             txtConfirmPassword.PasswordChar = '*';            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblEmpty.Text = "Empty box.";
            }

            else if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblEmpty.Text = "Empty box";
            }

            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                lblEmpty.Text = "Please enter same password";
            }

            else
            {
                bool isValid = true;
                using (SqlConnection sqlConnection =  new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string selectQuery = "SELECT Username FROM Users";
                    using (SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection))
                    {
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader["Username"].Equals(txtUsername.Text))
                            {
                                isValid = false;
                            }
                        }                        
                    }
                }

                if (isValid)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                    {
                        sqlConnection.Open();

                        lblEmpty.Text = String.Empty;
                        string insertQuery = "INSERT INTO Users(Username, UserPassword) values(@txtUsername, @txtPassword)";
                        using (SqlCommand sqlCommand2 = new SqlCommand(insertQuery, sqlConnection))
                        {
                            isRight = true;
                            sqlCommand2.Parameters.AddWithValue("@txtUsername", txtUsername.Text);
                            sqlCommand2.Parameters.AddWithValue("@txtPassword", txtPassword.Text);
                            sqlCommand2.ExecuteNonQuery();
                        }
                    }
                    TVSectionForm tVSectionForm = new TVSectionForm();
                    this.Hide();
                    tVSectionForm.Show();
                    
                }

                else
                {
                    lblEmpty.Text = "The username had been taken by other people";
                }
            }
        }

        private void llblLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogInForm userLogIn = new UserLogInForm();
            this.Hide();
            userLogIn.Show();
        }

        private void pctrExit_MouseHover(object sender, EventArgs e)
        {
            pctrExit.BackColor = Color.LightGray;
        }

        private void pctrExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pctrExit_MouseLeave(object sender, EventArgs e)
        {
            pctrExit.BackColor = Color.White;
        }

        private void pctrExit_MouseEnter(object sender, EventArgs e)
        {
            pctrExit.BackColor = Color.LightGray;
        }
    }
}
