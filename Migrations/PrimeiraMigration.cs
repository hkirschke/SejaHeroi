namespace SejaHeroi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiraMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "ConfirmaSenha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "ConfirmaSenha", c => c.String(nullable: false));
        }
    }
}
