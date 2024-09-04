using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    internal class Enemies
    {
        public string name;
        public int life;
        public int defense;
        public int dmg;


        public Enemies(string enemyName, int enemyLife, int enemyDefense, int enemyDMG)
        {
            name = enemyName;
            life = enemyLife;
            defense = enemyDefense;
            dmg = enemyDMG;
        }

        // Mobs
        public static Enemies Goblin = new Enemies("Goblin", 100, 5, 15);
        public static Enemies Orc = new Enemies("Orc", 150, 10, 10);
        public static Enemies Troll = new Enemies("Troll", 100, 15, 30);

        // Humans
        public static Enemies BlackMage = new Enemies("Black mage", 350, 0, 15);
    }
}
