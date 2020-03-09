namespace GoTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tempremoveIcollection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CharacterEpisode", "Character_Id", "dbo.Character");
            DropIndex("dbo.CharacterEpisode", new[] { "Character_Id" });
            DropColumn("dbo.CharacterEpisode", "Character_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CharacterEpisode", "Character_Id", c => c.Int());
            CreateIndex("dbo.CharacterEpisode", "Character_Id");
            AddForeignKey("dbo.CharacterEpisode", "Character_Id", "dbo.Character", "Id");
        }
    }
}
