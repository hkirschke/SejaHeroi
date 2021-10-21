namespace SejaHeroi.Migrations
{
  using SejaHeroi.Models;
  using SejaHeroi.Models.Animal;
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

      context.Usuarios.AddOrUpdate(
        p => p.UsuarioID,
        new Usuario { Login = "admin", Email = "henrique@teste.com", PerfilUsuario = Enums.PerfilUsuario.Administrador, Senha = "123456", UsuarioID = UsuarioAdmin },
        new Usuario { Login = "naoadmin", Email = "henrique@teste.com", PerfilUsuario = Enums.PerfilUsuario.Adotante, Senha = "123456", UsuarioID = UsuarioNaoAdmin }
      );

      context.Animals.AddOrUpdate(
         a => a.UsuarioID,
         new Animal
         {
           UsuarioID = UsuarioAdmin,
           Idade = 2,
           RacaAnimal = Enums.Racas.Viralata,
           Situacao = Enums.Situacao.DonoProprio,
           Nome = "Teste",
           TamanhoAnimal = Enums.PorteAnimal.Medio,
           Resenha = "Teste",
           AnimalID = new Guid("8fd7c807-84e7-4791-8e35-ba757df6f068")
         },
        new Animal
        {
          Idade = 2,
          RacaAnimal = Enums.Racas.ChowChow,
          Situacao = Enums.Situacao.Disponivel,
          Nome = "Teste2",
          TamanhoAnimal = Enums.PorteAnimal.Medio,
          Resenha = "Teste2",
          AnimalID = new Guid("d793b9c9-1e7c-4625-8c8d-80ae57db99c5")
        },
         new Animal
         {
           Idade = 2,
           RacaAnimal = Enums.Racas.Boxer,
           Situacao = Enums.Situacao.Disponivel,
           Nome = "Teste3",
           TamanhoAnimal = Enums.PorteAnimal.Pequeno,
           Resenha = "Teste3",
           AnimalID = new Guid("c59270c9-bf04-41f0-891a-4d6bcc5b2c88")
         }
        );

      context.EquipeVeterinarios.AddOrUpdate(
         b => b.EquipeVeterinarioID,
         new EquipeVeterinario { EquipeVeterinarioID = new Guid("305ac71b-5371-4eab-aa37-742346f558b3"), Nome = "Superman" },
         new EquipeVeterinario { EquipeVeterinarioID = new Guid("dffe3aa9-c77d-4bea-a78f-dec5f24f13cc"), Nome = "Batman" },
         new EquipeVeterinario { EquipeVeterinarioID = new Guid("dd763414-4410-4243-87fa-ba9cea0ed6ca"), Nome = "WonderWoman" }
         );
    }
    }
}
