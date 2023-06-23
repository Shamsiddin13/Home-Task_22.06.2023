namespace TryCatch.Class
{
    public abstract class ICard
    {
        public string Number;
        public string HolderName;
        public decimal Money;
        public ICard(string Number, string HolderName, decimal Money)
        {
            this.Number = Number;
            this.HolderName = HolderName;
            this.Money = Money;
        }

        public abstract bool Pay(decimal cost);



        public decimal Add(decimal amount)
        {
            Money += amount;
            return Money;
        }
        public virtual decimal AddWithBonus(decimal amount)
        {
            Money += amount;
            return Money;
        }

    }





}

