using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple_Gift_Card
{
    public partial class Form1 : Form
    {
        string filename = Application.StartupPath + "/db/index.html";
        public Form1()
        {
            InitializeComponent();
            if (System.IO.File.Exists(filename))
            {
                webView21.Source = new Uri(filename);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }else
                WindowState = FormWindowState.Normal;
        }
    }
}
