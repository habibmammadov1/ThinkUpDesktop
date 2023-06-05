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
    public partial class UserLogInForm : Form
    {
        public UserLogInForm()
        {
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=true";

        private void pctrExit_MouseLeave(object sender, EventArgs e)
        {
            pctrExit.BackColor = Color.White;
        }

        private void pctrExit_MouseClick(object sender, MouseEventArgs e)
        {
            pctrExit.BackColor = Color.Navy;
            Application.Exit();
        }

        private void pctrExit_MouseHover(object sender, EventArgs e)
        {
            pctrExit.BackColor = Color.LightGray;
        }

        private void pctrExit_MouseEnter(object sender, EventArgs e)
        {
            pctrExit.BackColor = Color.LightGray;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool isTrue = false;
            using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
            {
                sqlConnection.Open();
                string selectQuery = "SELECT Username, UserPassword FROM Users";
                using (SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader["Username"].Equals(txtUsername.Text) && sqlDataReader["UserPassword"].Equals(txtPassword.Text))
                        {
                            isTrue = true;
                        }
                    }
                }
            }

            if (isTrue)
            {
                TVSectionForm mainSectionForm = new TVSectionForm();
                mainSectionForm.Show();
                this.Hide();
            }

            else
            {
                lblInvalid.Text = "Username or password is not true. Try again.";
            }
        }

        private void UserLogInForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Utilities.PanelColor;
            txtPassword.PasswordChar = '*';
        }

        private void chckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chckShowPassword.Checked ? '\0' : '*';
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
            this.Hide();
            userRegistrationForm.Show();
        }
    }
}
