using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Player = new Player(100, 3, "You");

            Enemy Enemy = new Enemy(50, 0, "Goblin");

            Player.ShowHUD();

            Enemy.ShowHUD();

            Player.TakeDamage(33);

            Enemy.TakeDamage(15);

            Player.ShowHUD();

            Enemy.ShowHUD();

            Player.GainHealth(20);

            Enemy.GainHealth(100);

            Player.ShowHUD();

            Enemy.ShowHUD();

            Console.ReadKey(true);
        }
    }
}
