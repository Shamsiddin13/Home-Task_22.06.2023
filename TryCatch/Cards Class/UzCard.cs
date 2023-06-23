namespace TryCatch.Class
{
    public class UzCard : ICard
    {
        public UzCard(string Number, string HolderName, decimal Money)
        : base(Number, HolderName, Money)
        {
            base.Number = Number;
            base.HolderName = HolderName;
            base.Money = Money;
        }

        public override decimal AddWithBonus(decimal amout)
        {
            base.Money += amout;
            return base.Money;
        }
        public override bool Pay(decimal cost)
        {
            if (base.Money - cost < 0)
            {
                return false;
            }
            else { base.Money -= cost; return true; }
        }
    }
    
}
