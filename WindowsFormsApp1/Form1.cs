using System;
using System.IO;
using PD2RandomizerData;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string SaveFile = "Sav.Ree";
        public Form1()
        {
            InitializeComponent();
            SetCBs();
        }

        private void BtnRandom_Click(object sender, EventArgs e) => Randomize();
        private void BtnSave_Click(object sender, EventArgs e) => SaveRandom();
        private void BtnLoad_Click(object sender, EventArgs e) => LoadRandom();

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            Random_Settings.HitmanSafeGuard = cbHmsg.Checked;
            Random_Settings.GrinderSafeGuard = cbGsg.Checked;
            MessageBox.Show("Updated SafeGuards!");
        }

        private void Randomize()
        {
            PD2Randomize.SetAll();
            string[] disp;
            if (cbPerkDeck.Checked &&
                cbPrimary.Checked &&
                cbSecondary.Checked &&
                cbMelee.Checked &&
                cbArmor.Checked &&
                cbThrowable.Checked &&
                cbDeployable.Checked)
            {
                disp = new string[] {
                    "Deck: " + Random_Settings.Current_Deck,
                    "Primary: " + Random_Settings.PrimaryCat,
                    "Secondary: " + Random_Settings.SecondaryCat,
                    "Melee: " + Random_Settings.MeleeCat,
                    "Armor: " + Random_Settings.ArmorLv,
                    "Throwable: "+Random_Settings.Throwable,
                    "Deployable: "+Random_Settings.Deployable
                };
            }
            else
            {
                if (!cbPerkDeck.Checked &&
                    !cbPrimary.Checked &&
                    !cbSecondary.Checked &&
                    !cbMelee.Checked &&
                    !cbArmor.Checked &&
                    !cbThrowable.Checked &&
                    !cbDeployable.Checked)
                {
                    MessageBox.Show("Please Select a Category!");
                    return;
                }
                    disp = new string[7];
                if (cbPerkDeck.Checked)
                    disp[0] = "Deck: " + Random_Settings.Current_Deck;
                if (cbPrimary.Checked)
                    disp[1] = "Primary: " + Random_Settings.PrimaryCat;
                if (cbSecondary.Checked)
                    disp[2] = "Secondary: " + Random_Settings.SecondaryCat;
                if (cbMelee.Checked)
                    disp[3] = "Melee: " + Random_Settings.MeleeCat;
                if (cbArmor.Checked)
                    disp[4] = "Armor: " + Random_Settings.ArmorLv;
                if (cbThrowable.Checked)
                    disp[5] = "Throwable: " + Random_Settings.Throwable;
                if (cbDeployable.Checked)
                    disp[6] = "Deployable: " + Random_Settings.Deployable;
            }

            SetDisplay(disp);
        }

        private void SetDisplay(string[] Display)
        {
            listBox1.Items.Clear();
            foreach (string a in Display)
                if (a != null)
                    listBox1.Items.Add(a);
        }

        private void SaveRandom()
        {
            if (File.Exists(SaveFile))
                File.Delete(SaveFile);

            File.Create(SaveFile).Close();
            string[] info = {
                    "Deck: " + Random_Settings.Current_Deck,
                    "Primary: " + Random_Settings.PrimaryCat,
                    "Secondary: " + Random_Settings.SecondaryCat,
                    "Melee: " + Random_Settings.MeleeCat,
                    "Armor: " + Random_Settings.ArmorLv,
                    "Throwable: "+Random_Settings.Throwable,
                    "Deployable: "+Random_Settings.Deployable
                };
            StreamWriter sw = new StreamWriter(SaveFile);
            foreach (string a in info)
                sw.WriteLine(a);
            sw.Close();
            MessageBox.Show("Saved Config");
        }

        private void LoadRandom()
        {
            listBox1.Items.Clear();
            if (!File.Exists(SaveFile))
            {
                File.Create(SaveFile).Close();
                MessageBox.Show("File was Empty!");
                return;
            }

            StreamReader sr = new StreamReader(SaveFile);
            while (!sr.EndOfStream)
                listBox1.Items.Add(sr.ReadLine());
            sr.Close();
            MessageBox.Show("Loaded Config!");
        }

        private void SetCBs()
        {
            cbPerkDeck.Checked = true;
            cbGsg.Checked = Random_Settings.GrinderSafeGuard;
            cbHmsg.Checked = Random_Settings.HitmanSafeGuard;
        }
    }
}
