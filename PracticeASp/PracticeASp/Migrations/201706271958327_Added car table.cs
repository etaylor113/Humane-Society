namespace PracticeASp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcartable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Model = c.String(),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarId", "dbo.People");
            DropIndex("dbo.Cars", new[] { "CarId" });
            DropTable("dbo.Cars");
        }
    }
}
