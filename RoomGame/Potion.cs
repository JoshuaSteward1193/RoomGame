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
        public Potion(string name, string pluralName, string flavText, string useText, Type type, int strength)
        {
            Name = name;
            PluralName = pluralName;
            FlavorText = flavText;
            UseText = useText;
            PotionType = type;
            Strength = strength;
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
