namespace Client
{
    partial class LoginForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.hintPasswordLogin = new System.Windows.Forms.Label();
            this.hintUsernameLogin = new System.Windows.Forms.Label();
            this.createLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.passwordTxtLogin = new System.Windows.Forms.TextBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.usernameTxtLogin = new System.Windows.Forms.TextBox();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.hintAddress = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.addressTxtSign = new System.Windows.Forms.TextBox();
            this.hintConfirm = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.conformTxtSign = new System.Windows.Forms.TextBox();
            this.labelSignup = new System.Windows.Forms.Label();
            this.hintPasswordSignup = new System.Windows.Forms.Label();
            this.hintUsernameSign = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.createBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTxtSign = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameTxtSign = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.hintPasswordLogin);
            this.panelLogin.Controls.Add(this.hintUsernameLogin);
            this.panelLogin.Controls.Add(this.createLinkLabel);
            this.panelLogin.Controls.Add(this.loginBtn);
            this.panelLogin.Controls.Add(this.pictureBoxPassword);
            this.panelLogin.Controls.Add(this.passwordTxtLogin);
            this.panelLogin.Controls.Add(this.pictureBoxUser);
            this.panelLogin.Controls.Add(this.usernameTxtLogin);
            this.panelLogin.Location = new System.Drawing.Point(1, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(501, 572);
            this.panelLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(193, 81);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(86, 29);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Login!";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // hintPasswordLogin
            // 
            this.hintPasswordLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hintPasswordLogin.AutoSize = true;
            this.hintPasswordLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.hintPasswordLogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hintPasswordLogin.Location = new System.Drawing.Point(151, 255);
            this.hintPasswordLogin.Name = "hintPasswordLogin";
            this.hintPasswordLogin.Size = new System.Drawing.Size(70, 16);
            this.hintPasswordLogin.TabIndex = 7;
            this.hintPasswordLogin.Text = "Password";
            this.hintPasswordLogin.TextChanged += new System.EventHandler(this.removeHint);
            this.hintPasswordLogin.Click += new System.EventHandler(this.removeHint);
            // 
            // hintUsernameLogin
            // 
            this.hintUsernameLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hintUsernameLogin.AutoSize = true;
            this.hintUsernameLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintUsernameLogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hintUsernameLogin.Location = new System.Drawing.Point(149, 199);
            this.hintUsernameLogin.Name = "hintUsernameLogin";
            this.hintUsernameLogin.Size = new System.Drawing.Size(72, 16);
            this.hintUsernameLogin.TabIndex = 6;
            this.hintUsernameLogin.Text = "Username";
            this.hintUsernameLogin.Visible = false;
            this.hintUsernameLogin.TextChanged += new System.EventHandler(this.removeHint);
            this.hintUsernameLogin.Click += new System.EventHandler(this.removeHint);
            // 
            // createLinkLabel
            // 
            this.createLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createLinkLabel.AutoSize = true;
            this.createLinkLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createLinkLabel.Location = new System.Drawing.Point(216, 289);
            this.createLinkLabel.Name = "createLinkLabel";
            this.createLinkLabel.Size = new System.Drawing.Size(119, 16);
            this.createLinkLabel.TabIndex = 3;
            this.createLinkLabel.TabStop = true;
            this.createLinkLabel.Text = "Create Account?";
            this.createLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createLinkLabel_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(252, 321);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(93, 29);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPassword.Image = global::Client.Properties.Resources.password;
            this.pictureBoxPassword.Location = new System.Drawing.Point(96, 250);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(38, 29);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 3;
            this.pictureBoxPassword.TabStop = false;
            // 
            // passwordTxtLogin
            // 
            this.passwordTxtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTxtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxtLogin.Location = new System.Drawing.Point(140, 254);
            this.passwordTxtLogin.Name = "passwordTxtLogin";
            this.passwordTxtLogin.Size = new System.Drawing.Size(206, 20);
            this.passwordTxtLogin.TabIndex = 1;
            this.passwordTxtLogin.UseSystemPasswordChar = true;
            this.passwordTxtLogin.Click += new System.EventHandler(this.removeHint);
            this.passwordTxtLogin.TextChanged += new System.EventHandler(this.removeHint);
            this.passwordTxtLogin.Enter += new System.EventHandler(this.removeHint);
            this.passwordTxtLogin.Leave += new System.EventHandler(this.addHint);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxUser.BackgroundImage = global::Client.Properties.Resources.username;
            this.pictureBoxUser.Image = global::Client.Properties.Resources.username;
            this.pictureBoxUser.Location = new System.Drawing.Point(96, 194);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(38, 29);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usernameTxtLogin
            // 
            this.usernameTxtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTxtLogin.Location = new System.Drawing.Point(140, 198);
            this.usernameTxtLogin.Name = "usernameTxtLogin";
            this.usernameTxtLogin.Size = new System.Drawing.Size(206, 20);
            this.usernameTxtLogin.TabIndex = 0;
            this.usernameTxtLogin.Click += new System.EventHandler(this.removeHint);
            this.usernameTxtLogin.TextChanged += new System.EventHandler(this.removeHint);
            this.usernameTxtLogin.Enter += new System.EventHandler(this.removeHint);
            this.usernameTxtLogin.Leave += new System.EventHandler(this.addHint);
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.hintAddress);
            this.panelSignUp.Controls.Add(this.pictureBox4);
            this.panelSignUp.Controls.Add(this.addressTxtSign);
            this.panelSignUp.Controls.Add(this.hintConfirm);
            this.panelSignUp.Controls.Add(this.pictureBox3);
            this.panelSignUp.Controls.Add(this.conformTxtSign);
            this.panelSignUp.Controls.Add(this.labelSignup);
            this.panelSignUp.Controls.Add(this.hintPasswordSignup);
            this.panelSignUp.Controls.Add(this.hintUsernameSign);
            this.panelSignUp.Controls.Add(this.linkLabel1);
            this.panelSignUp.Controls.Add(this.createBtn);
            this.panelSignUp.Controls.Add(this.pictureBox1);
            this.panelSignUp.Controls.Add(this.passwordTxtSign);
            this.panelSignUp.Controls.Add(this.pictureBox2);
            this.panelSignUp.Controls.Add(this.usernameTxtSign);
            this.panelSignUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSignUp.Location = new System.Drawing.Point(508, 0);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(561, 572);
            this.panelSignUp.TabIndex = 1;
            this.panelSignUp.Visible = false;
            // 
            // hintAddress
            // 
            this.hintAddress.AutoSize = true;
            this.hintAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.hintAddress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hintAddress.Location = new System.Drawing.Point(166, 271);
            this.hintAddress.Name = "hintAddress";
            this.hintAddress.Size = new System.Drawing.Size(60, 16);
            this.hintAddress.TabIndex = 23;
            this.hintAddress.Text = "Address";
            this.hintAddress.TextChanged += new System.EventHandler(this.removeHint);
            this.hintAddress.Click += new System.EventHandler(this.removeHint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Client.Properties.Resources.address;
            this.pictureBox4.Location = new System.Drawing.Point(119, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // addressTxtSign
            // 
            this.addressTxtSign.Location = new System.Drawing.Point(155, 270);
            this.addressTxtSign.Name = "addressTxtSign";
            this.addressTxtSign.Size = new System.Drawing.Size(205, 20);
            this.addressTxtSign.TabIndex = 7;
            this.addressTxtSign.Click += new System.EventHandler(this.removeHint);
            this.addressTxtSign.TextChanged += new System.EventHandler(this.removeHint);
            this.addressTxtSign.Enter += new System.EventHandler(this.removeHint);
            this.addressTxtSign.Leave += new System.EventHandler(this.addHint);
            // 
            // hintConfirm
            // 
            this.hintConfirm.AutoSize = true;
            this.hintConfirm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.hintConfirm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hintConfirm.Location = new System.Drawing.Point(166, 230);
            this.hintConfirm.Name = "hintConfirm";
            this.hintConfirm.Size = new System.Drawing.Size(124, 16);
            this.hintConfirm.TabIndex = 20;
            this.hintConfirm.Text = "Confirm password";
            this.hintConfirm.TextChanged += new System.EventHandler(this.removeHint);
            this.hintConfirm.Click += new System.EventHandler(this.removeHint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Client.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(119, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // conformTxtSign
            // 
            this.conformTxtSign.BackColor = System.Drawing.SystemColors.Window;
            this.conformTxtSign.Location = new System.Drawing.Point(155, 229);
            this.conformTxtSign.Name = "conformTxtSign";
            this.conformTxtSign.Size = new System.Drawing.Size(206, 20);
            this.conformTxtSign.TabIndex = 6;
            this.conformTxtSign.UseSystemPasswordChar = true;
            this.conformTxtSign.Click += new System.EventHandler(this.removeHint);
            this.conformTxtSign.TextChanged += new System.EventHandler(this.removeHint);
            this.conformTxtSign.Enter += new System.EventHandler(this.removeHint);
            this.conformTxtSign.Leave += new System.EventHandler(this.addHint);
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignup.Location = new System.Drawing.Point(200, 81);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(107, 29);
            this.labelSignup.TabIndex = 17;
            this.labelSignup.Text = "SignUp!";
            // 
            // hintPasswordSignup
            // 
            this.hintPasswordSignup.AutoSize = true;
            this.hintPasswordSignup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.hintPasswordSignup.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hintPasswordSignup.Location = new System.Drawing.Point(166, 189);
            this.hintPasswordSignup.Name = "hintPasswordSignup";
            this.hintPasswordSignup.Size = new System.Drawing.Size(70, 16);
            this.hintPasswordSignup.TabIndex = 16;
            this.hintPasswordSignup.Text = "Password";
            this.hintPasswordSignup.TextChanged += new System.EventHandler(this.removeHint);
            this.hintPasswordSignup.Click += new System.EventHandler(this.removeHint);
            // 
            // hintUsernameSign
            // 
            this.hintUsernameSign.AutoSize = true;
            this.hintUsernameSign.Enabled = false;
            this.hintUsernameSign.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintUsernameSign.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hintUsernameSign.Location = new System.Drawing.Point(163, 150);
            this.hintUsernameSign.Name = "hintUsernameSign";
            this.hintUsernameSign.Size = new System.Drawing.Size(72, 16);
            this.hintUsernameSign.TabIndex = 15;
            this.hintUsernameSign.Text = "Username";
            this.hintUsernameSign.TextChanged += new System.EventHandler(this.removeHint);
            this.hintUsernameSign.Click += new System.EventHandler(this.removeHint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(152, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(182, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an Account?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.createBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createBtn.Location = new System.Drawing.Point(193, 347);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(167, 29);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(119, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTxtSign
            // 
            this.passwordTxtSign.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTxtSign.Location = new System.Drawing.Point(155, 188);
            this.passwordTxtSign.Name = "passwordTxtSign";
            this.passwordTxtSign.Size = new System.Drawing.Size(206, 20);
            this.passwordTxtSign.TabIndex = 5;
            this.passwordTxtSign.UseSystemPasswordChar = true;
            this.passwordTxtSign.Click += new System.EventHandler(this.removeHint);
            this.passwordTxtSign.TextChanged += new System.EventHandler(this.removeHint);
            this.passwordTxtSign.Enter += new System.EventHandler(this.removeHint);
            this.passwordTxtSign.Leave += new System.EventHandler(this.addHint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Client.Properties.Resources.username;
            this.pictureBox2.Image = global::Client.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(118, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // usernameTxtSign
            // 
            this.usernameTxtSign.Location = new System.Drawing.Point(154, 149);
            this.usernameTxtSign.Name = "usernameTxtSign";
            this.usernameTxtSign.Size = new System.Drawing.Size(206, 20);
            this.usernameTxtSign.TabIndex = 4;
            this.usernameTxtSign.Click += new System.EventHandler(this.removeHint);
            this.usernameTxtSign.TextChanged += new System.EventHandler(this.removeHint);
            this.usernameTxtSign.Enter += new System.EventHandler(this.removeHint);
            this.usernameTxtSign.Leave += new System.EventHandler(this.addHint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.panelLogin);
            this.MaximumSize = new System.Drawing.Size(1085, 611);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox usernameTxtLogin;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox passwordTxtLogin;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label hintPasswordLogin;
        private System.Windows.Forms.Label hintUsernameLogin;
        private System.Windows.Forms.LinkLabel createLinkLabel;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label hintConfirm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox conformTxtSign;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.Label hintPasswordSignup;
        private System.Windows.Forms.Label hintUsernameSign;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTxtSign;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usernameTxtSign;
        private System.Windows.Forms.Label hintAddress;
        private System.Windows.Forms.TextBox addressTxtSign;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

