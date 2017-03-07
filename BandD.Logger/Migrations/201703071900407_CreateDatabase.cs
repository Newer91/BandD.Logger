namespace BandD.Logger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BandDServisLoggers",
                c => new
                    {
                        ServisLoggerId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false, identity: true),
                        ErrorMessage = c.String(),
                        MethodsName = c.String(),
                        Client = c.String(),
                    })
                .PrimaryKey(t => t.ServisLoggerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BandDServisLoggers");
        }
    }
}