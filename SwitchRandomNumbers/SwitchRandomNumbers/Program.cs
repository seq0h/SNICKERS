namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühgest kuni kuueni");

            //kõik kuus numbrit tuleb ära käsitleda switchiga

            Console.Write("Sisesta number 1 kuni 6: ");
            Random random = new Random();
            int number = random.Next(1, 7); //Genereerib arvu 1 kuni 6

            Console.WriteLine("Genereeritud number: {number}");
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("üks");
                        break;
                    case 2:
                        Console.WriteLine("kaks");
                        break;
                    case 3:
                        Console.WriteLine("kolm");
                        break;
                    case 4:
                        Console.WriteLine("neli");
                        break;
                    case 5:
                        Console.WriteLine("viis");
                        break;
                    case 6:
                        Console.WriteLine("kuus");
                        break;
                    default:
                        Console.WriteLine("Palun sisesta number vahemikus 1 kuni 6.");
                        break;
                }
            }
           
            {
                
            }
        }
    }
}

