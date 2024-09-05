using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class Player
    {
        public string characterName;
        public int level;
        public double xp;
        public double maxXp;
        public int characterLife;
        public Classes characterClass;

        public Player(Classes charClass = null, int charLevel = 1, double charXp = 0, double charMaxXp = 50, string charName = " ", int charLife = 100)
        {
            level = charLevel;
            xp = charXp;
            maxXp = charMaxXp;
            characterName = charName;
            characterLife = charLife;
            characterClass = charClass;
        }

        public void InsertName()
        {
            Random rand = new Random();
            int choosenPhrase = rand.Next(0, 2);
            List<string> phrases = new List<string> {"Look's like a clever person...", "You made me curious...", "Strange one. hmpf"};
            
            while (true)
            {
                Console.WriteLine("What is your name, adventurer?");
                string nameAnswer = Console.ReadLine();

                if (nameAnswer == " " || nameAnswer == "")
                {
                    Console.Clear();
                    Thread.Sleep(2500);
                    Console.WriteLine("You can't be no one, nor be the one without a name.");
                    Thread.Sleep(2500);
                    Console.WriteLine("Now tell me, truly...");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    characterName = nameAnswer;
                    break;
                }
            }

            Thread.Sleep(1000);
            Console.WriteLine($"Hmm...");
            Thread.Sleep(2000);
            Console.WriteLine($"{characterName}, right?");
            Thread.Sleep(2500);
            Console.WriteLine(phrases[choosenPhrase]);
            Thread.Sleep(5000);

            Console.Clear();
        }

        public void SelectClass()
        {
            bool keep = true;
            while (keep)
            {
                Console.WriteLine("Now tell me, what best fit's you? Warrior, Mage, Assasin, perhaps a Hunter?");
                string classAnswer = Console.ReadLine();

                switch (classAnswer.ToLower())
                {
                    case "warrior":
                        characterClass = Classes.Warrior;
                        keep = false;
                        break;
                    case "mage":
                        characterClass = Classes.Mage;
                        keep = false;
                        break;
                    case "assassin":
                        characterClass = Classes.Assassin;
                        keep = false;
                        break;
                    case "hunter":
                        characterClass = Classes.Hunter;
                        keep = false;
                        break;
                    default:
                        Console.WriteLine("What are you talking about?");
                        break;
                }

                
            }
            characterClass.ShowInfo(characterClass.name);
            characterClass.classTalk(characterClass.name);
        }

        public void ShowLevelProgress()
        {
            if (xp >= maxXp)
            {
                xp = (xp - maxXp);
                maxXp *=  2;
                level += 1;
                characterClass.weaponDMG += 2;
                Console.WriteLine("________");
                Console.WriteLine("");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"Xp: {xp}/{maxXp}");
                Console.WriteLine($"Weapon DMG: {characterClass.weaponDMG}");
                Console.WriteLine("");
                Console.WriteLine("________");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("________");
                Console.WriteLine("");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"Xp: {xp}/{maxXp}");
                Console.WriteLine($"Weapon DMG: {characterClass.weaponDMG}");
                Console.WriteLine("");
                Console.WriteLine("________");
                Console.WriteLine("");
            }
        }

    }
}
