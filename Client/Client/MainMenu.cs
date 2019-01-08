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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Order order = new Order();
            order.TopLevel = false;
            ParentPanel.Controls.Clear();
            ParentPanel.Controls.Add(order);
            order.FormBorderStyle = FormBorderStyle.None;
            order.Dock = DockStyle.Fill;
            order.Show();
            resetColor();
            ((Button)sender).BackColor = Color.Tomato;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.TopLevel = false;
            ParentPanel.Controls.Clear();
            ParentPanel.Controls.Add(profile);
            profile.FormBorderStyle = FormBorderStyle.None;
            profile.Dock = DockStyle.Fill;
            profile.Show();
            resetColor();
            ((Button)sender).BackColor = Color.Tomato;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Order order = new Order();
            order.TopLevel = false;
            ParentPanel.Controls.Clear();
            ParentPanel.Controls.Add(order);
            order.FormBorderStyle = FormBorderStyle.None;
            order.Dock = DockStyle.Fill;
            order.Show();
        }

        private void historySideBarBtn_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.TopLevel = false;
            ParentPanel.Controls.Clear();
            ParentPanel.Controls.Add(history);
            history.FormBorderStyle = FormBorderStyle.None;
            history.Dock = DockStyle.Fill;
            history.Show();
            resetColor();
            ((Button)sender).BackColor = Color.Tomato;
        }
        private void resetColor()
        {
            historySideBarBtn.BackColor = Color.DarkOrange;
            profileSideBarBtn.BackColor = Color.DarkOrange;
            orderSideBarBtn.BackColor = Color.DarkOrange;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
            this.Hide();
        }
    }
}
