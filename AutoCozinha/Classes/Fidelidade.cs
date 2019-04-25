using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    class Fidelidade : Cliente
    {
        private int id_cliente { get; set; }
        public double desconto { get; set; }
        /// <summary>
        /// Quantidade de produtos comprados é um atributo de retorno apenas do banco de dados
        /// </summary>
        public int quantia_produtos_comprados { get; }


        public Fidelidade()
        {
            this.id_cliente = this.id;
        }

        public Fidelidade(int id_cliente)
        {
            this.id_cliente = id_cliente;
        }

        public Fidelidade(Cliente cliente)
        {
            this.id_cliente = cliente.id;
        }
        protected bool Adiciona()
        {
            try
            {
                using(var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Fidelidade>().Insert(this);
                }
                Log.GravarLog("Novo cliente em fidelidade", novo: this.id_cliente.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected bool Atualizar()
        {
            try
            {
                using(var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Fidelidade>().Update(this);
                }
                Log.GravarLog("Cliente fidelidade atualizado", novo: this.ToString(), antigo: this.desconto.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool NovoFidelidade()
        {
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            if(lite.GetCollection<Fidelidade>().FindById(this.id).id != 0)
            {
                return this.Adiciona();
            }
            else
            {
                return this.Atualizar();
            }
        }
        /// <summary>
        /// Busca o cliente usando o ID definido no construtor da classe
        /// </summary>
        /// <returns></returns>
        public Fidelidade BuscaCliente()
        {
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            return lite.GetCollection<Fidelidade>().FindById(id_cliente);
        }
        /// <summary>
        /// Busca o cliente usando o ID como parametro de metodo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Fidelidade BuscaCliente(int ID)
        {
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            return lite.GetCollection<Fidelidade>().FindById(ID);
        }
    }
}
