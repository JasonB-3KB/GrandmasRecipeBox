namespace RecipeBox.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Recipe", "Comment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recipe", "Comment", c => c.String());
        }
    }
}
