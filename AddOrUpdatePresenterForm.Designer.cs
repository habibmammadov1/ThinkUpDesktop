
namespace ThinkUpProject
{
    partial class AddOrUpdatePresenterForm
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
            this.lblPresenterName = new System.Windows.Forms.Label();
            this.lblPresenterSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.cmbPrograms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPresenterName
            // 
            this.lblPresenterName.AutoSize = true;
            this.lblPresenterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresenterName.Location = new System.Drawing.Point(45, 66);
            this.lblPresenterName.Name = "lblPresenterName";
            this.lblPresenterName.Size = new System.Drawing.Size(131, 20);
            this.lblPresenterName.TabIndex = 0;
            this.lblPresenterName.Text = "Presenter Name";
            // 
            // lblPresenterSurname
            // 
            this.lblPresenterSurname.AutoSize = true;
            this.lblPresenterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresenterSurname.Location = new System.Drawing.Point(45, 123);
            this.lblPresenterSurname.Name = "lblPresenterSurname";
            this.lblPresenterSurname.Size = new System.Drawing.Size(154, 20);
            this.lblPresenterSurname.TabIndex = 0;
            this.lblPresenterSurname.Text = "Presenter Surname";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.Location = new System.Drawing.Point(220, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSurname.Location = new System.Drawing.Point(220, 123);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.Color.Navy;
            this.btn.Location = new System.Drawing.Point(327, 235);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(107, 42);
            this.btn.TabIndex = 2;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(25, 248);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(0, 17);
            this.lblInvalid.TabIndex = 3;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(45, 173);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(122, 20);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Program Name";
            // 
            // cmbPrograms
            // 
            this.cmbPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbPrograms.FormattingEnabled = true;
            this.cmbPrograms.Location = new System.Drawing.Point(220, 173);
            this.cmbPrograms.Name = "cmbPrograms";
            this.cmbPrograms.Size = new System.Drawing.Size(191, 24);
            this.cmbPrograms.TabIndex = 4;
            // 
            // AddOrUpdatePresenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.cmbPrograms);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.lblPresenterSurname);
            this.Controls.Add(this.lblPresenterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdatePresenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdatePresenterForm";
            this.Load += new System.EventHandler(this.AddOrUpdatePresenterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresenterName;
        private System.Windows.Forms.Label lblPresenterSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.ComboBox cmbPrograms;
    }
}