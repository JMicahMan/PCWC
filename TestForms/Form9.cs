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
using System.Runtime;
using System.Net;



namespace TestForms
{
    public partial class Form9 : Form
    {


        public Form9(Form1 form1)
        {

            InitializeComponent();

            

            if (form1.OldGun == false)
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

            else if (form1.OldGun == true)
            {
               

                label1.Text = File.ReadAllText(@"AR.txt");

                label1.Text = label1.Text.Replace("{", "");
                label1.Text = label1.Text.Replace("}", "");
                label1.Text = label1.Text.Replace("Name", "");
                label1.Text = label1.Text.Replace(":", "");
                label1.Text = label1.Text.Replace(",", "");
                label1.Text = label1.Text.Replace("_", "");
                label1.Text = label1.Text.Replace(@"""", "");

                label18.Text = File.ReadAllText(@"BR.json");

                label18.Text = label18.Text.Replace("{", "");
                label18.Text = label18.Text.Replace("}", "");
                label18.Text = label18.Text.Replace("Name", "");
                label18.Text = label18.Text.Replace(":", "");
                label18.Text = label18.Text.Replace(",", "");
                label18.Text = label18.Text.Replace("_", "");
                label18.Text = label18.Text.Replace(@"""", "");

                label19.Text = File.ReadAllText(@"SMG.json");

                label19.Text = label19.Text.Replace("{", "");
                label19.Text = label19.Text.Replace("}", "");
                label19.Text = label19.Text.Replace("Name", "");
                label19.Text = label19.Text.Replace(":", "");
                label19.Text = label19.Text.Replace(",", "");
                label19.Text = label19.Text.Replace("_", "");
                label19.Text = label19.Text.Replace(@"""", "");

                label21.Text = File.ReadAllText(@"LMG.json");

                label21.Text = label21.Text.Replace("{", "");
                label21.Text = label21.Text.Replace("}", "");
                label21.Text = label21.Text.Replace("Name", "");
                label21.Text = label21.Text.Replace(":", "");
                label21.Text = label21.Text.Replace(",", "");
                label21.Text = label21.Text.Replace("_", "");
                label21.Text = label21.Text.Replace(@"""", "");

                label20.Text = File.ReadAllText(@"SG.json");

                label20.Text = label20.Text.Replace("{", "");
                label20.Text = label20.Text.Replace("}", "");
                label20.Text = label20.Text.Replace("Name", "");
                label20.Text = label20.Text.Replace(":", "");
                label20.Text = label20.Text.Replace(",", "");
                label20.Text = label20.Text.Replace("_", "");
                label20.Text = label20.Text.Replace(@"""", "");

                label22.Text = File.ReadAllText(@"SR.json");

                label22.Text = label22.Text.Replace("{", "");
                label22.Text = label22.Text.Replace("}", "");
                label22.Text = label22.Text.Replace("Name", "");
                label22.Text = label22.Text.Replace(":", "");
                label22.Text = label22.Text.Replace(",", "");
                label22.Text = label22.Text.Replace("_", "");
                label22.Text = label22.Text.Replace(@"""", "");

                label2.Text = File.ReadAllText(@"brl.json");

                label2.Text = label2.Text.Replace("{", "");
                label2.Text = label2.Text.Replace("}", "");
                label2.Text = label2.Text.Replace("Name", "");
                label2.Text = label2.Text.Replace(":", "");
                label2.Text = label2.Text.Replace(",", "");
                label2.Text = label2.Text.Replace("_", "");
                label2.Text = label2.Text.Replace(@"""", "");

                label3.Text = File.ReadAllText(@"hg.json");

                label3.Text = label3.Text.Replace("{", "");
                label3.Text = label3.Text.Replace("}", "");
                label3.Text = label3.Text.Replace("Name", "");
                label3.Text = label3.Text.Replace(":", "");
                label3.Text = label3.Text.Replace(",", "");
                label3.Text = label3.Text.Replace("_", "");
                label3.Text = label3.Text.Replace(@"""", "");

                label4.Text = File.ReadAllText(@"RC.json");

                label4.Text = label4.Text.Replace("{", "");
                label4.Text = label4.Text.Replace("}", "");
                label4.Text = label4.Text.Replace("Name", "");
                label4.Text = label4.Text.Replace(":", "");
                label4.Text = label4.Text.Replace(",", "");
                label4.Text = label4.Text.Replace("_", "");
                label4.Text = label4.Text.Replace(@"""", "");

                label5.Text = File.ReadAllText(@"stk.json");

                label5.Text = label5.Text.Replace("{", "");
                label5.Text = label5.Text.Replace("}", "");
                label5.Text = label5.Text.Replace("Name", "");
                label5.Text = label5.Text.Replace(":", "");
                label5.Text = label5.Text.Replace(",", "");
                label5.Text = label5.Text.Replace("_", "");
                label5.Text = label5.Text.Replace(@"""", "");

                label6.Text = File.ReadAllText(@"TP.json");

                label6.Text = label6.Text.Replace("{", "");
                label6.Text = label6.Text.Replace("}", "");
                label6.Text = label6.Text.Replace("Name", "");
                label6.Text = label6.Text.Replace(":", "");
                label6.Text = label6.Text.Replace(",", "");
                label6.Text = label6.Text.Replace("_", "");
                label6.Text = label6.Text.Replace(@"""", "");


                label7.Text = File.ReadAllText(@"muz.json");

                label7.Text = label7.Text.Replace("{", "");
                label7.Text = label7.Text.Replace("}", "");
                label7.Text = label7.Text.Replace("Name", "");
                label7.Text = label7.Text.Replace(":", "");
                label7.Text = label7.Text.Replace(",", "");
                label7.Text = label7.Text.Replace("_", "");
                label7.Text = label7.Text.Replace(@"""", "");

                label8.Text = File.ReadAllText(@"opt.json");

                label8.Text = label8.Text.Replace("{", "");
                label8.Text = label8.Text.Replace("}", "");
                label8.Text = label8.Text.Replace("Name", "");
                label8.Text = label8.Text.Replace(":", "");
                label8.Text = label8.Text.Replace(",", "");
                label8.Text = label8.Text.Replace("_", "");
                label8.Text = label8.Text.Replace(@"""", "");

                label9.Text = File.ReadAllText(@"srl.json");

                label9.Text = label9.Text.Replace("{", "");
                label9.Text = label9.Text.Replace("}", "");
                label9.Text = label9.Text.Replace("Name", "");
                label9.Text = label9.Text.Replace(":", "");
                label9.Text = label9.Text.Replace(",", "");
                label9.Text = label9.Text.Replace("_", "");
                label9.Text = label9.Text.Replace(@"""", "");

                label10.Text = File.ReadAllText(@"UB.json");

                label10.Text = label10.Text.Replace("{", "");
                label10.Text = label10.Text.Replace("}", "");
                label10.Text = label10.Text.Replace("Name", "");
                label10.Text = label10.Text.Replace(":", "");
                label10.Text = label10.Text.Replace(",", "");
                label10.Text = label10.Text.Replace("_", "");
                label10.Text = label10.Text.Replace(@"""", "");


                label11.Text = File.ReadAllText(@"auto.json");

                label11.Text = label11.Text.Replace("{", "");
                label11.Text = label11.Text.Replace("}", "");
                label11.Text = label11.Text.Replace("Name", "");
                label11.Text = label11.Text.Replace(":", "");
                label11.Text = label11.Text.Replace(",", "");
                label11.Text = label11.Text.Replace("_", "");
                label11.Text = label11.Text.Replace(@"""", "");

                label23.Text = File.ReadAllText(@"rev.json");

                label23.Text = label23.Text.Replace("{", "");
                label23.Text = label23.Text.Replace("}", "");
                label23.Text = label23.Text.Replace("Name", "");
                label23.Text = label23.Text.Replace(":", "");
                label23.Text = label23.Text.Replace(",", "");
                label23.Text = label23.Text.Replace("_", "");
                label23.Text = label23.Text.Replace(@"""", "");


                label12.Text = File.ReadAllText(@"frm.json");

                label12.Text = label12.Text.Replace("{", "");
                label12.Text = label12.Text.Replace("}", "");
                label12.Text = label12.Text.Replace("Name", "");
                label12.Text = label12.Text.Replace(":", "");
                label12.Text = label12.Text.Replace(",", "");
                label12.Text = label12.Text.Replace("_", "");
                label12.Text = label12.Text.Replace(@"""", "");

                label13.Text = File.ReadAllText(@"pbrl.json");

                label13.Text = label13.Text.Replace("{", "");
                label13.Text = label13.Text.Replace("}", "");
                label13.Text = label13.Text.Replace("Name", "");
                label13.Text = label13.Text.Replace(":", "");
                label13.Text = label13.Text.Replace(",", "");
                label13.Text = label13.Text.Replace("_", "");
                label13.Text = label13.Text.Replace(@"""", "");

                label14.Text = File.ReadAllText(@"slide.json");

                label14.Text = label14.Text.Replace("{", "");
                label14.Text = label14.Text.Replace("}", "");
                label14.Text = label14.Text.Replace("Name", "");
                label14.Text = label14.Text.Replace(":", "");
                label14.Text = label14.Text.Replace(",", "");
                label14.Text = label14.Text.Replace("_", "");
                label14.Text = label14.Text.Replace(@"""", "");

                label15.Text = File.ReadAllText(@"trg.json");

                label15.Text = label15.Text.Replace("{", "");
                label15.Text = label15.Text.Replace("}", "");
                label15.Text = label15.Text.Replace("Name", "");
                label15.Text = label15.Text.Replace(":", "");
                label15.Text = label15.Text.Replace(",", "");
                label15.Text = label15.Text.Replace("_", "");
                label15.Text = label15.Text.Replace(@"""", "");

                label16.Text = File.ReadAllText(@"pmzl.json");

                label16.Text = label16.Text.Replace("{", "");
                label16.Text = label16.Text.Replace("}", "");
                label16.Text = label16.Text.Replace("Name", "");
                label16.Text = label16.Text.Replace(":", "");
                label16.Text = label16.Text.Replace(",", "");
                label16.Text = label16.Text.Replace("_", "");
                label16.Text = label16.Text.Replace(@"""", "");

                label17.Text = File.ReadAllText(@"rlM.json");

                label17.Text = label17.Text.Replace("{", "");
                label17.Text = label17.Text.Replace("}", "");
                label17.Text = label17.Text.Replace("Name", "");
                label17.Text = label17.Text.Replace(":", "");
                label17.Text = label17.Text.Replace(",", "");
                label17.Text = label17.Text.Replace("_", "");
                label17.Text = label17.Text.Replace(@"""", "");

            }

            if (label1.Text == "label1")
            {
                label1.Text = "";
            }

            if (label2.Text == "label2")
            {
                label2.Text = "";
            }

            if (label3.Text == "label3")
            {
                label3.Text = "";
            }

            if (label4.Text == "label4")
            {
                label4.Text = "";
            }

            if (label5.Text == "label5")
            {
                label5.Text = "";
            }

            if (label6.Text == "label6")
            {
                label6.Text = "";
            }

            if (label7.Text == "label7")
            {
                label7.Text = "";
            }

            if (label8.Text == "label8")
            {
                label8.Text = "";
            }

            if (label9.Text == "label9")
            {
                label9.Text = "";
            }

            if (label10.Text == "label10")
            {
                label10.Text = "";
            }

            if (label11.Text == "label11")
            {
                label11.Text = "";
            }

            if (label12.Text == "label12")
            {
                label12.Text = "";
            }

            if (label13.Text == "label13")
            {
                label13.Text = "";
            }

            if (label14.Text == "label14")
            {
                label14.Text = "";
            }

            if (label15.Text == "label15")
            {
                label15.Text = "";
            }

            if (label16.Text == "label16")
            {
                label16.Text = "";
            }

            if (label17.Text == "label17")
            {
                label17.Text = "";
            }

            if (label18.Text == "label18")
            {
                label18.Text = "";
            }

            if (label19.Text == "label19")
            {
                label19.Text = "";
            }

            if (label20.Text == "label20")
            {
                label20.Text = "";
            }

            if (label21.Text == "label21")
            {
                label21.Text = "";
            }

            if (label22.Text == "label22")
            {
                label22.Text = "";
            }

            if (label23.Text == "label23")
            {
                label23.Text = "";
            }




        }

        public void button1_Click(object sender, EventArgs e)
        {
            Classes.Weapons.AssaultRifles assaultRifles = new Classes.Weapons.AssaultRifles();
            assaultRifles.Name = Form2.SetValueForRifle; ;

            Classes.Weapons.BattleRifles battleRifles = new Classes.Weapons.BattleRifles();
            battleRifles.Name = Form2.SetValueForRifle2;

            Classes.Weapons.SMGs sMGs = new Classes.Weapons.SMGs();
            sMGs.Name = Form2.SetValueForRifle3;

            Classes.Weapons.LMGs lMGs = new Classes.Weapons.LMGs();
            lMGs.Name = Form2.SetValueForRifle4;

            Classes.Weapons.Shotguns shotguns = new Classes.Weapons.Shotguns();
            shotguns.Name = Form2.SetValueForRifle5;

            Classes.Weapons.SniperRifles sniperRifles = new Classes.Weapons.SniperRifles();
            sniperRifles.Name = Form2.SetValueForRifle6;


            Classes.WeaponMods.Barrel barrel = new Classes.WeaponMods.Barrel();
            barrel.Name = Form3.SetValueForRifle3;

            Classes.WeaponMods.Handguard handguard = new Classes.WeaponMods.Handguard();
            handguard.Name = Form3.SetValueForRifle5;

            Classes.WeaponMods.Reciver reciver = new Classes.WeaponMods.Reciver();
            reciver.Name = Form3.SetValueForRifle2;

            Classes.WeaponMods.Stock stock = new Classes.WeaponMods.Stock();
            stock.Name = Form3.SetValueForRifle4;

            Classes.WeaponMods.TopPiece topPiece = new Classes.WeaponMods.TopPiece();
            topPiece.Name = Form3.SetValueForRifle;


            Classes.WeaponAttachments.Muzzle muzzle = new Classes.WeaponAttachments.Muzzle();
            muzzle.Name = Form4.SetValueForRifle4;

            Classes.WeaponAttachments.Optic optic = new Classes.WeaponAttachments.Optic();
            optic.Name = Form4.SetValueForRifle;

            Classes.WeaponAttachments.SideRail sideRail = new Classes.WeaponAttachments.SideRail();
            sideRail.Name = Form4.SetValueForRifle3;

            Classes.WeaponAttachments.Underbarrel underbarrel = new Classes.WeaponAttachments.Underbarrel();
            underbarrel.Name = Form4.SetValueForRifle2;


            Classes.Sidearms.Automatics automatics = new Classes.Sidearms.Automatics();
            automatics.Name = Form6.SetValueForRifle;

            Classes.Sidearms.Revolvers revolvers = new Classes.Sidearms.Revolvers();
            revolvers.Name = Form6.SetValueForRifle2;


            Classes.SideArmMods.Frame frame = new Classes.SideArmMods.Frame();
            frame.Name = Form7.SetValueForRifle4;

            Classes.SideArmMods.PBarrel pBarrel = new Classes.SideArmMods.PBarrel();
            pBarrel.Name = Form7.SetValueForRifle;

            Classes.SideArmMods.Slide slide = new Classes.SideArmMods.Slide();
            slide.Name = Form7.SetValueForRifle3;

            Classes.SideArmMods.Trigger trigger = new Classes.SideArmMods.Trigger();
            trigger.Name = Form7.SetValueForRifle2;


            Classes.SideArmAttachments.PMuzzle pMuzzle = new Classes.SideArmAttachments.PMuzzle();
            pMuzzle.Name = Form8.SetValueForRifle;

            Classes.SideArmAttachments.Railmount railmount = new Classes.SideArmAttachments.Railmount();
            railmount.Name = Form8.SetValueForRifle2;

            File.WriteAllText(@"AR.txt", JsonConvert.SerializeObject(label1.Text));

            File.WriteAllText(@"BR.json", JsonConvert.SerializeObject(label18.Text));

            File.WriteAllText(@"SMG.json", JsonConvert.SerializeObject(label19.Text));

            File.WriteAllText(@"LMG.json", JsonConvert.SerializeObject(label21.Text));

            File.WriteAllText(@"SG.json", JsonConvert.SerializeObject(label20.Text));

            File.WriteAllText(@"SR.json", JsonConvert.SerializeObject(label22.Text));

            File.WriteAllText(@"brl.json", JsonConvert.SerializeObject(label2.Text));

            File.WriteAllText(@"hg.json", JsonConvert.SerializeObject(label3.Text));

            File.WriteAllText(@"RC.json", JsonConvert.SerializeObject(label4.Text));

            File.WriteAllText(@"stk.json", JsonConvert.SerializeObject(label5.Text));

            File.WriteAllText(@"TP.json", JsonConvert.SerializeObject(label6.Text));

            File.WriteAllText(@"muz.json", JsonConvert.SerializeObject(label7.Text));

            File.WriteAllText(@"opt.json", JsonConvert.SerializeObject(label8.Text));

            File.WriteAllText(@"srl.json", JsonConvert.SerializeObject(label9.Text));

            File.WriteAllText(@"UB.json", JsonConvert.SerializeObject(label10.Text));

            File.WriteAllText(@"auto.json", JsonConvert.SerializeObject(label11.Text));

            File.WriteAllText(@"rev.json", JsonConvert.SerializeObject(label23.Text));

            File.WriteAllText(@"frm.json", JsonConvert.SerializeObject(label12.Text));

            File.WriteAllText(@"pbrl.json", JsonConvert.SerializeObject(label13.Text));

            File.WriteAllText(@"slide.json", JsonConvert.SerializeObject(label14.Text));

            File.WriteAllText(@"trg.json", JsonConvert.SerializeObject(label15.Text));

            File.WriteAllText(@"pmzl.json", JsonConvert.SerializeObject(label16.Text));

            File.WriteAllText(@"rlM.json", JsonConvert.SerializeObject(label17.Text));




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
