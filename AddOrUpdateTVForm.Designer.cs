
namespace ThinkUpProject
{
    partial class AddOrUpdateTVForm
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
            this.lblTVName = new System.Windows.Forms.Label();
            this.txtTVName = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTVName
            // 
            this.lblTVName.AutoSize = true;
            this.lblTVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVName.Location = new System.Drawing.Point(45, 66);
            this.lblTVName.Name = "lblTVName";
            this.lblTVName.Size = new System.Drawing.Size(79, 20);
            this.lblTVName.TabIndex = 0;
            this.lblTVName.Text = "TV Name";
            // 
            // txtTVName
            // 
            this.txtTVName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTVName.ForeColor = System.Drawing.Color.Navy;
            this.txtTVName.Location = new System.Drawing.Point(220, 66);
            this.txtTVName.Name = "txtTVName";
            this.txtTVName.Size = new System.Drawing.Size(191, 22);
            this.txtTVName.TabIndex = 1;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(45, 123);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(57, 20);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating";
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRating.ForeColor = System.Drawing.Color.Navy;
            this.txtRating.Location = new System.Drawing.Point(220, 123);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(191, 22);
            this.txtRating.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.Color.Navy;
            this.btn.Location = new System.Drawing.Point(304, 212);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(107, 42);
            this.btn.TabIndex = 2;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(49, 167);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(0, 17);
            this.lblInvalid.TabIndex = 3;
            // 
            // AddOrUpdateTVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtTVName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTVName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrUpdateTVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateTVForm";
            this.Load += new System.EventHandler(this.AddOrUpdateTVForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTVName;
        private System.Windows.Forms.TextBox txtTVName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblInvalid;
    }
}