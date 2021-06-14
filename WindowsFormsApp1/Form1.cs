using System.Windows.Forms;
using PD2RandomizerData;
using System.IO;
using System;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string SaveFile = "Sav.Ree";

        private bool Empty_Selection 
        { 
            get
            {
                if (cbPerkDeck.Checked &&
                    cbPrimary.Checked &&
                    cbSecondary.Checked &&
                    cbMelee.Checked &&
                    cbArmor.Checked &&
                    cbThrowable.Checked &&
                    cbDeployable.Checked &&
                    cbDiff.Checked)
                    return true;
                else
                    return false;
            } 
        }

        public Form1()
        {
            InitializeComponent();
            Get_SaveBits();

            cbPerkDeck.Checked = true;
            cbGsg.Checked = Random_Settings.GrinderSafeGuard;
            cbHmsg.Checked = Random_Settings.HitmanSafeGuard;
        }

        private void BtnRandom_Click(object sender, EventArgs e) => Randomize();
        private void BtnSave_Click(object sender, EventArgs e) => SaveRandom();
        private void BtnLoad_Click(object sender, EventArgs e) => LoadRandom();

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            Random_Settings.Hitman_SafeGuard = cbHmsg.Checked;
            Random_Settings.Grinder_SafeGuard = cbGsg.Checked;
            Random_Settings.Allow_OneDown = CBOneDown.Checked;
            MessageBox.Show("Updated SafeGuards!");
        }

        private void Randomize()
        {
            PD2Randomize.SetAll();
            string[] disp;
            if (Empty_Selection)
            {
                disp = new string[] {
                    "Deck: " + Random_Settings.Current_Deck,
                    "Primary: " + Random_Settings.PrimaryCat,
                    "Secondary: " + Random_Settings.SecondaryCat,
                    "Melee: " + Random_Settings.MeleeCat,
                    "Armor: " + Random_Settings.ArmorLv,
                    "Throwable: "+Random_Settings.Throwable,
                    "Deployable: "+Random_Settings.Deployable,
                    "Difficulty: "+Random_Settings.Difficulty
                };
            }
            else
            {
                disp = new string[8];
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
                if (cbDiff.Checked)
                    disp[7] = "Difficulty: " + Random_Settings.Difficulty;
            }
            SetDisplay(disp);
            Set_SaveBits();
        }

        private void Set_SaveBits()
        {
            string output = null;
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i] is Panel panel)
                    for (int x = 0; x < panel.Controls.Count; x++)
                        if (panel.Controls[x] is CheckBox check)
                            if (check.Checked)
                                output += 1;
                            else
                                output += 0;
            File.WriteAllText("bits.Ree", output);
        }

        private void Get_SaveBits()
        {
            if (!File.Exists("bits.Ree"))
                return;
            string bits = File.ReadAllText("bits.Ree");
            int[] Bit = new int[bits.Length];
            if (Bit.Length == 0)
                return;

            int index = 0;
            for (int i = 0; i < bits.Length; i++)
                Bit[i] = int.Parse(bits[i].ToString());
            for(int i = 0; i < Controls.Count; i++)
                if(Controls[i] is Panel panel)
                    for(int x = 0; x < panel.Controls.Count; x++)
                        if(panel.Controls[x] is CheckBox cb)
                        {
                            cb.Checked = Convert.ToBoolean(Bit[index]);
                            index++;
                        }
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
                    "Deployable: "+Random_Settings.Deployable,
                    "Difficulty: "+Random_Settings.Difficulty
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
            cbGsg.Checked = Random_Settings.Grinder_SafeGuard;
            cbHmsg.Checked = Random_Settings.Hitman_SafeGuard;
            CBOneDown.Checked = Random_Settings.Allow_OneDown;
        }
    }
}
