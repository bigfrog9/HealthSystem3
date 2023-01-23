using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3
{
    internal class GameCharacter
    {
        public int health;

        public int lives;

        public string name;

        public int MaxHealth;

        public GameCharacter(int health, int lives, string name)
        {
            this.health = health;
            this.lives = lives;
            this.name = name;
            this.MaxHealth = health;
        }

        public void TakeDamage(int hp)
        {
            health = health - hp;

            Console.WriteLine(name + " took " + hp + " damage!");
            Console.WriteLine();

            if (health < 0) health = 0;

            if (health == 0)
            {
                lives--;

                if (lives > 0)
                {
                    health = 100;
                }
            }

        }

        public void GainHealth(int hp)
        {
            Console.WriteLine(name + "got" + hp + "health!");
            Console.WriteLine();

            health = health + hp;

            if(health > MaxHealth) health = MaxHealth;
        }

        public void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("Health :" + health);
            Console.WriteLine();
            Console.WriteLine();
            
        }

    }
}
