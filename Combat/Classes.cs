﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    public class Classes
    {
        public string name;
        public int defense;
        public string weapon;
        public int weaponDMG;

        private static Random rand = new Random();

        public Classes(string className, int classDefense, string classWeapon, int minDMG, int maxDMG)
        {
            name = className;
            defense = classDefense;
            weapon = classWeapon;
            weaponDMG = rand.Next(minDMG, maxDMG + 1); ;
        }

        public static Classes Warrior = new Classes("Warrior", 10, "Sword", 12, 16);
        public static Classes Mage = new Classes("Mage", 5, "Staff", 18, 20);
        public static Classes Assassin = new Classes("Assassin", 7, "Dagger", 14, 18);
        public static Classes Hunter = new Classes("Hunter", 5, "Bow", 16, 24);

        public void ShowInfo(string classAnswer)
        {
                switch (classAnswer.ToLower())
                {
                    case "warrior":
                        Console.WriteLine("");
                        Console.WriteLine($"{Warrior.name}:");
                        Console.WriteLine($"Defense: {Warrior.defense}");
                        Console.WriteLine($"Weapon: {Warrior.weapon} / DMG: {Warrior.weaponDMG}");
                        Console.WriteLine("");
                        break;
                    case "mage":
                        Console.WriteLine("");
                        Console.WriteLine($"{Mage.name}:");
                        Console.WriteLine($"Defense: {Mage.defense}");
                        Console.WriteLine($"Weapon: {Mage.weapon} / DMG: {Mage.weaponDMG}");
                        Console.WriteLine("");
                        break;
                    case "assassin":
                        Console.WriteLine("");
                        Console.WriteLine($"{Assassin.name}:");
                        Console.WriteLine($"Defense: {Assassin.defense}");
                        Console.WriteLine($"Weapon: {Assassin.weapon} / DMG: {Assassin.weaponDMG}");
                        Console.WriteLine("");
                        break;
                    case "hunter":
                        Console.WriteLine("");
                        Console.WriteLine($"{Hunter.name}:");
                        Console.WriteLine($"Defense: {Hunter.defense}");
                        Console.WriteLine($"Weapon: {Hunter.weapon} / DMG: {Hunter.weaponDMG}");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("What are you talking about?");
                        break;
                }
            
        }

        public void classTalk (string classAnswer)
        {
            switch (classAnswer.ToLower())
            {
                case "warrior":
                    Thread.Sleep(1500);
                    Console.WriteLine("You are indeed courageous... Let's see if you will faint or not.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;
                case "mage":
                    Thread.Sleep(1500);
                    Console.WriteLine("It seems that you preffer looking into what you should not. You shall not prosper.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;
                case "assassin":
                    Thread.Sleep(1500);
                    Console.WriteLine("The one that lurks in the dark, that no one can see... A coward might survive, but at the cost of his honor. But... does he have any?");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;
                case "hunter":
                    Thread.Sleep(1500);
                    Console.WriteLine("Far distances you go, but your feet remains the same. What shall happen to you?");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;
            }
        }
    }
}
