using System;

namespace Quest
{






    public class Robe 
    {
        public int Length {get; set;}
       
       

        
        public Robe (int length)
        {
            Length = length;
        
        }

        

        public class Colors
        {
            public string Color {get; set;}

            public Colors(string color)
            {
                this.Color = color;
            }
        }

    
    }

    


}