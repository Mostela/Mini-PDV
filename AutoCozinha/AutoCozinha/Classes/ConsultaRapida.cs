using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCozinha.Classes
{
    class ConsultaRapida
    {
        public int ID { get; set;}
        public string metodo { get; set; }

        public ConsultaRapida()
        {

        }

        public ConsultaRapida(int ID, string metodo)
        {
            this.ID = ID;
            this.metodo = metodo;
        }

        public List<ConsultaRapida> Listar()
        {
            List<ConsultaRapida> consultas = new List<ConsultaRapida>();
            consultas.Add(new ConsultaRapida(1, "Nome"));
            consultas.Add(new ConsultaRapida(2, "Codigo"));
            consultas.Add(new ConsultaRapida(3, "Validade"));
            consultas.Add(new ConsultaRapida(4, "Categoria"));
            return consultas;
        }
    }
}
