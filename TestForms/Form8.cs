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

        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";

        public Form8()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForRifle = comboBox1.Text;
            SetValueForRifle2 = comboBox2.Text;

            Hide();
            Form9 form9 = new Form9();
            form9.Show();
        }
    }
}
