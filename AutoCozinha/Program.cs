using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCozinha
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //INICIA A APLICAÇÃO COM A TELA DE LOGIN
            Classes.BaseDados.ExisteBase();
            Application.Run(new Telas.Login());
            if (!Classes.Usuario.login)
            {
                //CASO A FLAG NA CLASSE DE USUARIO SEJA FALSA NÃO ABRA
                Application.Exit();
            }
            else
            {
                Application.Run(new form_principal());
            }
        }
    }
}
