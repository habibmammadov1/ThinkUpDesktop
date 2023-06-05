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

namespace ThinkUpProject
{
    public partial class AddOrUpdateTVForm : Form
    {
        private string _optType;
        private string _tVId;
        private string _tVName;
        private string _rating;

        public AddOrUpdateTVForm(string optType)
        {
            _optType = optType;
            InitializeComponent();
        }

        public AddOrUpdateTVForm(string tVId, string tVName, string rating, string optType)
        {
            _tVId = tVId;
            _optType = optType;
            _tVName = tVName;
            _rating = rating;
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=True";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btn.Text.Equals("Add"))
            {
                if (String.IsNullOrEmpty(txtTVName.Text) || String.IsNullOrEmpty(txtRating.Text))
                {
                    lblInvalid.Text = "Empty box";
                }

                else if (String.IsNullOrWhiteSpace(txtTVName.Text) || String.IsNullOrWhiteSpace(txtRating.Text))
                {
                    lblInvalid.Text = "Empty box";
                }

                else
                {
                    bool isValid = true;
                    using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                    {

                        sqlConnection.Open();
                        string selectQuery = "SELECT TVName FROM TVs";
                        using (SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection))
                        {
                            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                            {
                                while (sqlDataReader.Read())
                                {
                                    if (sqlDataReader["TVName"].Equals(txtTVName.Text))
                                    {
                                        isValid = false;
                                    }
                                }
                            }
                        }
                    }

                    using (SqlConnection sqlConnection1 = new SqlConnection(stringConnection))
                    {
                        sqlConnection1.Open();
                        string insertQuery = "INSERT INTO TVs(TVName, Rating) VALUES(@txtTVName, @txtRating)";
                        if (isValid)
                        {
                            using (SqlCommand sqlCommand1 = new SqlCommand(insertQuery, sqlConnection1))
                            {
                                sqlCommand1.Parameters.AddWithValue("@txtTVName", txtTVName.Text);
                                sqlCommand1.Parameters.AddWithValue("@txtRating", txtRating.Text);
                                lblInvalid.Text = String.Empty;
                                sqlCommand1.ExecuteNonQuery();
                            }

                            TVSectionForm tVSectionForm = new TVSectionForm();
                            this.Hide();
                            tVSectionForm.Show();
                        }

                        else
                        {
                            lblInvalid.Text = "TV Name is used by other person right now";
                        }
                    }           
                }
            }

            else if(btn.Text == "Update")
            {
                bool isValid = true;
                using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string selectQuery = "SELECT TVName FROM TVs";
                    using (SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection))
                    {
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader["TVName"].Equals(txtTVName.Text))
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
                        string updateQuery = "UPDATE TVs SET TVName = @txtTVName, Rating = @txtRating where TVId = @_tVId";
                        using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@txtTVName", txtTVName.Text);
                            sqlCommand.Parameters.AddWithValue("@txtRating", txtRating.Text);
                            sqlCommand.Parameters.AddWithValue("@_tVId", _tVId);
                            lblInvalid.Text = String.Empty;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    TVSectionForm tVSectionForm = new TVSectionForm();
                            tVSectionForm.Show();
                            this.Hide();
                }
                
            }

        }

        private void AddOrUpdateTVForm_Load(object sender, EventArgs e)
        {
            if (_optType.Equals("add"))
            {
                btn.Text = "Add";
            }

            else if (_optType.Equals("update"))
            {
                btn.Text = "Update";
                txtTVName.Text = _tVName;
                txtRating.Text = _rating;
            }
        }
    }
}
