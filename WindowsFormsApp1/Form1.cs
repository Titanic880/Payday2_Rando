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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void BtnReRand_Click(object sender, EventArgs e)
        {
            Randomize();
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadRandom();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveRandom();
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            PD2DataFile.SetHitmanSafe(cbHmsg.Checked);
            PD2DataFile.SetGrinderSafe(cbGsg.Checked);
            MessageBox.Show("Updated SafeGuards!");
        }

        private void Randomize()
        {
            PD2DataFile.SetAll();
            string[] disp = null;
            if (cbPerkDeck.Checked &&
                cbPrimary.Checked &&
                cbSecondary.Checked &&
                cbMelee.Checked &&
                cbArmor.Checked &&
                cbThrowable.Checked &&
                cbDeployable.Checked)
            {
                disp = new string[] {
                    "Deck: " + PD2DataFile.Current_Deck,
                    "Primary: " + PD2DataFile.PrimaryCat,
                    "Secondary: " + PD2DataFile.SecondaryCat,
                    "Melee: " + PD2DataFile.MeleeCat,
                    "Armor: " + PD2DataFile.ArmorLv,
                    "Throwable: "+PD2DataFile.Throwable,
                    "Deployable: "+PD2DataFile.Deployable
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
                    disp[0] = "Deck: " + PD2DataFile.Current_Deck;
                if (cbPrimary.Checked)
                    disp[1] = "Primary: " + PD2DataFile.PrimaryCat;
                if (cbSecondary.Checked)
                    disp[2] = "Secondary: " + PD2DataFile.SecondaryCat;
                if (cbMelee.Checked)
                    disp[3] = "Melee: " + PD2DataFile.MeleeCat;
                if (cbArmor.Checked)
                    disp[4] = "Armor: " + PD2DataFile.ArmorLv;
                if (cbThrowable.Checked)
                    disp[5] = "Throwable: " + PD2DataFile.Throwable;
                if (cbDeployable.Checked)
                    disp[6] = "Deployable: " + PD2DataFile.Deployable;
            }

            SetDisplay(disp);
        }

        /// <summary>
        /// Sets the string[] to the list
        /// </summary>
        /// <param name="Display"></param>
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
                    "Deck: " + PD2DataFile.Current_Deck,
                    "Primary: " + PD2DataFile.PrimaryCat,
                    "Secondary: " + PD2DataFile.SecondaryCat,
                    "Melee: " + PD2DataFile.MeleeCat,
                    "Armor: " + PD2DataFile.ArmorLv,
                    "Throwable: "+PD2DataFile.Throwable,
                    "Deployable: "+PD2DataFile.Deployable
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
            cbGsg.Checked = PD2DataFile.GrinderSafeGuard;
            cbHmsg.Checked = PD2DataFile.HitmanSafeGuard;
        }
    }
}
