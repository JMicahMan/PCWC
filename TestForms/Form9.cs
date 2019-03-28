using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class Form9 : Form
    {

        public Form9()
        {

            InitializeComponent();

            Classes.Weapons.AssaultRifles assaultRifles = new Classes.Weapons.AssaultRifles();
            assaultRifles.Name.ToString();

            label1.Text = assaultRifles.Name;

            Classes.Weapons.BattleRifles battleRifles = new Classes.Weapons.BattleRifles();
            battleRifles.Name.ToString();

            label2.Text = battleRifles.Name;

            Classes.Weapons.SMGs sMGs = new Classes.Weapons.SMGs();
            sMGs.Name.ToString();

            label3.Text = sMGs.Name;

            Classes.Weapons.LMGs lMGs = new Classes.Weapons.LMGs();
            lMGs.Name.ToString();

            label4.Text = lMGs.Name;

            Classes.Weapons.Shotguns shotguns = new Classes.Weapons.Shotguns();
            shotguns.Name.ToString();

            label5.Text = shotguns.Name;

            Classes.Weapons.SniperRifles sniperRifles = new Classes.Weapons.SniperRifles();
            sniperRifles.Name.ToString();

            label6.Text = sniperRifles.Name;


            Classes.WeaponMods.Barrel barrel = new Classes.WeaponMods.Barrel();
            barrel.Name.ToString();

            label17.Text = barrel.Name;

            Classes.WeaponMods.Handguard handguard = new Classes.WeaponMods.Handguard();
            handguard.Name.ToString();

            label8.Text = handguard.Name;

            Classes.WeaponMods.Reciver reciver = new Classes.WeaponMods.Reciver();
            reciver.Name.ToString();

            label9.Text = reciver.Name;

            Classes.WeaponMods.Stock stock = new Classes.WeaponMods.Stock();
            stock.Name.ToString();

            label10.Text = stock.Name;

            Classes.WeaponMods.TopPiece topPiece = new Classes.WeaponMods.TopPiece();
            topPiece.Name.ToString();

            label11.Text = topPiece.Name;


            Classes.WeaponAttachments.Muzzle muzzle = new Classes.WeaponAttachments.Muzzle();
            muzzle.Name.ToString();

            label12.Text = muzzle.Name;

            Classes.WeaponAttachments.Optic optic = new Classes.WeaponAttachments.Optic();
            optic.Name.ToString();

            label13.Text = optic.Name;

            Classes.WeaponAttachments.SideRail sideRail = new Classes.WeaponAttachments.SideRail();
            sideRail.Name.ToString();

            label14.Text = sideRail.Name;

            Classes.WeaponAttachments.Underbarrel underbarrel = new Classes.WeaponAttachments.Underbarrel();
            underbarrel.Name.ToString();

            label15.Text = underbarrel.Name;


            Classes.Sidearms.Automatics automatics = new Classes.Sidearms.Automatics();
            automatics.Name.ToString();

            label16.Text = automatics.Name;

            Classes.Sidearms.Revolvers revolvers = new Classes.Sidearms.Revolvers();
            revolvers.Name.ToString();

            label17.Text = revolvers.Name;


            Classes.SideArmMods.Frame frame = new Classes.SideArmMods.Frame();
            frame.Name.ToString();

            label18.Text = frame.Name;

            Classes.SideArmMods.PBarrel pBarrel = new Classes.SideArmMods.PBarrel();
            pBarrel.Name.ToString();

            label19.Text = pBarrel.Name;

            Classes.SideArmMods.Slide slide = new Classes.SideArmMods.Slide();
            slide.Name.ToString();

            label20.Text = slide.Name;

            Classes.SideArmMods.Trigger trigger = new Classes.SideArmMods.Trigger();
            trigger.Name.ToString();

            label21.Text = trigger.Name;


            Classes.SideArmAttachments.PMuzzle pMuzzle = new Classes.SideArmAttachments.PMuzzle();
            pMuzzle.Name.ToString();

            label22.Text = pMuzzle.Name;

            Classes.SideArmAttachments.Railmount railmount = new Classes.SideArmAttachments.Railmount();
            railmount.Name.ToString();

            label23.Text = railmount.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
