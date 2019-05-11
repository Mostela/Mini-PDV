using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{/// <summary>
/// Classe Cliente opera todas as situações simples entre o cliente
/// </summary>
    class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public bool status { get; set; }
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
        public Cliente(string nome, string email, string cpf, string cidade, bool status = true, int id = 0)
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
                bool saida;
                using (var db = new LiteDB.LiteDatabase(BaseDados.local))
                {
                    saida = db.GetCollection<Cliente>().Insert(this);
                    this.id = db.GetCollection<Cliente>().FindOne(Query.Contains("nome", this.nome)).id;
                }
                Log.GravarLog("Foi criado um novo cliene", novo: this.id.ToString());
                return saida;
            }
            catch (Exception ex)
            {
                Log.GravarLog("Erro novo cliente", antigo: ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Retorna lista de cliente com o nome buscado
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public List<Cliente> BuscaCliente(string nome = null)
        {
            List<Cliente> cliente = this.BuscaCliente();
            return cliente.Where(x => x.nome.Contains(nome)).ToList();
        }
        /// <summary>
        /// Retorna todos os clientes da base
        /// </summary>
        /// <returns></returns>
        public List<Cliente> BuscaCliente()
        {
            List<Cliente> cliente = new List<Cliente>();
            using (var db = new LiteDB.LiteDatabase(BaseDados.local))
            {
                cliente = db.GetCollection<Cliente>().FindAll().ToList();
            }
            return cliente;
        }
        /// <summary>
        /// Defina o CPF o nome não é usado nessa busca
        /// </summary>
        /// <param name="Cpf"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public List<Cliente> BuscaCliente(string Cpf, string nome = null)
        {
            List<Cliente> cliente = new List<Cliente>();
            using (var db = new LiteDB.LiteDatabase(BaseDados.local))
            {
                cliente = db.GetCollection<Cliente>().Find(Query.Contains("cpf", Cpf)).ToList();
            }
            return cliente;
        }
        /// <summary>
        /// Retorna o cliente buscado pelo CPF como objeto. Para uso na compra
        /// </summary>
        /// <param name="Cpf"></param>
        /// <param name="obejto"></param>
        /// <returns></returns>
        public Cliente BuscaCliente(string Cpf, bool obejto = true)
        {
            Cliente busClie = new Cliente();
            LiteDatabase lite = new LiteDatabase(BaseDados.local);
            var dados =lite.GetCollection<Cliente>().Find(Query.Contains("cpf", Cpf)).ToList();
            busClie = new Cliente(dados[0].nome, dados[0].email, dados[0].cpf, dados[0].cidade, dados[0].status, dados[0].id);
            return busClie;
        }
        /// <summary>
        /// Carregar a classe Cliente antes de usar. Atualiza os dados do usuario no sistema
        /// </summary>
        /// <returns></returns>
        public bool EditarCliente()
        {
            try
            {
                using(var db = new LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<Cliente>().Update(this);
                    Log.GravarLog("Cliente atualizado", antigo: this.id.ToString());
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
            if (ConsultaCPF(CPF))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Verifica se o email é valido
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ValidaEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success ? true : false;
        }
        /// <summary>
        /// Consulta na base de dados o CPF se não existe ainda
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool ConsultaCPF(string cpf)
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                var dados = lite.GetCollection<Cliente>().Find(Query.Contains("cpf", cpf)).ToList();
                return dados.Count == 0 ? true : false;
            }
            catch (Exception ex)
            {
                Log.GravarLog("Erro consulta CPF", novo: ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Busca e exlui o cliente em todas as bases de dados
        /// </summary>
        /// <returns></returns>
        public bool ExcluirCliente()
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                bool limpo = false;

                var emDebito = lite.GetCollection<Debito>().FindById(this.id);
                if(emDebito == null)
                {
                    if (lite.GetCollection<Debito>().Delete(this.id))
                    {
                        limpo = true;
                    }

                    if (lite.GetCollection<Cliente>().Delete(this.id))
                    {
                        limpo = true;
                    }

                    if (lite.GetCollection<Fidelidade>().Delete(this.id))
                    {
                        limpo = true;
                    }
                    Log.GravarLog("Cliente foi eliminado do sistema", antigo: this.id.ToString());
                }
                else
                {
                    Log.GravarLog("Erro eliminar cliente do sistema", antigo: this.id.ToString());
                }
                
                return limpo;
            }
            catch (Exception ex)
            {
                Log.GravarLog("Erro eliminar cliente do sistema", antigo: this.id.ToString(), novo: ex.Message);
                return false;
            }
        }

    }
}
