using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Fidelidade : Cliente
    {
        private int id_cliente { get; set; }
        private double desconto { get; set; }
        /// <summary>
        /// Quantidade de produtos comprados é um atributo de retorno apenas do banco de dados
        /// </summary>
        private int quantia_produtos_comprados { get; }

        public Fidelidade()
        {
            
        }

        public Fidelidade(int id_cliente)
        {
            this.id_cliente = id_cliente;
        }

        public Fidelidade(Cliente cliente)
        {

        }
    }
}
