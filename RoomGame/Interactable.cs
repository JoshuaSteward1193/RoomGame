using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Interactable
    {
        public int ID { get; set; }
        public int MethodCall { get; set; }    // The id number of the method that this interactable enacts
        public string Description { get; set; }// The description that is appended onto the room description
        public string Command { get; set; }    // The text for the command 
        public string Action { get; set; }     // The text the user reads when enact is called

       public Interactable(int mc, string d, string c, string a)
        {
            ProgramData.numberOfInteractables++;
            ID = ProgramData.numberOfInteractables;
            MethodCall = mc;
            Description = d;
            Command = c;
            Action = a;
        }
        public void enact()
        {
            Console.WriteLine(Action);
            ProgramData.enactInteractable(MethodCall);
        }

    }
}
