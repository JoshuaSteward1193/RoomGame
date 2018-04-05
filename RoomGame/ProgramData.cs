using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class ProgramData
    {
        public static int numberOfPeople = 0;
        public static int numberOfInteractables = 0;
        public static List<Room> rooms = new List<Room>();
        public static List<Journey> journeys = new List<Journey>();
        public static List<Person> people = new List<Person>();
        public static List<Interactable> interactables = new List<Interactable>();

        public static Room currentLocation;

        public static void loadRooms()
        {
            Console.WriteLine("Loading rooms....");
            rooms.Add(new Room("Test Room 1", "This is the first room for testing.")); /* 0 */
            rooms.Add(new Room("Test Room 2", "This is the second room for testing."));
            rooms.Add(new Room("Test Room 3", "This is the third room for testing. It has an interactable in it!"));
            rooms.Add(new Room("Test Room 4", "This is the fourth room for testing. There is a second interactable here!"));
        }

        public static void loadJourneys()
        {
            Console.WriteLine("Loading journeys....");
            journeys.Add(new Journey(rooms[1],"Go to Room 2", "You travel from Testing Room 1 to Testing Room 2.")); /* 0 */
            journeys.Add(new Journey(rooms[0],"Go to Room 1", "You travel from Testing Room 2 to Testing Room 1."));
            journeys.Add(new Journey(rooms[2], "Go to Room 3", "You travel from Testing Room 2 to Testing Room 3."));
            journeys.Add(new Journey(rooms[3], "Go to Room 4", "You travel from Testing Room 3 to Testing Room 4."));
        }  
        public static void applyJourneys()
        {            
            rooms[0].addExit(journeys[0]);
            rooms[1].addExit(journeys[1]);
            rooms[1].addExit(journeys[2]);
            rooms[2].addExit(journeys[3]);
        }
        public static void loadInteractables()
        {
            Console.WriteLine("Loading interactables....");
            interactables.Add(new Interactable(1, "There is a small chest here.", "Open the chest", "You bend down and " +
                "gently lift the lid of the chest. The rusty hinges squeak as you open the lid."));
        }
        public static void applyInteractables()
        {
            rooms[2].addInteractable(interactables[0]);
            rooms[3].addInteractable(interactables[0]);
        }
        public static void loadPeople()
        {
            Console.WriteLine("Loading people....");
            people.Add(new Person("Toby", "Johnson", rooms[3], 60)); /* 0 */
        }

        public static void enactInteractable(int id)
        {
            switch (id)
            {
                case 1:
                    Console.WriteLine("You find nothing.");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
    }
}
