namespace LocacaoBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Livroes", "Nome", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Usuarios", "Login", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Livroes", "Nome", c => c.String(nullable: false));
        }
    }
}
