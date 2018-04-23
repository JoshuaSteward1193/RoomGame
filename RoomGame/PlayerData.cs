using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class PlayerData
    {
        public static int Health { get; set; }
        public static int MaxHealth { get; set; }
        public static string Name { get; set; }

        public static void gainHealth(int value)
        {
            Health = Health + value;
            if(Health > MaxHealth)
            {
                Health = MaxHealth;
            }
            Console.WriteLine($"Your health is now at {Health}/{MaxHealth}.");
        }
    }
}
