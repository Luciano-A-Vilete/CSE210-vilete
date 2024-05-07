using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            // Old Testament
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength. They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint."),
            new Scripture(new Reference("Jeremiah", 29, 11), "For I know the plans I have for you,” declares the Lord, “plans to prosper you and not to harm you, plans to give you hope and a future."),
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning, God created the heavens and the earth."),

            // New Testament
            new Scripture(new Reference("Matthew", 5, 16), "Let your light shine before others, that they may see your good deeds and glorify your Father in heaven."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."),
            new Scripture(new Reference("1 Corinthians", 13, 13), "And now these three remain: faith, hope and love. But the greatest of these is love."),

            // Book of Mormon
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth."),
            new Scripture(new Reference("Alma", 7, 11), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."),
            new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."),

            // Doctrine and Covenants
            new Scripture(new Reference("Doctrine and Covenants", 88, 63), "Draw near unto me and I will draw near unto you; seek me diligently and ye shall find me; ask, and ye shall receive; knock, and it shall be opened unto you."),
            new Scripture(new Reference("Doctrine and Covenants", 89, 18), "And all saints who remember to keep and do these sayings, walking in obedience to the commandments, shall receive health in their navel and marrow to their bones;"),
            new Scripture(new Reference("Doctrine and Covenants", 93, 36), "The glory of God is intelligence, or, in other words, light and truth."),
            new Scripture(new Reference("Doctrine and Covenants", 130, 20), "There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated—"),
            new Scripture(new Reference("Doctrine and Covenants", 121, 7), "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment;"),

            // Pearl of Great Price
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Abraham", 3, 22), "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones;"),
            new Scripture(new Reference("Abraham", 4, 3), "And they went down at the beginning, and they, that is the Gods, organized and formed the heavens and the earth."),
            new Scripture(new Reference("Joseph Smith—Matthew", 1, 37), "But as the days of Noah were, so shall also the coming of the Son of Man be."),
            new Scripture(new Reference("Joseph Smith—History", 1, 15), "I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me."),

        };

        // Select a random scripture from the library
        Random random = new Random();
        Scripture currentScripture = SelectRandomScripture(scriptureLibrary, random);
        
        // Display the scripture and continue until all words are hidden
        while (!currentScripture.AreAllWordsHidden())
        {
            ClearConsole();
            currentScripture.Display();
            
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();
            
            if (input == "quit")
                break;
            
            currentScripture.HideRandomWord();
        }
    }

    static void ClearConsole()
    {
        if (!Console.IsOutputRedirected)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth * Console.WindowHeight));
            Console.SetCursorPosition(0, 0);
        }
    }

    static Scripture SelectRandomScripture(List<Scripture> scriptureLibrary, Random random)
    {
        int index = random.Next(0, scriptureLibrary.Count);
        return scriptureLibrary[index];
    }
}