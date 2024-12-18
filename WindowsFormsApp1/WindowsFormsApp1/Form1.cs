using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices; // Necessário para DllImport


namespace GameTrainerUI

{

    public partial class Form1 : Form
    {

        // Definindo as funções externas para acesso ao Windows API
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        const uint PROCESS_VM_READ = 0x0010; // Permissão de leitura de memória

        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Configurações do Form
            this.Text = "SMUNK_YT";
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 36);
            this.ClientSize = new System.Drawing.Size(800, 500);  // Aumentar o tamanho do formulário


            // Adicionar uma borda de sombra (com Guna2ShadowForm)
            Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
            shadowForm.SetShadowForm(this);

            // Desabilita redimencionamento
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Menu Lateral
            Guna2Panel sidePanel = new Guna2Panel();
            sidePanel.Size = new System.Drawing.Size(150, this.ClientSize.Height);
            sidePanel.Location = new System.Drawing.Point(0, 0);
            sidePanel.FillColor = System.Drawing.Color.FromArgb(25, 25, 60);
            this.Controls.Add(sidePanel);

            // Guna2TabControl
            Guna2TabControl tabControl = new Guna2TabControl();
            tabControl.Size = new System.Drawing.Size(800, 500);  // Ajuste no tamanho do TabControl
            tabControl.Location = new System.Drawing.Point(160, 20);
            tabControl.ItemSize = new System.Drawing.Size(200, 40);
            tabControl.SelectedIndexChanged += (sender, e) =>
            {
                // Ação ao mudar de aba, se necessário
            };
            tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(35, 35, 50); // Cor quando passar o mouse
            tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(25, 25, 60); // Cor da aba selecionada
            tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(18, 18, 36); // Cor das abas inativas
            tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent; // Remover borda das abas inativas
            tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent; // Remover borda da aba selecionada
            this.Controls.Add(tabControl);

            // Aba "Players"
            TabPage playersTab = new TabPage("Players");
            playersTab.BackColor = System.Drawing.Color.FromArgb(25, 25, 60); // Cor de fundo da aba
            tabControl.Controls.Add(playersTab);

            // Aba "Misc"
            TabPage miscTab = new TabPage("Misc");
            miscTab.BackColor = System.Drawing.Color.FromArgb(25, 25, 60); // Cor de fundo da aba
            tabControl.Controls.Add(miscTab);

            // Aba "Configs"
            TabPage configsTab = new TabPage("Configs");
            configsTab.BackColor = System.Drawing.Color.FromArgb(25, 25, 60); // Cor de fundo da aba
            tabControl.Controls.Add(configsTab);

            // Adicionar controles para cada aba (exemplo de funcionalidades)
            AddPlayerTabControls(playersTab);
            AddMiscTabControls(miscTab);
            AddConfigsTabControls(configsTab);
        }

        // Função para adicionar controles na aba "Players"
        private void AddPlayerTabControls(TabPage tabPage)
        {
            Guna2CheckBox infinityHealth = new Guna2CheckBox
            {
                Text = "Infinity Health",
                Location = new System.Drawing.Point(10, 30),
                ForeColor = System.Drawing.Color.White
            };
            tabPage.Controls.Add(infinityHealth);

            Guna2TrackBar damageMultiplier = new Guna2TrackBar
            {
                Location = new System.Drawing.Point(10, 70),
                Size = new System.Drawing.Size(200, 23),
                ThumbColor = System.Drawing.Color.DodgerBlue
            };
            tabPage.Controls.Add(damageMultiplier);

            // Adicionar mais controles conforme necessário...
        }

        // Função para adicionar controles na aba "Misc"
        private void AddMiscTabControls(TabPage tabPage)
        {
            Guna2CheckBox noCooldownSkills = new Guna2CheckBox
            {
                Text = "No Cooldown Skills",
                Location = new System.Drawing.Point(10, 30),
                ForeColor = System.Drawing.Color.White
            };
            tabPage.Controls.Add(noCooldownSkills);

            Guna2CheckBox chargeSkillsInstantly = new Guna2CheckBox
            {
                Text = "Charge Skills Instantly",
                Location = new System.Drawing.Point(10, 70),
                ForeColor = System.Drawing.Color.White
            };
            tabPage.Controls.Add(chargeSkillsInstantly);
        }

        // Função para adicionar controles na aba "Configs"
        private void AddConfigsTabControls(TabPage tabPage)
        {
            Guna2CheckBox instantCharacterSwitch = new Guna2CheckBox
            {
                Text = "Instant Character Switch",
                Location = new System.Drawing.Point(10, 30),
                ForeColor = System.Drawing.Color.White
            };
            tabPage.Controls.Add(instantCharacterSwitch);

            Guna2CheckBox critRate100 = new Guna2CheckBox
            {
                Text = "100% Crit Rate",
                Location = new System.Drawing.Point(10, 70),
                ForeColor = System.Drawing.Color.White
            };
            tabPage.Controls.Add(critRate100);
        }




        // Função para leitura de memória
        static byte[] ReadMemory(IntPtr processHandle, IntPtr baseAddress, uint bufferSize)
        {
            byte[] buffer = new byte[bufferSize];
            uint bytesRead;

            bool success = ReadProcessMemory(processHandle, baseAddress, buffer, bufferSize, out bytesRead);
            if (!success || bytesRead != bufferSize)
            {
                Console.WriteLine("[-] ERROR: Failed to read {0} bytes from 0x{1:X}. ReadProcessMemory failed.", bufferSize, baseAddress);
                return null;
            }

            return buffer;
        }

        // Exemplo de uso da leitura de memória
        private void Form1_Load(object sender, EventArgs e)
        {
            uint processId = 0000; // Substitua pelo PID real do processo
            IntPtr baseAddress = (IntPtr)0xDEADBEEF; // Substitua pelo endereço real
            uint bufferSize = 100; // O tamanho do buffer a ser lido



            // Abrindo o processo
            IntPtr processHandle = OpenProcess(PROCESS_VM_READ, false, processId);
            if (processHandle == IntPtr.Zero)
            {
                MessageBox.Show("Couldn't open process.");
                return;
            }

            // Lendo a memória
            byte[] memoryData = ReadMemory(processHandle, baseAddress, bufferSize);
            if (memoryData != null)
            {
                Console.WriteLine("Read memory data: " + BitConverter.ToString(memoryData));
            }

        }


        private void playersTab_Click(object sender, EventArgs e)
        {

        }

        private void chargeSkillsInstantly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void configsTab_Click(object sender, EventArgs e)
        {

        }

        private void infinityHealth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void damageMultiplier_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void noCooldownSkills_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void instantCharacterSwitch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void miscTab_Click(object sender, EventArgs e)
        {

        }

        private void critRate100_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
