using System;
using System.Collections.Generic;
using System.IO;

namespace Classes
{
    class Log
    {
        public static DateTime date = DateTime.Now;
        /// <summary>
        /// Grava o log com os dados informados
        /// </summary>
        /// <param name="ID_user"></param>
        /// <param name="antigo"></param>
        /// <param name="novo"></param>
        /// <param name="mensagem"></param>
        public static void GravarLog(string mensagem, string antigo =null, string novo = null)
        {
            int ID_user = Classes.NiveisAcesso.ID_Habilitado;
            
            string DateTime = date.Hour + "-" + date.Minute + "#" + date.Day + "/" + date.Month + "/" + date.Year;
            string mensagemGravar = ID_user + "$" + mensagem + ":" + antigo + " para " + novo + " em " + DateTime + "\r\n -----------------------\r\n";

            if (!File.Exists("log.txt"))
            {
                var file = File.CreateText("log.txt");
                file.Close();
            }

            File.AppendAllText("log.txt", mensagemGravar);
        }
        /// <summary>
        /// Le o arquivo log e retorna suas linhas
        /// </summary>
        /// <returns></returns>
        public static string[] LerLog()
        {
            string[] linhas = File.ReadAllLines("log.txt");
            string[] registros = new string[linhas.Length];
            int x = 0;
            foreach(string reg in linhas)
            {
                if (!reg.Contains("--------"))
                {
                    registros[x] = reg;
                    x++;
                }
            }
            return registros;
        }
    }
}
