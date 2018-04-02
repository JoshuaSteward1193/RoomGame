using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Room
    {
        public List<Journey> exits;
        public List<Person> occupants;
        public List<Interactable> interactables;

        public string Description { get; set; }
        
        public Room()
        {

        }

        public void addExit(Journey journey)
        {
            exits.Add(journey);
        }
        public void addOccupant(Person o)
        {
            occupants.Add(o);
        }
        public void removeOccupant(Person o)
        {

        }
    }
}
