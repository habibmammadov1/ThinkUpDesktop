
namespace ThinkUpProject
{
    partial class AddOrUpdateProgramForm
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
            this.lblProgramName = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblTVName = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblStartYear = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.cmbTVs = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(45, 66);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(122, 20);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Program Name";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(220, 66);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(191, 22);
            this.txtProgramName.TabIndex = 1;
            // 
            // lblTVName
            // 
            this.lblTVName.AutoSize = true;
            this.lblTVName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVName.Location = new System.Drawing.Point(45, 104);
            this.lblTVName.Name = "lblTVName";
            this.lblTVName.Size = new System.Drawing.Size(30, 20);
            this.lblTVName.TabIndex = 0;
            this.lblTVName.Text = "TV";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(45, 142);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(57, 20);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(45, 178);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 20);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            // 
            // lblStartYear
            // 
            this.lblStartYear.AutoSize = true;
            this.lblStartYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartYear.Location = new System.Drawing.Point(45, 212);
            this.lblStartYear.Name = "lblStartYear";
            this.lblStartYear.Size = new System.Drawing.Size(84, 20);
            this.lblStartYear.TabIndex = 0;
            this.lblStartYear.Text = "Start Year";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(220, 142);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(191, 22);
            this.txtRating.TabIndex = 1;
            // 
            // txtStartYear
            // 
            this.txtStartYear.Location = new System.Drawing.Point(220, 212);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(191, 22);
            this.txtStartYear.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.Color.Navy;
            this.btn.Location = new System.Drawing.Point(299, 278);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(112, 43);
            this.btn.TabIndex = 2;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(25, 341);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(0, 17);
            this.lblInvalid.TabIndex = 3;
            // 
            // cmbTVs
            // 
            this.cmbTVs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTVs.FormattingEnabled = true;
            this.cmbTVs.Location = new System.Drawing.Point(220, 104);
            this.cmbTVs.Name = "cmbTVs";
            this.cmbTVs.Size = new System.Drawing.Size(191, 24);
            this.cmbTVs.TabIndex = 4;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(220, 178);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(191, 24);
            this.cmbGenre.TabIndex = 4;
            // 
            // AddOrUpdateProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 379);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.cmbTVs);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtStartYear);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.lblStartYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTVName);
            this.Controls.Add(this.lblProgramName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdateProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateProgramForm";
            this.Load += new System.EventHandler(this.AddOrUpdateProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblTVName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblStartYear;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.ComboBox cmbTVs;
        private System.Windows.Forms.ComboBox cmbGenre;
    }
}