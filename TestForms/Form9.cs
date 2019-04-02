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
                label1.Text = File.ReadAllText(@"AR.json");
                label18.Text = File.ReadAllText(@"BR.json");
                label19.Text = File.ReadAllText(@"SMG.json");
                label21.Text = File.ReadAllText(@"LMG.json");
                label20.Text = File.ReadAllText(@"SG.json");
                label22.Text = File.ReadAllText(@"SR.json");

                label2.Text = File.ReadAllText(@"brl.json");
                label3.Text = File.ReadAllText(@"hg.json");
                label4.Text = File.ReadAllText(@"RC.json");
                label5.Text = File.ReadAllText(@"stk.json");
                label6.Text = File.ReadAllText(@"TP.json");

                label7.Text = File.ReadAllText(@"muz.json");
                label8.Text = File.ReadAllText(@"opt.json");
                label9.Text = File.ReadAllText(@"srl.json");
                label10.Text = File.ReadAllText(@"UB.json");

                label11.Text = File.ReadAllText(@"auto.json");
                label23.Text = File.ReadAllText(@"rev.json");

                label12.Text = File.ReadAllText(@"frm.json");
                label13.Text = File.ReadAllText(@"pbrl.json");
                label14.Text = File.ReadAllText(@"slide.json");
                label15.Text = File.ReadAllText(@"trg.json");
                label16.Text = File.ReadAllText(@"pmzl.json");
                label17.Text = File.ReadAllText(@"rlM.json");
            }

            if (label1.Text == "label1")
            {
                label1.Text = " ";
            }

            if (label2.Text == "label2")
            {
                label2.Text = " ";
            }

            if (label3.Text == "label3")
            {
                label3.Text = " ";
            }

            if (label4.Text == "label4")
            {
                label4.Text = " ";
            }

            if (label5.Text == "label5")
            {
                label5.Text = " ";
            }

            if (label6.Text == "label6")
            {
                label6.Text = " ";
            }

            if (label7.Text == "label7")
            {
                label7.Text = " ";
            }

            if (label8.Text == "label8")
            {
                label8.Text = " ";
            }

            if (label9.Text == "label9")
            {
                label9.Text = " ";
            }

            if (label10.Text == "label10")
            {
                label10.Text = " ";
            }

            if (label11.Text == "label11")
            {
                label11.Text = " ";
            }

            if (label12.Text == "label12")
            {
                label12.Text = " ";
            }

            if (label13.Text == "label13")
            {
                label13.Text = " ";
            }

            if (label14.Text == "label14")
            {
                label14.Text = " ";
            }

            if (label15.Text == "label15")
            {
                label15.Text = " ";
            }

            if (label16.Text == "label16")
            {
                label16.Text = " ";
            }

            if (label17.Text == "label17")
            {
                label17.Text = " ";
            }

            if (label18.Text == "label18")
            {
                label18.Text = " ";
            }

            if (label19.Text == "label19")
            {
                label19.Text = " ";
            }

            if (label20.Text == "label20")
            {
                label20.Text = " ";
            }

            if (label21.Text == "label21")
            {
                label21.Text = " ";
            }

            if (label22.Text == "label22")
            {
                label22.Text = " ";
            }

            if (label23.Text == "label23")
            {
                label23.Text = " ";
            }




        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            Classes.Weapons.AssaultRifles assaultRifles = new Classes.Weapons.AssaultRifles();
            assaultRifles.Name = Form2.SetValueForRifle;


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

            File.WriteAllText(@"AR.json", JsonConvert.SerializeObject(assaultRifles));

            File.WriteAllText(@"BR.json", JsonConvert.SerializeObject(battleRifles));
            using (StreamWriter file = File.CreateText(@"BR.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, battleRifles);
            }

            File.WriteAllText(@"SMG.json", JsonConvert.SerializeObject(sMGs));
            using (StreamWriter file = File.CreateText(@"SMG.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sMGs);
            }

            File.WriteAllText(@"LMG.json", JsonConvert.SerializeObject(lMGs));
            using (StreamWriter file = File.CreateText(@"LMG.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, lMGs);
            }

            File.WriteAllText(@"SG.json", JsonConvert.SerializeObject(shotguns));
            using (StreamWriter file = File.CreateText(@"SG.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, shotguns);
            }

            File.WriteAllText(@"SR.json", JsonConvert.SerializeObject(sniperRifles));
            using (StreamWriter file = File.CreateText(@"SR.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sniperRifles);
            }

            File.WriteAllText(@"brl.json", JsonConvert.SerializeObject(barrel));
            using (StreamWriter file = File.CreateText(@"brl.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, barrel);
            }

            File.WriteAllText(@"hg.json", JsonConvert.SerializeObject(handguard));
            using (StreamWriter file = File.CreateText(@"hg.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, handguard);
            }

            File.WriteAllText(@"RC.json", JsonConvert.SerializeObject(reciver));
            using (StreamWriter file = File.CreateText(@"RC.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, reciver);
            }

            File.WriteAllText(@"stk.json", JsonConvert.SerializeObject(stock));
            using (StreamWriter file = File.CreateText(@"stk.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, stock);
            }

            File.WriteAllText(@"TP.json", JsonConvert.SerializeObject(topPiece));
            using (StreamWriter file = File.CreateText(@"TP.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, topPiece);
            }

            File.WriteAllText(@"muz.json", JsonConvert.SerializeObject(muzzle));
            using (StreamWriter file = File.CreateText(@"muz.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, muzzle);
            }

            File.WriteAllText(@"opt.json", JsonConvert.SerializeObject(optic));
            using (StreamWriter file = File.CreateText(@"opt.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, optic);
            }

            File.WriteAllText(@"srl.json", JsonConvert.SerializeObject(sideRail));
            using (StreamWriter file = File.CreateText(@"srl.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sideRail);
            }

            File.WriteAllText(@"UB.json", JsonConvert.SerializeObject(underbarrel));
            using (StreamWriter file = File.CreateText(@"UB.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, underbarrel);
            }

            File.WriteAllText(@"auto.json", JsonConvert.SerializeObject(automatics));
            using (StreamWriter file = File.CreateText(@"auto.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, automatics);
            }

            File.WriteAllText(@"rev.json", JsonConvert.SerializeObject(revolvers));
            using (StreamWriter file = File.CreateText(@"rev.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, revolvers);
            }

            File.WriteAllText(@"frm.json", JsonConvert.SerializeObject(frame));
            using (StreamWriter file = File.CreateText(@"frm.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, frame);
            }

            File.WriteAllText(@"pbrl.json", JsonConvert.SerializeObject(pBarrel));
            using (StreamWriter file = File.CreateText(@"pbrl.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, pBarrel);
            }

            File.WriteAllText(@"slide.json", JsonConvert.SerializeObject(slide));
            using (StreamWriter file = File.CreateText(@"slide.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, slide);
            }

            File.WriteAllText(@"trg.json", JsonConvert.SerializeObject(trigger));
            using (StreamWriter file = File.CreateText(@"trg.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, trigger);
            }

            File.WriteAllText(@"pmzl.json", JsonConvert.SerializeObject(pMuzzle));
            using (StreamWriter file = File.CreateText(@"pmzl.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, pMuzzle);
            }

            File.WriteAllText(@"rlM.json", JsonConvert.SerializeObject(railmount));
            using (StreamWriter file = File.CreateText(@"rlM.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, railmount);
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
