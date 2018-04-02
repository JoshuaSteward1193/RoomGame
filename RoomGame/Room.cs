using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Room
    {
        public List<Journey> exits = new List<Journey>();
        public List<Person> occupants = new List<Person>();
        public List<Interactable> interactables = new List<Interactable>();

        public string Name { get; set; }
        public string Description { get; set; }
        
        public Room(string n, string d)
        {
            Name = n;
            Description = d;
        }

        public void display()
        {
            //Prints relevant information to the console
            Console.WriteLine(Description);
            Console.WriteLine("");
            int i = 1;
            foreach(Journey x in exits)
            {
                Console.WriteLine($"{i}. {x.Description}");
            }
        }
        public void takeExit(int value)
        {
            //Enacts the actions of the indicated journey
            //Input validation is done in the InputHandler.roomAction() method
            exits[value].enact();
        }

        public void addExit(Journey journey)
        {
            //Adds indicated journey to a rooom
            exits.Add(journey);
        }
        public void removeExit(Journey journey)
        {
            //Removes indicated journey from a room
        }
        public void addOccupant(Person o)
        {
            //Adds indicated occupant to a room
            occupants.Add(o);
        }
        public void removeOccupant(Person o)
        {
            //Removes indicated occupant from a room.
        }
    }
}
