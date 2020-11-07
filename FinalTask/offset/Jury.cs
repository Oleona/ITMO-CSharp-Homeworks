using System;

namespace FinalTask
{
   public  abstract class Jury
    {
        protected static Random random = new Random();

        public abstract int GivePoints();      
    }

}
