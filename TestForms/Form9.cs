using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace TestForms
{
    public partial class Form9 : Form
    {

        public Form9(Form8 form8)
        {

            InitializeComponent();

            if (form8.ANewGun == true)
            {
                Classes.Weapons.AssaultRifles assaultRifles = new Classes.Weapons.AssaultRifles();
                assaultRifles.Name = Form2.SetValueForRifle;
                label1.Text = assaultRifles.Name;


                Classes.Weapons.BattleRifles battleRifles = new Classes.Weapons.BattleRifles();
                battleRifles.Name = Form2.SetValueForRifle2;
                label18.Text = battleRifles.Name;

                Classes.Weapons.SMGs sMGs = new Classes.Weapons.SMGs();
                sMGs.Name = Form2.SetValueForRifle3;
                label19.Text = sMGs.Name;

                Classes.Weapons.LMGs lMGs = new Classes.Weapons.LMGs();
                lMGs.Name = Form2.SetValueForRifle4;
                label21.Text = lMGs.Name;

                Classes.Weapons.Shotguns shotguns = new Classes.Weapons.Shotguns();
                shotguns.Name = Form2.SetValueForRifle5;
                label20.Text = shotguns.Name;

                Classes.Weapons.SniperRifles sniperRifles = new Classes.Weapons.SniperRifles();
                sniperRifles.Name = Form2.SetValueForRifle6;
                label22.Text = sniperRifles.Name;


                Classes.WeaponMods.Barrel barrel = new Classes.WeaponMods.Barrel();
                barrel.Name = Form3.SetValueForRifle3;
                label2.Text = barrel.Name;

                Classes.WeaponMods.Handguard handguard = new Classes.WeaponMods.Handguard();
                handguard.Name = Form3.SetValueForRifle5;
                label3.Text = handguard.Name;

                Classes.WeaponMods.Reciver reciver = new Classes.WeaponMods.Reciver();
                reciver.Name = Form3.SetValueForRifle2;
                label4.Text = reciver.Name;

                Classes.WeaponMods.Stock stock = new Classes.WeaponMods.Stock();
                stock.Name = Form3.SetValueForRifle4;
                label5.Text = stock.Name;

                Classes.WeaponMods.TopPiece topPiece = new Classes.WeaponMods.TopPiece();
                topPiece.Name = Form3.SetValueForRifle;
                label6.Text = topPiece.Name;


                Classes.WeaponAttachments.Muzzle muzzle = new Classes.WeaponAttachments.Muzzle();
                muzzle.Name = Form4.SetValueForRifle4;
                label7.Text = muzzle.Name;

                Classes.WeaponAttachments.Optic optic = new Classes.WeaponAttachments.Optic();
                optic.Name = Form4.SetValueForRifle;
                label8.Text = optic.Name;

                Classes.WeaponAttachments.SideRail sideRail = new Classes.WeaponAttachments.SideRail();
                sideRail.Name = Form4.SetValueForRifle3;
                label9.Text = sideRail.Name;

                Classes.WeaponAttachments.Underbarrel underbarrel = new Classes.WeaponAttachments.Underbarrel();
                underbarrel.Name = Form4.SetValueForRifle2;
                label10.Text = underbarrel.Name;


                Classes.Sidearms.Automatics automatics = new Classes.Sidearms.Automatics();
                automatics.Name = Form6.SetValueForRifle;
                label11.Text = automatics.Name;

                Classes.Sidearms.Revolvers revolvers = new Classes.Sidearms.Revolvers();
                revolvers.Name = Form6.SetValueForRifle2;
                label23.Text = revolvers.Name;


                Classes.SideArmMods.Frame frame = new Classes.SideArmMods.Frame();
                frame.Name = Form7.SetValueForRifle4;
                label12.Text = frame.Name;

                Classes.SideArmMods.PBarrel pBarrel = new Classes.SideArmMods.PBarrel();
                pBarrel.Name = Form7.SetValueForRifle;
                label13.Text = pBarrel.Name;

                Classes.SideArmMods.Slide slide = new Classes.SideArmMods.Slide();
                slide.Name = Form7.SetValueForRifle3;
                label14.Text = slide.Name;

                Classes.SideArmMods.Trigger trigger = new Classes.SideArmMods.Trigger();
                trigger.Name = Form7.SetValueForRifle2;
                label15.Text = trigger.Name;


                Classes.SideArmAttachments.PMuzzle pMuzzle = new Classes.SideArmAttachments.PMuzzle();
                pMuzzle.Name = Form8.SetValueForRifle;
                label16.Text = pMuzzle.Name;

                Classes.SideArmAttachments.Railmount railmount = new Classes.SideArmAttachments.Railmount();
                railmount.Name = Form8.SetValueForRifle2;
                label17.Text = railmount.Name;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(save.FileName, FileMode.CreateNew))
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {
                    string json = JsonConvert.SerialzeObject(_data.TpArray());
                }
            }
            save.FileName = "Untitled";
            save.Filter = "Json File | *.json";
            save.DefaultExt = "json";
            save.AddExtension = true;
            save.RestoreDirectory = true;
            save.ShowDialog();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
