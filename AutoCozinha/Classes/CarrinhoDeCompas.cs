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
        public List<Produto> carrinhoDeCompas = new List<Produto>();
        public double Desconto { get; set; }
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
        public List<Produto> UltimosProdutos()
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
            this.carrinhoDeCompas.Add(new CarrinhoDeCompas(id, nome, quantidade, preco));
        }
        /// <summary>
        /// Altera um elemento no carrinho de compras
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public void EditaCarrinho(int id, string nome = null, int quantidade = 1, double preco = 1.0, bool aumentaQuantia = false)
        {
            if(this.carrinhoDeCompas.Exists(x => x.ID == id))
            {
                int id_found = 0;
                foreach(CarrinhoDeCompas busca in carrinhoDeCompas)
                {
                    if(busca.ID == id)
                    {
                        break;
                    }
                    id_found++;
                }
                this.carrinhoDeCompas[id_found].nomeReferencia = nome;
                this.carrinhoDeCompas[id_found].preco = float.Parse(preco.ToString());
                if (aumentaQuantia)
                {
                    this.carrinhoDeCompas[id_found].quantidade++;
                }
                else
                {
                    this.carrinhoDeCompas[id_found].quantidade = quantidade;
                }
            }
        }
        /// <summary>
        /// Remove um produto pela sua ID
        /// </summary>
        /// <param name="id"></param>
        public void RemoveCarrinho(int id)
        {
            int id_remove = 0;
            foreach(CarrinhoDeCompas carro in carrinhoDeCompas)
            {
                if (carro.ID == id)
                {
                    this.carrinhoDeCompas.RemoveAt(id_remove);
                    break;
                }
                else
                {
                    id_remove++;
                }
            }
            
        }
        /// <summary>
        /// Após a compra limpar a lista
        /// </summary>
        public void LimpaLista()
        {
            this.carrinhoDeCompas.Clear();
        }
        /// <summary>
        /// Calcula o valor total de itens na lista
        /// </summary>
        /// <returns></returns>
        public double CalculaTotal()
        {
            double pote = 0;
            foreach(CarrinhoDeCompas car in carrinhoDeCompas)
            {
                pote += car.preco * car.quantidade;
            }
            return pote - (pote * Desconto);
        }
        /// <summary>
        /// Retorna um objeto do propio objeto CarrinhoDeCompras
        /// </summary>
        /// <returns></returns>
        public CarrinhoDeCompas ToObject()
        {
            return this;
        }
    }
}
