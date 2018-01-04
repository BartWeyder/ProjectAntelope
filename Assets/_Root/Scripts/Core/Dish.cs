using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Root.Scripts.Core
{
    public class Dish
    {
        //private GameObject gameObject;
        public Food Food { set; get; }
        float capacity;
        public float Capacity
        {
            set
            {
                // event logic
                //

                capacity = value;
            }
            get { return capacity; }
        }

    }
}
