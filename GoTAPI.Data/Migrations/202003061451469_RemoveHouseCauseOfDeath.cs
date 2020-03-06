namespace GoTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveHouseCauseOfDeath : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.House", "CauseOfDeath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.House", "CauseOfDeath", c => c.String());
        }
    }
}
