namespace GoTAPI.Data.Migrations
{
    using GoTAPI.Data.DataClasses;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoTAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GoTAPI.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Houses.AddOrUpdate(
                h => h.Name,
                new House { Name = "Stark", Sigil = "A grey direwolf on a white field", Words = "Winter Is Coming", Region = "The North" },
                new House { Name = "Lannister", Sigil = "A golden lion rampant on a crimson field", Words = "Hear Me Roar", Region = "The Westerlands" },
                new House { Name = "Targaryen", Sigil = "A red three-headed dragon, on a black field", Words = "Fire and Blood", Region = "The Crownlands" },
                new House { Name = "Baratheon", Sigil = "A crowned black stag salient on a gold field", Words = "Ours Is the Fury", Region = "The Stormlands" },
                new House { Name = "Baratheon of King's Landing", Sigil = "The crowned stag of Baratheon black on gold and the lion of Lannister golden on red", Words = "Ours Is the Fury", Region = "The Crownlands" },
                new House { Name = "Baratheon of Dragonstone", Sigil = "The crowned black stag of Baratheon enclosed within the fiery red heart of the Lord of the Light", Words = "Ours is the Fury", Region = "The Stormlands" },
                new House { Name = "Tyrell", Sigil = "A golden rose on a green field", Words = "Growing Strong", Region = "The Reach" },
                new House { Name = "Martell", Sigil = "A red sun pierced by a gold spear, on an orange field", Words = "Unbowed, Unbent, Unbroken", Region = "Dome" },
                new House { Name = "Tully", Sigil = "A silver trout leaping on a red and blue background", Words = "Family, Duty, Honor", Region = "The Riverlands" },
                new House { Name = "Arryn", Sigil = "A white falcon volant and crescent moon on a blue field", Words = "As High as Honor", Region = "The Vale of Arryn" },
                new House { Name = "Greyjoy", Sigil = "A golden kraken on a black field", Words = "We Do Not Sow", Region = "Iron Islands" },
                new House { Name = "Frey", Sigil = "The two stone grey towers and bridge of the Twins, on a dark grey field, surmounting an escutcheon of blue water", Words = "We Stand Together", Region = "The Riverlands" },
                new House { Name = "Bolton", Sigil = "A red flayed man, hanging upside-down on a white X-shaped cross, on a black background", Words = "Our Blades Are Sharp", Region = "The North" });
            context.SaveChanges();
            context.Characters.AddOrUpdate(
                c => c.Name,
                new Character { HouseId = 2, Name = "Tyrion Lannister", Alive = true, EpisodeOfDeath = null, Gender = "Male", Actor = "Peter Dinklage", CauseOfDeath = "N/A" },
                new Character { HouseId = 2, Name = "Cersei Lannister", Alive = false, EpisodeOfDeath = 72, Gender = "Female", Actor = "Lena Headey", CauseOfDeath = "N/A" },
                new Character { HouseId = 3, Name = "Daenerys Targaryen", Alive = false, EpisodeOfDeath = 73, Gender = "Female", Actor = "Emilia Clarke", CauseOfDeath = "N/A" },
                new Character { HouseId = 1, Name = "Jon Snow", Alive = true, EpisodeOfDeath = null, Gender = "Male", Actor = "Kit Harington", CauseOfDeath = "N/A" },
                new Character { HouseId = 1, Name = "Sansa Stark", Alive = true, EpisodeOfDeath = null, Gender = "Female", Actor = "Sophie Turner", CauseOfDeath = "N/A" },
                new Character { HouseId = 1, Name = "Arya Stark", Alive = true, EpisodeOfDeath = null, Gender = "Female", Actor = "Maisie Williams", CauseOfDeath = "N/A" },
                new Character { HouseId = 2, Name = "Jaime Lannister", Alive = false, EpisodeOfDeath = 72, Gender = "Male", Actor = "Nikolaj Coster-Waldau", CauseOfDeath = "N/A" },

                //new Character { HouseId = 18, Name = "Jorah Mormont", Alive = false, EpisodeOfDeath = 70, Gender = "Male", Actor = "Peter Dinklage", CauseOfDeath = "N/A" },
                //new Character { HouseId = 19, Name = "Samwell Tarly", Alive = true, EpisodeOfDeath = null, Gender = "Male", Actor = "Peter Dinklage", CauseOfDeath = "N/A" },
                new Character { HouseId = 11, Name = "Theon Greyjoy", Alive = true, EpisodeOfDeath = null, Gender = "Male", Actor = "Alfie Allen", CauseOfDeath = "N/A" });
            context.SaveChanges();

