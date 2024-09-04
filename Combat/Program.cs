using System;


namespace Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Random rand = new Random();
            int delay = 1500;

            Console.WriteLine("Welcome to O'Combat!");

            Thread.Sleep(2000);

            Console.Clear();

            for (int i = 0; i < 100; i++)
            {
                int randDelay = rand.Next(1, 1);
                string loadMessage = $"Loading {i}/100";
                Console.WriteLine(loadMessage);


                Thread.Sleep(randDelay);

                Console.SetCursorPosition(0, Console.CursorTop - 1);

            }

            Console.Clear();

            Console.WriteLine("Loading Completed!");

            Thread.Sleep(3000);

            Console.Clear();

            bool enterPressed = false;

            while(!enterPressed)
            {
                string startMessage = "Press 'Enter' to start.";
                Console.WriteLine(startMessage);
                Thread.Sleep(delay);

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    enterPressed = true;
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine(new string(' ', startMessage.Length));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Thread.Sleep(delay / 2);
                }
            }

            Console.Clear();

            player.InsertName();

            player.SelectClass();


            
        }
    }
}
