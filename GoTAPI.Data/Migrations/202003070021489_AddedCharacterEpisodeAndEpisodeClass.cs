namespace GoTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCharacterEpisodeAndEpisodeClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CharacterEpisode", "Character_Id", "dbo.Character");
            DropIndex("dbo.CharacterEpisode", new[] { "Character_Id" });
            RenameColumn(table: "dbo.CharacterEpisode", name: "Character_Id", newName: "CharacterId");
            AddColumn("dbo.CharacterEpisode", "EpisodeId", c => c.Int(nullable: false));
            AddColumn("dbo.Episode", "Season", c => c.Int(nullable: false));
            AddColumn("dbo.Episode", "EpisodeNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Episode", "Title", c => c.String());
            AddColumn("dbo.Episode", "RunTime", c => c.Int(nullable: false));
            AlterColumn("dbo.CharacterEpisode", "CharacterId", c => c.Int(nullable: false));
            CreateIndex("dbo.CharacterEpisode", "EpisodeId");
            CreateIndex("dbo.CharacterEpisode", "CharacterId");
            AddForeignKey("dbo.CharacterEpisode", "EpisodeId", "dbo.Episode", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CharacterEpisode", "CharacterId", "dbo.Character", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CharacterEpisode", "CharacterId", "dbo.Character");
            DropForeignKey("dbo.CharacterEpisode", "EpisodeId", "dbo.Episode");
            DropIndex("dbo.CharacterEpisode", new[] { "CharacterId" });
            DropIndex("dbo.CharacterEpisode", new[] { "EpisodeId" });
            AlterColumn("dbo.CharacterEpisode", "CharacterId", c => c.Int());
            DropColumn("dbo.Episode", "RunTime");
            DropColumn("dbo.Episode", "Title");
            DropColumn("dbo.Episode", "EpisodeNumber");
            DropColumn("dbo.Episode", "Season");
            DropColumn("dbo.CharacterEpisode", "EpisodeId");
            RenameColumn(table: "dbo.CharacterEpisode", name: "CharacterId", newName: "Character_Id");
            CreateIndex("dbo.CharacterEpisode", "Character_Id");
            AddForeignKey("dbo.CharacterEpisode", "Character_Id", "dbo.Character", "Id");
        }
    }
}
