using System;
using System.Collections.Generic;
using System.Text;

namespace Auta_IT3A
{
    public class Car
    {
        private int loaded;

        public string Marque { get; }
        public int MaxWeight { get; }
        public int Loaded { get => loaded; }

        public Car(string marque, int maxWeight)
        {
            Marque = marque;
            MaxWeight = maxWeight;
        }

        public int Load(int stuff)
        {
            var space = MaxWeight - Loaded;
            if(space > stuff)
            {
                loaded += stuff;
                return stuff;
            }
            else
            {
                loaded += space;
                return space;
            }
        }

        public int Unload(int stuff)
        {
            if(stuff > Loaded)
            {
                var realStuff = Loaded;
                loaded = 0;
                return realStuff;               
            }
            else
            {
                loaded -= stuff;
                return stuff;
            }
        }

        public int Park()
        {
            var realStuff = Loaded;
            loaded = 0;
            return realStuff;
        }
    }
}
