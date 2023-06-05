
namespace ThinkUpProject
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.RegisterLeftSide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.llblLogIn = new System.Windows.Forms.LinkLabel();
            this.pctrExit = new System.Windows.Forms.PictureBox();
            this.RegisterLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExit)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterLeftSide
            // 
            this.RegisterLeftSide.BackColor = System.Drawing.Color.Navy;
            this.RegisterLeftSide.Controls.Add(this.pictureBox1);
            this.RegisterLeftSide.Controls.Add(this.lblDeveloper);
            this.RegisterLeftSide.Controls.Add(this.lblWelcome);
            this.RegisterLeftSide.Controls.Add(this.lblHeaderText);
            this.RegisterLeftSide.Location = new System.Drawing.Point(-1, 0);
            this.RegisterLeftSide.Name = "RegisterLeftSide";
            this.RegisterLeftSide.Size = new System.Drawing.Size(359, 528);
            this.RegisterLeftSide.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Location = new System.Drawing.Point(205, 483);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(140, 34);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Developed \r\nby Habib Mammadov\r\n";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(55, 121);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(274, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Qeydiyyat anketinə xoş gəlmişsiniz!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderText.Font = new System.Drawing.Font("Footlight MT Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(100, 62);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(170, 44);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "ThinkUp";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsername.Location = new System.Drawing.Point(377, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "İstifadəçi adı";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPassword.Location = new System.Drawing.Point(377, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Parol";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblConfirmPassword.Location = new System.Drawing.Point(377, 241);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(134, 17);
            this.lblConfirmPassword.TabIndex = 1;
            this.lblConfirmPassword.Text = "Parolu yenidən girin";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(380, 119);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(380, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(380, 261);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(222, 22);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Navy;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(380, 332);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 39);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Qeydiyyatdan keç";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblEmpty.Location = new System.Drawing.Point(377, 301);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(0, 17);
            this.lblEmpty.TabIndex = 4;
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblHaveAccount.Location = new System.Drawing.Point(377, 432);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(143, 17);
            this.lblHaveAccount.TabIndex = 5;
            this.lblHaveAccount.Text = "Artıq bir hesabın var?";
            // 
            // llblLogIn
            // 
            this.llblLogIn.AutoSize = true;
            this.llblLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLogIn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblLogIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.llblLogIn.Location = new System.Drawing.Point(526, 432);
            this.llblLogIn.Name = "llblLogIn";
            this.llblLogIn.Size = new System.Drawing.Size(39, 18);
            this.llblLogIn.TabIndex = 6;
            this.llblLogIn.TabStop = true;
            this.llblLogIn.Text = "Giriş";
            this.llblLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLogIn_LinkClicked);
            // 
            // pctrExit
            // 
            this.pctrExit.Image = ((System.Drawing.Image)(resources.GetObject("pctrExit.Image")));
            this.pctrExit.Location = new System.Drawing.Point(667, 12);
            this.pctrExit.Name = "pctrExit";
            this.pctrExit.Size = new System.Drawing.Size(23, 25);
            this.pctrExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrExit.TabIndex = 7;
            this.pctrExit.TabStop = false;
            this.pctrExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctrExit_MouseClick);
            this.pctrExit.MouseEnter += new System.EventHandler(this.pctrExit_MouseEnter);
            this.pctrExit.MouseLeave += new System.EventHandler(this.pctrExit_MouseLeave);
            this.pctrExit.MouseHover += new System.EventHandler(this.pctrExit_MouseHover);
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 526);
            this.Controls.Add(this.pctrExit);
            this.Controls.Add(this.llblLogIn);
            this.Controls.Add(this.lblHaveAccount);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.RegisterLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegisterLeftSide.ResumeLayout(false);
            this.RegisterLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RegisterLeftSide;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.LinkLabel llblLogIn;
        private System.Windows.Forms.PictureBox pctrExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeveloper;
    }
}

