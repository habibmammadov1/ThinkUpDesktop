
namespace ThinkUpProject
{
    partial class TVSectionForm
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
            this.pnlTv = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddTv = new System.Windows.Forms.Button();
            this.gridTVs = new System.Windows.Forms.DataGridView();
            this.TVId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlTv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTVs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTv
            // 
            this.pnlTv.BackColor = System.Drawing.Color.Navy;
            this.pnlTv.Controls.Add(this.btnUpdate);
            this.pnlTv.Controls.Add(this.btnDelete);
            this.pnlTv.Controls.Add(this.btnAddTv);
            this.pnlTv.Controls.Add(this.gridTVs);
            this.pnlTv.Location = new System.Drawing.Point(37, 152);
            this.pnlTv.Name = "pnlTv";
            this.pnlTv.Size = new System.Drawing.Size(967, 510);
            this.pnlTv.TabIndex = 0;
            this.pnlTv.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrid_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Location = new System.Drawing.Point(243, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 37);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(130, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddTv
            // 
            this.btnAddTv.BackColor = System.Drawing.Color.White;
            this.btnAddTv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTv.ForeColor = System.Drawing.Color.Navy;
            this.btnAddTv.Location = new System.Drawing.Point(16, 29);
            this.btnAddTv.Name = "btnAddTv";
            this.btnAddTv.Size = new System.Drawing.Size(98, 37);
            this.btnAddTv.TabIndex = 1;
            this.btnAddTv.Text = "Add";
            this.btnAddTv.UseVisualStyleBackColor = false;
            this.btnAddTv.Click += new System.EventHandler(this.btnAddTv_Click);
            // 
            // gridTVs
            // 
            this.gridTVs.BackgroundColor = System.Drawing.Color.White;
            this.gridTVs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridTVs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTVs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TVId,
            this.TVName,
            this.Rating});
            this.gridTVs.GridColor = System.Drawing.Color.Navy;
            this.gridTVs.Location = new System.Drawing.Point(3, 89);
            this.gridTVs.Name = "gridTVs";
            this.gridTVs.RowHeadersWidth = 51;
            this.gridTVs.RowTemplate.Height = 30;
            this.gridTVs.RowTemplate.ReadOnly = true;
            this.gridTVs.Size = new System.Drawing.Size(961, 418);
            this.gridTVs.TabIndex = 0;
            // 
            // TVId
            // 
            this.TVId.DataPropertyName = "TVId";
            this.TVId.HeaderText = "TVId";
            this.TVId.MinimumWidth = 6;
            this.TVId.Name = "TVId";
            this.TVId.Visible = false;
            this.TVId.Width = 125;
            // 
            // TVName
            // 
            this.TVName.DataPropertyName = "TVName";
            this.TVName.HeaderText = "TVName";
            this.TVName.MinimumWidth = 6;
            this.TVName.Name = "TVName";
            this.TVName.Width = 125;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(503, 46);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(58, 29);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "TVs";
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(782, 51);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(182, 25);
            this.cmb.TabIndex = 2;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(40, 129);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 3;
            // 
            // TVSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 674);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlTv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TVSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSectionForm";
            this.Load += new System.EventHandler(this.MainSectionForm_Load);
            this.pnlTv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTVs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTv;
        private System.Windows.Forms.DataGridView gridTVs;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddTv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.Label lblError;
    }
}