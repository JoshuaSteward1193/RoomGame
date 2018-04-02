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
        public static List<Room> rooms = new List<Room>();
        public static List<Journey> journeys = new List<Journey>();
        public static List<Person> people = new List<Person>();

        public static Room currentLocation;

        public static void loadRooms()
        {
            Console.WriteLine("Loading rooms....");
            /* 0 */ rooms.Add(new Room("Test Room 1", "This is the first room for testing."));
                    rooms.Add(new Room("Test Room 2", "This is the second room for testing."));
        }

        public static void loadJourneys()
        {
            Console.WriteLine("Loading journeys....");
            /* 0 */ journeys.Add(new Journey(rooms[1],"Go to Room 2", "You travel from Testing Room 1 to Testing Room 2."));
                    journeys.Add(new Journey(rooms[0],"Go to Room 1", "You travel from Testing Room 2 to Testing Room 1."));
        }  
        public static void applyJourneys()
        {
             rooms[0].addExit(journeys[0]);
             rooms[1].addExit(journeys[1]);
        }

        public static void loadPeople()
        {
            Console.WriteLine("Loading people....");
            /* 0 */ people.Add(new Person("Toby", "Johns", rooms[1] ,60));
        }
    }
}
