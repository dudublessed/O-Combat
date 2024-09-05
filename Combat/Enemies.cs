using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    public class Enemies
    {
        public string name;
        public int life;
        public int defense;
        public int dmg;
        public double givenXP;


        public Enemies(string enemyName, int enemyLife, int enemyDefense, int enemyDMG, double enemyGivenXP)
        {
            name = enemyName;
            life = enemyLife;
            defense = enemyDefense;
            dmg = enemyDMG;
            givenXP = enemyGivenXP;
        }

        // Mobs
        public static Enemies Goblin = new Enemies("Goblin", 100, 5, 15, 10);
        public static Enemies Orc = new Enemies("Orc", 150, 10, 20, 30);
        public static Enemies Troll = new Enemies("Troll", 150, 10, 30, 80);

        // Humans
        public static Enemies BlackMage = new Enemies("Black mage", 350, 0, 15, 250);

        public void CombatEnemy(string enemyName, string playerName, int playerHealth, int playerDefense, int playerDMG, ref double playerXP)
        {
            bool enemyAlive = true;
            bool playerTurn = true;
            bool isDefending = false;
            switch(enemyName)
            {
                case "goblin":
                    Console.WriteLine($"A wild {Goblin.name} appeared!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Shshshsh... shshshsh...");
                    Console.WriteLine("");

                    while (enemyAlive)
                    {
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine($"Farewell {playerName}. This world was not ment for you anyways.");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            if (Goblin.life <= 0)
                            {
                                Console.WriteLine($"{Goblin.name} is dead. Congratulations!");
                                Console.WriteLine($"You received {Goblin.givenXP} xp.");
                                Console.WriteLine($" ");
                                playerXP += Goblin.givenXP;
                                Thread.Sleep(500);
                                Goblin.life = 100;
                                playerHealth = 100;
                                enemyAlive = false;

                            }
                            else
                            {
                                Thread.Sleep(1500);
                                Console.WriteLine("");
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{Goblin.name}:");
                                Console.WriteLine($"Health: {Goblin.life}");
                                Console.WriteLine($"Defense: {Goblin.defense}");
                                Console.WriteLine($"DMG: {Goblin.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                if (playerTurn)
                                {
                                    playerTurn = false;

                                    while (true)
                                    {
                                        Console.WriteLine("It's your turn. Attack or Defend?");
                                        string selectAction = Console.ReadLine();

                                        if (selectAction.ToLower() == "attack")
                                        {
                                            int effectivePlayerDamage = Math.Max(playerDMG - Goblin.defense, 0);
                                            Goblin.life -= effectivePlayerDamage;
                                            break;
                                        }
                                        else if (selectAction.ToLower() == "defend")
                                        {
                                            playerDefense += 15;
                                            isDefending = true;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Select a valid option.");
                                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                                            Console.WriteLine("");
                                        }
                                    }
                                }

                                Console.WriteLine("");
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{Goblin.name}:");
                                Console.WriteLine($"Health: {Goblin.life}");
                                Console.WriteLine($"Defense: {Goblin.defense}");
                                Console.WriteLine($"DMG: {Goblin.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                Thread.Sleep(1000);
                                if (!playerTurn && Goblin.life >= 0)
                                {
                                    playerTurn = true;

                                    Console.WriteLine("");
                                    Console.WriteLine("Now it's the enemy. Take care.");

                                    // Enemy attack (always attacks)

                                    int effectiveEnemyDamage = Math.Max(Goblin.dmg - playerDefense, 0);
                                    playerHealth -= effectiveEnemyDamage;

                                    if (isDefending)
                                    {
                                        isDefending = false;
                                        playerDefense -= 15;
                                    }
                                }
                            }


                        }
                    }
                    break;

                case "orc":
                    Console.WriteLine($"A dangerous {Orc.name} appeared!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Hgron mshvatz!! Hgron mshvatz!!");
                    Console.WriteLine("");

                    while (enemyAlive)
                    {
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine($"Farewell {playerName}. This world was not ment for you anyways.");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            if (Orc.life <= 0)
                            {
                                Console.WriteLine($"{Orc.name} is dead. Congratulations!");
                                Console.WriteLine($"You received {Orc.givenXP} xp.");
                                Console.WriteLine($" ");
                                playerXP += Orc.givenXP;
                                Thread.Sleep(500);
                                Orc.life = 150;
                                playerHealth = 100;
                                enemyAlive = false;
                            }
                            else
                            {
                                Thread.Sleep(1500);
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{Orc.name}:");
                                Console.WriteLine($"Health: {Orc.life}");
                                Console.WriteLine($"Defense: {Orc.defense}");
                                Console.WriteLine($"DMG: {Orc.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                if (playerTurn)
                                {
                                    playerTurn = false;

                                    while (true)
                                    {
                                        Console.WriteLine("It's your turn. Attack or Defend?");
                                        string selectAction = Console.ReadLine();

                                        if (selectAction.ToLower() == "attack")
                                        {
                                            int effectivePlayerDamage = Math.Max(playerDMG - Orc.defense, 0);
                                            Orc.life -= effectivePlayerDamage;
                                            break;
                                        }
                                        else if (selectAction.ToLower() == "defend")
                                        {
                                            playerDefense += 15;
                                            isDefending = true;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Select a valid option.");
                                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                                            Console.WriteLine("");
                                        }
                                    }
                                }

                                Console.WriteLine("");
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{Orc.name}:");
                                Console.WriteLine($"Health: {Orc.life}");
                                Console.WriteLine($"Defense: {Orc.defense}");
                                Console.WriteLine($"DMG: {Orc.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                Thread.Sleep(1000);
                                if (!playerTurn && Orc.life >= 0)
                                {
                                    playerTurn = true;

                                    Console.WriteLine("");
                                    Console.WriteLine("Now it's the enemy. Take care.");

                                    // Enemy attack (always attacks)

                                    int effectiveEnemyDamage = Math.Max(Orc.dmg - playerDefense, 0);
                                    playerHealth -= effectiveEnemyDamage;

                                    if (isDefending)
                                    {
                                        isDefending = false;
                                        playerDefense -= 15;
                                    }
                                }
                            }
                        
                        }
                    }
                    break;

                case "troll":
                    Console.WriteLine($"A {Troll.name} appeared! That one is indeed a big threat...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Hur HUMMMMM!!!");
                    Console.WriteLine("");

                    while (enemyAlive)
                    {
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine($"Farewell {playerName}. This world was not ment for you anyways.");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            if (Troll.life <= 0)
                            {
                                Console.WriteLine($"{Troll.name} is dead. Congratulations!");
                                Console.WriteLine($"You received {Troll.givenXP} xp.");
                                Console.WriteLine($" ");
                                playerXP += Troll.givenXP;
                                Thread.Sleep(500);
                                Troll.life = 150;
                                playerHealth = 100;
                                enemyAlive = false;
                            }
                            else
                            {
                                Thread.Sleep(1500);
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{Troll.name}:");
                                Console.WriteLine($"Health: {Troll.life}");
                                Console.WriteLine($"Defense: {Troll.defense}");
                                Console.WriteLine($"DMG: {Troll.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                if (playerTurn)
                                {
                                    playerTurn = false;

                                    while (true)
                                    {
                                        Console.WriteLine("It's your turn. Attack or Defend?");
                                        string selectAction = Console.ReadLine();

                                        if (selectAction.ToLower() == "attack")
                                        {
                                            int effectivePlayerDamage = Math.Max(playerDMG - Troll.defense, 0);
                                            Troll.life -= effectivePlayerDamage;
                                            break;
                                        }
                                        else if (selectAction.ToLower() == "defend")
                                        {
                                            playerDefense += 15;
                                            isDefending = true;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Select a valid option.");
                                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                                            Console.WriteLine("");
                                        }
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{Troll.name}:");
                                Console.WriteLine($"Health: {Troll.life}");
                                Console.WriteLine($"Defense: {Troll.defense}");
                                Console.WriteLine($"DMG: {Troll.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                Thread.Sleep(1000);
                                if (!playerTurn && Troll.life >= 0)
                                {
                                    playerTurn = true;

                                    Console.WriteLine("");
                                    Console.WriteLine("Now it's the enemy. Take care.");

                                    // Enemy attack (always attacks)

                                    int effectiveEnemyDamage = Math.Max(Troll.dmg - playerDefense, 0);
                                    playerHealth -= effectiveEnemyDamage;

                                    if (isDefending)
                                    {
                                        isDefending = false;
                                        playerDefense -= 15;
                                    }
                                }
                            }
                       
                        }
                    }
                    break;

                case "blackmage":
                    Console.WriteLine($"A dark {BlackMage.name} appeared!");
                    Thread.Sleep(2000);
                    Console.WriteLine("A pitiful being, you have no chance against me. Beg for your life.");
                    Console.WriteLine("");

                    while (enemyAlive)
                    {
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine($"Farewell {playerName}. This world was not ment for you anyways.");
                            Thread.Sleep(5000);
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            if (BlackMage.life <= 0)
                            {
                                Console.WriteLine($"{BlackMage.name} is dead. Congratulations!");
                                Console.WriteLine($"You received {BlackMage.givenXP} xp.");
                                Console.WriteLine($" ");
                                playerXP += BlackMage.givenXP;
                                Thread.Sleep(500);
                                BlackMage.life = 350;
                                playerHealth = 100;
                                enemyAlive = false;
                            }
                            else
                            {
                                Thread.Sleep(1500);
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{BlackMage.name}:");
                                Console.WriteLine($"Health: {BlackMage.life}");
                                Console.WriteLine($"Defense: {BlackMage.defense}");
                                Console.WriteLine($"DMG: {BlackMage.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                if (playerTurn)
                                {
                                    playerTurn = false;

                                    while (true)
                                    {
                                        Console.WriteLine("It's your turn. Attack or Defend?");
                                        string selectAction = Console.ReadLine();

                                        if (selectAction.ToLower() == "attack")
                                        {
                                            int effectivePlayerDamage = Math.Max(playerDMG - BlackMage.defense, 0);
                                            BlackMage.life -= effectivePlayerDamage;

                                            break;
                                        }
                                        else if (selectAction.ToLower() == "defend")
                                        {
                                            playerDefense += 15;
                                            isDefending = true;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Select a valid option.");
                                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                                            Console.WriteLine("");
                                        }
                                    }
                                }

                                Console.WriteLine("");
                                Console.WriteLine("____________");
                                Console.WriteLine("");
                                Console.WriteLine($"{BlackMage.name}:");
                                Console.WriteLine($"Health: {BlackMage.life}");
                                Console.WriteLine($"Defense: {BlackMage.defense}");
                                Console.WriteLine($"DMG: {BlackMage.dmg}");
                                Console.WriteLine("");
                                Console.WriteLine("____________");

                                Console.WriteLine("");
                                Console.WriteLine($"{playerName}:");
                                Console.WriteLine($"Health: {playerHealth}");
                                Console.WriteLine($"Defense: {playerDefense}");
                                Console.WriteLine($"DMG: {playerDMG}");
                                Console.WriteLine("");

                                Thread.Sleep(1000);
                                if (!playerTurn && BlackMage.life >= 0)
                                {
                                    playerTurn = true;

                                    Console.WriteLine("");
                                    Console.WriteLine("Now it's the enemy. Take care.");

                                    // Enemy attack (always attacks)

                                    int effectiveEnemyDamage = Math.Max(BlackMage.dmg - playerDefense, 0);
                                    playerHealth -= effectiveEnemyDamage;

                                    if (isDefending)
                                    {
                                        isDefending = false;
                                        playerDefense -= 15;
                                    }
                                }
                            }
                        
                        }
                    }
                    break;
            }
        }

    }

}
