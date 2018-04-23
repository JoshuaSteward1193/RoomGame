using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    abstract class Item
    {
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string FlavorText { get; set; }

        public void get()
        {

        }
    }
}
