using System;
using System.Collections.Generic;
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


        public Classes(string className, int classDefense, string classWeapon, int classWeaponDMG)
        {
            name = className;
            defense = classDefense;
            weapon = classWeapon;
            weaponDMG = classWeaponDMG;
        }

        public static Classes Warrior = new Classes("Warrior", 10, "Sword", 0);
        public static Classes Mage = new Classes("Mage", 5, "Staff", 0);
        public static Classes Assassin = new Classes("Assassin", 7, "Dagger", 0);
        public static Classes Hunter = new Classes("Hunter", 5, "Bow", 0);

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
    }
}
