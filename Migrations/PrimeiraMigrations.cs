namespace SejaHeroi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiraMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Guid(nullable: false),
                        PerfilUsuario = c.Int(nullable: false),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        ConfirmaSenha = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CPF = c.String(),
                        RG = c.String(),
                        DataNascimento = c.DateTime(),
                        Nome = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
