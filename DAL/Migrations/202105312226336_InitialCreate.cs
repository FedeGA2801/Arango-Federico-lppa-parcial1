namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        email = c.String(),
                        telefono = c.String(),
                        cuit = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Afiliados");
        }
    }
}
