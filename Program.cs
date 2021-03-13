using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int speed = 200,notes=350;
            string computerwin = "COMPUTER WIN!!";
            string youwin = "YOU WIN !!";

           
           
            //OPENING OF THE GAME
             Console.ForegroundColor = ConsoleColor.Red;
        
             Console.WriteLine("  J");
             Console.Beep(300,100);
             Thread.Sleep(speed);
             Console.Clear();
             Console.WriteLine(" J     O");
             Console.Beep(400, 100);
             Thread.Sleep(speed);
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("JOK");
             Console.Beep(500, 100);
             Thread.Sleep(speed);
             Console.Clear();
             Console.WriteLine("JO        KE");
             Console.Beep(600, 100);
             Thread.Sleep(speed);
             Console.Clear();
             Console.WriteLine(" JO KEN");
             Console.Beep(700, 100);
             Thread.Sleep(speed);
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Clear();
             Console.WriteLine("JOKENPO");
             Console.Beep(800, 100);

            int scoreCumputer = 0,scorePlayer=0;
            int cont=0;
            while (true)
            {
                cont++;
            comeback:

                Computer comp = new Computer();
                int play1, play2_Pc;
                Console.WriteLine("0)STONE\n5)PAPER\n2)SCISSOR");
                Console.WriteLine("You------------>");
                int colect = int.Parse(Console.ReadLine());


                //logic of transform 0,5,2 for 1,2,3 for alimentation of the class.
                int parse_val = 0;
                switch (colect)
                {
                    case 0:
                        parse_val = 1;
                        break;
                    case 2:
                        parse_val = 3;
                        break;
                    case 5:
                        parse_val = 2;
                        break;
                    default:
                        Console.Beep();
                        Console.Clear();
                        goto comeback;
                        break;

                }


                play1 = parse_val;
                comp.num = parse_val;

                int init = 1;
                //in this point are go iniciate the class
                comp.Pcplay(init);
                int y = comp.data;
                play2_Pc = y;
                comp.num = y;
                Console.WriteLine("\nCumputer-------> \n");
                //init class
                comp.Pcplay(init);

                /*play1 and play2_PC are coleted, int this time make the logical

                test make verific if play1 and play2 are coleted== test ok
                Console.WriteLine("\n\nyou = "+play1+" pc = "+play2_Pc);*/
                if (play1 == play2_Pc)
                {
                    Console.WriteLine("******************* GAVE A TIE!!");
                }
                //play1 wining
                else if ((play1 == 1 && play2_Pc == 3) || (play1 == 2 && play2_Pc == 1) || (play1 == 3 && play2_Pc == 2))
                {
                    scorePlayer += 1;
                    Console.WriteLine("*************** " + youwin+" SCORE: "+scorePlayer);
                    
                }
                else
                {
                    scoreCumputer += 1;
                    Console.WriteLine("*************** " + computerwin + " SCORE: " + scoreCumputer);
                  
                }
               if(cont ==5)
               {
                   break;
               }
               Thread.Sleep(2500);
               Console.Clear();
            }
            Console.Clear();
            if (scorePlayer > scoreCumputer)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("     Y      O     U      W         I       N ");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(" Y          O    U   W    I    N ");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(" ");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Y O U   W I N ");
               
               
                for (int i = 0; i < 10; i++)
                {
                    notes += 100;
                    Console.Beep(notes, 300);

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" G A M E - O V E R");
                Console.Beep(900,1000);
            }

           

            Console.ReadKey();

        }

    }
}
