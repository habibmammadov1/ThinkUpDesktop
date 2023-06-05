
namespace ThinkUpProject
{
    partial class ProgramsSectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrograms = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.pnlPrograms = new System.Windows.Forms.Panel();
            this.cmbTVs = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridProgram = new System.Windows.Forms.DataGridView();
            this.ProgramId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrograms
            // 
            this.lblPrograms.AutoSize = true;
            this.lblPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograms.Location = new System.Drawing.Point(469, 51);
            this.lblPrograms.Name = "lblPrograms";
            this.lblPrograms.Size = new System.Drawing.Size(123, 29);
            this.lblPrograms.TabIndex = 0;
            this.lblPrograms.Text = "Programs";
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(782, 51);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(182, 24);
            this.cmb.TabIndex = 1;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // pnlPrograms
            // 
            this.pnlPrograms.BackColor = System.Drawing.Color.Navy;
            this.pnlPrograms.Controls.Add(this.cmbTVs);
            this.pnlPrograms.Controls.Add(this.btnUpdate);
            this.pnlPrograms.Controls.Add(this.btnDelete);
            this.pnlPrograms.Controls.Add(this.btnAdd);
            this.pnlPrograms.Controls.Add(this.gridProgram);
            this.pnlPrograms.Location = new System.Drawing.Point(37, 152);
            this.pnlPrograms.Name = "pnlPrograms";
            this.pnlPrograms.Size = new System.Drawing.Size(967, 510);
            this.pnlPrograms.TabIndex = 2;
            this.pnlPrograms.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbTVs
            // 
            this.cmbTVs.BackColor = System.Drawing.Color.White;
            this.cmbTVs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTVs.FormattingEnabled = true;
            this.cmbTVs.Location = new System.Drawing.Point(806, 35);
            this.cmbTVs.Name = "cmbTVs";
            this.cmbTVs.Size = new System.Drawing.Size(121, 24);
            this.cmbTVs.TabIndex = 2;
            this.cmbTVs.SelectedIndexChanged += new System.EventHandler(this.cmbTVs_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(232, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(129, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(24, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridProgram
            // 
            this.gridProgram.BackgroundColor = System.Drawing.Color.White;
            this.gridProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramId,
            this.TVId,
            this.GenreId,
            this.ProgramName,
            this.TVName,
            this.Rating,
            this.Genre,
            this.StartYear});
            this.gridProgram.GridColor = System.Drawing.Color.Navy;
            this.gridProgram.Location = new System.Drawing.Point(3, 89);
            this.gridProgram.Name = "gridProgram";
            this.gridProgram.ReadOnly = true;
            this.gridProgram.RowHeadersWidth = 51;
            this.gridProgram.RowTemplate.Height = 24;
            this.gridProgram.Size = new System.Drawing.Size(961, 418);
            this.gridProgram.TabIndex = 0;
            this.gridProgram.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProgram_CellContentClick);
            // 
            // ProgramId
            // 
            this.ProgramId.DataPropertyName = "ProgramId";
            this.ProgramId.HeaderText = "ProgramId";
            this.ProgramId.MinimumWidth = 6;
            this.ProgramId.Name = "ProgramId";
            this.ProgramId.ReadOnly = true;
            this.ProgramId.Visible = false;
            this.ProgramId.Width = 125;
            // 
            // TVId
            // 
            this.TVId.DataPropertyName = "TVId";
            this.TVId.HeaderText = "TVId";
            this.TVId.MinimumWidth = 6;
            this.TVId.Name = "TVId";
            this.TVId.ReadOnly = true;
            this.TVId.Visible = false;
            this.TVId.Width = 125;
            // 
            // GenreId
            // 
            this.GenreId.DataPropertyName = "GenreId";
            this.GenreId.HeaderText = "GenreId";
            this.GenreId.MinimumWidth = 6;
            this.GenreId.Name = "GenreId";
            this.GenreId.ReadOnly = true;
            this.GenreId.Visible = false;
            this.GenreId.Width = 125;
            // 
            // ProgramName
            // 
            this.ProgramName.DataPropertyName = "ProgramName";
            this.ProgramName.HeaderText = "ProgramName";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            this.ProgramName.Width = 125;
            // 
            // TVName
            // 
            this.TVName.DataPropertyName = "TVName";
            this.TVName.HeaderText = "TV Name";
            this.TVName.MinimumWidth = 6;
            this.TVName.Name = "TVName";
            this.TVName.ReadOnly = true;
            this.TVName.Width = 125;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 125;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "GenreName";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 125;
            // 
            // StartYear
            // 
            this.StartYear.DataPropertyName = "StartYear";
            this.StartYear.HeaderText = "Start Year";
            this.StartYear.MinimumWidth = 6;
            this.StartYear.Name = "StartYear";
            this.StartYear.ReadOnly = true;
            this.StartYear.Width = 125;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(37, 122);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 3;
            // 
            // ProgramsSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 674);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlPrograms);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.lblPrograms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramsSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramsSectionForm";
            this.Load += new System.EventHandler(this.ProgramsSectionForm_Load);
            this.pnlPrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProgram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrograms;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Panel pnlPrograms;
        private System.Windows.Forms.DataGridView gridProgram;
        private System.Windows.Forms.ComboBox cmbTVs;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartYear;
        private System.Windows.Forms.Label lblError;
    }
}