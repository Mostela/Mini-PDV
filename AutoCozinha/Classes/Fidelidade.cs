using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    class Fidelidade
    {
        [BsonId]
        public int id_cliente { get; set; }
        public double desconto { get; set; }
        /// <summary>
        /// Quantidade de produtos comprados é um atributo de retorno apenas do banco de dados
        /// </summary>
        public int quantia_produtos_comprados { get; }


        public Fidelidade()
        {
            
        }

        public Fidelidade(int id_cliente)
        {
            this.id_cliente = id_cliente;
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
            catch (Exception ex)
            {
                Log.GravarLog("Falha adicionar cliente", antigo: ex.Message);
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

        public bool Excluir()
        {
            try
            {
                using (var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Fidelidade>().Delete(this.id_cliente);
                }
                Log.GravarLog("Cliente fidelidade removido", novo: this.ToString(), antigo: this.desconto.ToString());
                return true;
            }
            catch (Exception ex)
            {
                Log.GravarLog("Falha remover cliente", antigo: ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Adiciona um novo cliente caso não esteja ou atualiza caso ja esteja
        /// </summary>
        /// <returns></returns>
        public bool NovoFidelidade()
        {
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            if(!lite.GetCollection<Fidelidade>().Exists(Query.Contains("id_cliente", this.id_cliente.ToString())))
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
