using System;
using System.Collections.Generic;

namespace FinalTask
{
    class offsetProgram
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Сat show welcomes you!");
            Console.WriteLine("Enter your cat's name");
            string catName = Console.ReadLine();

            Console.WriteLine("Enter your cat's age-full years ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your cat's age-month ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Does your cat have a pedigree? (y or n)");
            string pedigree = Console.ReadLine();

            Cat YourCat = new Cat(catName, year, month);

            string ring;
            string title;
            if (pedigree == "n")
                ring = YourCat.RingParticipantNoTitle();
            else
                ring = YourCat.RingParticipant(year);

            title = YourCat.SetTitle();

            Console.WriteLine($"\nYour cat {catName} {year} years {month} month has a title {title} and participates in the ring {ring}");

            List<Cat> Cats = new List<Cat>(10)
            {
                new Cat("Mario", 2, 7, "", "", 0),
                new Cat("Zakira", 4, 1, "", "", 0),
                new Cat("Somalissa", 7, 1, "", "", 0),
                new Cat("Malish", 0, 6, "", "", 0),
                new Cat("Zavka", 3, 9, "", "", 0),
                new Cat("Gosha", 14, 9, "", "", 0),
                new Cat("Roksi", 0, 9, "", "", 0),
            };

            Console.WriteLine("\nYour rivals:\n");

            foreach (Cat cat in Cats)
            {
                cat.SetTitle();
                int pedigree1 = rand.Next(0, 100);

                if (pedigree1 <= 40)
                {
                    string catRing = cat.RingParticipantNoTitle();
                    cat.SetRing(catRing);
                }
                else
                {
                    string catRing = cat.RingParticipant(cat.age.year);
                    cat.SetRing(catRing);
                }

                Console.WriteLine($"Cat {cat.name} {cat.age.year} years {cat.age.month} month has a title {cat.title} and participates in the ring {cat.ring}");

            }
            Console.WriteLine("");

            Cat myCat = new Cat(catName, year, month, title, ring, 0);
            Cats.Add(myCat);

            Judge judge = new Judge();
            foreach (Cat cat in Cats)
            {
                int judgePoints = judge.GivePoints();
                cat.SetPoints(judgePoints);
                Console.WriteLine($"Cat {cat.name} receives from the jury {cat.point} points");
            }

            Sponsor sponsor = new Sponsor();
            foreach (Cat cat in Cats)
            {
                int temp = cat.point;
                int sponsorPoints = sponsor.GivePoints();
                cat.SetPoints(sponsorPoints);

                Console.WriteLine($" \nCat {cat.name} receives from the sponsor {cat.point} points");
                Console.WriteLine($"and prize {sponsor.GivePrize()} ");
                
                temp += sponsorPoints;
                cat.SetPoints(temp);
            }

            Console.WriteLine("");

            foreach (Cat cat in Cats)
            {
                Console.WriteLine($"Cat {cat.name} receives in sum {cat.point} points");
                if (cat.point >= 9)
                {
                    cat.ChangeTitle();
                    Console.WriteLine($"Congratulations to the cat {cat.name} on receiving a new title {cat.title} ");
                }
            }

            Console.WriteLine($" \nMost points received :");

            Cat[] cats = Cats.ToArray();
            Array.Sort(cats);

            foreach (Cat newcats in cats)
            {
                Console.WriteLine($" {newcats.name} point {newcats.point} ");
            }

            Spectator spectator = new Spectator();
            foreach (Cat cat in cats)
            {
                int peopleChoiseAward = spectator.GivePeopleChoiceAward();
                if (peopleChoiseAward == 1)
                    Console.WriteLine($"\nCat {cat.name} receives People's Choice Award");
            }

            Console.ReadKey();
        }
    }
}
