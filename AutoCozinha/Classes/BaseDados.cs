using System;
using System.Collections.Generic;
using System.IO;
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
        /// <summary>
        /// Verifica se existe a base de dados senão cria uma nova com um usuario padrão
        /// </summary>
        /// <returns></returns>
        public static bool ExisteBase()
        {
            if (!File.Exists("smartBoss.db")) {
                Usuario.GeraUserPadrao();
                CategoriaProduto.CategoriaPadrao();
                Log.GravarLog("Foi criada base de dados");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
