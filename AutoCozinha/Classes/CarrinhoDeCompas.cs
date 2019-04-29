using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /// <summary>
    /// Carrinho de compras da tela inicial com a lista de produtos passados
    /// </summary>
    class CarrinhoDeCompas : Produto
    {
        public List<CarrinhoDeCompas> carrinhoDeCompas { get; set; }
        /// <summary>
        /// Construtor vazio
        /// </summary>
        public CarrinhoDeCompas()
        {

        }
        /// <summary>
        /// Construtor que adiciona produtos no carrinho de compras
        /// </summary>
        public CarrinhoDeCompas(int id,string nome, int quantidade, double preco)
        {
            this.ID = id;
            this.nomeReferencia = nome;
            this.quantidade = quantidade;
            this.preco = float.Parse(preco.ToString());
        }
        /// <summary>
        /// Retorna os elementos presentes no carrinho de compra
        /// </summary>
        /// <returns></returns>
        public List<CarrinhoDeCompas> UltimosProdutos()
        {
            return this.carrinhoDeCompas;
        }
        /// <summary>
        /// Adiciona um novo elemento no carrinho de compras
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public void AdicionaCarrinho(int id, string nome, int quantidade, double preco)
        {
            this.carrinhoDeCompas.Add(new CarrinhoDeCompas(id,nome,quantidade,preco));
        }
        /// <summary>
        /// Altera um elemento no carrinho de compras
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public void EditaCarrinho(int id, string nome = null, int quantidade = 1, double preco = 1.0)
        {
            if(this.carrinhoDeCompas.Exists(x => x.ID == id))
            {
                this.carrinhoDeCompas[id].nomeReferencia = nome;
                this.carrinhoDeCompas[id].quantidade = quantidade;
                this.carrinhoDeCompas[id].preco = float.Parse(preco.ToString());
            }
        }
        /// <summary>
        /// Remove um produto pela sua ID
        /// </summary>
        /// <param name="id"></param>
        public void RemoveCarrinho(int id)
        {
            this.carrinhoDeCompas.RemoveAt(id);
        }

        protected void LimpaLista()
        {
            this.carrinhoDeCompas.Clear();
        }
    }
}
