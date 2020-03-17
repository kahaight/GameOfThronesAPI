namespace GoTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationAffiliation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharacterAffiliation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CharacterId = c.Int(nullable: false),
                        AffiliationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Affiliation", t => t.AffiliationId, cascadeDelete: true)
                .ForeignKey("dbo.Character", t => t.CharacterId, cascadeDelete: true)
                .Index(t => t.CharacterId)
                .Index(t => t.AffiliationId);
            
            CreateTable(
                "dbo.Affiliation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Group = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CharacterAffiliation", "CharacterId", "dbo.Character");
            DropForeignKey("dbo.CharacterAffiliation", "AffiliationId", "dbo.Affiliation");
            DropIndex("dbo.CharacterAffiliation", new[] { "AffiliationId" });
            DropIndex("dbo.CharacterAffiliation", new[] { "CharacterId" });
            DropTable("dbo.Affiliation");
            DropTable("dbo.CharacterAffiliation");
        }
    }
}
