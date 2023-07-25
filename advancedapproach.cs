// /**
//  * CodinGame planet is being attacked by slimy insectoid aliens.
//  * <---
//  * Hint:To protect the planet, you can implement the pseudo-code provided in the statement, below the player.
//  **/
// You have to output a correct ship name to shoot ("Buzz", enemy1, enemy2, ...)     

using System;
using System.Linq;

class Player
{
    class Enemy
    {
        public string Name { get; set; }
        public int Distance { get; set; }
    }

    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            Enemy[] enemies = new Enemy[2];

            for (int i = 0; i < 2; i++)
            {
                string enemyName = Console.ReadLine();
                int enemyDistance = int.Parse(Console.ReadLine());
                enemies[i] = new Enemy { Name = enemyName, Distance = enemyDistance };
            }

            // Sort the enemies array based on distance (nearest enemy comes first)
            Array.Sort(enemies, (a, b) => a.Distance.CompareTo(b.Distance));

            // Shoot the nearest enemy
            Console.WriteLine(enemies[0].Name);
        }
    }
}
