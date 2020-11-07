using System;

namespace FinalTask
{
    public class Spectator
    {
        private static Random rand = new Random();

        public int GivePeopleChoiceAward() => rand.Next(0, 2);
    }
}
