using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Interactable
    {
        public bool Usable { get; set; }
        public int ID { get; set; }
        public int CommandNum { get; set; }    // Iterate in Room to make the command entered match the order
        public int MethodCall { get; set; }    // The id number of the method that this interactable enacts
        public int Uses { get; set; }          // The number of times the interactable can be used before it no longer appears
        public string Description { get; set; }// The description that is appended onto the room description
        public string Command { get; set; }    // The text for the command 
        public string Action { get; set; }     // The text the user reads when enact is called
        

       public Interactable(int mc, string d, string c, string a, int u = 1)
        {
            ProgramData.numberOfInteractables++;
            ID = ProgramData.numberOfInteractables;
            MethodCall = mc;
            Description = d;
            Command = c;
            Action = a;
            Uses = u;
            if(Uses > 0)
            {
                Usable = true;
            } else
            {
                Usable = false;
            }
        }        

        public void enact()
        {
            Uses--;
            
            Console.WriteLine(Action);
            ProgramData.enactInteractable(MethodCall);
            if (Uses >= 0)
            {
                ProgramData.currentLocation.removeInteractable(ID);
            }
        }

    }
}
