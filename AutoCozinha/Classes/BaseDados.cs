using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class BaseDados
    {
        public static string local = "Filename=smartBoss.db";
        /// <summary>
        /// Faz a copia da base de dados para um novo local
        /// </summary>
        /// <param name="novoLocal"></param>
        /// <returns>Valor Booleano</returns>
        public bool CopiaBase(string novoLocal)
        {
            if (System.IO.File.Exists(local))
            {
                System.IO.File.Copy(local, novoLocal);
            }

            return System.IO.File.Exists(novoLocal) ? true : false;
        }
    }
}
