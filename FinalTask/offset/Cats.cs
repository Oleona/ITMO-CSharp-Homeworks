using System;

namespace FinalTask
{
    public class Cat : IComparable
    {
        public readonly string name;
        public readonly Age age;
        public string title { get; private set; }     
        public string ring { get; private set; }
        public int point { get; private set; }

        static private Random rand = new Random();

        public void SetPoints(int point) => this.point = point;
        public void SetRing(string ring) => this.ring = ring;

        public struct Age
        {
            public int year;
            public int month;

            public Age(int year, int month)
            {
                this.year = year;
                this.month = month;
            }
        }

        public Cat(string catName, int year, int month)
        {
            name = catName;
            age = new Age(year, month);
        }

        public Cat(string catName, int year, int month, string title, string ring, int point)
            : this(catName, year, month)
        {
            this.title = title;
            this.ring = ring;
            this.point = point;
        }

        public string SetTitle()
        {
            int index = rand.Next(0, 4);

            switch (index)
            {
                case 0:
                    return title = "NoTitle";
                case 1:
                    return title = "Champion";
                case 2:
                    return title = "GrandChampion";
                case 3:
                    return title = "GrInterChampion";
                case 4:
                    return title = "WorldChampion";
                default:
                    throw new Exception("Incorrect title number");
            }
        }

        public string ChangeTitle()
        {
            switch (title)
            {
                case "NoTitle":
                    return title = "Champion";
                case "Champion":
                    return title = "GrandChampion";
                case "GrandChampion":
                    return title = "GrInterChampion";
                case "GrInterChampion":
                    return title = "WorldChampion";
                case "WorldChampion":
                    return title = "You have confirmed your title";
                default:
                    throw new Exception("Incorrect title");
            }
        }


        public string RingParticipantNoTitle() => "pet";

        public string RingParticipant(int year)
        {
            if (age.year == 0)
                return "kitten";
            else if (age.year >= 7)
                return "veteran";
            else
                return "adult_animal";
        }

        public int CompareTo(object obj)
        {
            Cat it = obj as Cat;

            if (this.point == it.point) return 0;
            else if (this.point > it.point) return -1;
            else return 1;
        }
    }
}







