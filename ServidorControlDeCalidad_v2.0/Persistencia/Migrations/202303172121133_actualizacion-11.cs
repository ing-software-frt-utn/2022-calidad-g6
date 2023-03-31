namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion11 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.OrdenesDeProduccion", "NumeroOP", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.OrdenesDeProduccion", new[] { "NumeroOP" });
        }
    }
}
