﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace TestForms
{
    public partial class Form1 : Form
    {
        public bool AssRif = false;
        public bool BatRif = false;
        public bool SubGun = false;
        public bool MacGun = false;
        public bool Shotty = false;
        public bool SniRif = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button2, new Point(0, button2.Height));
        }

        private void assaultRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssRif = true;
            Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void battleRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatRif = true;
            Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void sMGsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubGun = true;
            Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void lMGsGPMGsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MacGun = true;
            Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void shotgunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shotty = true;
            Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void sniperRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SniRif = true;
            Hide();
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files| *.json";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Can't read file" + ex.Message);
                }
            }
        }
    }
}
