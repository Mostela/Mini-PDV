using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AutoCozinha.Classes
{
    class Usuario
    {
        [BsonId]
        public int ID { get; set;}
        private string email { set; get; }
        private string senha { set; get; }
        private string nome { get; set; }
        private int nivelAcesso { set; get; }
        public static bool login;
        
        public Usuario()
        {

        }

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public void Cadastrar(Classes.Usuario usuario)
        {
            using (var db = new LiteDatabase("Filename=smartBoss.db"))
            {
                db.GetCollection<Classes.Usuario>().Insert(usuario);
            }
        }
        public bool VerificaAcesso()
        {
            using(var bd = new LiteDatabase("Filename=smartBoss.db"))
            {
                //ADICIONA FUNÇÃO PARA BUSCA USUARIO E SENHA
            }
            return true;
        }


    }
}
