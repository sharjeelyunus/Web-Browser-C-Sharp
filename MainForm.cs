using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class MainForm : Form
    {
        private string url_address = Properties.Settings.Default.HomePage;
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All right reserved IUB", "CS Web Browser", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            myMethod(url_address);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            myMethod(url_address);
        }
        
        private void myMethod(string adr)
        {
            webBrowser1.Navigate(adr);
            toolStripComboBox1.Text = adr;
        }

        private void toolStripComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myMethod(toolStripComboBox1.Text);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            myMethod(toolStripComboBox1.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingForm sf = new settingForm();
            sf.ShowDialog();
        }
    }
}
