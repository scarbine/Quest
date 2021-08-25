using System;
using System.Collections.Generic;
using System.Linq;

namespace Quest
{
    public class Hat 
    {
        public int ShininessLevel {get; set;}

        public string ShininessDescription {get; set;}
        
        public Hat (int level)
        {
            ShininessLevel = level;
            ShininessDescription = "dull"; 
        }
        
            // if (ShininessLevel < 2 )
            // {
            //     ShininessDescription = "dull";
            // }
            // if (ShininessLevel >= 2 || ShininessLevel <= 5)
            // {
            //     return "noticeable";
            // }
            // if(ShininessLevel >= 6 || ShininessLevel <= 9)
            // {
            //     return "btight";
            // }
            // if(ShininessLevel > 9)
            // {
            //     return "blinding";
            // }
        

    }
}