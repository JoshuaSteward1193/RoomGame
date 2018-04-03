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
            int countI = ProgramData.currentLocation.interactables.Count;
            int countE = ProgramData.currentLocation.exits.Count;

            if(value > 0 && value <= countI)
            {
                ProgramData.currentLocation.useInteractable(value - 1);
            }
            else if(value > countI && value <= countE + countI)
            {
                ProgramData.currentLocation.takeExit(value - 1 - countI);
            }
            else
            {
                Console.WriteLine("The entered number does not match an applicible command.");
            }
        }
    }
}
