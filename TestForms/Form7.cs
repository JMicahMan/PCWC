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
    public partial class Form7 : Form
    {

        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";
        public static string SetValueForRifle3 = " ";
        public static string SetValueForRifle4 = " ";

        public Form7()
        {
            InitializeComponent();

            comboBox1.Text = "Standard";
            String[] PMod = File.ReadAllLines("Bar.txt");
            foreach(var line in PMod)
            {
                string[] stuff = line.Split(',');
                comboBox1.Items.Add(stuff[0]);
            }

            comboBox2.Text = "Standard";
            String[] PMod2 = File.ReadAllLines("Trig.txt");
            foreach (var line in PMod2)
            {
                string[] stuff = line.Split(',');
                comboBox2.Items.Add(stuff[0]);
            }

            comboBox3.Text = "Standard";
            String[] PMod3 = File.ReadAllLines("Slid.txt");
            foreach (var line in PMod3)
            {
                string[] stuff = line.Split(',');
                comboBox3.Items.Add(stuff[0]);
            }

            comboBox4.Text = "Standard";
            String[] PMod4 = File.ReadAllLines("Frm.txt");
            foreach (var line in PMod4)
            {
                string[] stuff = line.Split(',');
                comboBox4.Items.Add(stuff[0]);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForRifle = comboBox1.Text;
            SetValueForRifle2 = comboBox2.Text;
            SetValueForRifle3 = comboBox3.Text;
            SetValueForRifle4 = comboBox4.Text;

            Hide();
            Form8 form8 = new Form8();
            form8.Show();
            
        }
    }
}
