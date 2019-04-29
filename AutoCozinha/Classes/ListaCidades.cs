using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{/// <summary>
/// Lista as cidades obtidas para que sejam exibidas no Combobox
/// </summary>
    class ListaCidades
    {
        public int id { set; get; }
        public string nome { set; get; }

        public ListaCidades()
        {

        }
        /// <summary>
        /// Carrega a classe
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="nome"></param>
        public ListaCidades(int ID, string nome)
        {
            this.id = ID;
            this.nome = nome;
        }
        /// <summary>
        /// Lista das as cidades para uma possivel comboBox, retorno em lista
        /// </summary>
        /// <returns></returns>
        public static List<ListaCidades> Listar()
        {
            List<ListaCidades> cidades = new List<ListaCidades>();
            cidades.Add(new ListaCidades(1, "Santa Branca"));
            cidades.Add(new ListaCidades(2, "São Paulo"));
            cidades.Add(new ListaCidades(3, "Mogi Das Cruzes"));
            cidades.Add(new ListaCidades(4, "Suzano"));
            cidades.Add(new ListaCidades(5, "Poa"));
            cidades.Add(new ListaCidades(6, "Jacareí"));
            cidades.Add(new ListaCidades(7, "São Jose Dos Campos"));
            return cidades.OrderBy(c => c.nome).ToList();
        }

    }
}
