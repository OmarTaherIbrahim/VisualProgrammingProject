using Client.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        HintManager hintManager;
        Server server;
        Thread t;
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
            server = new Server();

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


        private void loginBtn_Click(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
           string s= server.Execute("login" + usernameTxtLogin.Text + "," + passwordTxtLogin.Text);
            if (s.CompareTo("loginTrue") == 0)
            {
                
                login();
            }
        }
        public void showMessage()
        {
            MessageBox.Show("waiting for login");
        }
        public void login()
        {

            try
            {
                MainMenu mainMenu = new MainMenu();
                //this.Parent.Controls.Clear();
                userinfo.username = usernameTxtLogin.Text;
                mainMenu.Closed += (s, args) => this.Close();// adds this to close when the mainMenu form closes
                this.Hide();
                mainMenu.ShowDialog();
                if (t.IsAlive) t.Abort();
            }
            catch (Exception e)
            {

            }
            
        }
        public void loginFailed()
        {
            labelLogin.Text = "failed";
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
            if (passwordTxtSign.Text.Contains(";") || usernameTxtSign.Text.Contains(";")||addressTxtSign.Text.Contains(";")) { MessageBox.Show("you can't use ';'"); return; }
            if (passwordTxtSign.Text == conformTxtSign.Text)
            {
                server.Execute("createuser" + usernameTxtSign.Text.ToLower() + "," + passwordTxtSign.Text + ","+addressTxtSign.Text+";");
                if (server.response.CompareTo("loginTrue")==0)
                {
                    MessageBox.Show("account Created");
                }
                else
                {
                    MessageBox.Show("username inuse");
                }
            }
            else
            {
                MessageBox.Show("Password don't match!"); return;
            }
              
            panelSignUp.Visible = false;
            panelLogin.Visible = true;
            usernameTxtLogin.Select();
        }

        private void panelSignUp_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
