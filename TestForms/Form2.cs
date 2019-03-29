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
    public partial class Form2 : Form
    {
        public static string SetValueForRifle = " ";
        public static string SetValueForRifle2 = " ";
        public static string SetValueForRifle3 = " ";
        public static string SetValueForRifle4 = " ";
        public static string SetValueForRifle5 = " ";
        public static string SetValueForRifle6 = " ";

        


    


        public bool AssRif2 = false;
        public bool BatRif2 = false;
        public bool SubGun2 = false;
        public bool MacGun2 = false;
        public bool Shotty2 = false;
        public bool SniRif2 = false;

        public Form2(Form1 form1)
        {
            InitializeComponent();



            if (form1.AssRif == true)
            {
                
                AssRif2 = true;
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
                BatRif2 = true;
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
                SubGun2 = true;
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
                MacGun2 = true;
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
                Shotty2 = true;
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
                SniRif2 = true;
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

        public void button1_Click(object sender, EventArgs e)
        {
            if (AssRif2 == true)
            {
                SetValueForRifle = comboBox1.Text;
                Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            if (BatRif2 == true)
            {
                SetValueForRifle2 = comboBox1.Text;
                Hide();
                Form3 form3 = new Form3();
                form3.Show();

            }
            if (SubGun2 == true)
            {
                SetValueForRifle3 = comboBox1.Text;
                Hide();
                Form3 form3 = new Form3();
                form3.Show();

            }
            if (MacGun2 == true)
            {
                SetValueForRifle4 = comboBox1.Text;
                Hide();
                Form3 form3 = new Form3();
                form3.Show();

            }
            if (Shotty2 == true)
            {
                SetValueForRifle5 = comboBox1.Text;
                Hide();
                Form3 form3 = new Form3();
                form3.Show();

            }
            if (SniRif2 == true)
            {
                SetValueForRifle6 = comboBox1.Text;
                Hide();
                Form3 form3 = new Form3();
                form3.Show();

            }

        }


    }
}
