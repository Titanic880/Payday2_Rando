
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbPerkDeck = new System.Windows.Forms.CheckBox();
            this.cbPrimary = new System.Windows.Forms.CheckBox();
            this.cbSecondary = new System.Windows.Forms.CheckBox();
            this.cbMelee = new System.Windows.Forms.CheckBox();
            this.cbArmor = new System.Windows.Forms.CheckBox();
            this.PanChecks = new System.Windows.Forms.Panel();
            this.cbDiff = new System.Windows.Forms.CheckBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblPanRand = new System.Windows.Forms.Label();
            this.cbDeployable = new System.Windows.Forms.CheckBox();
            this.cbThrowable = new System.Windows.Forms.CheckBox();
            this.PanOutput = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.PanOptions = new System.Windows.Forms.Panel();
            this.CBOneDown = new System.Windows.Forms.CheckBox();
            this.cbGsg = new System.Windows.Forms.CheckBox();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHmsg = new System.Windows.Forms.CheckBox();
            this.PanChecks.SuspendLayout();
            this.PanOutput.SuspendLayout();
            this.PanOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 160);
            this.listBox1.TabIndex = 0;
            // 
            // cbPerkDeck
            // 
            this.cbPerkDeck.AutoSize = true;
            this.cbPerkDeck.Location = new System.Drawing.Point(3, 22);
            this.cbPerkDeck.Name = "cbPerkDeck";
            this.cbPerkDeck.Size = new System.Drawing.Size(77, 17);
            this.cbPerkDeck.TabIndex = 1;
            this.cbPerkDeck.Text = "Perk Deck";
            this.cbPerkDeck.UseVisualStyleBackColor = true;
            // 
            // cbPrimary
            // 
            this.cbPrimary.AutoSize = true;
            this.cbPrimary.Location = new System.Drawing.Point(3, 45);
            this.cbPrimary.Name = "cbPrimary";
            this.cbPrimary.Size = new System.Drawing.Size(104, 17);
            this.cbPrimary.TabIndex = 2;
            this.cbPrimary.Text = "Primary Weapon";
            this.cbPrimary.UseVisualStyleBackColor = true;
            // 
            // cbSecondary
            // 
            this.cbSecondary.AutoSize = true;
            this.cbSecondary.Location = new System.Drawing.Point(3, 68);
            this.cbSecondary.Name = "cbSecondary";
            this.cbSecondary.Size = new System.Drawing.Size(121, 17);
            this.cbSecondary.TabIndex = 3;
            this.cbSecondary.Text = "Secondary Weapon";
            this.cbSecondary.UseVisualStyleBackColor = true;
            // 
            // cbMelee
            // 
            this.cbMelee.AutoSize = true;
            this.cbMelee.Location = new System.Drawing.Point(3, 91);
            this.cbMelee.Name = "cbMelee";
            this.cbMelee.Size = new System.Drawing.Size(99, 17);
            this.cbMelee.TabIndex = 4;
            this.cbMelee.Text = "Melee Weapon";
            this.cbMelee.UseVisualStyleBackColor = true;
            // 
            // cbArmor
            // 
            this.cbArmor.AutoSize = true;
            this.cbArmor.Location = new System.Drawing.Point(3, 114);
            this.cbArmor.Name = "cbArmor";
            this.cbArmor.Size = new System.Drawing.Size(53, 17);
            this.cbArmor.TabIndex = 5;
            this.cbArmor.Text = "Armor";
            this.cbArmor.UseVisualStyleBackColor = true;
            // 
            // PanChecks
            // 
            this.PanChecks.Controls.Add(this.cbDiff);
            this.PanChecks.Controls.Add(this.btnRandom);
            this.PanChecks.Controls.Add(this.lblPanRand);
            this.PanChecks.Controls.Add(this.cbDeployable);
            this.PanChecks.Controls.Add(this.cbThrowable);
            this.PanChecks.Controls.Add(this.cbMelee);
            this.PanChecks.Controls.Add(this.cbArmor);
            this.PanChecks.Controls.Add(this.cbPerkDeck);
            this.PanChecks.Controls.Add(this.cbPrimary);
            this.PanChecks.Controls.Add(this.cbSecondary);
            this.PanChecks.Location = new System.Drawing.Point(12, 12);
            this.PanChecks.Name = "PanChecks";
            this.PanChecks.Size = new System.Drawing.Size(127, 225);
            this.PanChecks.TabIndex = 6;
            // 
            // cbDiff
            // 
            this.cbDiff.AutoSize = true;
            this.cbDiff.Location = new System.Drawing.Point(3, 183);
            this.cbDiff.Name = "cbDiff";
            this.cbDiff.Size = new System.Drawing.Size(66, 17);
            this.cbDiff.TabIndex = 11;
            this.cbDiff.Text = "Difficulty";
            this.cbDiff.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(3, 199);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(120, 23);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Randomize!";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // lblPanRand
            // 
            this.lblPanRand.AutoSize = true;
            this.lblPanRand.Location = new System.Drawing.Point(4, 6);
            this.lblPanRand.Name = "lblPanRand";
            this.lblPanRand.Size = new System.Drawing.Size(60, 13);
            this.lblPanRand.TabIndex = 9;
            this.lblPanRand.Text = "Randomize";
            // 
            // cbDeployable
            // 
            this.cbDeployable.AutoSize = true;
            this.cbDeployable.Location = new System.Drawing.Point(3, 160);
            this.cbDeployable.Name = "cbDeployable";
            this.cbDeployable.Size = new System.Drawing.Size(79, 17);
            this.cbDeployable.TabIndex = 7;
            this.cbDeployable.Text = "Deployable";
            this.cbDeployable.UseVisualStyleBackColor = true;
            // 
            // cbThrowable
            // 
            this.cbThrowable.AutoSize = true;
            this.cbThrowable.Location = new System.Drawing.Point(3, 137);
            this.cbThrowable.Name = "cbThrowable";
            this.cbThrowable.Size = new System.Drawing.Size(76, 17);
            this.cbThrowable.TabIndex = 6;
            this.cbThrowable.Text = "Throwable";
            this.cbThrowable.UseVisualStyleBackColor = true;
            // 
            // PanOutput
            // 
            this.PanOutput.Controls.Add(this.BtnSave);
            this.PanOutput.Controls.Add(this.BtnLoad);
            this.PanOutput.Controls.Add(this.listBox1);
            this.PanOutput.Location = new System.Drawing.Point(145, 12);
            this.PanOutput.Name = "PanOutput";
            this.PanOutput.Size = new System.Drawing.Size(240, 225);
            this.PanOutput.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(0, 164);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 54);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save Random";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(139, 164);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(101, 54);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "Load Random";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // PanOptions
            // 
            this.PanOptions.Controls.Add(this.CBOneDown);
            this.PanOptions.Controls.Add(this.cbGsg);
            this.PanOptions.Controls.Add(this.BtnOptions);
            this.PanOptions.Controls.Add(this.label2);
            this.PanOptions.Controls.Add(this.cbHmsg);
            this.PanOptions.Location = new System.Drawing.Point(391, 13);
            this.PanOptions.Name = "PanOptions";
            this.PanOptions.Size = new System.Drawing.Size(122, 109);
            this.PanOptions.TabIndex = 8;
            // 
            // CBOneDown
            // 
            this.CBOneDown.AutoSize = true;
            this.CBOneDown.Location = new System.Drawing.Point(6, 57);
            this.CBOneDown.Name = "CBOneDown";
            this.CBOneDown.Size = new System.Drawing.Size(111, 17);
            this.CBOneDown.TabIndex = 70;
            this.CBOneDown.Text = "Allow One Down?";
            this.CBOneDown.UseVisualStyleBackColor = true;
            // 
            // cbGsg
            // 
            this.cbGsg.AutoSize = true;
            this.cbGsg.Location = new System.Drawing.Point(6, 39);
            this.cbGsg.Name = "cbGsg";
            this.cbGsg.Size = new System.Drawing.Size(112, 17);
            this.cbGsg.TabIndex = 1;
            this.cbGsg.Text = "Grinder Safeguard";
            this.cbGsg.UseVisualStyleBackColor = true;
            // 
            // BtnOptions
            // 
            this.BtnOptions.Location = new System.Drawing.Point(3, 80);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(114, 23);
            this.BtnOptions.TabIndex = 69;
            this.BtnOptions.Text = "Apply Options";
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Options";
            // 
            // cbHmsg
            // 
            this.cbHmsg.AutoSize = true;
            this.cbHmsg.Location = new System.Drawing.Point(6, 21);
            this.cbHmsg.Name = "cbHmsg";
            this.cbHmsg.Size = new System.Drawing.Size(111, 17);
            this.cbHmsg.TabIndex = 0;
            this.cbHmsg.Text = "Hitman Safeguard";
            this.cbHmsg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 243);
            this.Controls.Add(this.PanOptions);
            this.Controls.Add(this.PanOutput);
            this.Controls.Add(this.PanChecks);
            this.Name = "Form1";
            this.Text = "Payday 2 Randomizer";
            this.PanChecks.ResumeLayout(false);
            this.PanChecks.PerformLayout();
            this.PanOutput.ResumeLayout(false);
            this.PanOptions.ResumeLayout(false);
            this.PanOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cbPerkDeck;
        private System.Windows.Forms.CheckBox cbPrimary;
        private System.Windows.Forms.CheckBox cbSecondary;
        private System.Windows.Forms.CheckBox cbMelee;
        private System.Windows.Forms.CheckBox cbArmor;
        private System.Windows.Forms.Panel PanChecks;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblPanRand;
        private System.Windows.Forms.CheckBox cbDeployable;
        private System.Windows.Forms.CheckBox cbThrowable;
        private System.Windows.Forms.Panel PanOutput;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Panel PanOptions;
        private System.Windows.Forms.Button BtnOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbHmsg;
        private System.Windows.Forms.CheckBox cbGsg;
        private System.Windows.Forms.CheckBox CBOneDown;
        private System.Windows.Forms.CheckBox cbDiff;
    }
}

