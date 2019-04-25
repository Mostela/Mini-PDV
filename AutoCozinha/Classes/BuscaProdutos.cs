using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class BuscaProdutos : Estoque
    {
        public int id { get; set; }
        public string modelo { get; set; }
        /// <summary>
        /// Usado para gerar as listas
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="modelo"></param>
        public BuscaProdutos(int ID, string modelo)
        {
            this.id = ID;
            this.modelo = modelo;
        }

        public BuscaProdutos()
        {

        }

        public static List<BuscaProdutos> Listar()
        {
            List<BuscaProdutos> buscas = new List<BuscaProdutos>();
            buscas.Add(new BuscaProdutos(1,"Nome"));
            buscas.Add(new BuscaProdutos(2, "Codigo"));
            buscas.Add(new BuscaProdutos(3, "Categoria"));
            return buscas;
        }
    }
}
