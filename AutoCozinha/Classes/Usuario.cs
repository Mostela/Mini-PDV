using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AutoCozinha.Classes
{
    class Usuario : Estoque
    {
        [BsonId]
        public int ID { get; set;}
        public string email { set; get; }
        public string senha { set; get; }
        public string nome { set; get; }
        public int nivelAcesso { set; get; }
        public static int nivelAcessoHabilitado;
        public static int ID_Habilitado;
        public static bool login;
        /// <summary>
        /// Cosntrutor vazio permite overload
        /// </summary>
        public Usuario()
        {
            this.nivelAcesso = -1;
        }
        /// <summary>
        /// Construtor com overload
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.nivelAcesso = -1;
        }
        /// <summary>
        /// Função para cadastrar o usuario no banco de dados, após prencher os metodos da classe
        /// Usuario. (nome, email, senha, nivelAcesso)
        /// </summary>
        public void Cadastrar()
        {
            using (var db = new LiteDatabase(BaseDados.local))
            {
                db.GetCollection<Classes.Usuario>().Insert(this);
            }
        }
        /// <summary>
        /// Busca o usuario no banco de dados e retorna valor booleano
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool VerificaAcesso(string email, string senha)
        {
            bool flag = false;
            using (var bd = new LiteDatabase(BaseDados.local))
            {
                var user = bd.GetCollection<Usuario>().FindAll().Where(x => x.email == email && x.senha == senha).ToList();
                if(user.Count > 0)
                {
                    Classes.Usuario.nivelAcessoHabilitado = user[0].nivelAcesso;
                    Classes.Usuario.ID_Habilitado = user[0].ID;
                    flag = true;
                }
            }
            return flag;
        }


    }
}
