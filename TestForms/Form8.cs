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
    public partial class Form8 : Form
    {
        //public bool ANewGun = false;
        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";
        public bool aNewGun;
        public Form8()
        {
            InitializeComponent();

            aNewGun = false;

            comboBox1.Text = "None";
            String[] pAta = File.ReadAllLines("Muzlo.txt");
            foreach(var line in pAta)
            {
                string[] stuff = line.Split(',');
                comboBox1.Items.Add(stuff[0]);
            }


            comboBox2.Text = "None";
            String[] pAta2 = File.ReadAllLines("RM.txt");
            foreach (var line in pAta2)
            {
                string[] stuff = line.Split(',');
                comboBox2.Items.Add(stuff[0]);
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            aNewGun = true;
            SetValueForRifle = comboBox1.Text;
            SetValueForRifle2 = comboBox2.Text;
            Form1 form1 = new Form1();

            Hide();
            Form9 form9 = new Form9(form1);
            form9.Show();
        }
    }
}
