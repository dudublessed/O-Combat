using System;


namespace Combat
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Player player = new Player();

            // Mobs
            Enemies goblin = Enemies.Goblin;
            Enemies orc = Enemies.Orc;
            Enemies troll = Enemies.Troll;

            // Human 
            Enemies blackmage = Enemies.BlackMage;


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
            Thread.Sleep(100);
            player.SelectClass(); // You can Select your Class, will display your class atributtes and it will display an conversation.

            Console.WriteLine("Let's start your adventure.");
            Thread.Sleep(2000);
            Console.WriteLine("You are in the Black Forest. Take care.");
            Thread.Sleep(2000);
            Console.Clear();

            // Game section


            while (true)
            {

                string[] mobEnemies = {"goblin", "orc", "troll", "blackmage"};
                double[] chances = {0.7, 0.15, 0.1, 0.05};

                string selectedMob = GetRandomMob(mobEnemies, chances);

                switch (selectedMob)
                {
                    case "goblin":
                        goblin.CombatEnemy(selectedMob, player.characterName, player.characterLife, player.characterClass.defense, player.characterClass.weaponDMG, ref player.xp);
                        player.ShowLevelProgress();
                        break;
                    case "orc":
                        orc.CombatEnemy(selectedMob, player.characterName, player.characterLife, player.characterClass.defense, player.characterClass.weaponDMG, ref player.xp);
                        player.ShowLevelProgress();
                        break;
                    case "troll":
                        troll.CombatEnemy(selectedMob, player.characterName, player.characterLife, player.characterClass.defense, player.characterClass.weaponDMG, ref player.xp);
                        player.ShowLevelProgress();
                        break;
                    case "blackmage":
                        blackmage.CombatEnemy(selectedMob, player.characterName, player.characterLife, player.characterClass.defense, player.characterClass.weaponDMG, ref player.xp);
                        player.ShowLevelProgress();
                        break;

                      
                }

                Thread.Sleep(2000);


            }

            static string GetRandomMob(string[] mobs, double[] chances)
            {
                double randomValue = rand.NextDouble();
                double cumulativeChance = 0.0;

                for (int i = 0; i < mobs.Length; i++)
                {
                    cumulativeChance += chances[i];
                    if (randomValue <= cumulativeChance)
                    {
                        return mobs[i];
                    }
                }

                // Retorna o primeiro mob em caso de erro
                return mobs[0];
            }

        }
    }
}
