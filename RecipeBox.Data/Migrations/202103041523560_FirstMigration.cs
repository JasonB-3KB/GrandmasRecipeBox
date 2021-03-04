namespace RecipeBox.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Source", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Source", "SourceOrigin", c => c.String(nullable: false));
            DropColumn("dbo.Source", "Origin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Source", "Origin", c => c.String(nullable: false));
            DropColumn("dbo.Source", "SourceOrigin");
            DropColumn("dbo.Source", "OwnerId");
        }
    }
}
