using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    abstract class Consumable : Item
    {
        public string UseText { get; set; }
        virtual public void use()
        {

        }
        
    }
}
