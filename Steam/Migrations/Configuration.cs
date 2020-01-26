namespace Steam.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Steam.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Steam.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Steam.Models.ApplicationDbContext context)
        {
            //DOTA 2


           /* string Dota2Description = "The most-played game on Steam. Every day, millions of players worldwide" +
                " enter battle as one of over a hundred Dota heroes. And no matter if it's their 10th hour of" +
                " play or 1,000th, there's always something new to discover.With regular updates that ensure" +
                " a constant evolution of gameplay, features, and heroes, Dota 2 has truly taken on a life of its own. " +
                "When it comes to diversity of heroes, abilities, and powerful items, Dota boasts an endless" +
                " array—no two games are the same. Any hero can fill multiple roles, and there's an abundance" +
                " of items to help meet the needs of each game. Dota doesn't provide limitations on how to play," +
                " it empowers you to express your own style. Competitive balance is Dota's crown jewel, and to" +
                " ensure everyone is playing on an even field, the core content of the game—like the vast pool" +
                " of heroes—is available to all players. Fans can collect cosmetics for heroes and fun add-ons" +
                " for the world they inhabit, but everything you need to play is already included before you join" +
                " your first match. Dota is deep, and constantly evolving, but it's never too late to join. " +
                "Learn the ropes playing co - op vs.bots.Sharpen your skills in the hero demo mode. " +
                "Jump into the behavior-and skill - based matchmaking system that ensures you'll" +
                "be matched with the right players each game.";
            string Dota2Name = "Dota2";
            string Dota2Developer = "VALVE Corporation";
            DateTime Dota2Date = DateTime.Now;
            float Dota2Price = 0f;
            GameImage Dota2Image = new GameImage("https://www.elsetge.cat/myimg/f/41-418602_dota-2-logo-wallpaper-hd.jpg");


            //Magicka 2

            string Magicka2Description = "The world’s most irreverent co-op action adventure returns!" +
                " In the next chapter of Magicka, players ascend from the ruins of Aldrheim to experience" +
                " a Midgård almost wiped free of Wizards after the Wizard Wars, with the few that do remain" +
                " having either gone mad or extremely hostile toward all others.To rid the world of evil, again," +
                " up to four Wizards, and their guide Vlad, will traverse Midgård armed with the next iteration" +
                " of the famous Magicka dynamic spellcasting system, as players reprise their roles as the most overpowered," +
                " unpredictably funny Wizards ever known to fantasy!";
            string Magicka2Name = "Magicka2";
            string Magicka2Developer = "Piece Interactive";
            DateTime Magicka2Date = DateTime.Now;
            float Magicka2Price = 14.99f;
            GameImage Magicka2Image = new GameImage("https://vistapointe.net/images/magicka-2-wallpaper-7.jpg");

            //Supraland

            string SupralandDescripton = "Supraland is a First-Person Metroidvania Puzzle game. The main sources of inspiration are Zelda," +
                " Metroid and Portal.Supraland assumes that you are intelligent and lets you play independently. The story is minimal," +
                " gives you an overarching goal to pursue, and then sets you free. Despite child friendly visuals," +
                " the game targets experienced players. Playtime: ~12-25h";
            string SupralandName = "Supraland";
            string SupralandDeveloper = "Supra Games";
            DateTime SupralandDate = DateTime.Now;
            float SupralandPrice = 19.99f;
            GameImage SupralandImage = new GameImage("https://cdkeyprices.com/images/games/675835/cover.jpg");


            // Witcher 3 

            string Witcher3Description = "The Witcher: Wild Hunt is a story-driven open world RPG set in a visually stunning fantasy universe" +
                " full of meaningful choices and impactful consequences. In The Witcher, you play as professional monster hunter Geralt of Rivia" +
                " tasked with finding a child of prophecy in a vast open world rich with merchant cities, pirate islands, dangerous mountain passes," +
                " and forgotten caverns to explore.";
            string Witcher3Name = "Witcher3";
            string Witcher3Developer = "CD PROJEKT RED";
            DateTime Witcher3Date = DateTime.Now;
            float Witcher3Price = 29.99f;
            GameImage Witcher3Image = new GameImage("https://images5.alphacoders.com/916/916526.jpg");



            // BorderOfficer

            string BorderOfficerDescription = "Usually everyone is unemployed here. But by chance you got a job. You'il work for the state." +
                "Everyone in your family is sick or unemployed, only you can help them. You're an immigrant officer." +
                "The state assigned you a car and a house. The whole economy is in your hands." +
                "You have to spend your salary in the most efficient way. Sometimes you have to sacrifice some to survive." +
                "You can join the secret organization if you want to interfere in the affairs of the state." +
                "You can only work for the welfare of the family if you want. If you trust your luck, you could be rich in luck games." +
                "You have to decide who can enter and who can not enter Stavronzkaya. The state publishes new announcements according" +
                " to their own interests and changes the rules accordingly. You should follow these announcements and question people" +
                " according to the rules.";
            string BorderOfficerName = "BorderOfficer";
            string BorderOfficerDeveloper = "Cocopo";
            DateTime BorderOfficerDate = DateTime.Now;
            float BorderOfficerPrice = 8.19f;
            GameImage BorderOfficerImage = new GameImage("https://www.wasdzone.com/wp-content/uploads/2019/12/Border-Officer_sistem_gereksinimleri-768x432.jpg");

            // DIRT 4

            string Dirt4Description = "Motorsport by its very nature is dangerous. DiRT 4 is all about embracing that danger." +
               " It’s about the thrill, exhilaration and adrenaline that is absolutely vital to off-road racing. And more than that," +
               " it’s about loving that feeling. It’s about pushing flat out next to a sheer cliff drop. Going for the gap that’s slightly too small." +
               " Seeing how much air you can get in a truck. They call it ‘being fearless’.DiRT 4 also features a game-changing system called Your Stage," +
               " an innovative rally route creation tool that allows you to produce an almost-infinite number of unique stages at the press of a button." +
               " You choose your location and set the route parameters, then Your Stage does the hard work to create a unique rally stage that you can race," +
               " share with your friends and then challenge them to beat your time. Your Stage allows experienced rally players to create longer, more technical routes," +
               " whilst newcomers can create simpler shorter routes as they hone their skills. ";
            string Dirt4Name = "Dirt4";
            string Dirt4Developer = "Codemasters";
            DateTime Dirt4Date = DateTime.Now;
            float Dirt4Price = 54.99f;
            GameImage Dirt4Image = new GameImage("https://www.seven-gamers.com/wp-content/uploads/dirt-4-logo2.jpg");

            // HENTAI

            string HentaiDescription = "As supreme military general, lead your girls to against enemy and take back freedom for your planet...";
            string HentaiName = "Hentai";
            string HentaiDeveloper = "Mature Games";
            DateTime HentaiDate = DateTime.Now;
            float HentaiPrice = 1.59f;
            GameImage HentaiImage = new GameImage("https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_26a759c7e3dc1b5c2928a0e6a531026166871b3f.1920x1080.jpg?t=1566268407");

            // TombRaider

            string TombRaiderDescription = "Experience Lara Croft’s defining moment as she becomes the Tomb Raider." +
                " In Shadow of the Tomb Raider, Lara must master a deadly jungle, overcome terrifying tombs," +
                " and persevere through her darkest hour. As she races to save the world from a Maya apocalypse," +
                " Lara will ultimately be forged into the Tomb Raider she is destined to be.";
            string TombRaiderName = "TombRaider";
            string TombRaiderDeveloper = "Eidos-Montreal";
            DateTime TombRaiderDate = DateTime.Now;
            float TombRaiderPrice = 59.99f;
            GameImage TombRaiderImage = new GameImage("https://cdn.wallpapersafari.com/94/95/QhfcMJ.jpg");

            //Slender

            string SlenderDescription = "You're on your own. No one to come for you. No one to help you. No one to hear you scream." +
                " Slender: The Arrival is the official videogame adaption of Slender Man, developed in collaboration with Eric \"Victor Surge\" Knudson," +
                " creator of the paranormal phenomenon that has been terrifying the curious-minded around the world since its inception, with Mark Hadley and Blue Isle Studios.";
            string SlenderName = "Slender";
            string SlenderDeveloper = "Blue Isle Studios";
            DateTime SlenderDate = DateTime.Now;
            float SlenderPrice = 9.99f;
            GameImage SlenderImage = new GameImage("https://image.tmdb.org/t/p/w1280/m28bl4gFE46W2RyTm3Gc7uP5ctq.jpg");

            //Games

            Game Dota2 = new Game(Dota2Name, Dota2Price, Dota2Description, Dota2Developer, Dota2Image);
            Game BorderOfficer = new Game(BorderOfficerName, BorderOfficerPrice, BorderOfficerDescription, BorderOfficerDeveloper, BorderOfficerImage);
            Game Dirt4 = new Game(Dirt4Name, Dirt4Price, Dirt4Description, Dirt4Developer, Dirt4Image);
            Game Hentai = new Game(HentaiName, HentaiPrice, HentaiDescription, HentaiDeveloper, HentaiImage);
            Game Magicka2 = new Game(Magicka2Name, Magicka2Price, Magicka2Description, Magicka2Developer, Magicka2Image);
            Game Slender = new Game(SlenderName, SlenderPrice, SlenderDescription, SlenderDeveloper, SlenderImage);
            Game Supraland = new Game(SupralandName, SupralandPrice, SupralandDescripton, SupralandDeveloper, SupralandImage);
            Game TombRaider = new Game(TombRaiderName, TombRaiderPrice, TombRaiderDescription, TombRaiderDeveloper, TombRaiderImage);
            Game Witcher3 = new Game(Witcher3Name, Witcher3Price, Witcher3Description, Witcher3Developer, Witcher3Image);

            //if (!System.Diagnostics.Debugger.IsAttached)
            //    System.Diagnostics.Debugger.Launch();

            List<Game> Games = new List<Game> { Dota2, BorderOfficer, Dirt4, Hentai, Magicka2, Slender, Supraland, TombRaider, Witcher3 };
            Games.ForEach(g => context.Games.AddOrUpdate(g));


            //GameImages

            //List<GameImage> Dota2Images = new List<> {
            //new GameImage()};


            context.SaveChanges();*/

        }
    }
}
