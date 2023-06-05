
namespace ThinkUpProject
{
    partial class PresentersSectionForm
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
            this.lblPresenters = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.pnlPresenters = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridPresenters = new System.Windows.Forms.DataGridView();
            this.PresenterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresenterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresenterSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlPresenters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresenters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresenters
            // 
            this.lblPresenters.AutoSize = true;
            this.lblPresenters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresenters.Location = new System.Drawing.Point(469, 51);
            this.lblPresenters.Name = "lblPresenters";
            this.lblPresenters.Size = new System.Drawing.Size(135, 29);
            this.lblPresenters.TabIndex = 0;
            this.lblPresenters.Text = "Presenters";
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
            // pnlPresenters
            // 
            this.pnlPresenters.BackColor = System.Drawing.Color.Navy;
            this.pnlPresenters.Controls.Add(this.btnUpdate);
            this.pnlPresenters.Controls.Add(this.btnDelete);
            this.pnlPresenters.Controls.Add(this.btnAdd);
            this.pnlPresenters.Controls.Add(this.gridPresenters);
            this.pnlPresenters.Location = new System.Drawing.Point(37, 152);
            this.pnlPresenters.Name = "pnlPresenters";
            this.pnlPresenters.Size = new System.Drawing.Size(967, 510);
            this.pnlPresenters.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(274, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(146, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(18, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridPresenters
            // 
            this.gridPresenters.BackgroundColor = System.Drawing.Color.White;
            this.gridPresenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPresenters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PresenterId,
            this.PresenterName,
            this.PresenterSurname,
            this.ProgramName});
            this.gridPresenters.Location = new System.Drawing.Point(3, 89);
            this.gridPresenters.Name = "gridPresenters";
            this.gridPresenters.RowHeadersWidth = 51;
            this.gridPresenters.RowTemplate.Height = 24;
            this.gridPresenters.Size = new System.Drawing.Size(961, 418);
            this.gridPresenters.TabIndex = 3;
            // 
            // PresenterId
            // 
            this.PresenterId.DataPropertyName = "PresenterId";
            this.PresenterId.HeaderText = "PresenterId";
            this.PresenterId.MinimumWidth = 6;
            this.PresenterId.Name = "PresenterId";
            this.PresenterId.Visible = false;
            this.PresenterId.Width = 125;
            // 
            // PresenterName
            // 
            this.PresenterName.DataPropertyName = "PresenterName";
            this.PresenterName.HeaderText = "PresenterName";
            this.PresenterName.MinimumWidth = 6;
            this.PresenterName.Name = "PresenterName";
            this.PresenterName.Width = 125;
            // 
            // PresenterSurname
            // 
            this.PresenterSurname.DataPropertyName = "PresenterSurname";
            this.PresenterSurname.HeaderText = "PresenterSurname";
            this.PresenterSurname.MinimumWidth = 6;
            this.PresenterSurname.Name = "PresenterSurname";
            this.PresenterSurname.Width = 125;
            // 
            // ProgramName
            // 
            this.ProgramName.DataPropertyName = "ProgramName";
            this.ProgramName.HeaderText = "Program Name";
            this.ProgramName.MinimumWidth = 6;
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Width = 125;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(52, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // PresentersSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 674);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlPresenters);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.lblPresenters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentersSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PresentersSectionForm";
            this.Load += new System.EventHandler(this.PresentersSectionForm_Load);
            this.pnlPresenters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPresenters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresenters;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Panel pnlPresenters;
        private System.Windows.Forms.DataGridView gridPresenters;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresenterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresenterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresenterSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.Label lblError;
    }
}