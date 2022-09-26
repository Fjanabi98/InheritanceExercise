using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animals
   
    {
      public Animals()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;
                 
        }

        public bool IsAlive { get; set; } 
        public int Age { get; set; }    
        public int LegCount { get; set; }
        public string LandSeaAir { get; set; } 
    }
}
