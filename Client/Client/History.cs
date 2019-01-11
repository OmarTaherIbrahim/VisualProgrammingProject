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
using Client.Util;

namespace Client
{
    public partial class History : Form
    {
        Server s;
        public History()
        {
            InitializeComponent();
            s = new Server();
        }

        private void History_Load(object sender, EventArgs e)
        {
            
            try
            {
                string str=s.Execute("history" + userinfo.username);
                fillListview(str);
            }catch(Exception ex)
            {
                MessageBox.Show(userinfo.username);
            }
        }
        private void fillListview(string r)
        {
            String s=r.Split(':')[1];
            String[] list = s.Split('^');
            foreach(string item in list)
            {
                string[] column = item.Split(',');
                ListViewItem listItem=listView1.Items.Add(column[0]);
                listItem.SubItems.Add(column[1]);
            }
        }
    }
}
