namespace SejaHeroi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crud_endereco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        UsuarioID = c.Guid(nullable: false),
                        Bairro = c.String(),
                        Rua = c.String(),
                        CEP = c.String(),
                        Numero = c.Int(nullable: false),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Endereco");
        }
    }
}