            context.Episodes.AddOrUpdate(
                c => c.Title,
                new Episode { Season = 1, EpisodeNumber = 1, Title = "Winter is Coming", RunTime = 62 },
                new Episode { Season = 1, EpisodeNumber = 2, Title = "The Kingsroad", RunTime = 56 },
                new Episode { Season = 1, EpisodeNumber = 3, Title = "Lord Snow", RunTime = 58 },
                new Episode { Season = 1, EpisodeNumber = 4, Title = "Cripples, Bastards, and Broken Things", RunTime = 56 },
                new Episode { Season = 1, EpisodeNumber = 5, Title = "The Wolf and the Lion", RunTime = 55 },
                new Episode { Season = 1, EpisodeNumber = 6, Title = "A Golden Crown", RunTime = 53 },
                new Episode { Season = 1, EpisodeNumber = 7, Title = "You Win or You Die", RunTime = 58 },
                new Episode { Season = 1, EpisodeNumber = 8, Title = "The Pointy End", RunTime = 59 },
                new Episode { Season = 1, EpisodeNumber = 9, Title = "Baelor", RunTime = 57 },
                new Episode { Season = 1, EpisodeNumber = 10, Title = "Fire and Blood", RunTime = 53 },
                new Episode { Season = 2, EpisodeNumber = 1, Title = "The North Remembers", RunTime = 53 },
                new Episode { Season = 2, EpisodeNumber = 2, Title = "The Night Lands", RunTime = 54 },
                new Episode { Season = 2, EpisodeNumber = 3, Title = "What is Dead May Never Die", RunTime = 53 },
                new Episode { Season = 2, EpisodeNumber = 4, Title = "Garden of Bones", RunTime = 51 },
                new Episode { Season = 2, EpisodeNumber = 5, Title = "The Ghost of Harrenhal", RunTime = 55 },
                new Episode { Season = 2, EpisodeNumber = 6, Title = "The Old Gods and the New", RunTime = 54 },
                new Episode { Season = 2, EpisodeNumber = 7, Title = "A Man Without Honor", RunTime = 56 },
                new Episode { Season = 2, EpisodeNumber = 8, Title = "The Prince of Winterfell", RunTime = 54 },
                new Episode { Season = 2, EpisodeNumber = 9, Title = "Blackwater", RunTime = 55 },
                new Episode { Season = 2, EpisodeNumber = 10, Title = "Valar Morghulis", RunTime = 64 },
                new Episode { Season = 3, EpisodeNumber = 1, Title = "Valer Dohaeris", RunTime = 55 },
                new Episode { Season = 3, EpisodeNumber = 2, Title = "Dark WIngs, Dark Words", RunTime = 57 },
                new Episode { Season = 3, EpisodeNumber = 3, Title = "Walk of Punishment", RunTime = 53 },
                new Episode { Season = 3, EpisodeNumber = 4, Title = "And Now His Watch is Ended", RunTime = 54 },
                new Episode { Season = 3, EpisodeNumber = 5, Title = "Kissed by Fire", RunTime = 58 },
                new Episode { Season = 3, EpisodeNumber = 6, Title = "The Climb", RunTime = 53 },
                new Episode { Season = 3, EpisodeNumber = 7, Title = "The Bear and the Maiden Fair", RunTime = 57 },
                new Episode { Season = 3, EpisodeNumber = 8, Title = "Second Sons", RunTime = 56 },
                new Episode { Season = 3, EpisodeNumber = 9, Title = "The Rains of Castamere", RunTime = 52 },
                new Episode { Season = 3, EpisodeNumber = 10, Title = "Mhysa", RunTime = 62 },
                new Episode { Season = 4, EpisodeNumber = 1, Title = "Two Swords", RunTime = 58 },
                new Episode { Season = 4, EpisodeNumber = 2, Title = "The Lion and the Rose", RunTime = 52 },
                new Episode { Season = 4, EpisodeNumber = 3, Title = "Breaker of Chains", RunTime = 57 },
                new Episode { Season = 4, EpisodeNumber = 4, Title = "Oathkeeper", RunTime = 55 },
                new Episode { Season = 4, EpisodeNumber = 5, Title = "First of His Name", RunTime = 53 },
                new Episode { Season = 4, EpisodeNumber = 6, Title = "The Laws of Gods and Men", RunTime = 50 },
                new Episode { Season = 4, EpisodeNumber = 7, Title = "Mockingbird", RunTime = 51 },
                new Episode { Season = 4, EpisodeNumber = 8, Title = "The Mountain and the Viper", RunTime = 52 },
                new Episode { Season = 4, EpisodeNumber = 9, Title = "The Watchers on the Wall", RunTime = 50 },
                new Episode { Season = 4, EpisodeNumber = 10, Title = "The Children", RunTime = 65 },
                new Episode { Season = 5, EpisodeNumber = 1, Title = "The Wars to Come", RunTime = 52 },
                new Episode { Season = 5, EpisodeNumber = 2, Title = "The House of Black and White", RunTime = 55 },
                new Episode { Season = 5, EpisodeNumber = 3, Title = "High Sparrow", RunTime = 60 },
                new Episode { Season = 5, EpisodeNumber = 4, Title = "Sons of the Harpy", RunTime = 50 },
                new Episode { Season = 5, EpisodeNumber = 5, Title = "Kill the Boy", RunTime = 57 },
                new Episode { Season = 5, EpisodeNumber = 6, Title = "Unbowed, Unbent, Unbroken", RunTime = 54 },
                new Episode { Season = 5, EpisodeNumber = 7, Title = "The Gift", RunTime = 59 },
                new Episode { Season = 5, EpisodeNumber = 8, Title = "Hardhome", RunTime = 60 },
                new Episode { Season = 5, EpisodeNumber = 9, Title = "The Dance of Dragons", RunTime = 53 },
                new Episode { Season = 5, EpisodeNumber = 10, Title = "Mother's Mercy", RunTime = 61 },
                new Episode { Season = 6, EpisodeNumber = 1, Title = "The Red Woman", RunTime = 50 },
                new Episode { Season = 6, EpisodeNumber = 2, Title = "Home", RunTime = 54 },
                new Episode { Season = 6, EpisodeNumber = 3, Title = "Oathbreaker", RunTime = 53 },
                new Episode { Season = 6, EpisodeNumber = 4, Title = "Book of the Stranger", RunTime = 59 },
                new Episode { Season = 6, EpisodeNumber = 5, Title = "The Door", RunTime = 57 },
                new Episode { Season = 6, EpisodeNumber = 6, Title = "Blood of My Blood", RunTime = 52 },
                new Episode { Season = 6, EpisodeNumber = 7, Title = "The Broken Man", RunTime = 51 },
                new Episode { Season = 6, EpisodeNumber = 8, Title = "No One", RunTime = 59 },
                new Episode { Season = 6, EpisodeNumber = 9, Title = "Battle of the Bastards", RunTime = 60 },
                new Episode { Season = 6, EpisodeNumber = 10, Title = "The Winds of Winter", RunTime = 68 },
                new Episode { Season = 7, EpisodeNumber = 1, Title = "Dragonstone", RunTime = 59 },
                new Episode { Season = 7, EpisodeNumber = 2, Title = "Stormborn", RunTime = 59 },
                new Episode { Season = 7, EpisodeNumber = 3, Title = "The Queen's Justice", RunTime = 63 },
                new Episode { Season = 7, EpisodeNumber = 4, Title = "The Spoils of War", RunTime = 50 },
                new Episode { Season = 7, EpisodeNumber = 5, Title = "Eastwatch", RunTime = 59 },
                new Episode { Season = 7, EpisodeNumber = 6, Title = "Beyond the Wall", RunTime = 70 },
                new Episode { Season = 7, EpisodeNumber = 7, Title = "The Dragon and the Wolf", RunTime = 80 },
                new Episode { Season = 8, EpisodeNumber = 1, Title = "Winterfell", RunTime = 54 },
                new Episode { Season = 8, EpisodeNumber = 2, Title = "A Knight of the Seven Kingdoms", RunTime = 58 },
                new Episode { Season = 8, EpisodeNumber = 3, Title = "The Long Night", RunTime = 82 },
                new Episode { Season = 8, EpisodeNumber = 4, Title = "The Last of the Starks", RunTime = 78 },
                new Episode { Season = 8, EpisodeNumber = 5, Title = "The Bells", RunTime = 78 },
                new Episode { Season = 8, EpisodeNumber = 6, Title = "The Iron Throne", RunTime = 79 });
        }
    }
}
