using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Classes
{
    /// <summary>
    /// Classe usada para encher a ComboBox Categoria dos produtos
    /// </summary>
    class CategoriaProduto
    {
        [BsonId]
        public int id_categoria { get; set; }
        public string categoria { get; set; }

        public CategoriaProduto()
        {
                
        }

        public CategoriaProduto(int ID, string categoria)
        {
            this.id_categoria = ID;
            this.categoria = categoria;
        }
        /// <summary>
        /// Retorna em lista as categorias dos produtos na base de dados
        /// </summary>
        /// <returns></returns>
        public static List<CategoriaProduto> Listar()
        {
            List<CategoriaProduto> lista = new List<CategoriaProduto>();
            using(var db = new LiteDB.LiteDatabase(BaseDados.local))
            {
                lista = db.GetCollection<CategoriaProduto>().FindAll().ToList();
            }

            return lista;
        }

        public void NovaCategoria()
        {
            using(var db = new LiteDB.LiteDatabase(BaseDados.local))
            {
                db.GetCollection<CategoriaProduto>().Insert(this);
            }
        }
        /// <summary>
        /// Informa a ID da categoria a ser removida
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoverCategoria(int id)
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(BaseDados.local))
                {
                    db.GetCollection<CategoriaProduto>().Delete(id);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Retorna a classe Categoria Produto que foi buscada
        /// </summary>
        /// <param name="ID_busca"></param>
        /// <returns></returns>
        public static CategoriaProduto RetornaCategoria(int ID_busca)
        {
            LiteDB.LiteDatabase lite = new LiteDB.LiteDatabase(BaseDados.local);
            return lite.GetCollection<CategoriaProduto>().FindById(ID_busca);
        }
    }
}
