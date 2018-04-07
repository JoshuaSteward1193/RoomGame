﻿using System;
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
            rooms.Add(new Room("Your Room", "A simple bedroom, not too small, but not very big."));
            rooms.Add(new Room("Dorm Hallway", "A brightly lit hallway, with tile floor and flourescent lights.")); //5
        }

        public static void loadJourneys()
        {
            Console.WriteLine("Loading journeys....");
            journeys.Add(new Journey(rooms[1],"Go to Room 2", "You travel from Testing Room 1 to Testing Room 2.")); /* 0 */
            journeys.Add(new Journey(rooms[0],"Go to Room 1", "You travel from Testing Room 2 to Testing Room 1."));
            journeys.Add(new Journey(rooms[2], "Go to Room 3", "You travel from Testing Room 2 to Testing Room 3."));
            journeys.Add(new Journey(rooms[3], "Go to Room 4", "You travel from Testing Room 3 to Testing Room 4."));
            journeys.Add(new Journey(rooms[2], "Go to room 3", "You travel from Testing Room 4 to Testing Room 3."));
            journeys.Add(new Journey(rooms[5], "Leave your room", "You open the bedroom door and walk out into the " +
                "hallway. You close the door behind you."));
            journeys.Add(new Journey(rooms[4], "Go to your room", "You open the door to your bedroom and enter. You" +
                "close the door behind you."));
        }  
        public static void applyJourneys()
        {            
            rooms[0].addExit(journeys[0]);
            rooms[1].addExit(journeys[1]);
            rooms[1].addExit(journeys[2]);
            rooms[2].addExit(journeys[3]);
            rooms[3].addExit(journeys[4]);
            rooms[4].addExit(journeys[5]);
        }
        public static void loadInteractables()
        {
            //Until more work has been done, have unique interactable for each room. 
            Console.WriteLine("Loading interactables....");
            interactables.Add(new Interactable(1, "There is a small chest here.", "Open the chest", "You bend down and " +
                "gently lift the lid of the chest. The rusty hinges squeak as you open the lid."));
            interactables.Add(new Interactable(1, "There is a big chest here.", "Open the chest", "You bend down and " +
                "gently lift the lid of the chest. The rusty hinges squeak as you open the lid."));
        }
        public static void applyInteractables()
        {
            rooms[2].addInteractable(interactables[0]);
            rooms[3].addInteractable(interactables[1]);
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
