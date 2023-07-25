using System;

class Player
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            string enemy1 = Console.ReadLine(); // name of enemy 1
            int dist1 = int.Parse(Console.ReadLine()); // distance to enemy 1
            string enemy2 = Console.ReadLine(); // name of enemy 2
            int dist2 = int.Parse(Console.ReadLine()); // distance to enemy 2

            // Identify the nearest enemy
            string nearestEnemy;
            if (dist1 < dist2)
                nearestEnemy = enemy1;
            else
                nearestEnemy = enemy2;

            // Shoot the nearest enemy
            Console.WriteLine(nearestEnemy);
        }
    }
}
