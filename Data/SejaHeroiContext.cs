using System.Data.Entity;

namespace SejaHeroi.Data
{
    public class SejaHeroiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public SejaHeroiContext() : base("name=SejaHeroi")
        {
        }
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        public System.Data.Entity.DbSet<SejaHeroi.Models.Usuario> Usuarios { get; set; }
     
    }
}
