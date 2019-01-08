using Client.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        HintManager hintManager;
        public LoginForm()
        {
            InitializeComponent();
            hintManager = new HintManager();
            hintManager.SetPair(usernameTxtLogin, hintUsernameLogin);
            hintManager.SetPair(usernameTxtSign, hintUsernameSign);
            hintManager.SetPair(passwordTxtLogin, hintPasswordLogin);
            hintManager.SetPair(passwordTxtSign, hintPasswordSignup);
            hintManager.SetPair(conformTxtSign, hintConfirm);
            hintManager.SetPair(addressTxtSign, hintAddress);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void removeHint(object sender, EventArgs e)
        {
            if (sender is TextBox)
                hintManager.disableHint((TextBox)sender);
            else
                hintManager.disableHint((Label)sender);
        }
        private void addHint(object sender, EventArgs e)
        {
            if (sender is TextBox)
                hintManager.enableHint((TextBox)sender);
        }

        private void labelSignup_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (true)//add validation
                login();
        }

        private void login()
        {
            MainMenu mainMenu = new MainMenu();
            //this.Parent.Controls.Clear();
            mainMenu.Closed += (s, args) => this.Close();// adds this to close when the mainMenu form closes
            this.Hide();
            mainMenu.ShowDialog();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Image image = Image.FromFile("SplashScreen.png");
            graphics.DrawImage(image, x: 0, y: 0, width: 800 * (int)Math.Ceiling(Width / 800.0), height: 600 * (int)Math.Ceiling(Height / 600.0));
        }

        private void createLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSignUp.Visible = true;
            panelLogin.Visible = false;
            usernameTxtSign.Select();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSignUp.Visible = false;
            panelLogin.Visible = true; 
            usernameTxtLogin.Select();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            this.Parent.Controls.Add(loginForm);
            loginForm.Dock = DockStyle.Fill;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Show();
            this.Hide();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
