using System;
using System.IO;
using System.Windows.Controls.Primitives;
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
    public class MyClassEvent
    {
        public static void OnClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button mybotton = sender as System.Windows.Forms.Button;
            Form myform = mybotton.Parent as Form;
        }

    }
    public partial class Form2 : Form
    {
        public static string SetValueForRifle = " \n";
        public static string SetValueForRifle2 = " \n";
        public static string SetValueForRifle3 = " \n";
        public static string SetValueForRifle4 = " \n";
        public static string SetValueForRifle5 = " \n";
        public static string SetValueForRifle6 = " \n";

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

                void button1_Click(object sender, EventArgs e)
                {
                    button1.Click += MyClassEvent.OnClick;
                    if (form1.AssRif == true)
                    {
                        SetValueForRifle = comboBox1.Text;
                        Hide();
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                    if (form1.BatRif == true)
                    {
                        SetValueForRifle2 = comboBox1.Text;
                        Hide();
                        Form3 form3 = new Form3();
                        form3.Show();

                    }
                    if (form1.SubGun == true)
                    {
                        SetValueForRifle3 = comboBox1.Text;
                        Hide();
                        Form3 form3 = new Form3();
                        form3.Show();

                    }
                    if (form1.MacGun == true)
                    {
                        SetValueForRifle4 = comboBox1.Text;
                        Hide();
                        Form3 form3 = new Form3();
                        form3.Show();

                    }
                    if (form1.Shotty == true)
                    {
                        SetValueForRifle5 = comboBox1.Text;
                        Hide();
                        Form3 form3 = new Form3();
                        form3.Show();

                    }
                    if (form1.SniRif == true)
                    {
                        SetValueForRifle6 = comboBox1.Text;
                                                Hide();
                        Form3 form3 = new Form3();
                        form3.Show();

                    }

                }


            }

        }

    }
}
