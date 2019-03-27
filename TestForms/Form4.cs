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
    public partial class Form4 : Form
    {
        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";
        public static string SetValueForRifle3 = " ";
        public static string SetValueForRifle4 = " ";

        public Form4()
        {
            InitializeComponent();

            comboBox1.Text = "None";
            String[] Ata = File.ReadAllLines("Opo.txt");
            foreach (var line in Ata)
            {
                string[] stuff = line.Split(',');
                comboBox1.Items.Add(stuff[0]);
            }

            comboBox2.Text = "None";
            String[] Ata2 = File.ReadAllLines("gips.txt");
            foreach (var line in Ata2)
            {
                string[] stuff = line.Split(',');
                comboBox2.Items.Add(stuff[0]);
            }

            comboBox3.Text = "None";
            String[] Ata3 = File.ReadAllLines("mont.txt");
            foreach (var line in Ata3)
            {
                string[] stuff = line.Split(',');
                comboBox3.Items.Add(stuff[0]);
            }

            comboBox4.Text = "None";
            String[] Ata4 = File.ReadAllLines("Muzzy.txt");
            foreach (var line in Ata4)
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
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
