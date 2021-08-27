﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Server.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.PlatformId });

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", Url = "action" },
                    new Category { Id = 2, Name = "Adventure", Url = "adventure" },
                    new Category { Id = 3, Name = "Rpg", Url = "rpg" },
                    new Category { Id = 4, Name = "Simulation", Url = "simulation" },
                    new Category { Id = 5, Name = "Strategy", Url = "strategy" },
                    new Category { Id = 6, Name = "Sports", Url = "sports" },
                    new Category { Id = 7, Name = "Platform", Url = "platform" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Red Dead Redemption 2",
                    Description = "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and is a prequel to the 2010 game Red Dead Redemption. The story is set in 1899 in a fictionalized representation of the Western, Midwestern, and Southern United States and follows outlaw Arthur Morgan, a member of the Van der Linde gang.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "GTA V",
                    Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the first main entry in the Grand Theft Auto series since 2008's.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Escape from monkey island",
                    Description = "Escape from Monkey Island is an adventure game developed and released by LucasArts in 2000. It is the fourth game in the Monkey Island series and the first to use 3D graphics.The game centers on the pirate Guybrush Threepwood, who returns home with his wife Elaine Marley after their honeymoon, to find her erroneously declared dead, and her office of governor up for election.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d6/Escape_from_Monkey_Island_artwork.jpg/220px-Escape_from_Monkey_Island_artwork.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Half-Life",
                    Description = "Half-Life is a first-person shooter game developed by Valve and published by Sierra Studios for Microsoft Windows in 1998. It was Valve's debut product and the first game in the Half-Life series. Players assume the role of Gordon Freeman, a scientist who must escape the Black Mesa Research Facility after it is invaded by aliens. The core gameplay consists of fighting alien and human enemies with a variety of weapons and solving puzzles.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/f/fa/Half-Life_Cover_Art.jpg/220px-Half-Life_Cover_Art.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Firewatch",
                    Description = "Firewatch is an adventure game developed by Campo Santo and published by the developer in partnership with Panic. The game was released in February 2016 for Microsoft Windows, OS X, Linux, and PlayStation 4, for Xbox One in September 2016, and for Nintendo Switch in December 2018.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Firewatch_cover.jpg/220px-Firewatch_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "World of Warcraft",
                    Description = "World of Warcraft (WoW) is a massively multiplayer online role-playing game (MMORPG) released in 2004 by Blizzard Entertainment. Set in the Warcraft fantasy universe, World of Warcraft takes place within the world of Azeroth, approximately four years after the events of the previous game in the series, Warcraft III: The Frozen Throne.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/9/91/WoW_Box_Art1.jpg/220px-WoW_Box_Art1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 1,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 5,
                    Title = "Stronghold Crusader",
                    Description = "Stronghold: Crusader is the successor to Firefly Studios's 2001 real-time strategy video game Stronghold.[2] Crusader has much in common with the original Stronghold, but differs from its predecessor in the fact that the game is no longer set in England, instead being set in the Middle East during the Crusades.[3] Another prominent addition not found in its predecessor is a skirmish mode in single-player, allowing customized battles with AI opponents instead of the linear campaign. The game was also released as Stronghold Warchest.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/Crusadercover.jpg/220px-Crusadercover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 4,
                    Title = "The sims 4",
                    Description = "The Sims 4 is a 2014 life simulation video game developed by the Redwood Shores studio of Maxis and published by Electronic Arts. It is the fourth major title in The Sims series and was originally announced on May 6, 2013. It was released in North America on September 2, 2014, for Microsoft Windows. A Mac-compatible version of the game was released on February 17, 2015. The Sims 4 is the first PC game to top all-format charts in two years. The game has received mixed reviews since its release, with the majority of criticism directed towards its lack of content.",
                    Image = "https://upload.wikimedia.org/wikipedia/hr/1/1b/The_Sims_4_Cover_Art_1.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 5,
                    Title = "Age of Mythology",
                    Description = "Age of Mythology (AoM) is a real-time strategy video game developed by Ensemble Studios and published by Microsoft Game Studios. It was released on October 30, 2002 in North America and a week later in Europe.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Age_of_Mythology_Liner.jpg/220px-Age_of_Mythology_Liner.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 13,
                    CategoryId = 5,
                    Title = "Stronghold Legends",
                    Description = "Stronghold Legends is a real-time strategy game developed by Firefly Studios and published by 2K Games in 2006. It follows in the series of Stronghold and Stronghold 2.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c5/Stronghold_Legends_Coverart.jpg/220px-Stronghold_Legends_Coverart.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 14,
                    CategoryId = 6,
                    Title = "Pro Evolution Soccer 2020",
                    Description = "eFootball PES 2020 (officially abbreviated as eFootball PES 2020, also known in Japan as eFootball Winning Eleven 2020) is the 19th installment in the game series. eFootball PES 2020 introduces a change in the name and a focus from Konami in the online gaming space. The game will also mark its installment of the UEFA Euro 2020, which was originally scheduled in the same year before being postponed to next year following to the COVID-19 pandemic.",
                    Image = "data:image/jpeg;base64,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",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 15,
                    CategoryId = 7,
                    Title = "Super Mario Odyssey",
                    Description = "Super Mario Odyssey is a 2017 platform game developed and published by Nintendo for the Nintendo Switch. An entry in the Super Mario series, it follows Mario and Cappy, a sentient hat that allows Mario to control other characters and objects, as they journey across various kingdoms to save Princess Peach from his nemesis Bowser, who plans to forcibly marry her. In contrast to the linear gameplay of prior entries, the game returns to the primarily open-ended, 3D platform gameplay featured in Super Mario 64 and Super Mario Sunshine.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Super_Mario_Odyssey.jpg/220px-Super_Mario_Odyssey.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 16,
                    CategoryId = 7,
                    Title = "A Hat in Time",
                    Description = "A Hat in Time is a platform action-adventure game developed by Gears for Breakfast and published by Humble Bundle. The game was developed using Unreal Engine 3 and funded through a Kickstarter campaign, which doubled its fundraising goals within its first two days. It is inspired by earlier 3D platformers such as Super Mario 64, Banjo-Kazooie, Spyro the Dragon and Psychonauts. The game was self-published for Microsoft Windows and macOS in October 2017, and by Humble Bundle for the PlayStation 4 and Xbox One consoles two months later.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2a/A_Hat_in_Time_cover_art.png/220px-A_Hat_in_Time_cover_art.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 17,
                    CategoryId = 6,
                    Title = "FIFA 21",
                    Description = "FIFA 21 is a football simulation video game published by Electronic Arts as part of the FIFA series.[1] It is the 28th installment in the FIFA series, and was released on 9 October 2020 for Microsoft Windows, Nintendo Switch, PlayStation 4 and Xbox One. Enhanced versions for the PlayStation 5 and Xbox Series X and Series S were released on 3 December 2020, in addition to a version for Stadia in March 2021.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bb/FIFA_21_Standard_Edition_Cover.jpg/220px-FIFA_21_Standard_Edition_Cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 18,
                    CategoryId = 1,
                    Title = "GTA San Andreas",
                    Description = "Grand Theft Auto: San Andreas is a 2004 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh game in the Grand Theft Auto series, following Grand Theft Auto: Vice City (2002). It was released in October 2004 for PlayStation 2, and in June 2005 for Microsoft Windows and Xbox. The game is set within an open world environment that players can explore and interact with at their leisure",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c4/GTASABOX.jpg/220px-GTASABOX.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );

            modelBuilder.Entity<Platform>().HasData(
                    new Platform { Id = 1, Name = "Play Station 5" },
                    new Platform { Id = 2, Name = "Play Station 4" },
                    new Platform { Id = 3, Name = "Play Station 3" },
                    new Platform { Id = 4, Name = "PC" },
                    new Platform { Id = 5, Name = "Xbox Series X" },
                    new Platform { Id = 6, Name = "Xbox One" },
                    new Platform { Id = 7, Name = "Xbox 360" },
                    new Platform { Id = 8, Name = "Nintendo Wii" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    PlatformId = 1,
                    Price = 79.99m,
                    OriginalPrice = 89.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    PlatformId = 4,
                    Price = 69.99m,
                    OriginalPrice = 74.99m,
                },
                new ProductVariant
                {
                    ProductId = 1,
                    PlatformId = 5,
                    Price = 59.99m,
                    OriginalPrice = 68.49m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    PlatformId = 1,
                    Price = 69.99m,
                    OriginalPrice = 79.99m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    PlatformId = 4,
                    Price = 49.99m,
                    OriginalPrice = 79.99m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    PlatformId = 5,
                    Price = 59.99m,
                    OriginalPrice = 47.99m,
                },
                new ProductVariant
                {
                    ProductId = 3,
                    PlatformId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m,
                },
                new ProductVariant
                {
                    ProductId = 4,
                    PlatformId = 3,
                    Price = 14.99m,
                    OriginalPrice = 39.99m,
                },
                new ProductVariant
                {
                    ProductId = 4,
                    PlatformId = 4,
                    Price = 17.99m,
                    OriginalPrice = 36.99m,
                },
                new ProductVariant
                {
                    ProductId = 5,
                    PlatformId = 1,
                    Price = 59.99m,
                    OriginalPrice = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 5,
                    PlatformId = 2,
                    Price = 49.99m,
                    OriginalPrice = 67.99m,
                },
                new ProductVariant
                {
                    ProductId = 5,
                    PlatformId = 3,
                    Price = 44.99m,
                    OriginalPrice = 59.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    PlatformId = 4,
                    Price = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    PlatformId = 4,
                    Price = 59.99m,
                    OriginalPrice = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 8,
                    PlatformId = 4,
                    Price = 29.99m,
                    OriginalPrice = 34.99m,
                },
                new ProductVariant
                {
                    ProductId = 8,
                    PlatformId = 8,
                    Price = 31.99m,
                    OriginalPrice = 34.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    PlatformId = 4,
                    Price = 19.99m,
                    OriginalPrice = 49.99m,
                },
                new ProductVariant
                {
                    ProductId = 10,
                    PlatformId = 1,
                    Price = 59.99m,
                    OriginalPrice = 64.99m,
                },
                new ProductVariant
                {
                    ProductId = 10,
                    PlatformId = 2,
                    Price = 49.99m,
                    OriginalPrice = 54.99m,
                },
                new ProductVariant
                {
                    ProductId = 10,
                    PlatformId = 4,
                    Price = 54.99m,
                    OriginalPrice = 60.99m,
                },
                new ProductVariant
                {
                    ProductId = 10,
                    PlatformId = 5,
                    Price = 53.99m,
                    OriginalPrice = 64.99m,
                },
                new ProductVariant
                {
                    ProductId = 11,
                    PlatformId = 4,
                    Price = 23.99m,
                    OriginalPrice = 34.99m,
                },
                new ProductVariant
                {
                    ProductId = 13,
                    PlatformId = 4,
                    Price = 36.99m,
                    OriginalPrice = 55.99m,
                },
                new ProductVariant
                {
                    ProductId = 14,
                    PlatformId = 1,
                    Price = 59.99m,
                    OriginalPrice = 79.99m,
                },
                new ProductVariant
                {
                    ProductId = 14,
                    PlatformId = 4,
                    Price = 53.99m,
                    OriginalPrice = 64.99m,
                },
                new ProductVariant
                {
                    ProductId = 14,
                    PlatformId = 5,
                    Price = 63.99m,
                    OriginalPrice = 64.99m,
                },
                new ProductVariant
                {
                    ProductId = 14,
                    PlatformId = 8,
                    Price = 43.99m,
                    OriginalPrice = 58.99m,
                },
                new ProductVariant
                {
                    ProductId = 15,
                    PlatformId = 8,
                    Price = 33.99m,
                    OriginalPrice = 48.99m,
                },
                new ProductVariant
                {
                    ProductId = 16,
                    PlatformId = 1,
                    Price = 59.99m,
                    OriginalPrice = 49.99m,
                },
                new ProductVariant
                {
                    ProductId = 17,
                    PlatformId = 1,
                    Price = 73.99m,
                    OriginalPrice = 78.99m,
                },
                new ProductVariant
                {
                    ProductId = 17,
                    PlatformId = 4,
                    Price = 59.99m,
                    OriginalPrice = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 17,
                    PlatformId = 5,
                    Price = 64.99m,
                    OriginalPrice = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 18,
                    PlatformId = 3,
                    Price = 44.99m,
                    OriginalPrice = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 18,
                    PlatformId = 4,
                    Price = 39.99m,
                    OriginalPrice = 49.99m,
                },
                new ProductVariant
                {
                    ProductId = 18,
                    PlatformId = 7,
                    Price = 34.99m,
                    OriginalPrice = 39.99m,
                },
                new ProductVariant
                {
                    ProductId = 18,
                    PlatformId = 8,
                    Price = 27.99m,
                    OriginalPrice = 29.99m,
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
