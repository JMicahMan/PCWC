using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class Form5 : Form
    {
        public bool AutoLoader = false;
        public bool SixGun = false;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }

        private void automaticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoLoader = true;
            Hide();
            Form6 form6 = new Form6(this);
            form6.Show();
        }

        private void revolversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SixGun = true;
            Hide();
            Form6 form6 = new Form6(this);
            form6.Show();
        }
    }
}
