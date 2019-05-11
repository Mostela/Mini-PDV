using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    class Usuario
    {
        [BsonId]
        public int ID { get; set;}
        public string email { set; get; }
        public string senha { set; get; }
        public string nome { set; get; }
        public NiveisAcesso nivelAcesso { set; get; }
        [BsonIgnore]
        public static int nivelAcessoHabilitado;
        [BsonIgnore]
        public static int ID_Habilitado;
        [BsonIgnore]
        public static bool login;
        /// <summary>
        /// Cosntrutor vazio permite overload
        /// </summary>
        public Usuario()
        {

        }
        /// <summary>
        /// Construtor com overload
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        public Usuario(string nome, string email, string senha, NiveisAcesso niveis = null)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.nivelAcesso = niveis;
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
                db.GetCollection<Usuario>().Insert(this);
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

            try
            {
                //
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                Usuario user = lite.GetCollection<Usuario>().FindAll().Where(x => x.email == email && x.senha == senha).ToList()[0];
                if(user.ID != 0)
                {
                    Usuario.nivelAcessoHabilitado = user.nivelAcesso.nivel;
                    Usuario.ID_Habilitado = user.ID;
                    flag = true;
                }
            }
            catch(Exception ex)
            {
                Log.GravarLog("Erro Verificar Acesso", novo: ex.Message);
            }
            return flag;
        }

        /// <summary>
        /// Monta as senhas em MD5
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
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
        /// <summary>
        /// É criado um usuario padrão para acessar o sistema
        /// </summary>
        public static void GeraUserPadrao()
        {
            NiveisAcesso acesso = new NiveisAcesso();
            acesso.nivel = 3;
            acesso.cargo = "Gerente";
            Usuario usPadrao = new Usuario("Default", "admin@admin", "1234578", acesso);
            usPadrao.Cadastrar();
            Log.GravarLog("Foi criado um usuario padrão", novo: usPadrao.email, antigo: "1234578");   
        }

        /// <summary>
        /// Busca o usuario pelo nome na base de dados. Retorna Bool
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool BuscaUsuario(string nome)
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                return lite.GetCollection<Usuario>().Exists(x => x.nome == nome) ? true : false;
            }catch(Exception ex)
            {
                Log.GravarLog("Erro BuscaUsuario", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Busca o usuario pelo email na base de dados. Retorna Bool
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool BuscaUsuario(string email, string nome = null)
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                return lite.GetCollection<Usuario>().Exists(x => x.email == email) ? true : false;
            }
            catch (Exception ex)
            {
                Log.GravarLog("Erro BuscaUsuario", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Retorna todos os Usuarios da base
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> TodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                return lite.GetCollection<Usuario>().FindAll().ToList();
            }catch(Exception ex)
            {
                Log.GravarLog("Erro retornar todos usuarios", ex.Message);
                return usuarios;
            }
        }
        /// <summary>
        /// Remove o usuario pela ID informada
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool RemoverUsuario(int ID)
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                lite.GetCollection<Usuario>().Delete(ID);
                return true;
            }catch(Exception ex)
            {
                Log.GravarLog("Erro RemoverUsuario", ex.Message);
                return false;
            }
        }

        public bool Atualiza()
        {
            try
            {
                LiteDatabase lite = new LiteDatabase(BaseDados.local);
                lite.GetCollection<Usuario>().Update(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
