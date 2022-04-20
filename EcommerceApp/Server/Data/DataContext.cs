﻿namespace EcommerceApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                   new ProductType { Id = 1, Name = "Default" },
                   new ProductType { Id = 2, Name = "Paperback" },
                   new ProductType { Id = 3, Name = "E-Book" },
                   new ProductType { Id = 4, Name = "Audiobook" },
                   new ProductType { Id = 5, Name = "Stream" },
                   new ProductType { Id = 6, Name = "Blu-ray" },
                   new ProductType { Id = 7, Name = "VHS" },
                   new ProductType { Id = 8, Name = "PC" },
                   new ProductType { Id = 9, Name = "Nintendo" },
                   new ProductType { Id = 10, Name = "PlayStation" }
               );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                }, 
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Mistborn: The Final Empire",
                        Description = "Mistborn: The Final Empire, also known simply as Mistborn or The Final Empire, is a fantasy novel written by American author Brandon Sanderson. It was published on July 17, 2006, by Tor Books and is the first novel in the Mistborn trilogy, followed by The Well of Ascension in 2007 and The Hero of Ages in 2008. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/Mistborn-cover.jpg",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Harry Potter and the Half-Blood Prince",
                        Description = "Harry Potter and the Half-Blood Prince is a fantasy novel written by British author J.K. Rowling and the sixth and penultimate novel in the Harry Potter series. Set during Harry Potter's sixth year at Hogwarts, the novel explores the past of the boy wizard's nemesis, Lord Voldemort, and Harry's preparations for the final battle against Voldemort alongside his headmaster and mentor Albus Dumbledore. The book was published in the United Kingdom by Bloomsbury and in the United States by Scholastic on 16 July 2005, as well as in several other countries. It sold nine million copies in the first 24 hours after its release, a record that was eventually broken by its sequel, Harry Potter and the Deathly Hallows. There were many controversies before and after it was published, including the right to read copies delivered before the release date in Canada. Reception to the novel was generally positive, and it won several awards and honours, including the 2006 British Book of the Year award. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b5/Harry_Potter_and_the_Half-Blood_Prince_cover.png",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "The Joy Luck Club",
                        Description = "The Joy Luck Club is a 1989 novel written by Amy Tan. It focuses on four Chinese American immigrant families in San Francisco who start a club known as The Joy Luck Club, playing the Chinese game of mahjong for money while feasting on a variety of foods. The book is structured similarly to a mahjong game, with four parts divided into four sections to create sixteen chapters. The three mothers and four daughters (one mother, Suyuan Woo, dies before the novel opens) share stories about their lives in the form of short vignettes. Each part is preceded by a parable relating to the themes within that section. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/ca/TheJoyLuckClub.jpg",
                        CategoryId = 1,
                        Featured = true
                    }, new Product
                    {
                        Id = 4,
                        Title = "The Fellowship of the Ring",
                        Description = "The Fellowship of the Ring is the first of three volumes of the epic novel The Lord of the Rings by the English author J. R. R. Tolkien. It is followed by The Two Towers and The Return of the King. It takes place in the fictional universe of Middle-earth, and was originally published on 29 July 1954 in the United Kingdom. The volume consists of a foreword, in which the author discusses his writing of The Lord of the Rings, a prologue titled \"Concerning Hobbits, and other matters and the main narrative in Book I and Book II.\"",
                        ImageUrl = "https://novelnotions.net/wp-content/uploads/2020/05/910DjRN2msL.jpg",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Outliers",
                        Description = "Outliers: The Story of Success is the third non-fiction book written by Malcolm Gladwell and published by Little, Brown and Company on November 18, 2008. In Outliers, Gladwell examines the factors that contribute to high levels of success. To support his thesis, he examines why the majority of Canadian ice hockey players are born in the first few months of the calendar year, how Microsoft co-founder Bill Gates achieved his extreme wealth, how the Beatles became one of the most successful musical acts in human history, how Joseph Flom built Skadden, Arps, Slate, Meagher & Flom into one of the most successful law firms in the world, how cultural differences play a large part in perceived intelligence and rational decision making, and how two people with exceptional intelligence, Christopher Langan and J. Robert Oppenheimer, end up with such vastly different fortunes. Throughout the publication, Gladwell repeatedly mentions the \"10,000 - Hour Rule\", claiming that the key to achieving world-class expertise in any skill, is, to a large extent, a matter of practicing the correct way, for a total of around 10,000 hours, though the authors of the original study have disputed Gladwell's usage.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/ec/Outliers_%28book_cover%29.png",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "The Fault in Our Stars",
                        Description = "The Fault in Our Stars is a novel by John Green. It is his fourth solo novel, and sixth novel overall. It was published on January 10, 2012. The title is inspired by Act 1, Scene 2 of Shakespeare's play Julius Caesar, in which the nobleman Cassius says to Brutus: \"The fault,dear Brutus, is not in our stars, / But in ourselves, that we are underlings.\" The story is narrated by Hazel Grace Lancaster, a 16-year-old girl with thyroid cancer that has affected her lungs. Hazel is forced by her parents to attend a support group where she subsequently meets and falls in love with 17-year-old Augustus Waters, an ex-basketball player, amputee and survivor of osteosarcoma.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a9/The_Fault_in_Our_Stars.jpg",
                        CategoryId = 1,

                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Akira (アキラ)",
                        Description = "Akira is a 1988 Japanese animated cyberpunk action film directed by Katsuhiro Otomo, produced by Ryōhei Suzuki and Shunzō Katō, and written by Otomo and Izo Hashimoto, based on Otomo's 1982 manga of the same name. The film had a production budget of ¥700 million ($5.5 million), making it the most expensive anime film at the time (until it was surpassed a year later by Kiki's Delivery Service). Set in a dystopian 2019, Akira tells the story of Shōtarō Kaneda, a leader of a biker gang whose childhood friend,Tetsuo Shima, acquires incredible telekinetic abilities after a motorcycle accident, eventually threatening an entire military complex amid chaos and rebellion in the sprawling futuristic metropolis of Neo - Tokyo.While most of the character designs and settings were adapted from the manga, the plot differs considerably and does not include much of the last half of the manga, which continued publication for two years after the film's release. The soundtrack, which draws heavily from traditional Indonesian gamelan as well as Japanese noh music, was composed by Shōji Yamashiro and performed by Geinoh Yamashirogumi. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5d/AKIRA_%281988_poster%29.jpg",
                        CategoryId = 2,

                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Dune",
                        Description = "Dune (titled onscreen as Dune: Part One) is a 2021 American epic science fiction film directed by Denis Villeneuve from a screenplay by Villeneuve, Jon Spaihts, and Eric Roth. It is the first of a two-part adaptation of the 1965 novel by Frank Herbert, primarily covering the first half of the book. Set in the far future, the film follows Paul Atreides as his family, the noble House Atreides, is thrust into a war for the deadly and inhospitable desert planet Arrakis. The ensemble cast includes Timothée Chalamet, Rebecca Ferguson, Oscar Isaac, Josh Brolin, Stellan Skarsgård, Dave Bautista, Stephen McKinley Henderson, Zendaya, David Dastmalchian, Chang Chen, Sharon Duncan-Brewster, Charlotte Rampling, Jason Momoa, and Javier Bardem. The film is the second theatrical adaptation of Dune following David Lynch's 1984 film, which was a critical and commercial failure, and the third adaptation overall following both the David Lynch film and John Harrison's 2000 miniseries. After an unsuccessful attempt by Paramount Pictures to produce a new adaptation, Legendary Entertainment acquired the Dune film and TV rights in 2016, with Villeneuve signing on as director in February 2017.Production contracts were only secured for the first film, relying on its success before a second film would be greenlit after the first film's release. Filming took place from March to July 2019 at locations including Budapest, Jordan, Norway, and Abu Dhabi. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Spider-Man: No Way Home",
                        Description = "Spider-Man: No Way Home is a 2021 American superhero film based on the Marvel Comics character Spider-Man, co-produced by Columbia Pictures and Marvel Studios and distributed by Sony Pictures Releasing. It is the sequel to Spider-Man: Homecoming (2017) and Spider-Man: Far From Home (2019), and the 27th film in the Marvel Cinematic Universe (MCU). The film was directed by Jon Watts and written by Chris McKenna and Erik Sommers. It stars Tom Holland as Peter Parker / Spider-Man alongside Zendaya, Benedict Cumberbatch, Jacob Batalon, Jon Favreau, Jamie Foxx, Willem Dafoe, Alfred Molina, Benedict Wong, Tony Revolori, Marisa Tomei, Andrew Garfield, and Tobey Maguire. In the film, Parker asks Dr. Stephen Strange (Cumberbatch) to use magic to make his identity as Spider-Man a secret again following its public revelation. When the spell goes wrong, the multiverse is broken open which allows visitors from alternate realities to enter Parker's universe. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                        CategoryId = 2,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "John Wick",
                        Description = "John Wick is a 2014 American neo-noir action thriller film directed by Chad Stahelski, in his directorial debut, and written by Derek Kolstad. It stars Keanu Reeves, Michael Nyqvist, Alfie Allen, Adrianne Palicki, Bridget Moynahan, Dean Winters, Ian McShane, John Leguizamo, and Willem Dafoe. It is the first installment in the John Wick franchise. The story focuses on John Wick(Reeves) searching for the men who broke into his home, stole his vintage car and killed his puppy, which was a last gift to him from his recently deceased wife. Chad Stahelski and David Leitch directed the film together, though only Stahelski was credited. Kolstad had completed the screenplay in 2012 and further developed it for Thunder Road Pictures. The film was produced by Basil Iwanyk of Thunder Road Pictures, Leitch, Eva Longoria, and Michael Witherill.It marks Stahelski and Leitch's directorial debut as a team after multiple separate credits as second-unit directors and stunt coordinators. They previously worked with Reeves as stunt doubles on The Matrix trilogy",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/98/John_Wick_TeaserPoster.jpg",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "Enter the Dragon",
                        Description = "Enter the Dragon (Chinese: 龍爭虎鬥) is a 1973 action spy film directed by Robert Clouse and starring Bruce Lee, John Saxon and Jim Kelly. It was Lee's final completed film appearance before his death on 20 July 1973 at age 32. An American and Hong Kong co-production, it premiered in Los Angeles on 19 August 1973, one month after Lee's death. The film grossed an estimated US$350 million worldwide (equivalent to more than $1 billion adjusted for inflation), against a budget of $850,000. Having earned over 400 times its budget, it is one of the most profitable films of all time, as well as being the most profitable martial arts film. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/ef/Enter_the_dragon.jpg",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "La La Land",
                        Description = "La La Land is a 2016 American musical romance film written and directed by Damien Chazelle. It stars Ryan Gosling and Emma Stone as a struggling jazz pianist and an aspiring actress, respectively, who meet and fall in love while pursuing their dreams in Los Angeles. John Legend, Rosemarie DeWitt, Finn Wittrock, and J. K. Simmons appear in supporting roles. Having been fond of musicals during his time as a drummer, Chazelle first conceptualized the film alongside Justin Hurwitz while attending Harvard University together.After moving to Los Angeles in 2010, Chazelle penned the script but did not find a studio willing to finance the production without changes to his design. After the success of his film Whiplash(2014), the project was picked up by Summit Entertainment. Miles Teller and Emma Watson were originally slated to star, but after both dropped out Gosling and Stone were cast.Filming took place in Los Angeles between August and September 2015, with the film's score composed by Hurwitz and the dance choreography by Mandy Moore. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ab/La_La_Land_%28film%29.png",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "Elden Ring",
                        Description = "Elden Ring is an action role-playing game developed by FromSoftware and published by Bandai Namco Entertainment. The game was directed by Hidetaka Miyazaki and made in collaboration with fantasy novelist George R. R. Martin, who provided material for the game's setting. It was released for Microsoft Windows, PlayStation 4, PlayStation 5, Xbox One, and Xbox Series X/S on February 25, 2022. Elden Ring is presented through a third - person perspective, with players freely roaming its interactive open world.Gameplay elements include combat, featuring several types of weapons and magic spells, horseback riding, and crafting.Elden Ring received critical acclaim, with praise for its open world gameplay.The game sold 12 million copies worldwide within three weeks of its release. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b9/Elden_Ring_Box_art.jpg",
                        CategoryId = 3,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Pokémon Legends: Arceus",
                        Description = "Pokémon Legends: Arceus is a 2022 action role-playing game developed by Game Freak and published by Nintendo and The Pokémon Company for the Nintendo Switch. It is part of the eighth generation of the Pokémon video game series and serves as a prequel to Pokémon Diamond and Pearl (2006), their enhanced version Pokémon Platinum (2008), and their remakes Pokémon Brilliant Diamond and Shining Pearl (2021). The game was first announced as part of the Pokémon 25th Anniversary event in February 2021, and was released worldwide on 28 January 2022. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "Fall Guys",
                        Description = "Fall Guys: Ultimate Knockout is a platform battle royale game developed by Mediatonic and published by Devolver Digital. It was released for Microsoft Windows and PlayStation 4 on 4 August 2020. The game is planned for eventual release on Nintendo Switch, Xbox One, and Xbox Series X/S. Up to 60 players control jellybean - like creatures and compete against each other in a series of challenges, such as obstacle courses or tag.Many different courses have been added since the game was first released; the minority are team-based, while many require not falling into slime on a spinning, floating platform with obstacles designed to knock players in and waiting for a specified number of others to be eliminated, but most are obstacle courses that involve players racing to get to the finish line as soon as possible, lest they are eliminated—starting at 40, there is a limited number of players that can qualify, and the number lowers as rounds progress.Eventually, the number of players get down to one, the player who is crowned the winner. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5e/Fall_Guys_cover.jpg",
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 16,
                        Title = "Death Stranding",
                        Description = "Death Stranding is an action game developed by Kojima Productions. It is the first game from director Hideo Kojima and Kojima Productions after their split from Konami in 2015. It was published by Sony Interactive Entertainment for the PlayStation 4 in November 2019 and by 505 Games for Windows in July 2020. A director's cut version was released for the PlayStation 5 in September 2021, followed by a release for Windows in March 2022. The game is set in the United States following a cataclysmic event which caused destructive creatures to begin roaming the Earth.Players control Sam Porter Bridges(Norman Reedus), a courier tasked with delivering supplies to isolated colonies and reconnecting them via a wireless communications network.Alongside Reedus, the game features actors Mads Mikkelsen, Léa Seydoux, Margaret Qualley, Troy Baker, Tommie Earl Jenkins, and Lindsay Wagner, in addition to the likenesses of film directors Guillermo del Toro and Nicolas Winding Refn as supporting characters. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/Death_Stranding.jpg",
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 17,
                        Title = "Dragon Ball FighterZ",
                        Description = "Dragon Ball FighterZ (pronounced \"fighters\") is a 2.5D fighting game, developed by Arc System Works and published by Bandai Namco Entertainment. Based on the Dragon Ball franchise, it was released for the PlayStation 4, Xbox One, and Microsoft Windows in most regions in January 2018, and in Japan the following month, and was released worldwide for the Nintendo Switch in September 2018. Dragon Ball FighterZ involves the player picking a team of 3 playable characters and a unique assist for each, then fighting an AI or human opponent with their own team of 3 characters.The game received positive reviews from critics, with many citing the game as one of the best fighting games released in the eighth generation of video game consoles.The game's fighting system, character roster, visuals, story mode, and music were all highly praised while its online functionality was criticized. The game was also a commercial success, having sold over 8 million copies worldwide as of 2021. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ad/DBFZ_cover_art.jpg",
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 18,
                        Title = "Hollow Knight",
                        Description = "Hollow Knight is a 2017 Metroidvania action-adventure game developed and published by Team Cherry. In the game, players control the Knight, a nameless warrior uncertain of their own identity or origin. The Knight explores Hallownest, a once thriving kingdom whose inhabitants were deprived of their minds. The game itself is set in diverse locations, and it features friendly and hostile bug-like characters and numerous bosses. Players have the opportunity to unlock new abilities as they explore each location, along with pieces of lore that are spread throughout the world. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c0/Hollow_Knight_cover.jpg",
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 19,
                        Title = "Nintendo Switch",
                        Description = "The Nintendo Switch is a video game console developed by Nintendo and released worldwide in most regions on March 3, 2017. The console itself is a tablet that can either be docked for use as a home console or used as a portable device, making it a hybrid console. Its wireless Joy-Con controllers, with standard buttons and directional analog sticks for user input, motion sensing, and tactile feedback, can attach to both sides of the console to support handheld-style play. They can also connect to a grip accessory to provide a traditional home console gamepad form, or be used individually in the hand like the Wii Remote and Nunchuk, supporting local multiplayer modes. The Nintendo Switch's software supports online gaming through Internet connectivity, as well as local wireless ad hoc connectivity with other consoles. Nintendo Switch games and software are available on both physical flash-based ROM cartridges and digital distribution via Nintendo eShop; the system has no region lockout.A handheld-focused revision of the system, called the Nintendo Switch Lite, was released on September 20, 2019. A revised higher-end version of the original system, featuring an OLED screen, was released on October 8, 2021. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Nintendo-Switch-Console-Docked-wJoyConRB.jpg/1920px-Nintendo-Switch-Console-Docked-wJoyConRB.jpg",
                        CategoryId = 3,
                    },
                    new Product
                    {
                        Id = 20,
                        Title = "PlayStation 5",
                        Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020, in Australia, Japan, New Zealand, North America, and South Korea, with worldwide release following a week later. The PS5 is part of the ninth generation of video game consoles, along with Microsoft's Xbox Series X and Series S consoles, which were released in the same month. The base model includes an optical disc drive compatible with Ultra HD Blu - ray discs.The Digital Edition lacks this drive, allowing it to serve as a lower - cost model for those who prefer to buy games through digital download.The two variants were launched simultaneously. The PlayStation 5's main hardware features include a solid-state drive customized for high-speed data streaming to enable significant improvements in storage performance, an AMD GPU capable of 4K resolution display at up to 120 frames per second, hardware-accelerated ray tracing for realistic lighting and reflections, and the Tempest Engine allowing for hardware-accelerated 3D audio effects. Other features include the DualSense controller with haptic feedback and backward compatibility with the majority of PlayStation 4 and PlayStation VR games.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        CategoryId = 3,
                    }
                );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 11.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 9.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 11.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 4,
                    Price = 9.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 2,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 3,
                    Price = 9.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 4,
                    Price = 12.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 9.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 2,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 3,
                    Price = 5.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 5,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 6,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 7,
                    Price = 79.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 5,
                    Price = 19.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 5,
                    Price = 24.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 5,
                    Price = 4.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 6,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 5,
                    Price = 4.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 6,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 7,
                    Price = 79.99m
                },
                new ProductVariant
                {
                    ProductId = 12,
                    ProductTypeId = 5,
                    Price = 4.99m
                },
                new ProductVariant
                {
                    ProductId = 12,
                    ProductTypeId = 6,
                    Price = 11.99m
                },
                new ProductVariant
                {
                    ProductId = 13,
                    ProductTypeId = 8,
                    Price = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 13,
                    ProductTypeId = 9,
                    Price = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 13,
                    ProductTypeId = 10,
                    Price = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 14,
                    ProductTypeId = 9,
                    Price = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 15,
                    ProductTypeId = 8,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 15,
                    ProductTypeId = 9,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 15,
                    ProductTypeId = 10,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 16,
                    ProductTypeId = 8,
                    Price = 29.99m,
                    OriginalPrice = 39.99m
                },
                new ProductVariant
                {
                    ProductId = 16,
                    ProductTypeId = 10,
                    Price = 39.99m
                }
                ,
                new ProductVariant
                {
                    ProductId = 17,
                    ProductTypeId = 8,
                    Price = 39.99m,
                    OriginalPrice = 59.99m
                }
                ,
                new ProductVariant
                {
                    ProductId = 17,
                    ProductTypeId = 10,
                    Price = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 18,
                    ProductTypeId = 8,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 19,
                    ProductTypeId = 1,
                    Price = 299.99m
                },
                new ProductVariant
                {
                    ProductId = 20,
                    ProductTypeId = 1,
                    Price = 499.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
