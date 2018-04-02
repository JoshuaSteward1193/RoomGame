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
                    rooms.Add(new Room("Test Room 3", "This is the third room for testing. It has an interactable in it!"));
                    rooms.Add(new Room("Test Room 4", "This is the fourth room for testing. There is a person here!"));
        }

        public static void loadJourneys()
        {
            Console.WriteLine("Loading journeys....");
            /* 0 */ journeys.Add(new Journey(rooms[1],"Go to Room 2", "You travel from Testing Room 1 to Testing Room 2."));
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

        public static void loadPeople()
        {
            Console.WriteLine("Loading people....");
            /* 0 */ people.Add(new Person("Toby", "Johnson", rooms[4] ,60));
        }
    }
}
