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
    public partial class Form2 : Form
    {
        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";
        public static string SetValueForRifle3 = " ";
        public static string SetValueForRifle4 = " ";
        public static string SetValueForRifle5 = " ";
        public static string SetValueForRifle6 = " ";

        public Form2(Form1 form1)
        {
            InitializeComponent();

            if (form1.AssRif == true)
            {
                comboBox1.Text = "M16 : 5.56x45mm";

                String[] guns = File.ReadAllLines("AsultRifl.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
                SetValueForRifle = comboBox1.Text;
            }

            if (form1.BatRif == true)
            {
                comboBox1.Text = "FAL : 7.62x51mm";

                String[] guns = File.ReadAllLines("BattRifl.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
                SetValueForRifle2 = comboBox1.Text;


            }

            if (form1.SubGun == true)
            {
                comboBox1.Text = "Uzi : 9x19mm";

                String[] guns = File.ReadAllLines("Subby.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
                SetValueForRifle3 = comboBox1.Text;


            }

            if (form1.MacGun == true)
            {
                comboBox1.Text = "M60 : 7.62x51mm";

                String[] guns = File.ReadAllLines("Maschinengewehr.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
                SetValueForRifle4 = comboBox1.Text;


            }

            if (form1.Shotty == true)
            {
                comboBox1.Text = "Mossberg 500 : 12 Gauge";

                String[] guns = File.ReadAllLines("Shotg.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
                SetValueForRifle5 = comboBox1.Text;


            }


            if (form1.SniRif == true)
            {
                comboBox1.Text = "Remington 700 : 7.62x51mm";

                String[] guns = File.ReadAllLines("ELR.txt");
                foreach (var line in guns)
                {
                    string[] stuff = line.Split(',');
                    comboBox1.Items.Add(stuff[0]);
                }
                SetValueForRifle5 = comboBox1.Text;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.Text == SetValueForRifle)
            //{
            //    SetValueForRifle = comboBox1.Text;
            //    Hide();
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            //if (comboBox1.Text == SetValueForRifle2)
            //{
            //    SetValueForRifle2 = comboBox1.Text;
            //    Hide();
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            //if (comboBox1.Text == SetValueForRifle3)
            //{
            //    SetValueForRifle3 = comboBox1.Text;
            //    Hide();
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            //if (comboBox1.Text == SetValueForRifle4)
            //{
            //    SetValueForRifle4 = comboBox1.Text;
            //    Hide();
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            //if (comboBox1.Text == SetValueForRifle5)
            //{
            //    SetValueForRifle5 = comboBox1.Text;
            //    Hide();
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            //if (comboBox1.Text == SetValueForRifle6)
            //{
            //    SetValueForRifle6 = comboBox1.Text;
            //    Hide();
            //    Form3 form3 = new Form3();
            //    form3.Show();
            //}

            SetValueForRifle = comboBox1.Text;
            SetValueForRifle2 = comboBox1.Text;
            SetValueForRifle3 = comboBox1.Text;
            SetValueForRifle4 = comboBox1.Text;
            SetValueForRifle5 = comboBox1.Text;
            SetValueForRifle6 = comboBox1.Text;

            Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
