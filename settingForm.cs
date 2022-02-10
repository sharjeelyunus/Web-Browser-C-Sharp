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
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HomePage = textBox1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Home Page Setting Saved", "homepage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
