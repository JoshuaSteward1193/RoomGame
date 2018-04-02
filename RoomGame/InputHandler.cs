using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class InputHandler
    {
        public static void roomAction(int value)
        {
            if(value > 0 && value <= ProgramData.currentLocation.exits.Count)
            {
                ProgramData.currentLocation.takeExit(value - 1);
            }
            else
            {
                Console.WriteLine("The entered number does not match an applicible command.");
            }
        }
    }
}
