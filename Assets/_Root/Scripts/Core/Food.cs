using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Root.Scripts.Core
{
    public enum Rarity { Common, Rare, Delicious }
    public enum FoodType { Dry, Liquid, Drink }
    // list will increase 
    public enum FoodName { Poridge, Borsch, Tea, Kompot, Soup }

    public class Food
    {
        public FoodName Name { set; get; }
        public FoodType Type { set; get; }
        private float portions;
        public float Portions {
            set
            {
                //some logic add later
                portions = value;
            }
            get
            {
                return portions;
            }
        }
        public Rarity Rarity { set; get; }
        
        public Food (FoodName name, FoodType type, Rarity rarity, float portions = 1)
        {
            Name = name;
            Type = type;
            Rarity = rarity;
            Portions = portions;
        }
    }
}
