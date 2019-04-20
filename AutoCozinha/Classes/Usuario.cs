using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AutoCozinha.Classes
{
    class Usuario
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
            this.senha = this.GeraHasMD5(this.senha);
            using (var db = new LiteDatabase(BaseDados.local))
            {
                db.GetCollection<Classes.Usuario>().Insert(this);
            }
            Log.GravarLog("Novo usuario", novo: this.email);
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
            senha = this.GeraHasMD5(senha);
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

        protected string GeraHasMD5(string valor)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(valor));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }


    }
}
