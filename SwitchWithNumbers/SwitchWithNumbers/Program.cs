namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Teie töö on teha switch rakendus,
            //kus on kolm case (1, 2, 3)
            //Iga case puhul teeb erinev arv beep-e

            Console.Write("Sisesta number (1, 2 või 3): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number)) ;


            switch (number)
            {
                case 1:
                    Console.Beep(1000,500);
                    break;
                case 2:
                    Console.Beep(2000,500);
                    Console.Beep(2000,500);
                    break;
                case 3:
                    Console.Beep(3000,500);
                    Console.Beep(3000, 500);
                    Console.Beep(3000, 500);
                    break;
                default:
                    Console.WriteLine("Palun sisesta number 1, 2 või 3.");
                    break;



            }
        }
    }
}
