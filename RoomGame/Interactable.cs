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
        //NEED: A BOOL THAT IS TRUE WHILE USES > 0
        //THIS BOOL WILL TELL ROOM.DISPLAY() WHETHER TO SHOW AN INTERACTABLE OR NOT. 

        public void enact()
        {
            Uses--;
            if(Uses == 0)
            {
                Usable = false;
            }
            Console.WriteLine(Action);
            ProgramData.enactInteractable(MethodCall);
        }

    }
}
