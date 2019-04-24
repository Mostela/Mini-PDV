using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Debito : Cliente
    {
        private int id_cliente { get; set; }
        private DateTime ultimoPagamento { get; set; }
        private int parcelas { get; set; }
        private double valorInicial { get; set; }
        private double valorRestante { get; set; }

        public Debito()
        {
            
        }

    }
}
