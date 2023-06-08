namespace SoftServe1lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write a number of iterations ");
            var x = Convert.ToInt32(Console.ReadLine());
            int i;
            Console.BackgroundColor = ConsoleColor.Green;

            for (i = 0; i < x; i++)
            {
                Console.WriteLine("▒▒▒▒▒▒▐███████▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐░▀░▀░▀░▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐▄▄▄▄▄▄▄▌▒▒▒▒▒▒");
                Console.WriteLine("▄▀▀▀█▒▐░▀▀▄▀▀░▌▒█▀▀▀▄");
                Console.WriteLine("▌▌▌▌▐▒▄▌░▄▄▄░▐▄▒▌▐▐▐▐");
                Thread.Sleep(600);
                Console.Clear();
                Console.WriteLine("▒▒▒▒▒▒▐███████▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐░▀░▀░▀░▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐▄▄▄▄▄▄▄▌▒▒▒▒▒▒");
                Console.WriteLine("▄▀▀▀█▒▐░▀ ▄ ▀░▌▒█▀▀▀▄");
                Console.WriteLine("▌▌▌▌▐▒▄▌░▄▄▄░▐▄▒▌▐▐▐▐");
                Thread.Sleep(600);
                Console.Clear();

            }


            Console.WriteLine("▒▒▒▒▒▒▐███████▌▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒▐░▀░▀░▀░▌▒▒▒▒▒▒");
            Console.WriteLine("▒▒▒▒▒▒▐▄▄▄▄▄▄▄▌▒▒▒▒▒▒");
            Console.WriteLine("▄▀▀▀█▒▐░▀▀▄▀▀░▌▒█▀▀▀▄");
            Console.WriteLine("▌▌▌▌▐▒▄▌░▄▄▄░▐▄▒▌▐▐▐▐");

            Console.Write("Is bear sleeping?");
            string answer = Console.ReadLine();
            if (answer == "y")
                {
                Console.WriteLine("▒▒▒▒▒▒▐███████▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐░▀░▀░▀░▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐▄▄▄▄▄▄▄▌▒▒▒▒▒▒");
                Console.WriteLine("▄▀▀▀█▒▐░▀▀▄▀▀░▌▒█▀▀▀▄");
                Console.WriteLine("▌▌▌▌▐▒▄▌░▄▄▄░▐▄▒▌▐▐▐▐");
                Thread.Sleep(800);
            }
            else if (answer == "n")
            {
                Console.WriteLine("▒▒▒▒▒▒▐███████▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐░▀░▀░▀░▌▒▒▒▒▒▒");
                Console.WriteLine("▒▒▒▒▒▒▐▄▄▄▄▄▄▄▌▒▒▒▒▒▒");
                Console.WriteLine("▄▀▀▀█▒▐░  ▄  ░▌▒█▀▀▀▄");
                Console.WriteLine("▌▌▌▌▐▒▄▌░▄▄▄░▐▄▒▌▐▐▐▐");
                Thread.Sleep(800);
            }
;
        }
    }
}