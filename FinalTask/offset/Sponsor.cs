using System;

namespace FinalTask
{
    public class Sponsor : Jury
    {
        enum Prizes { food, couch, scratching_post, toy, bowl, dainty, harness }
        
        public override int GivePoints() => random.Next(1, 4);

        public string GivePrize()
        {   
            Array values = Enum.GetValues(typeof(Prizes));
            int enumLen = values.Length;
            Prizes randomPrizes = (Prizes)values.GetValue(random.Next(values.Length));
            string randomPrize = randomPrizes.ToString();

            return randomPrize;
        }
    }
}

