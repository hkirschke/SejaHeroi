namespace SejaHeroi.Migrations
{
  using SejaHeroi.Models;
  using System;
  using System.Data.Entity.Migrations;

  internal sealed class Configuration : DbMigrationsConfiguration<SejaHeroi.Data.SejaHeroiContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(SejaHeroi.Data.SejaHeroiContext context)
    {
      var UsuarioAdmin = new Guid("8807B82C-D6AE-464F-B3A8-1904900F7150");
      var UsuarioNaoAdmin = new Guid("E90C50D7-7C58-4A1F-9C7C-2CD446EDDAF3");
      //  This method will be called after migrating to the latest version. 

      context.Usuarios.AddOrUpdate(
        p => p.UsuarioID,
        new Usuario { Login = "admin", Email = "henrique@teste.com", PerfilUsuario = Enums.PerfilUsuario.Administrador, Senha = "123456", UsuarioID = UsuarioAdmin },
        new Usuario { Login = "naoadmin", Email = "henrique@teste.com", PerfilUsuario = Enums.PerfilUsuario.Adotante, Senha = "123456", UsuarioID = UsuarioNaoAdmin }
      );
    }
  }
}
