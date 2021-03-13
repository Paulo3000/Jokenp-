using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jokenpo
{
    class Computer
    {
        public int num;
       public int data;
    
        public int Pcplay(int x)
        {
            Random rand = new Random();
           data = rand.Next(1, 4);
           
            switch(num)
            {
                case 1:
                    Console.WriteLine("STONE");
                    break;
                case 2:
                    Console.WriteLine("PAPER");
                    break;
                case 3:
                    Console.WriteLine("SCISSOR");
                    break;
            }
          
            return x;
        }


    }
}
