using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AutoCozinha.Classes
{
    class Estoque
    {
        public string NumLote { set; get; }
        public int quantidade { set; get; }
        /// <summary>
        /// Busca e retorna em lista todos os produtos no estoque
        /// </summary>
        /// <returns></returns>
        public List<Produto> BuscaProdutosEstoque()
        {
            List<Produto> produtos = new List<Produto>();
            using(var bd= new LiteDatabase(BaseDados.local))
            {
                produtos = bd.GetCollection<Produto>().FindAll().ToList();
            }
            return produtos;
        }
        /// <summary>
        /// RETORNA LISTA COM TODOS OS PRODUTOS EM QUANTIDADE NEGATIVA
        /// </summary>
        /// <returns></returns>
        public List<Produto> ProdutosEmFalta()
        {
            List<Produto> produtos = new List<Produto>();
            using(var db = new LiteDatabase(BaseDados.local))
            {
                produtos = db.GetCollection<Produto>().FindAll().Where(x => x.quantidade <= 0).ToList();
            }
            return produtos;
        }
    }
}
