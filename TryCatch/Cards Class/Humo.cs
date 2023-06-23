namespace TryCatch.Class
{
    public class Humo : ICard
    {
        public Humo(string Number, string HolderName, decimal Money)
        : base(Number, HolderName, Money)
        {
            base.Number = Number;
            base.HolderName = HolderName;
            base.Money = Money;
        }
        public override bool Pay(decimal cost)
        {
            base.Money -= cost;
            return true;
        }
        public bool PayWireless(decimal cost)
        {
            if (cost < 50000 || base.Money - cost < 0)
            {
                return false;
            }
            else
            {
                base.Money -= cost;
                return true;
            }
        }
    }
}
