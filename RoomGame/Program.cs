using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Program
    {
        public static int TurnNum { get; set; }
        static void Main(string[] args)
        {            
            Console.WriteLine("Press anykey to Initialize");
            Console.WriteLine("");
            Console.ReadKey();
            
            ProgramData.loadRooms();
            ProgramData.loadJourneys();
            ProgramData.applyJourneys();
            ProgramData.loadInteractables();
            ProgramData.applyInteractables();
            ProgramData.loadItems();
            ProgramData.loadPeople();

            ProgramData.currentLocation = ProgramData.rooms[0]; //Set starting location here
            TurnNum = 1;

            Console.Clear();
            Console.WriteLine("Please enter a name for your character:");
            PlayerData.Name = Console.ReadLine();
            PlayerData.Health = 10;

            Console.WriteLine($"Press enter to begin the game, {PlayerData.Name}");
            
            while (PlayerData.Health > 0)
            {
                Console.Clear();
                Console.WriteLine(header());
                //MAIN GAME LOOP
                ProgramData.currentLocation.display();
                bool goodInput = false;
                while (!goodInput)
                {
                    string input = Console.ReadLine();
                    int x;
                    if (Int32.TryParse(input, out x))
                    {
                        goodInput = true;
                        InputHandler.roomAction(x);
                    }
                    else
                    {
                        if(input == "i" || input == "I")
                        {
                            InputHandler.menuCommand(input);
                        }
                        goodInput = false;
                        Console.WriteLine("Please enter an integer that matches one of the numbered commands.");
                    }
                }
                Console.ReadKey();
                TurnNum++;
            }            
        }

        private static string header()
        {
            return $"{PlayerData.Name} | Health: {PlayerData.Health} | Turn: {TurnNum} | {ProgramData.currentLocation.Name}";
        }
        public static void inventoryDisplay()
        {
            int i = 1;
            Console.Clear();
            header();
            Console.WriteLine("");
            Console.WriteLine("INVENTORY - Enter a matching number to use an item, or any other key to exit Inventory screen.");
            foreach(Consumable x in PlayerData.inventory)
            {
                Console.WriteLine($"{i}: {x.Name}");
            }
        }
    }
}
