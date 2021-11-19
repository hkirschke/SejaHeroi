using System.Data.Entity;

namespace SejaHeroi.Data
{
  public class SejaHeroiContext : DbContext
  {
    public SejaHeroiContext() : base("name=SejaHeroi")
    {
    } 
    public System.Data.Entity.DbSet<SejaHeroi.Models.Usuario> Usuarios { get; set; } 
    public System.Data.Entity.DbSet<SejaHeroi.Models.Animal.Animal> Animals { get; set; } 
    public System.Data.Entity.DbSet<SejaHeroi.Models.FichaCastracao> FichaCastracaos { get; set; }
    public System.Data.Entity.DbSet<SejaHeroi.Models.EquipeVeterinario> EquipeVeterinarios { get; set; }
    public System.Data.Entity.DbSet<SejaHeroi.Models.Endereco> Enderecoes { get; set; } 
    public System.Data.Entity.DbSet<SejaHeroi.Models.EquipeVeterinario> EquipeVeterinarios { get; set; }
  }
}
