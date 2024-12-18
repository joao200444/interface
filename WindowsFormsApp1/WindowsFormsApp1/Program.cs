using System;
using System.Windows.Forms;

namespace GameTrainerUI
{
    static class Program
    {
        // Ponto de entrada principal para o aplicativo.
        [STAThread]
        static void Main()
        {
            // Configurações para melhorar o desempenho e aparência do Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia o formulário principal
            Application.Run(new Form1());
        } 
    }
}
