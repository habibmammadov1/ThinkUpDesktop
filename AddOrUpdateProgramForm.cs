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
    public partial class AddOrUpdateProgramForm : Form
    {
        private string _optType;
        private string _programId;
        private string _tVName;
        private string _rating;
        private string _startYear;
        private string _genre;
        private string _programName;
        private string _tVId;
        private string _genreId;

        public AddOrUpdateProgramForm(string optType)
        {
            _optType = optType;
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=True";

        public AddOrUpdateProgramForm(string programId, string tVName, string rating, string startYear, string genre, string programName, string tVId, string genreId, string optType)
        {
            _programId = programId;
            _tVName = tVName;
            _rating = rating;
            _startYear = startYear;
            _genre = genre;
            _programName = programName;
            _tVId = tVId;
            _genreId = genreId;
            _optType = optType;

            InitializeComponent();
        }

        private void AddOrUpdateProgramForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
            {
                sqlConnection.Open();
                string selectQuery = "SELECT TVName FROM TVs";

                using (SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(ds);
                    sqlCommand.ExecuteNonQuery();

                    cmbTVs.DataSource = ds.Tables[0];
                    cmbTVs.DisplayMember = "TVName";
                    cmbTVs.ValueMember = "TVName";
                }

                string selectGenreQuery = "SELECT GenreName from Genres";

                using (SqlCommand sqlCommand1 = new SqlCommand(selectGenreQuery, sqlConnection))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand1);
                    sqlDataAdapter.Fill(ds);
                    sqlCommand1.ExecuteNonQuery();

                    cmbGenre.DataSource = ds.Tables[0];
                    cmbGenre.DisplayMember = "GenreName";
                    cmbGenre.ValueMember = "GenreName";
                }
            }

            if (_optType.Equals("Add"))
            {
                btn.Text = "Add";
            }

            else if (_optType.Equals("Update"))
            {
                btn.Text = "Update";
                txtProgramName.Text = _programName;
                txtRating.Text = _rating;
                txtStartYear.Text = _startYear;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btn.Text.Equals("Add"))
            {
                if (String.IsNullOrEmpty(txtProgramName.Text)
                    || String.IsNullOrEmpty(txtRating.Text) || String.IsNullOrEmpty(txtStartYear.Text))
                {
                    lblInvalid.Text = "Empty box";
                }

                else if (String.IsNullOrEmpty(txtProgramName.Text)
                    || String.IsNullOrEmpty(txtRating.Text) || String.IsNullOrEmpty(txtStartYear.Text))
                {
                    lblInvalid.Text = "Empty box";
                }

                else
                {
                    // tVId, genreId
                    string tvId = String.Empty, genreId = String.Empty;
                    using (SqlConnection sqlConnection1 = new SqlConnection(stringConnection))
                    {
                        sqlConnection1.Open();
                        string selectTVId = "SELECT TVId FROM TVs WHERE TVName = @cmbTVSelectedItem";
                        
                        using (SqlCommand sqlCommand1 = new SqlCommand(selectTVId, sqlConnection1))
                        {
                            sqlCommand1.Parameters.AddWithValue("@cmbTVSelectedItem", cmbTVs.SelectedValue);
                            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                            while (sqlDataReader.Read())
                            {
                                tvId = sqlDataReader["TVId"].ToString();
                            }
                        }
                    }

                    using (SqlConnection sqlConnection2 = new SqlConnection(stringConnection))
                    {
                        sqlConnection2.Open();
                        string selectGenreId = "SELECT GenreId FROM Genres WHERE GenreName = @cmbGenresSelectedItem";
                        using (SqlCommand sqlCommand2 = new SqlCommand(selectGenreId, sqlConnection2))
                        {
                            sqlCommand2.Parameters.AddWithValue("@cmbGenresSelectedItem", cmbGenre.SelectedValue);
                            SqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
                            while (sqlDataReader1.Read())
                            {
                                genreId = sqlDataReader1["GenreId"].ToString();
                            }
                        }
                    }

                    using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                    {
                        sqlConnection.Open();
                        string insertQuery = "INSERT INTO Programs(ProgramName, TVId, Rating, StartYear, GenreId) " +
                            "VALUES(@txtProgramName, @tVId, @txtRating, @txtStartYear, @txtGenreId)";
                        using (SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@txtProgramName", txtProgramName.Text);
                            sqlCommand.Parameters.AddWithValue("@tVId", tvId);
                            sqlCommand.Parameters.AddWithValue("@txtRating", txtRating.Text);
                            sqlCommand.Parameters.AddWithValue("@txtStartYear", txtStartYear.Text);
                            sqlCommand.Parameters.AddWithValue("@txtGenreId", genreId);
                            sqlCommand.ExecuteNonQuery();
                            this.Hide();
                        }
                    }

                    ProgramsSectionForm programsSectionForm = new ProgramsSectionForm();
                    programsSectionForm.Show();
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
                        sqlCommand1.Parameters.AddWithValue("@txtProgramName", txtProgramName.Text);
                        SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            programId = (int)sqlDataReader["ProgramId"];
                        }
                    }
                }

                string tvId = String.Empty;
                using (SqlConnection sqlConnection2 = new SqlConnection(stringConnection))
                {
                    sqlConnection2.Open();
                    string selectQuery = "SELECT TVId FROM TVs WHERE TVName = @cmbTVSelectedValue";
                    using (SqlCommand sqlCommand2 = new SqlCommand(selectQuery, sqlConnection2))
                    {
                        sqlCommand2.Parameters.AddWithValue(@"cmbTVSelectedValue", cmbTVs.SelectedValue);
                        SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            tvId = sqlDataReader["TVId"].ToString();
                        }
                    }
                }

                string genreId = String.Empty;
                using (SqlConnection sqlConnection3 = new SqlConnection(stringConnection))
                {
                    sqlConnection3.Open();
                    string selectQuery = "SELECT GenreId FROM Genres WHERE GenreName = @cmbGenreSelectedValue";
                    using (SqlCommand sqlCommand3 = new SqlCommand(selectQuery, sqlConnection3))
                    {
                        sqlCommand3.Parameters.AddWithValue(@"cmbGenreSelectedValue", cmbGenre.SelectedValue);
                        SqlDataReader sqlDataReader = sqlCommand3.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            genreId = sqlDataReader["GenreId"].ToString();
                        }
                    }
                }

                using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string updateQuery = "UPDATE Programs SET ProgramName = @txtProgramName, TVId = @tvId, Rating = @txtRating, StartYear = @txtStartYear, GenreId = @genreId where ProgramId = @_programId";
                    using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@txtProgramName", txtProgramName.Text);
                        sqlCommand.Parameters.AddWithValue("@tvId", tvId);
                        sqlCommand.Parameters.AddWithValue("@txtRating", txtRating.Text);
                        sqlCommand.Parameters.AddWithValue("@txtStartYear", txtStartYear.Text);
                        sqlCommand.Parameters.AddWithValue("@genreId", genreId);
                        sqlCommand.Parameters.AddWithValue("@_programId", _programId);
                        lblInvalid.Text = String.Empty;
                        sqlCommand.ExecuteNonQuery();
                    }


                    ProgramsSectionForm programsSectionForm = new ProgramsSectionForm();
                    programsSectionForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
