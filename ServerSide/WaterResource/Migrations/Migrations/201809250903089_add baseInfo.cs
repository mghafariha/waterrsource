namespace WaterResource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbaseInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AreaStudies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        Kind = c.String(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OtherTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        FieldName = c.String(),
                        Type = c.String(),
                        Options = c.String(),
                        IsMultiple = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OtherTypes");
            DropTable("dbo.AreaStudies");
        }
    }
}
