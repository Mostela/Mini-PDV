using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AutoCozinha.Classes
{
    class Produto : Estoque
    {
        [BsonId]
        public int ID { set; get; }
        public float preco { set; get; }
        public string validade { set; get; }
        public string nomeReferencia { set; get; }
        public string descricao { set; get; }
        public string codigo { set; get; }

        public Produto()
        {
            
        }
        /// <summary>
        /// Overload construtor. ID pode ou não ser definida caso esteja sendo criado um novo produto
        /// </summary>
        /// <param name="preco"></param>
        /// <param name="lote"></param>
        /// <param name="validade"></param>
        /// <param name="nome"></param>
        /// <param name="codigo"></param>
        /// <param name="ID"></param>
        public Produto(float preco, string lote, string validade, string nome, string codigo,string descricao,int quantidade, int ID = 0)
        {
            this.ID = ID;
            this.preco = preco;
            this.NumLote = lote;
            this.validade = validade;
            this.nomeReferencia = nome;
            this.codigo = codigo;
            this.descricao = descricao;
            this.quantidade = quantidade;
        }

        /// <summary>
        /// Cadastra um novo produto com a classe produto carregada
        /// </summary>
        public bool Cadastra()
        {
            try
            {
                using (var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Produto>().Insert(this);
                }
                return true;
            }
            catch (Exception ex)
            {
                Classes.Log.GravarLog(string.Format("Erro cadastrar produto {0}", ex.Message));
                return false;
            }
        }
        /// <summary>
        /// Atualiza todo o objeto
        /// </summary>
        /// <returns></returns>
        public bool Editar()
        {
            try
            {
                using (var bd = new LiteDatabase(BaseDados.local))
                {
                    bd.GetCollection<Produto>().Update(this);
                }
                return true;
            }
            catch (Exception ex)
            {
                Classes.Log.GravarLog(string.Format("Erro editar produto {0}", ex.Message));
                return false;
            }
            
        }
        /// <summary>
        /// EXCLUI O PRODUTO PELO ATRIBUTO ID
        /// </summary>
        public bool Excluir()
        {
            try
            {
                using (var bd = new LiteDatabase(BaseDados.local))
                {
                    bd.GetCollection<Produto>().Delete(this.ID);
                }
                return true;
            }
            catch (Exception ex)
            {
                Classes.Log.GravarLog(string.Format("Erro excluir produto {0}",ex.Message), this.nomeReferencia);
                return false;
            }
            
        }

        public List<Produto> BuscaProduto(string nome)
        {
            List<Produto> produtos = new List<Produto>();
            using(var db = new LiteDatabase(BaseDados.local))
            {
                db.GetCollection<Produto>().Find(Query.Contains("nomeReferencia", nome)).ToList();
            }
            return produtos;
        }
    }
}
