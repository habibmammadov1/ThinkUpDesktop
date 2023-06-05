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
    public partial class ProgramsSectionForm : Form
    {
        public ProgramsSectionForm()
        {
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=true";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProgramsSectionForm_Load(object sender, EventArgs e)
        {
            pnlPrograms.BackColor = Utilities.PanelColor;

            cmb.Items.Add("TVs");
            cmb.Items.Add("Programs");
            cmb.Items.Add("Presenters");

            cmbTVs.Items.Add("All");

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

                    cmbTVs.DisplayMember = "TVName";
                    cmbTVs.ValueMember = "TVName";
                    cmbTVs.DataSource = ds.Tables[0];
                }
            }

            using (SqlConnection sqlConnection1 = new SqlConnection(stringConnection))
            {
                sqlConnection1.Open();
                string selectPresenterQuery = "SELECT p.ProgramId, p.ProgramName, t.TVName, p.Rating, p.StartYear, g.GenreName, p.TVId, p.GenreId " +
                    "FROM Programs p inner join TVs t on p.TVId = t.TVId inner join Genres g on p.GenreId = g.GenreId";
                using (SqlCommand sqlCommand1 = new SqlCommand(selectPresenterQuery, sqlConnection1))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                    sqlDataAdapter1.Fill(dt);
                    gridProgram.AutoGenerateColumns = false;
                    gridProgram.DataSource = dt;
                }
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedItem.ToString().Equals("TVs"))
            {
                this.Hide();
                TVSectionForm tVSectionForm = new TVSectionForm();
                tVSectionForm.Show();
            }

            else if (cmb.SelectedItem.ToString().Equals("Presenters"))
            {
                this.Hide();
                PresentersSectionForm presentersSectionForm = new PresentersSectionForm();
                presentersSectionForm.Show();
            }
        }

        private void gridProgram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTVs_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridProgram.DataSource = null;
            string tvId = String.Empty;
            string tvName =  cmbTVs.SelectedItem.ToString();
            using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
            {
                sqlConnection.Open();
                string selectTVIdQuery = "SELECT TVId FROM TVs where TVName = @tvName";
                using (SqlCommand sqlCommand = new SqlCommand(selectTVIdQuery, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@tvName", tvName);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        tvId = sqlDataReader["TVId"].ToString();
                    }
                }
            }

            using (SqlConnection sqlConnection1 = new SqlConnection(stringConnection))
            {
                sqlConnection1.Open();
                string selectQuery = "SELECT p.ProgramId, p.ProgramName, t.TVName, p.Rating, p.StartYear, g.GenreName " +
                    "FROM Programs p inner join TVs t on p.TVId = t.TVId inner join Genres g on p.GenreId = g.GenreId where p.TVId = @tvId";
                using (SqlCommand sqlCommand1 = new SqlCommand(selectQuery, sqlConnection1))
                {
                    sqlCommand1.Parameters.AddWithValue("@tvId", tvId);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand1);
                    sqlDataAdapter.Fill(dt);
                    gridProgram.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateProgramForm addOrUpdateProgramForm = new AddOrUpdateProgramForm("Add");
            this.Hide();
            addOrUpdateProgramForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = gridProgram.SelectedRows[0].Index;
            string programId = gridProgram.Rows[index].Cells["ProgramId"].Value.ToString();
            string programName = gridProgram.Rows[index].Cells["ProgramName"].Value.ToString();
            string tvName = gridProgram.Rows[index].Cells["TVName"].Value.ToString();
            string rating = gridProgram.Rows[index].Cells["Rating"].Value.ToString();
            string startYear = gridProgram.Rows[index].Cells["StartYear"].Value.ToString();
            string genreName = gridProgram.Rows[index].Cells["Genre"].Value.ToString();
            string tvId = gridProgram.Rows[index].Cells["TVId"].Value.ToString();
            string genreId = gridProgram.Rows[index].Cells["genreId"].Value.ToString();
            AddOrUpdateProgramForm addOrUpdateProgramForm = new AddOrUpdateProgramForm(programId, tvName, rating, startYear, genreName, programName, tvId, genreId, "Update");
            this.Hide();
            addOrUpdateProgramForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = gridProgram.SelectedRows[0].Index;
            string programId = gridProgram.Rows[index].Cells["ProgramId"].Value.ToString();

            if (gridProgram.Rows[index].Cells["ProgramName"].Value.ToString() != String.Empty)
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string deleteQuery = "DELETE FROM Programs WHERE ProgramId = @programId";
                    using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@programId", programId);
                        lblError.Text = String.Empty;
                        sqlCommand.ExecuteNonQuery();
                        gridProgram.Rows.RemoveAt(this.gridProgram.SelectedRows[0].Index);
                    }
                }
            }

            else
            {
                lblError.Text = "Select a row, please";
            }
        }
    }
}
