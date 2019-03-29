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
    public partial class Form3 : Form
    {
        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";
        public static string SetValueForRifle3 = " ";
        public static string SetValueForRifle4 = " ";
        public static string SetValueForRifle5 = " ";

        public Form3()
        {
            InitializeComponent();

            comboBox1.Text = "Standard";

            String[] Mods = File.ReadAllLines("Top.txt");
            foreach (var line in Mods)
            {
                string[] stuff = line.Split(',');
                comboBox1.Items.Add(stuff[0]);
            }

            comboBox2.Text = "Standard";

            String[] Mods2 = File.ReadAllLines("Rec.txt");
            foreach (var line in Mods2)
            {
                string[] stuff = line.Split(',');
                comboBox2.Items.Add(stuff[0]);
            }



            comboBox3.Text = "Standard";

            String[] Mods3 = File.ReadAllLines("Recy.txt");
            foreach (var line in Mods3)
            {
                string[] stuff = line.Split(',');
                comboBox3.Items.Add(stuff[0]);
            }


            comboBox4.Text = "Standard";

            String[] Mods4 = File.ReadAllLines("Stoky.txt");
            foreach (var line in Mods4)
            {
                string[] stuff = line.Split(',');
                comboBox4.Items.Add(stuff[0]);
            }


            comboBox5.Text = "Standard";

            String[] Mods5 = File.ReadAllLines("Handsy.txt");
            foreach (var line in Mods5)
            {
                string[] stuff = line.Split(',');
                comboBox5.Items.Add(stuff[0]);
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            SetValueForRifle = comboBox1.Text;
            SetValueForRifle2 = comboBox2.Text;
            SetValueForRifle3 = comboBox3.Text;
            SetValueForRifle4 = comboBox4.Text;
            SetValueForRifle5 = comboBox5.Text;

            Hide();
            Form4 form4 = new Form4();
            form4.Show();



        }
    }





}
