using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animals
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "air";
            Age = 0;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool migrate { get; set; }
        public double BeakLength { get; set; }

    }
}
