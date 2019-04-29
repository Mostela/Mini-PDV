using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    class Estoque
    {
        
        public int quantidade { set; get; }
        public int categoria { set; get; }
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
        /// Busca e retorna em lista os produtos pelo nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public List<Produto> BuscaProdutosEstoque(string nome = null)
        {
            List<Produto> produtos = this.BuscaProdutosEstoque();
            return produtos.Where(x => x.nomeReferencia.Contains(nome)).ToList();
        }

        public List<Produto> BuscaProdutosEstoque(string codigo, string nome = null)
        {
            List<Produto> produtos = this.BuscaProdutosEstoque();
            return produtos.Where(x => x.codigo.Contains(codigo)).ToList();
        }

        public List<Produto> BuscaProdutosEstoque(int id_categoria, string codigo= null, string nome = null)
        {
            List<Produto> produtos = this.BuscaProdutosEstoque();
            return produtos.Where(x => x.categoria == id_categoria).ToList();
        }
            /// <summary>
            /// RETORNA LISTA COM TODOS OS PRODUTOS EM QUANTIDADE NEGATIVA
            /// </summary>
            /// <returns></returns>
        public List<Produto> ProdutosEmFalta()
        {
            List<Produto> produtos = new List<Produto>();
            using (var db = new LiteDatabase(BaseDados.local))
            {
                produtos = db.GetCollection<Produto>().FindAll().Where(x => x.quantidade <= 0).ToList();
            }
            return produtos;
        }

        /// <summary>
        /// Verifica se existe codigos usados para que não sejam reptidos na base de dados
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool CodigosUsados(string codigo)
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                var dado = lite.GetCollection<Produto>().FindAll().Where(x => !x.codigo.Contains(codigo)).ToList();
                return dado.Count != 0 ? false : true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
