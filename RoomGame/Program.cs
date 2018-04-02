﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Press anykey to Initialize");
            Console.WriteLine("");
            Console.ReadKey();
            
            ProgramData.loadRooms();
            ProgramData.loadJourneys();
            ProgramData.applyJourneys();
            ProgramData.loadPeople();

            PlayerData.Health = 10;
            ProgramData.currentLocation = ProgramData.rooms[0];

            while (PlayerData.Health > 0)
            {
                //MAIN GAME LOOP
                ProgramData.currentLocation.display();
                int x;
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    InputHandler.roomAction(x);
                }
                else
                {
                    Console.WriteLine("Please enter an integer that matches one of the numbered commands.");
                }                
            }            
        }
    }
}
