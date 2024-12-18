namespace GameTrainerUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.configsTab = new System.Windows.Forms.TabPage();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.guna2CheckBox14 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox13 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox12 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox11 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox10 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox9 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.playersTab = new System.Windows.Forms.TabPage();
            this.guna2CheckBox7 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.damageMultiplier = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.miscTab.SuspendLayout();
            this.playersTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // configsTab
            // 
            this.configsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.configsTab.Location = new System.Drawing.Point(184, 4);
            this.configsTab.Name = "configsTab";
            this.configsTab.Padding = new System.Windows.Forms.Padding(3);
            this.configsTab.Size = new System.Drawing.Size(622, 484);
            this.configsTab.TabIndex = 2;
            this.configsTab.Text = "⚙ Configs";
            this.configsTab.Click += new System.EventHandler(this.configsTab_Click);
            // 
            // miscTab
            // 
            this.miscTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.miscTab.Controls.Add(this.guna2CheckBox14);
            this.miscTab.Controls.Add(this.guna2CheckBox13);
            this.miscTab.Controls.Add(this.guna2CheckBox12);
            this.miscTab.Controls.Add(this.guna2CheckBox11);
            this.miscTab.Controls.Add(this.guna2CheckBox10);
            this.miscTab.Controls.Add(this.guna2CheckBox9);
            this.miscTab.Controls.Add(this.guna2TrackBar1);
            this.miscTab.Location = new System.Drawing.Point(184, 4);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(622, 484);
            this.miscTab.TabIndex = 1;
            this.miscTab.Text = "⿻ Misc";
            this.miscTab.Click += new System.EventHandler(this.miscTab_Click);
            // 
            // guna2CheckBox14
            // 
            this.guna2CheckBox14.AutoSize = true;
            this.guna2CheckBox14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox14.CheckedState.BorderRadius = 0;
            this.guna2CheckBox14.CheckedState.BorderThickness = 0;
            this.guna2CheckBox14.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox14.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox14.Location = new System.Drawing.Point(271, 286);
            this.guna2CheckBox14.Name = "guna2CheckBox14";
            this.guna2CheckBox14.Size = new System.Drawing.Size(170, 22);
            this.guna2CheckBox14.TabIndex = 8;
            this.guna2CheckBox14.Text = "📈 Number bullet fired";
            this.guna2CheckBox14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox14.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox14.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox14.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox14.CheckedChanged += new System.EventHandler(this.guna2CheckBox14_CheckedChanged);
            // 
            // guna2CheckBox13
            // 
            this.guna2CheckBox13.AutoSize = true;
            this.guna2CheckBox13.CheckedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.guna2CheckBox13.CheckedState.BorderRadius = 0;
            this.guna2CheckBox13.CheckedState.BorderThickness = 0;
            this.guna2CheckBox13.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox13.Location = new System.Drawing.Point(37, 286);
            this.guna2CheckBox13.Name = "guna2CheckBox13";
            this.guna2CheckBox13.Size = new System.Drawing.Size(112, 22);
            this.guna2CheckBox13.TabIndex = 7;
            this.guna2CheckBox13.Text = " 🍬Rapid Fire";
            this.guna2CheckBox13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox13.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox13.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox13.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox12
            // 
            this.guna2CheckBox12.AutoSize = true;
            this.guna2CheckBox12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox12.CheckedState.BorderRadius = 0;
            this.guna2CheckBox12.CheckedState.BorderThickness = 0;
            this.guna2CheckBox12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox12.Location = new System.Drawing.Point(271, 163);
            this.guna2CheckBox12.Name = "guna2CheckBox12";
            this.guna2CheckBox12.Size = new System.Drawing.Size(118, 22);
            this.guna2CheckBox12.TabIndex = 6;
            this.guna2CheckBox12.Text = "🎯 No Spread ";
            this.guna2CheckBox12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox12.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox12.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox11
            // 
            this.guna2CheckBox11.AutoSize = true;
            this.guna2CheckBox11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox11.CheckedState.BorderRadius = 0;
            this.guna2CheckBox11.CheckedState.BorderThickness = 0;
            this.guna2CheckBox11.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox11.Location = new System.Drawing.Point(271, 30);
            this.guna2CheckBox11.Name = "guna2CheckBox11";
            this.guna2CheckBox11.Size = new System.Drawing.Size(105, 22);
            this.guna2CheckBox11.TabIndex = 5;
            this.guna2CheckBox11.Text = "✴ No recoil";
            this.guna2CheckBox11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox11.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox11.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox10
            // 
            this.guna2CheckBox10.AutoSize = true;
            this.guna2CheckBox10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox10.CheckedState.BorderRadius = 0;
            this.guna2CheckBox10.CheckedState.BorderThickness = 0;
            this.guna2CheckBox10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox10.Location = new System.Drawing.Point(37, 163);
            this.guna2CheckBox10.Name = "guna2CheckBox10";
            this.guna2CheckBox10.Size = new System.Drawing.Size(109, 22);
            this.guna2CheckBox10.TabIndex = 4;
            this.guna2CheckBox10.Text = "💧 Lock Ammo";
            this.guna2CheckBox10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox10.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox10.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox10.CheckedChanged += new System.EventHandler(this.guna2CheckBox10_CheckedChanged);
            // 
            // guna2CheckBox9
            // 
            this.guna2CheckBox9.AutoSize = true;
            this.guna2CheckBox9.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.guna2CheckBox9.CheckedState.BorderRadius = 0;
            this.guna2CheckBox9.CheckedState.BorderThickness = 0;
            this.guna2CheckBox9.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2CheckBox9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox9.Location = new System.Drawing.Point(40, 30);
            this.guna2CheckBox9.Name = "guna2CheckBox9";
            this.guna2CheckBox9.Size = new System.Drawing.Size(112, 22);
            this.guna2CheckBox9.TabIndex = 3;
            this.guna2CheckBox9.Text = "🔫 Ammo Inf ";
            this.guna2CheckBox9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox9.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox9.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox9.CheckedChanged += new System.EventHandler(this.guna2CheckBox9_CheckedChanged);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(40, 314);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(160, 33);
            this.guna2TrackBar1.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.guna2TrackBar1.TabIndex = 2;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // playersTab
            // 
            this.playersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.playersTab.Controls.Add(this.guna2CheckBox7);
            this.playersTab.Controls.Add(this.guna2CheckBox6);
            this.playersTab.Controls.Add(this.guna2CheckBox5);
            this.playersTab.Controls.Add(this.guna2CheckBox4);
            this.playersTab.Controls.Add(this.guna2CheckBox3);
            this.playersTab.Controls.Add(this.guna2CheckBox2);
            this.playersTab.Controls.Add(this.guna2CheckBox1);
            this.playersTab.Controls.Add(this.damageMultiplier);
            this.playersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersTab.Location = new System.Drawing.Point(184, 4);
            this.playersTab.Name = "playersTab";
            this.playersTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersTab.Size = new System.Drawing.Size(622, 484);
            this.playersTab.TabIndex = 0;
            this.playersTab.Text = "♘ Players";
            this.playersTab.Click += new System.EventHandler(this.playersTab_Click);
            // 
            // guna2CheckBox7
            // 
            this.guna2CheckBox7.AutoSize = true;
            this.guna2CheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox7.CheckedState.BorderRadius = 0;
            this.guna2CheckBox7.CheckedState.BorderThickness = 0;
            this.guna2CheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox7.Location = new System.Drawing.Point(310, 318);
            this.guna2CheckBox7.Name = "guna2CheckBox7";
            this.guna2CheckBox7.Size = new System.Drawing.Size(99, 22);
            this.guna2CheckBox7.TabIndex = 8;
            this.guna2CheckBox7.Text = "⚔ Damage ";
            this.guna2CheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox7.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox7.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox7.CheckedChanged += new System.EventHandler(this.guna2CheckBox7_CheckedChanged);
            // 
            // guna2CheckBox6
            // 
            this.guna2CheckBox6.AutoSize = true;
            this.guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.CheckedState.BorderRadius = 0;
            this.guna2CheckBox6.CheckedState.BorderThickness = 0;
            this.guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox6.Location = new System.Drawing.Point(310, 231);
            this.guna2CheckBox6.Name = "guna2CheckBox6";
            this.guna2CheckBox6.Size = new System.Drawing.Size(162, 22);
            this.guna2CheckBox6.TabIndex = 7;
            this.guna2CheckBox6.Text = "♾️ NoCdSwitchPlayer";
            this.guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox6.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox6.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox5
            // 
            this.guna2CheckBox5.AutoSize = true;
            this.guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.CheckedState.BorderRadius = 0;
            this.guna2CheckBox5.CheckedState.BorderThickness = 0;
            this.guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2CheckBox5.Location = new System.Drawing.Point(310, 147);
            this.guna2CheckBox5.Name = "guna2CheckBox5";
            this.guna2CheckBox5.Size = new System.Drawing.Size(87, 22);
            this.guna2CheckBox5.TabIndex = 6;
            this.guna2CheckBox5.Text = "♨ Speed";
            this.guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox5.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox5.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox4
            // 
            this.guna2CheckBox4.AutoSize = true;
            this.guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.CheckedState.BorderRadius = 0;
            this.guna2CheckBox4.CheckedState.BorderThickness = 0;
            this.guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox4.Location = new System.Drawing.Point(21, 321);
            this.guna2CheckBox4.Name = "guna2CheckBox4";
            this.guna2CheckBox4.Size = new System.Drawing.Size(87, 22);
            this.guna2CheckBox4.TabIndex = 5;
            this.guna2CheckBox4.Text = "⇯ Stamina";
            this.guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox4.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox4.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox4.CheckedChanged += new System.EventHandler(this.guna2CheckBox4_CheckedChanged);
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.CheckedState.BorderRadius = 0;
            this.guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2CheckBox3.Location = new System.Drawing.Point(21, 231);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(155, 22);
            this.guna2CheckBox3.TabIndex = 4;
            this.guna2CheckBox3.Text = "🜍 Unlimited Ult. Skill";
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox3.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2CheckBox2.Location = new System.Drawing.Point(21, 45);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(74, 22);
            this.guna2CheckBox2.TabIndex = 3;
            this.guna2CheckBox2.Text = "❤ Life";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.guna2CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CheckBox1.Location = new System.Drawing.Point(21, 147);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(177, 22);
            this.guna2CheckBox1.TabIndex = 2;
            this.guna2CheckBox1.Text = "⚡Unlimited Stand. Skill";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // damageMultiplier
            // 
            this.damageMultiplier.Location = new System.Drawing.Point(310, 346);
            this.damageMultiplier.Name = "damageMultiplier";
            this.damageMultiplier.Size = new System.Drawing.Size(171, 20);
            this.damageMultiplier.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.damageMultiplier.TabIndex = 1;
            this.damageMultiplier.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.damageMultiplier.Scroll += new System.Windows.Forms.ScrollEventHandler(this.damageMultiplier_Scroll);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.playersTab);
            this.tabControl.Controls.Add(this.miscTab);
            this.tabControl.Controls.Add(this.configsTab);
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(-3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(810, 492);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(807, 496);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "SMUNK_YT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.miscTab.ResumeLayout(false);
            this.miscTab.PerformLayout();
            this.playersTab.ResumeLayout(false);
            this.playersTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabPage configsTab;
        private System.Windows.Forms.TabPage miscTab;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.TabPage playersTab;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TrackBar damageMultiplier;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox9;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox7;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox6;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox5;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox4;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox10;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox12;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox11;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox14;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox13;
    }
}
