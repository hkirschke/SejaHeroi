namespace SejaHeroi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracao_animal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animal", "StatusVacina", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animal", "StatusVacina", c => c.Boolean(nullable: false));
        }
    }
}
