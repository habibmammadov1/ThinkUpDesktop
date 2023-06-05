
namespace ThinkUpProject
{
    partial class UserLogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pctrExit = new System.Windows.Forms.PictureBox();
            this.lblDontAccount = new System.Windows.Forms.Label();
            this.llblRegister = new System.Windows.Forms.LinkLabel();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.chckShowPassword = new System.Windows.Forms.CheckBox();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblDeveloper);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblHeaderName);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 528);
            this.panel1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(380, 119);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsername.Location = new System.Drawing.Point(377, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "İstifadəçi adı";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(380, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPassword.Location = new System.Drawing.Point(377, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Parol";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Navy;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(380, 260);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(92, 37);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Giriş";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pctrExit
            // 
            this.pctrExit.BackColor = System.Drawing.Color.White;
            this.pctrExit.Image = ((System.Drawing.Image)(resources.GetObject("pctrExit.Image")));
            this.pctrExit.Location = new System.Drawing.Point(667, 12);
            this.pctrExit.Name = "pctrExit";
            this.pctrExit.Size = new System.Drawing.Size(23, 25);
            this.pctrExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrExit.TabIndex = 4;
            this.pctrExit.TabStop = false;
            this.pctrExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctrExit_MouseClick);
            this.pctrExit.MouseLeave += new System.EventHandler(this.pctrExit_MouseLeave);
            this.pctrExit.MouseHover += new System.EventHandler(this.pctrExit_MouseHover);
            // 
            // lblDontAccount
            // 
            this.lblDontAccount.AutoSize = true;
            this.lblDontAccount.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDontAccount.Location = new System.Drawing.Point(377, 366);
            this.lblDontAccount.Name = "lblDontAccount";
            this.lblDontAccount.Size = new System.Drawing.Size(235, 17);
            this.lblDontAccount.TabIndex = 5;
            this.lblDontAccount.Text = "Hələ də qeydiyyatdan keçməmisən?";
            // 
            // llblRegister
            // 
            this.llblRegister.AutoSize = true;
            this.llblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblRegister.LinkColor = System.Drawing.Color.Navy;
            this.llblRegister.Location = new System.Drawing.Point(377, 394);
            this.llblRegister.Name = "llblRegister";
            this.llblRegister.Size = new System.Drawing.Size(72, 18);
            this.llblRegister.TabIndex = 6;
            this.llblRegister.TabStop = true;
            this.llblRegister.Text = "Qeydiyyat";
            this.llblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegister_LinkClicked);
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInvalid.Location = new System.Drawing.Point(380, 226);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(0, 17);
            this.lblInvalid.TabIndex = 7;
            // 
            // chckShowPassword
            // 
            this.chckShowPassword.AutoSize = true;
            this.chckShowPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.chckShowPassword.Location = new System.Drawing.Point(561, 269);
            this.chckShowPassword.Name = "chckShowPassword";
            this.chckShowPassword.Size = new System.Drawing.Size(115, 21);
            this.chckShowPassword.TabIndex = 9;
            this.chckShowPassword.Text = "Parolu göstər";
            this.chckShowPassword.UseVisualStyleBackColor = true;
            this.chckShowPassword.CheckedChanged += new System.EventHandler(this.chckShowPassword_CheckedChanged);
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderName.Font = new System.Drawing.Font("Footlight MT Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderName.ForeColor = System.Drawing.Color.White;
            this.lblHeaderName.Location = new System.Drawing.Point(100, 62);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(170, 44);
            this.lblHeaderName.TabIndex = 10;
            this.lblHeaderName.Text = "ThinkUp";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(68, 119);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(232, 20);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Giriş anketinə xoşgəlmişsiniz!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Location = new System.Drawing.Point(205, 483);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(140, 34);
            this.lblDeveloper.TabIndex = 13;
            this.lblDeveloper.Text = "Developed\r\nby Habib Mammadov\r\n";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 526);
            this.Controls.Add(this.chckShowPassword);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.llblRegister);
            this.Controls.Add(this.lblDontAccount);
            this.Controls.Add(this.pctrExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogIn";
            this.Load += new System.EventHandler(this.UserLogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pctrExit;
        private System.Windows.Forms.Label lblDontAccount;
        private System.Windows.Forms.LinkLabel llblRegister;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.CheckBox chckShowPassword;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeveloper;
    }
}