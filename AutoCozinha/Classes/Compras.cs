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
        public CarrinhoDeCompas carrinho { set; get; }
        public DateTime date = DateTime.Today;
        public Cliente Cliente { set; get; }
}
}
