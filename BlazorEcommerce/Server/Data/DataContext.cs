

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany.[4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg",
                    Price = 5.70m
                },
                new Product
                {
                    Id = 4,
                    Title = "Gone with the Wind",
                    Description = "Gone with the Wind is a novel by American writer Margaret Mitchell, first published in 1936. The story is set in Clayton County and Atlanta, both in Georgia, during the American Civil War and Reconstruction Era. It depicts the struggles of young Scarlett O'Hara, the spoiled daughter of a well-to-do plantation owner, who must use every means at her disposal to claw her way out of poverty following Sherman's destructive 'March to the Sea'. This historical novel features a coming-of-age story, with the title taken from the poem (Non Sum Qualis eram Bonae Sub Regno Cynarae), written by Ernest Dowson.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6b/Gone_with_the_Wind_cover.jpg",
                    Price = 8.49m
                },
                new Product
                {
                    Id = 6,
                    Title = "Daily Chronicle",
                    Description = "The Daily Chronicle was developed by Edward Lloyd out of a local newspaper that had started life as the Clerkenwell News and Domestic Intelligencer, set up as a halfpenny 4-page weekly in 1855. Launched after the duties on advertising and published news had been abolished in 1853 and July 1855, this local paper specialised in small personal ads. At first, it carried about three times as much advertising as it did local news.\r\n\r\nAs the formula proved popular, it grew in size and frequency and often changed its name to match. In 1872, it finally changed from the London Daily Chronicle and Clerkenwell News[2] to plain Daily Chronicle. It was then being published daily in eight pages, half of which were news and half advertising.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b1/Daily_Chronicle_placard_The_Day_June_30_1919.jpg",
                    Price = 18.09m
                },
                new Product
                {
                    Id = 7,
                    Title = "The Black Cat",
                    Description = "The Black Cat\" is a short story by American writer Edgar Allan Poe. It was first published in the August 19, 1843, edition of The Saturday Evening Post. In the story, an unnamed narrator has a strong affection for pets until he perversely turns to abusing them. His favorite, a pet black cat, bites him one night and the narrator punishes it by cutting its eye out and then hanging it from a tree. The home burns down but one remaining wall shows a burned outline of a cat hanging from a noose. He soon finds another black cat, similar to the first except for a white mark on its chest, but he develops a hatred for it as well. He attempts to kill the cat with an axe but his wife stops him; instead, the narrator murders his wife. He conceals the body behind a brick wall in his basement. The police soon come and, after the narrator's tapping on the wall is met with a shrieking sound, they find not only the wife's corpse but also the black cat that had been accidentally walled in with the body and alerted them with its cry.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3c/Poe_black_cat_byam_shaw.JPG",
                    Price = 8.49m
                },
                new Product
                {
                    Id = 8,
                    Title = "War and Peace",
                    Description = "War and Peace[a] is a literary work by Russian author Leo Tolstoy. Set during the Napoleonic Wars, the work mixes fictional narrative with chapters discussing history and philosophy. First published serially beginning in 1865, the work was rewritten and published in its entirety in 1869. It is regarded as Tolstoy's finest literary achievement and remains an internationally praised classic of world literature.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/af/Tolstoy_-_War_and_Peace_-_first_edition%2C_1869.jpg",
                    Price = 12.00m
                },
                new Product
                {
                    Id = 9,
                    Title = "Neverwhere",
                    Description = "Neverwhere is the companion novelisation written by English author Neil Gaiman of the television serial Neverwhere, written by Gaiman and devised by Lenny Henry.[1] The plot and characters are exactly the same as in the series, with the exception that the novel form allowed Gaiman to expand and elaborate on certain elements of the story and restore changes made in the televised version from his original plans.[2] Most notable is the appearance of the Floating Market at Harrods (in the novel) rather than under Battersea power station (the TV series). This is because the management of Harrods changed their minds about proposed filming. The novel was originally released by BBC Books in 1996, three episodes into the television series run. It was accompanied by a spoken word CD and cassette release, also by the BBC.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Neverwhere.jpg",
                    Price = 8.49m
                },
                 new Product
                 {
                     Id = 10,
                     Title = "Odyssey",
                     Description = "The Odyssey (/ˈɒdɪsi/; Ancient Greek: Ὀδύσσεια, romanized: Odýsseia) is one of two major ancient Greek epic poems attributed to Homer. It is one of the oldest extant works of literature still widely read by modern audiences. As with the Iliad, the poem is divided into 24 books. It follows the Greek hero Odysseus, king of Ithaca, and his journey home after the Trojan War. After the war, which lasted ten years, his journey from Troy to Ithaca, via Africa and southern Europe, lasted for ten additional years during which time he encountered many perils and all of his crewmates were killed. In his absence, Odysseus was assumed dead, and his wife Penelope and son Telemachus had to contend with a group of unruly suitors who were competing for Penelope's hand in marriage.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/32/Wall_painting_-_rape_of_the_palladion_-_Pompeii_%28I_2_26%29_-_Napoli_MAN_109751_-_02.jpg",
                     Price = 7.40m
                 },
                  new Product
                  {
                      Id = 11,
                      Title = "American Gods",
                      Description = "American Gods (2001) is a fantasy novel by British author Neil Gaiman. The novel is a blend of Americana, fantasy, and various strands of ancient and modern mythology, all centering on the mysterious and taciturn Shadow.\r\n\r\nThe book was published in 2001 by Headline in the United Kingdom and by William Morrow in the United States. It gained a positive critical response and won the 2002 Hugo and Nebula awards. A special tenth anniversary edition, which includes the \"author's preferred text\" and 12,000 additional words, was published in June 2011 by William Morrow. Two audio versions of the book were produced and published by Harper Audio: an unabridged version of the original published edition, read by George Guidall, released in 2001; a full cast audiobook version of the tenth anniversary edition, released in 2011. In March 2017, The Folio Society published a special collector's edition of American Gods, with many corrections to the author's preferred text version.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/49/American_gods.jpg",
                      Price = 18.11m
                  }

            );
        }
        public DbSet<Product> Products { get; set; }
    }
}
