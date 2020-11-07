namespace FinalTask
{
    class Judge : Jury
    {        
        public override int GivePoints() =>  random.Next(1, 11);
    }
}
