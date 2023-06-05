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
    public partial class TVSectionForm : Form
    {
        public TVSectionForm()
        {
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=true";

        private void pnlGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainSectionForm_Load(object sender, EventArgs e)
        {
            pnlTv.BackColor = Utilities.PanelColor;
                        
            cmb.Items.Add("TVs");
            cmb.Items.Add("Programs");
            cmb.Items.Add("Presenters");

            using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
            {
                sqlConnection.Open();
                string selectTvQuery = "SELECT TVId, TVName, Rating FROM TVs";
                using (SqlCommand sqlCommand = new SqlCommand(selectTvQuery, sqlConnection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    gridTVs.AutoGenerateColumns = false;
                    gridTVs.DataSource = dt;
                }
            }   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedItem.ToString() == "Programs")
            {
                this.Hide();
                ProgramsSectionForm programsSectionForm = new ProgramsSectionForm();
                programsSectionForm.Show();
            }

            else if (cmb.SelectedItem.ToString().Equals("Presenters"))
            {
                this.Hide();
                PresentersSectionForm presentersSectionForm = new PresentersSectionForm();
                presentersSectionForm.Show();
            }
        }

        private void btnAddTv_Click(object sender, EventArgs e)
        {
            AddOrUpdateTVForm addOrUpdateTV = new AddOrUpdateTVForm("add");
            this.Hide();
            addOrUpdateTV.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = gridTVs.SelectedRows[0].Index;
            string tVId = gridTVs.Rows[index].Cells["TVId"].Value.ToString();
            string tVName = gridTVs.Rows[index].Cells["TVName"].Value.ToString();
            string rating = gridTVs.Rows[index].Cells["Rating"].Value.ToString();
            if (gridTVs.Rows[index].Cells["TVName"].Value.ToString() != String.Empty)
            {
                AddOrUpdateTVForm addOrUpdateTV = new AddOrUpdateTVForm(tVId, tVName, rating, "update");
                this.Hide();
                addOrUpdateTV.Show();
            }

            else
            {
                lblError.Text = "Select a row, please";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = gridTVs.SelectedRows[0].Index;
            string tVId = gridTVs.Rows[index].Cells["TVId"].Value.ToString();

            if (gridTVs.Rows[index].Cells["TVName"].Value.ToString() != String.Empty)
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string deleteQuery = "DELETE FROM TVs WHERE TVId = @tVId";
                    using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@tVId", tVId);
                        lblError.Text = String.Empty;
                        sqlCommand.ExecuteNonQuery();
                        gridTVs.Rows.RemoveAt(this.gridTVs.SelectedRows[0].Index);
                    }
                }

                this.Refresh();
            }

            else
            {
                lblError.Text = "Select a row, please";
            }
        }
    }
}
