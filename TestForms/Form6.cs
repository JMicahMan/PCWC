using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using Newtonsoft.Json;

namespace TestForms
{
    public partial class Form6 : Form
    {
        public static string SetValueForRifle = "";
        public static string SetValueForRifle2 = "";

        public bool AutoLoader2 = false;
        public bool SixGun2 = false;

        public Form6(Form5 form5)
        {
            InitializeComponent();

            if (form5.AutoLoader == true)
            {
                AutoLoader2 = true;
                comboBox1.Text = "1911 : .45 ACP";

                String[] guns = File.ReadAllLines("Autis.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
            }

            if (form5.SixGun == true)
            {
                SixGun2 = true;
                comboBox1.Text = "S&W 10 : .38 Spc.";

                String[] guns = File.ReadAllLines("Sixers.txt");
                foreach(var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AutoLoader2 == true)
            {
                SetValueForRifle = comboBox1.Text;
                Hide();
                Form7 form7 = new Form7();
                form7.Show();

            }

            if (SixGun2 == true)
            {
                SetValueForRifle2 = comboBox1.Text;
                Hide();
                Form7 form7 = new Form7();
                form7.Show();

            }



        }
    }
}
