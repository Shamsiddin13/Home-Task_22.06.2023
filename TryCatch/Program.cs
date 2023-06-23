using TryCatch.Class;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool check;

        UzCard uzcard = new UzCard("9999 8888 5555 4444", "Umarov Shamsiddin", 60000);
        uzcard.AddWithBonus(10000);
        check = uzcard.Pay(60000);
        Console.Write("UzCard\n" + uzcard.Money + " ");
        if (check == false)
        {
            Console.WriteLine(check);
        }


        Humo humo = new Humo("1111 2222 3333 4444", "Umarov Shamsiddin", 75000);
        humo.Pay(55000);
        check = humo.PayWireless(50000);

        if (check == true) { Console.Write("\n\nHumo\n" + humo.Money + " "); }

        else if (check == false)
        {
            Console.WriteLine("\n\nHumo\n" + check);
        }

        Console.WriteLine();
    }
}