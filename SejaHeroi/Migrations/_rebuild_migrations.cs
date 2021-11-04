namespace SejaHeroi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rebuild_migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        AnimalID = c.Guid(nullable: false),
                        UsuarioID = c.Guid(nullable: false),
                        TamanhoAnimal = c.Int(nullable: false),
                        RacaAnimal = c.Int(nullable: false),
                        Nome = c.String(nullable: false),
                        Idade = c.Int(nullable: false),
                        Situacao = c.Int(nullable: false),
                        Resenha = c.String(),
                        Foto = c.Binary(),
                        StatusVacina = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AnimalID);
            
            CreateTable(
                "dbo.EquipeVeterinario",
                c => new
                    {
                        EquipeVeterinarioID = c.Guid(nullable: false),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EquipeVeterinarioID);
            
            CreateTable(
                "dbo.FichaCastracao",
                c => new
                    {
                        CastracaoID = c.Guid(nullable: false),
                        DataEntrada = c.DateTime(),
                        DataSaida = c.DateTime(),
                        UsuarioID = c.Guid(nullable: false),
                        AnimalID = c.Guid(nullable: false),
                        EquipeVeterinarioID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.CastracaoID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Guid(nullable: false),
                        PerfilUsuario = c.Int(nullable: false),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.FichaCastracao");
            DropTable("dbo.EquipeVeterinario");
            DropTable("dbo.Animal");
        }
    }
}
