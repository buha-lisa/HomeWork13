namespace hw13
{
    internal class Program
    {
        static void Main()
        {
            var moreRadosti = new Poem()
            { 
                Name = "Море радості",
                AuthorName = "Vasyl Simonenko",
                WritingYear = 1961,
                PoemText = "Я із надій будую човен,\r\nІ вже немовби наяву\r\nЗ тобою, ніжний, срібномовен,\r\nПо морю радості пливу.\r\n\r\nІ гомонять навколо хвилі,\r\nЗ бортів човна змивають мох,\r\nІ ми з тобою вже не в силі\r\nБуть нещасливими удвох.\r\n\r\nІ ти ясна, і я прозорий,\r\nІ душі наші мов пісні,\r\nІ світ великий, неозорий\r\nНалежить нам – тобі й мені.\r\n\r\nО море радості безкрає,\r\nЧи я тебе перепливу?\r\nЯкби того, що в мріях маю,\r\nХоч краплю мати наяву.",
                Theme = "Love"
            };
            var toBeOrNot = new Poem()
            {
                Name = "To be, or not to be, that is the question",
                AuthorName = "William Shakespeare",
                WritingYear = 1600,
                PoemText = "To be, or not to be, that is the question:\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles\r\nAnd by opposing end them. To die—to sleep,\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to: 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep;\r\nTo sleep, perchance to dream—ay, there's the rub:\r\nFor in that sleep of death what dreams may come,\r\nWhen we have shuffled off this mortal coil,\r\nMust give us pause—there's the respect\r\nThat makes calamity of so long life.\r\nFor who would bear the whips and scorns of time,\r\nTh'oppressor's wrong, the proud man's contumely,\r\nThe pangs of dispriz'd love, the law's delay,\r\nThe insolence of office, and the spurns\r\nThat patient merit of th'unworthy takes,\r\nWhen he himself might his quietus make\r\nWith a bare bodkin? Who would fardels bear,\r\nTo grunt and sweat under a weary life,\r\nBut that the dread of something after death,\r\nThe undiscovere'd country, from whose bourn\r\nNo traveller returns, puzzles the will,\r\nAnd makes us rather bear those ills we have\r\nThan fly to others that we know not of?\r\nThus conscience doth make cowards of us all,\r\nAnd thus the native hue of resolution\r\nIs sicklied o'er with the pale cast of thought,\r\nAnd enterprises of great pith and moment\r\nWith this regard their currents turn awry\r\nAnd lose the name of action.\r\n",
                Theme = "Philosophical"
            };

            var collection = new PoemCollection();
            collection.AddPoem(moreRadosti);
            collection.AddPoem(toBeOrNot);

            //2
            var poemGroups = collection.SearchPoemsByName("Море радості").Select(x => x.Name);
            Console.WriteLine("Poems by Poem Name:");
            Console.WriteLine($"- {poemGroups.Count()} poem");

            var authorGroups = collection.SearchPoemsByAuthorName("William Shakespeare").Select(x => x.Name);
            Console.WriteLine("Poems by Author Name:");
            Console.WriteLine($"- {authorGroups.Count()} poem");

            var themeGroups = collection.SearchPoemsByTheme("Philosophical").Select(x => x.Name);
            Console.WriteLine("Poems by Theme:");
            Console.WriteLine($"- {themeGroups.Count()} poem");

            //3
            var wordGroups = collection.SearchPoemsByText("Я").Select(x => x.Name);
            Console.WriteLine("Poems by Text:");
            Console.WriteLine($"- {wordGroups.Count()} poem");

            var yearGroups = collection.SearchPoemsByYear(1961).Select(x => x.Name);
            Console.WriteLine("Poems by Year:");
            Console.WriteLine($"- {yearGroups.Count()} poem");

            var lenghtGroups = collection.SearchPoemsByLenght(243).Select(x => x.Name);
            Console.WriteLine("Poems by Lenght:");
            Console.WriteLine($"- {lenghtGroups.Count()} poem");
        }
    }
}
