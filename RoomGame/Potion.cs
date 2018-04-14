using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGame
{
    
    class Potion : Consumable
    {
        public int Strength { get; set; }
        public enum Type { healing, poision, resting }
        public Type PotionType;
        public Potion(string n, string pn, string ft, string ut, Type pt, int s)
        {
            Name = n;
            PluralName = pn;
            FlavorText = ft;
            UseText = ut;
            PotionType = pt;
            Strength = s;
        }

        override public void use()
        {
            switch (PotionType)
            {
                case Type.healing:
                    PlayerData.gainHealth(Strength);
                    break;
                case Type.resting:
                    //Restores player stamina
                    break;
                case Type.poision:
                    //Damages player health
                    break;
                default:
                    break;
            }
        }
    }
}
