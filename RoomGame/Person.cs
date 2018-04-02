using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    class Person
    {
        public int ID { get; set; }
        public int mood;
        public int Mood
        {
            get
            {
                return mood;
            }
            set
            {
                if(value > 100)
                {
                    value = 100;
                }
                if(value < 0)
                {
                    value = 0;
                }
                mood = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Room Location { get; set; }

        public Person(string fn, string ln, Room l, int m = 50 )
        {
            ProgramData.numberOfPeople++;
            ID = ProgramData.numberOfPeople;
            Mood = m;
            FirstName = fn;
            LastName = ln;
            FullName = $"{FirstName} {LastName}";
            Location = l;
        }
    }
}
