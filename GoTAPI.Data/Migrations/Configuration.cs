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
                new House { Name = "Stark", Sigil = "A grey direwolf on a white field", Words = "Winter Is Coming" },
                new House { Name = "Lannister", Sigil = "A golden lion rampant on a crimson field", Words = "Hear Me Roar" },
                new House { Name = "Targaryen", Sigil = "A red three-headed dragon, on a black field", Words = "Fire and Blood" },
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
        }
    }
}
