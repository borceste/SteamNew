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

            /*
                       string Dota2Description = "The most-played game on Steam. Every day, millions of players worldwide" +
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
                        string Dota2ShortDescription = "The most-played game on Steam. Every day, millions of players worldwide" +
                            " enter battle as one of over a hundred Dota heroes.";
                        string Dota2Name = "Dota2";
                        string Dota2Developer = "VALVE Corporation";
                        DateTime Dota2Date = DateTime.Now;
                        float Dota2Price = 0f;
                        String Dota2Image = "https://www.elsetge.cat/myimg/f/41-418602_dota-2-logo-wallpaper-hd.jpg";


                        //Magicka 2

                        string Magicka2Description = "The world’s most irreverent co-op action adventure returns!" +
                            " In the next chapter of Magicka, players ascend from the ruins of Aldrheim to experience" +
                            " a Midgård almost wiped free of Wizards after the Wizard Wars, with the few that do remain" +
                            " having either gone mad or extremely hostile toward all others.To rid the world of evil, again," +
                            " up to four Wizards, and their guide Vlad, will traverse Midgård armed with the next iteration" +
                            " of the famous Magicka dynamic spellcasting system, as players reprise their roles as the most overpowered," +
                            " unpredictably funny Wizards ever known to fantasy!";
                        string Magicka2ShortDescription = "In the next chapter of Magicka, players ascend from the ruins of Aldrheim to experience" +
                            " a Midgård almost wiped free of Wizards after the Wizard Wars, with the few that do remain" +
                            " having either gone mad or extremely hostile toward all others.";
                        string Magicka2Name = "Magicka2";
                        string Magicka2Developer = "Piece Interactive";
                        DateTime Magicka2Date = DateTime.Now;
                        float Magicka2Price = 14.99f;
                        String Magicka2Image = "https://vistapointe.net/images/magicka-2-wallpaper-7.jpg";

                        //Supraland

                        string SupralandDescripton = "Supraland is a First-Person Metroidvania Puzzle game. The main sources of inspiration are Zelda," +
                            " Metroid and Portal.Supraland assumes that you are intelligent and lets you play independently. The story is minimal," +
                            " gives you an overarching goal to pursue, and then sets you free. Despite child friendly visuals," +
                            " the game targets experienced players. Playtime: ~12-25h";
                        string SupralandShortDescription = "Supraland is a First-Person Metroidvania Puzzle game. The main sources of inspiration are Zelda," +
                            " Metroid and Portal.";
                        string SupralandName = "Supraland";
                        string SupralandDeveloper = "Supra Games";
                        DateTime SupralandDate = DateTime.Now;
                        float SupralandPrice = 19.99f;
                        String SupralandImage = "https://cdkeyprices.com/images/games/675835/cover.jpg";


                        // Witcher 3 

                        string Witcher3Description = "The Witcher: Wild Hunt is a story-driven open world RPG set in a visually stunning fantasy universe" +
                            " full of meaningful choices and impactful consequences. In The Witcher, you play as professional monster hunter Geralt of Rivia" +
                            " tasked with finding a child of prophecy in a vast open world rich with merchant cities, pirate islands, dangerous mountain passes," +
                            " and forgotten caverns to explore.";
                        string Witcher3ShortDescription = "The Witcher: Wild Hunt is a story-driven open world RPG set in a visually stunning fantasy universe" +
                            " full of meaningful choices and impactful consequences.";
                        string Witcher3Name = "Witcher3";
                        string Witcher3Developer = "CD PROJEKT RED";
                        DateTime Witcher3Date = DateTime.Now;
                        float Witcher3Price = 29.99f;
                        String Witcher3Image = "https://images5.alphacoders.com/916/916526.jpg";



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
                        string BorderOfficerShortDescription = "Usually everyone is unemployed here. But by chance you got a job. You'il work for the state." +
                            "Everyone in your family is sick or unemployed, only you can help them.";
                        string BorderOfficerName = "BorderOfficer";
                        string BorderOfficerDeveloper = "Cocopo";
                        DateTime BorderOfficerDate = DateTime.Now;
                        float BorderOfficerPrice = 8.19f;
                        String BorderOfficerImage = "https://i.imgur.com/KYd9zZq.png";

                        // DIRT 4

                        string Dirt4Description = "Motorsport by its very nature is dangerous. DiRT 4 is all about embracing that danger." +
                           " It’s about the thrill, exhilaration and adrenaline that is absolutely vital to off-road racing. And more than that," +
                           " it’s about loving that feeling. It’s about pushing flat out next to a sheer cliff drop. Going for the gap that’s slightly too small." +
                           " Seeing how much air you can get in a truck. They call it ‘being fearless’.DiRT 4 also features a game-changing system called Your Stage," +
                           " an innovative rally route creation tool that allows you to produce an almost-infinite number of unique stages at the press of a button." +
                           " You choose your location and set the route parameters, then Your Stage does the hard work to create a unique rally stage that you can race," +
                           " share with your friends and then challenge them to beat your time. Your Stage allows experienced rally players to create longer, more technical routes," +
                           " whilst newcomers can create simpler shorter routes as they hone their skills. ";
                        string Dirt4ShortDescription = "Motorsport by its very nature is dangerous. DiRT 4 is all about embracing that danger." +
                           " It’s about the thrill, exhilaration and adrenaline that is absolutely vital to off-road racing.";
                        string Dirt4Name = "Dirt4";
                        string Dirt4Developer = "Codemasters";
                        DateTime Dirt4Date = DateTime.Now;
                        float Dirt4Price = 54.99f;
                        String Dirt4Image = "https://www.seven-gamers.com/wp-content/uploads/dirt-4-logo2.jpg";

                        // HENTAI

                        string HentaiDescription = "As supreme military general, lead your girls to against enemy and take back freedom for your planet...";
                        string HentaiShortDescription = "As supreme military general, lead your girls to against enemy and take back freedom for your planet...";

                        string HentaiName = "Hentai";
                        string HentaiDeveloper = "Mature Games";
                        DateTime HentaiDate = DateTime.Now;
                        float HentaiPrice = 1.59f;
                        String HentaiImage = "https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_26a759c7e3dc1b5c2928a0e6a531026166871b3f.1920x1080.jpg?t=1566268407";

                        // TombRaider

                        string TombRaiderDescription = "Experience Lara Croft’s defining moment as she becomes the Tomb Raider." +
                            " In Shadow of the Tomb Raider, Lara must master a deadly jungle, overcome terrifying tombs," +
                            " and persevere through her darkest hour. As she races to save the world from a Maya apocalypse," +
                            " Lara will ultimately be forged into the Tomb Raider she is destined to be.";
                        string TombRaiderShortDescription = "Experience Lara Croft’s defining moment as she becomes the Tomb Raider.";
                        string TombRaiderName = "TombRaider";
                        string TombRaiderDeveloper = "Eidos-Montreal";
                        DateTime TombRaiderDate = DateTime.Now;
                        float TombRaiderPrice = 59.99f;
                        String TombRaiderImage = "https://cdn.wallpapersafari.com/94/95/QhfcMJ.jpg";

                        //Slender

                        string SlenderDescription = "You're on your own. No one to come for you. No one to help you. No one to hear you scream." +
                            " Slender: The Arrival is the official videogame adaption of Slender Man, developed in collaboration with Eric \"Victor Surge\" Knudson," +
                            " creator of the paranormal phenomenon that has been terrifying the curious-minded around the world since its inception, with Mark Hadley and Blue Isle Studios.";
                        string SlenderShortDescription = "You're on your own. No one to come for you. No one to help you. No one to hear you scream.";
                        string SlenderName = "Slender";
                        string SlenderDeveloper = "Blue Isle Studios";
                        DateTime SlenderDate = DateTime.Now;
                        float SlenderPrice = 9.99f;
                        String SlenderImage = "https://image.tmdb.org/t/p/w1280/m28bl4gFE46W2RyTm3Gc7uP5ctq.jpg";

                        //Games

                        Game Dota2 = new Game(Dota2Name, Dota2Price, Dota2Description, Dota2ShortDescription , Dota2Developer, Dota2Image);
                        Game BorderOfficer = new Game(BorderOfficerName, BorderOfficerPrice, BorderOfficerDescription, BorderOfficerShortDescription, BorderOfficerDeveloper, BorderOfficerImage);
                        Game Dirt4 = new Game(Dirt4Name, Dirt4Price, Dirt4Description, Dirt4ShortDescription, Dirt4Developer, Dirt4Image);
                        Game Hentai = new Game(HentaiName, HentaiPrice, HentaiDescription, HentaiShortDescription, HentaiDeveloper, HentaiImage);
                        Game Magicka2 = new Game(Magicka2Name, Magicka2Price, Magicka2Description, Magicka2ShortDescription, Magicka2Developer, Magicka2Image);
                        Game Slender = new Game(SlenderName, SlenderPrice, SlenderDescription, SlenderShortDescription, SlenderDeveloper, SlenderImage);
                        Game Supraland = new Game(SupralandName, SupralandPrice, SupralandDescripton, SupralandShortDescription, SupralandDeveloper, SupralandImage);
                        Game TombRaider = new Game(TombRaiderName, TombRaiderPrice, TombRaiderDescription, TombRaiderShortDescription, TombRaiderDeveloper, TombRaiderImage);
                        Game Witcher3 = new Game(Witcher3Name, Witcher3Price, Witcher3Description, Witcher3ShortDescription, Witcher3Developer, Witcher3Image);

                        //if (!System.Diagnostics.Debugger.IsAttached)
                        //    System.Diagnostics.Debugger.Launch();

                        List<Game> Games = new List<Game> { Dota2, BorderOfficer, Dirt4, Hentai, Magicka2, Slender, Supraland, TombRaider, Witcher3 };
                        Games.ForEach(g => context.Games.AddOrUpdate(g));


                        //GameImages

                        //List<GameImage> Dota2Images = new List<> {
                        //new GameImage()};



           


            
                        List<GameImage> Dota2Images = new List<GameImage>();
                        List<GameImage> BorderOfficerImages = new List<GameImage>();
                        List<GameImage> Dirt4Images = new List<GameImage>();
                        List<GameImage> HentaiImages = new List<GameImage>();
                        List<GameImage> Magicka2Images = new List<GameImage>();
                        List<GameImage> SlenderImages = new List<GameImage>();
                        List<GameImage> SupralandImages = new List<GameImage>();
                        List<GameImage> TombRaiderImages = new List<GameImage>();
                        List<GameImage> Witcher3Images = new List<GameImage>();


                        //ADD IMAGES !!!

                        Dota2Images.Add(new GameImage(1, "https://steamcdn-a.akamaihd.net/steam/apps/570/ss_86d675fdc73ba10462abb8f5ece7791c5047072c.1920x1080.jpg?t=1561594389"));
                        Dota2Images.Add(new GameImage(1, "https://steamcdn-a.akamaihd.net/steam/apps/570/ss_ad8eee787704745ccdecdfde3a5cd2733704898d.1920x1080.jpg?t=1561594389"));
                        Dota2Images.Add(new GameImage(1, "https://steamcdn-a.akamaihd.net/steam/apps/570/ss_7ab506679d42bfc0c0e40639887176494e0466d9.1920x1080.jpg?t=1561594389"));
                        Dota2Images.Add(new GameImage(1, "https://steamcdn-a.akamaihd.net/steam/apps/570/ss_c9118375a2400278590f29a3537769c986ef6e39.1920x1080.jpg?t=1561594389"));
                        Dota2Images.Add(new GameImage(1, "https://steamcdn-a.akamaihd.net/steam/apps/570/ss_f9ebafedaf2d5cfb80ef1f74baa18eb08cad6494.1920x1080.jpg?t=1561594389"));

                        Dota2Images.ForEach(i => context.GameImages.AddOrUpdate(i));

                        Magicka2Images.Add(new GameImage(5, "https://steamcdn-a.akamaihd.net/steam/apps/238370/ss_41b744c738cc2d394378ccd1b1bf5e1db0163b64.1920x1080.jpg?t=1561043582"));
                        Magicka2Images.Add(new GameImage(5, "https://steamcdn-a.akamaihd.net/steam/apps/238370/ss_ab78099a447154ad202a1043a2a051c35df7a586.1920x1080.jpg?t=1561043582"));
                        Magicka2Images.Add(new GameImage(5, "https://steamcdn-a.akamaihd.net/steam/apps/238370/ss_b270b4da37c5fd3daa6c0d9d2b75064f32679556.1920x1080.jpg?t=1561043582"));
                        Magicka2Images.Add(new GameImage(5, "https://steamcdn-a.akamaihd.net/steam/apps/238370/ss_acc283cf39ad175376cc75fd718a8738e3d91372.1920x1080.jpg?t=1561043582"));
                        Magicka2Images.Add(new GameImage(5, "https://steamcdn-a.akamaihd.net/steam/apps/238370/ss_1af2c0b9659e116ed200c994900074e496ef1d07.1920x1080.jpg?t=1561043582"));

                        Magicka2Images.ForEach(i => context.GameImages.AddOrUpdate(i));

                        SupralandImages.Add(new GameImage(7, "https://steamcdn-a.akamaihd.net/steam/apps/813630/ss_2196cce530d054f647b35d4603cf89cc1f562f6a.1920x1080.jpg?t=1562607587"));
                        SupralandImages.Add(new GameImage(7, "https://steamcdn-a.akamaihd.net/steam/apps/813630/ss_2595c90ee1a524d1f4a21f4012bfcae4af544945.1920x1080.jpg?t=1562607587"));
                        SupralandImages.Add(new GameImage(7, "https://steamcdn-a.akamaihd.net/steam/apps/813630/ss_8a01de634e5470eb32db61772870a91693f576e2.1920x1080.jpg?t=1562607587"));
                        SupralandImages.Add(new GameImage(7, "https://steamcdn-a.akamaihd.net/steam/apps/813630/ss_f2973b56bcd8786c8643163179f3fd155836448a.1920x1080.jpg?t=1562607587"));
                        SupralandImages.Add(new GameImage(7, "https://steamcdn-a.akamaihd.net/steam/apps/813630/ss_ed174e05edfcdf307b349760969e0c00173cb02b.1920x1080.jpg?t=1562607587"));

                        SupralandImages.ForEach(i => context.GameImages.AddOrUpdate(i));

                        Witcher3Images.Add(new GameImage(9, "https://steamcdn-a.akamaihd.net/steam/apps/292030/ss_107600c1337accc09104f7a8aa7f275f23cad096.1920x1080.jpg?t=1550078557"));
                        Witcher3Images.Add(new GameImage(9, "https://steamcdn-a.akamaihd.net/steam/apps/292030/ss_64eb760f9a2b67f6731a71cce3a8fb684b9af267.1920x1080.jpg?t=1550078557"));
                        Witcher3Images.Add(new GameImage(9, "https://steamcdn-a.akamaihd.net/steam/apps/292030/ss_eda99e7f705a113d04ab2a7a36068f3e7b343d17.1920x1080.jpg?t=1550078557"));
                        Witcher3Images.Add(new GameImage(9, "https://steamcdn-a.akamaihd.net/steam/apps/292030/ss_d5b80eb63c12a6484f26796f3e34410651bba068.1920x1080.jpg?t=1550078557"));
                        Witcher3Images.Add(new GameImage(9, "https://steamcdn-a.akamaihd.net/steam/apps/292030/ss_b74d60ee215337d765e4d20c8ca6710ae2362cc2.1920x1080.jpg?t=1550078557"));

                        Witcher3Images.ForEach(i => context.GameImages.AddOrUpdate(i));

                        BorderOfficerImages.Add(new GameImage(2, "https://steamcdn-a.akamaihd.net/steam/apps/1057180/ss_5294f17cc17afa2b009271c2178cd26301c2db4c.1920x1080.jpg?t=1565336368"));
                        BorderOfficerImages.Add(new GameImage(2, "https://steamcdn-a.akamaihd.net/steam/apps/1057180/ss_7ac9ee9e4b965648fd6296fae2da699d2893eb53.1920x1080.jpg?t=1565336368"));
                        BorderOfficerImages.Add(new GameImage(2, "https://steamcdn-a.akamaihd.net/steam/apps/1057180/ss_6bd08b4f58c14079f12e92efc42bf61cbe2b62d0.1920x1080.jpg?t=1565336368"));
                        BorderOfficerImages.Add(new GameImage(2, "https://steamcdn-a.akamaihd.net/steam/apps/1057180/ss_b6ad4ace86d8c7dfa676728d0394cb3639c77349.1920x1080.jpg?t=1565336368"));
                        BorderOfficerImages.Add(new GameImage(2, "https://steamcdn-a.akamaihd.net/steam/apps/1057180/ss_c570539f1ffcfa1ff8869da34e4001b4c46db2aa.1920x1080.jpg?t=1565336368"));

                        BorderOfficerImages.ForEach(i => context.GameImages.AddOrUpdate(i));

                        Dirt4Images.Add(new GameImage(3, "https://steamcdn-a.akamaihd.net/steam/apps/421020/ss_101e771250373db1e6a4a17955b8bc671d1c4617.1920x1080.jpg?t=1553771363"));
                        Dirt4Images.Add(new GameImage(3, "https://steamcdn-a.akamaihd.net/steam/apps/421020/ss_76b9373f3f4813d771ae84fc9de74ea7be8ef7db.1920x1080.jpg?t=1553771363"));
                        Dirt4Images.Add(new GameImage(3, "https://steamcdn-a.akamaihd.net/steam/apps/421020/ss_0f3f41c4739e829b8093790fa5b767647ddf7045.1920x1080.jpg?t=1553771363"));
                        Dirt4Images.Add(new GameImage(3, "https://steamcdn-a.akamaihd.net/steam/apps/421020/ss_cfeb262662bc7e6f852db299902637c59642273b.1920x1080.jpg?t=1553771363"));
                        Dirt4Images.Add(new GameImage(3, "https://steamcdn-a.akamaihd.net/steam/apps/421020/ss_68353d6b1f74c5478e5b37dbdd47cd5bd94df082.1920x1080.jpg?t=1553771363"));

                        Dirt4Images.ForEach(i => context.GameImages.AddOrUpdate(i));

                        HentaiImages.Add(new GameImage(4, "https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_26a759c7e3dc1b5c2928a0e6a531026166871b3f.1920x1080.jpg?t=1566268407"));
                        HentaiImages.Add(new GameImage(4, "https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_131e4abcfccfcb51dfa4fbd29b42eca57ccb0b6f.1920x1080.jpg?t=1566268407"));
                        HentaiImages.Add(new GameImage(4, "https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_0bddd6726e70b9337fe6a40f6bab2a9d649ef59c.1920x1080.jpg?t=1566268407"));
                        HentaiImages.Add(new GameImage(4, "https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_7cab3bbf06113ec82c68ab356284cc558ea11e02.1920x1080.jpg?t=1566268407"));
                        HentaiImages.Add(new GameImage(4, "https://steamcdn-a.akamaihd.net/steam/apps/1113680/ss_2cfa6ed8f7beb70191df6a8d43236b4feea5c190.1920x1080.jpg?t=1566268407"));

                        HentaiImages.ForEach(i => context.GameImages.AddOrUpdate(i));

                        TombRaiderImages.Add(new GameImage(8, "https://steamcdn-a.akamaihd.net/steam/apps/750920/ss_3f370f69eef0caeceb533d06925cc48f0f26c83c.1920x1080.jpg?t=1561711273"));
                        TombRaiderImages.Add(new GameImage(8, "https://steamcdn-a.akamaihd.net/steam/apps/750920/ss_3fcd62a2831bcc1e557a0fe2a061b6369ba030d1.1920x1080.jpg?t=1561711273"));
                        TombRaiderImages.Add(new GameImage(8, "https://steamcdn-a.akamaihd.net/steam/apps/750920/ss_794a3ecd4ae51313f8cfffbc6b3d8b91c665b12b.1920x1080.jpg?t=1561711273"));
                        TombRaiderImages.Add(new GameImage(8, "https://steamcdn-a.akamaihd.net/steam/apps/750920/ss_8907e0a624a1113be01fa1b426d0e3ab0971e7d2.1920x1080.jpg?t=1561711273"));
                        TombRaiderImages.Add(new GameImage(8, "https://steamcdn-a.akamaihd.net/steam/apps/750920/ss_191adc1f11bf9d13498cb411ac71f29221732e86.1920x1080.jpg?t=1561711273"));

                        TombRaiderImages.ForEach(i => context.GameImages.AddOrUpdate(i));

                        SlenderImages.Add(new GameImage(6, "https://steamcdn-a.akamaihd.net/steam/apps/252330/ss_8791183f0de3ef85cf1c363e687fd59cfb08d95d.1920x1080.jpg?t=1548194589"));
                        SlenderImages.Add(new GameImage(6, "https://steamcdn-a.akamaihd.net/steam/apps/252330/ss_9d559cf0437931888e1ea13868355ab648004ebc.1920x1080.jpg?t=1548194589"));
                        SlenderImages.Add(new GameImage(6, "https://steamcdn-a.akamaihd.net/steam/apps/252330/ss_78653ec456cd850260b75a3882a4807ba1f43bb8.1920x1080.jpg?t=1548194589"));
                        SlenderImages.Add(new GameImage(6, "https://steamcdn-a.akamaihd.net/steam/apps/252330/ss_b1c6109d69e638d80739f156614e9db2cd4be70f.1920x1080.jpg?t=1548194589"));
                        SlenderImages.Add(new GameImage(6, "https://steamcdn-a.akamaihd.net/steam/apps/252330/ss_74c39a1d7b8523fa7fe5c1dbac97a81b89aa71b5.1920x1080.jpg?t=1548194589"));

                        SlenderImages.ForEach(i => context.GameImages.AddOrUpdate(i));

                    */    
            context.SaveChanges();

        }
    }
}
