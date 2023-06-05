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
    public partial class AddOrUpdatePresenterForm : Form
    {
        private string _optType;
        private string _presenterId;
        private string _presenterName;
        private string _presenterSurname;
        private string _programName;

        public AddOrUpdatePresenterForm(string optType)
        {
            _optType = optType;
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=True";

        public AddOrUpdatePresenterForm(string presenterId, string presenterName, string presenterSurname, string programName, string optType)
        {
            _presenterId = presenterId;
            _presenterName = presenterName;
            _presenterSurname = presenterSurname;
            _programName = programName;
            _optType = optType;
            InitializeComponent();
        }

        private void AddOrUpdatePresenterForm_Load(object sender, EventArgs e)
        {
            if (_optType.Equals("add"))
            {
                btn.Text = "Add";
            }

            else if (_optType.Equals("update"))
            {
                btn.Text = "Update";
                txtName.Text = _presenterName;
                txtSurname.Text = _presenterSurname;
            }

            using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
            {
                sqlConnection.Open();
                string selectQuery = "SELECT ProgramName FROM Programs";

                using (SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(ds);
                    sqlCommand.ExecuteNonQuery();

                    cmbPrograms.DataSource = ds.Tables[0];
                    cmbPrograms.DisplayMember = "ProgramName";
                    cmbPrograms.ValueMember = "ProgramName";
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btn.Text.Equals("Add"))
            {
                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text))
                {
                    lblInvalid.Text = "Empty box";
                }

                else if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(txtSurname.Text))
                {
                    lblInvalid.Text = "Empty box";
                }

                else
                {
                    int presenterId = 0;
                    using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                    {
                        sqlConnection.Open();
                        string joinQuery = "SELECT ProgramId from Programs where ProgramName = @txtProgramName";
                        using (SqlCommand sqlCommand = new SqlCommand(joinQuery, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@txtProgramName", cmbPrograms.SelectedValue);
                            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                            while (sqlDataReader.Read())
                            {
                                presenterId = (int)sqlDataReader["ProgramId"];
                            }
                        }
                    }

                    using (SqlConnection sqlConnection1 = new SqlConnection(stringConnection))
                    {
                        sqlConnection1.Open();
                        string insertQuery = "INSERT INTO Presenters(PresenterName, PresenterSurname, ProgramId) VALUES(@txtPresenterName, @txtPresenterSurname, @presenterId)";
                        using (SqlCommand sqlCommand1 = new SqlCommand(insertQuery, sqlConnection1))
                        {
                            sqlCommand1.Parameters.AddWithValue("@txtPresenterName", txtName.Text);
                            sqlCommand1.Parameters.AddWithValue("@txtPresenterSurname", txtSurname.Text);
                            sqlCommand1.Parameters.AddWithValue("@presenterId", presenterId);
                            lblInvalid.Text = String.Empty;
                            sqlCommand1.ExecuteNonQuery();
                        }

                        PresentersSectionForm presentersSectionForm = new PresentersSectionForm();
                        presentersSectionForm.Show();
                        this.Hide();
                    }
                }
            }

            else if (btn.Text == "Update")
            {
                int programId = 0;
                using (SqlConnection sqlConnection1 = new SqlConnection(stringConnection))
                {
                    sqlConnection1.Open();
                    string selectQuery = "SELECT ProgramId FROM Programs where ProgramName = @txtProgramName";
                    using (SqlCommand sqlCommand1 = new SqlCommand(selectQuery, sqlConnection1))
                    {
                        sqlCommand1.Parameters.AddWithValue("@txtProgramName", cmbPrograms.SelectedValue);
                        SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            programId = (int)sqlDataReader["ProgramId"];
                        }
                    }
                }

                using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string updateQuery = "UPDATE Presenters SET PresenterName = @txtPresenterName, PresenterSurname = @txtPresenterSurname, ProgramId = @programId where PresenterId = @_presenterId";
                    using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@txtPresenterName", txtName.Text);
                        sqlCommand.Parameters.AddWithValue("@txtPresenterSurname", txtSurname.Text);
                        sqlCommand.Parameters.AddWithValue("@programId", programId);
                        sqlCommand.Parameters.AddWithValue("@_presenterId", _presenterId);
                        lblInvalid.Text = String.Empty;
                        sqlCommand.ExecuteNonQuery();
                    }
                

                    PresentersSectionForm presentersSectionForm = new PresentersSectionForm();
                    presentersSectionForm.Show();
                    this.Hide();
                }

            }
        }
    }
}
