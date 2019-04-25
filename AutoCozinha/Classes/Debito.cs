using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    /// <summary>
    /// A classe debito é para os clientes que estão em debito com o caixa
    /// </summary>
    class Debito : Cliente
    {
        [BsonId]
        private int id_cliente { get; set; }
        private DateTime ultimoPagamento { get; set; }
        private int parcelas { get; set; }
        private double valorInicial { get; set; }
        private double valorRestante { get; set; }

        public Debito()
        {
            this.id_cliente = this.id;
        }
        /// <summary>
        /// Carrega a classe com os seus metodos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="parcelas"></param>
        /// <param name="valorInicial"></param>
        /// <param name="valorRestante"></param>
        public Debito(Cliente cliente, DateTime date, int parcelas, double valorInicial, double valorRestante = 0.0)
        {
            this.id_cliente = cliente.id;
            this.ultimoPagamento = date;
            this.parcelas = parcelas;
            this.valorInicial = valorInicial;
            this.valorRestante = valorRestante;
        }
        /// <summary>
        /// Adiciona um novo cliente ao debito ou atualiza os dados de um ja existente. Você pode usar para
        /// atualizar um debito também definindo os novos valores a serem gravados
        /// </summary>
        /// <returns></returns>
        public bool Adicionar()
        {
            try
            {
                var db = new LiteDatabase(BaseDados.local);
                if (db.GetCollection<Debito>().FindById(this.id_cliente).id_cliente != 0)
                {
                    db.GetCollection<Debito>().Insert(this);
                    Log.GravarLog("Foi adicionado um novo cliente", novo: this.ToString());
                }
                else
                {
                    this.Atualizar();
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Atualiza toda a divida do cliente caso ela ja exista
        /// </summary>
        private void Atualizar()
        {
            using(var db = new LiteDatabase(BaseDados.local))
            {
                db.GetCollection<Debito>().Update(this);
                Log.GravarLog("Foi atualizado o cliente",novo: this.id_cliente.ToString(), antigo: this.ToString());
            }
        }

        public bool Remover()
        {
            try
            {
                using (var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Debito>().Delete(this.id_cliente);
                }
                Log.GravarLog("Cliente foi removido do debito", antigo: this.id.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Retorna todos em debito
        /// </summary>
        /// <returns></returns>
        public List<Debito> ClienteEmDebito()
        {
            List<Debito> debitos = null;
            using(var db = new LiteDatabase(BaseDados.local))
            {
                debitos = db.GetCollection<Debito>().FindAll().ToList();
            }
            return debitos;
        }

        public List<Debito> ClienteEmDebito(int id_cliente)
        {
            List<Debito> debitos = this.ClienteEmDebito();
            return debitos.Where(x => x.id_cliente == id_cliente).ToList();
        }
    }
}
