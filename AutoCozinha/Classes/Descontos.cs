using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /// <summary>
    /// Carrega a comboBox Descontos na tela principal
    /// </summary>
    class Descontos
    {
        public double valDesconto { get; set; }
        public string valor { get; set; }
        /// <summary>
        /// Construtor vazio para definição
        /// </summary>
        public Descontos()
        {

        }

        /// <summary>
        /// Construtor para encher a comboBox
        /// </summary>
        public Descontos(double valDesconto, string valor)
        {
            this.valDesconto = valDesconto;
            this.valor = valor;
        }
        /// <summary>
        /// Retorna a lista com possiveis valores de descontos a ser aplicados
        /// </summary>
        /// <returns></returns>
        public static List<Descontos> Listar()
        {
            List<Descontos> descontos = new List<Descontos>();
            descontos.Add(new Descontos(0.05, "5%"));
            descontos.Add(new Descontos(0.1, "10%"));
            descontos.Add(new Descontos(0.25, "25%"));
            descontos.Add(new Descontos(0.5, "50%"));
            descontos.Add(new Descontos(0.75, "75%"));
            descontos.Add(new Descontos(0.90, "90%"));
            return descontos;
        }
    }
}
