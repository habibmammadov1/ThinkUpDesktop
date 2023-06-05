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
    public partial class PresentersSectionForm : Form
    {
        public PresentersSectionForm()
        {
            InitializeComponent();
        }

        const string stringConnection = @"Server=(localdb)\MSSQLLocalDB; Database=ThinkUp; Trusted_Connection=true";

        private void PresentersSectionForm_Load(object sender, EventArgs e)
        {
            pnlPresenters.BackColor = Utilities.PanelColor;


            cmb.Items.Add("TVs");
            cmb.Items.Add("Programs");
            cmb.Items.Add("Presenters");

            using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
            {
                sqlConnection.Open();
                string selectPresenterQuery = "SELECT p.PresenterId, p.PresenterName, p.PresenterSurname, p.ProgramId, pr.ProgramName FROM Presenters p inner join Programs pr on p.ProgramId = pr.ProgramId";
                using (SqlCommand sqlCommand = new SqlCommand(selectPresenterQuery, sqlConnection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt);
                    gridPresenters.AutoGenerateColumns = false;
                    gridPresenters.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdatePresenterForm addOrUpdatePresenterForm = new AddOrUpdatePresenterForm("add");
            this.Hide();
            addOrUpdatePresenterForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = gridPresenters.SelectedRows[0].Index;
            string presenterId = gridPresenters.Rows[index].Cells["PresenterId"].Value.ToString();
            string persenterName = gridPresenters.Rows[index].Cells["PresenterName"].Value.ToString();
            string presenterSurname = gridPresenters.Rows[index].Cells["PresenterSurname"].Value.ToString();
            string programName = gridPresenters.Rows[index].Cells["ProgramName"].Value.ToString();
            if (gridPresenters.Rows[index].Cells["PresenterName"].Value.ToString() != String.Empty)
            {
                AddOrUpdatePresenterForm addOrUpdatePresenterForm = new AddOrUpdatePresenterForm(presenterId, persenterName, presenterSurname, programName, "update");
                this.Hide();
                addOrUpdatePresenterForm.Show();
            }

            else
            {
                lblError.Text = "Select a row, please";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = gridPresenters.SelectedRows[0].Index;
            string presenterId = gridPresenters.Rows[index].Cells["PresenterId"].Value.ToString();
            if (gridPresenters.Rows[index].Cells["PresenterName"].Value.ToString() != String.Empty)
            {
                using (SqlConnection sqlConnection = new SqlConnection(stringConnection))
                {
                    sqlConnection.Open();
                    string deleteQuery = "DELETE FROM Presenters where PresenterId = @presenterId";
                    using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@presenterId", presenterId);
                        sqlCommand.ExecuteNonQuery();
                        gridPresenters.Rows.RemoveAt(this.gridPresenters.SelectedRows[0].Index);
                    }
                }
            }

            else
            {
                lblError.Text = "Select a row, please";
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.SelectedItem.ToString() == "Programs")
            {
                this.Hide();
                ProgramsSectionForm programsSectionForm = new ProgramsSectionForm();
                programsSectionForm.Show();
            }

            else if (cmb.SelectedItem.ToString().Equals("TVs"))
            {
                this.Hide();
                TVSectionForm tVSectionForm = new TVSectionForm();
                tVSectionForm.Show();
            }
        }
    }
}
