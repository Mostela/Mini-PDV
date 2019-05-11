using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    /// <summary>
    /// Salva ultimos itens comprados pelos clientes [CONSTRUÇÃO]
    /// </summary>
    class Compras
    {
        [BsonId]
        public int id { set; get; }
        /// <summary>
        /// Classe do carrinho de compras
        /// </summary>
        public List<Produto> carrinho { set; get; }
        /// <summary>
        /// Data e hora da venda
        /// </summary>
        public DateTime date = DateTime.Now;
        /// <summary>
        /// Dados do cliente se for um cliente cadastrado
        /// </summary>
        public Cliente Cliente { set; get; }
        public double total { get; set; }
        public double valorRecebido { get; set; }
        public string MetodoPagamento { get; set; }

        public Compras()
        {

        }

        public Compras(List<Produto> carrinho, Cliente cliente, int id = 0)
        {
            this.id = id;
            this.carrinho = carrinho;
            this.Cliente = cliente;
        }

        /// <summary>
        /// Finaliza a compra
        /// </summary>
        /// <returns></returns>
        public bool FinalizaCompra()
        {
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            try
            {
                lite.GetCollection<Compras>().Insert(this);
                foreach (Produto produto in this.carrinho)
                {
                    Produto produtoEstoque = lite.GetCollection<Produto>().FindById(produto.ID);
                    produtoEstoque.quantidade -= produto.quantidade;
                    lite.GetCollection<Produto>().Update(produtoEstoque);
                }
                
                Log.GravarLog("Nova compra realizada", novo: this.ToString());
                return true;
            }
            catch (Exception ex)
            {
                Log.GravarLog("Erro gravar compra", antigo: ex.Message, novo: this.ToString());
                return false;
            }
        }
        /// <summary>
        /// Retorna em forma de objeto a ultima compra
        /// </summary>
        /// <returns></returns>
        public Compras UltimaCompra()
        {
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            Compras UltimasCompras = new Compras();
            try
            {
                UltimasCompras = lite.GetCollection<Compras>().FindAll().ToList().Last();
            }
            catch (Exception ex)
            {
                Log.GravarLog("Falha consulta ultima compra", antigo: ex.Message);
            }

            return UltimasCompras;
        }
        public List<Compras> UltimasCompras(int ID_cliente)
        {
            List<Compras> compras = new List<Compras>();
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                compras = lite.GetCollection<Compras>().Find(x => x.Cliente.id == ID_cliente).ToList();
            }catch(Exception ex)
            {
                Log.GravarLog("Erro busca ultimas compras", ex.Message);
            }
            return compras;
        }
    }
}
