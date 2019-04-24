using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    class Cliente
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string email { get; set; }
        private string cpf { get; set; }
        private string cidade { get; set; }
        private bool status { get; set; }
        /// <summary>
        /// Cliente vazio
        /// </summary>
        public Cliente()
        {

        }
        /// <summary>
        /// Define ID para o cliente
        /// </summary>
        /// <param name="ID"></param>
        public Cliente(int ID)
        {
            this.id = ID;
        }
        /// <summary>
        /// Cria ou atribui a um novo cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <param name="cidade"></param>
        /// <param name="status"></param>
        public Cliente(int id, string nome, string email, string cpf, string cidade, bool status = true)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.cidade = cidade;
            this.status = status;
        }
        /// <summary>
        /// Carrege a classe antes de usar
        /// </summary>
        /// <returns></returns>
        public bool CriaNovoCliente()
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Cliente>().Insert(this);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Retorna lista de cliente com o nome buscado
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public List<Cliente> BuscaCliente(string nome = "")
        {
            List<Cliente> cliente = new List<Cliente>();
            using (var db = new LiteDB.LiteDatabase(BaseDados.local))
            {
                cliente = db.GetCollection<Cliente>().Find(Query.Contains("nome", nome)).ToList();
            }
            return cliente;
        }
        /// <summary>
        /// Carregar a classe Cliente antes de usar
        /// </summary>
        /// <returns></returns>
        public bool EditarCliente()
        {
            try
            {
                using(var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Cliente>().Update(this);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Informa o CPF do cliente e recebe a respota em bolean se esta de acordo
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public static bool ValidaCPF(string CPF)
        {
            const string Pattern = @"^([0-9]{3})\.?([0-9]{3})\.?([0-9]{3})\-?([0-9]{2})$";
            return Regex.IsMatch(CPF, Pattern) ? true : false;
        }

        public bool ExcluirCliente()
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                bool limpo = false;
                if (lite.GetCollection<Cliente>().Delete(this.id))
                {
                    limpo = true;
                }

                if (lite.GetCollection<Fidelidade>().Delete(this.id))
                {
                    limpo = true;
                }

                var emDebito = lite.GetCollection<Debito>().FindById(this.id);
                if(emDebito.nome != null)
                {
                    if (lite.GetCollection<Debito>().Delete(this.id))
                    {
                        limpo = true;
                    }
                }
                
                return limpo;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
