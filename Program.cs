using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0, scoreCPU = 0; 

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose among the following : R - Rock, P - Paper, S - Scissor :-  ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1,4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "R";
                            Console.WriteLine("The CPU has chosen ROCK");
                            if (inputPlayer == "R") { Console.WriteLine("DRAW!! \n\n"); }
                            else if (inputPlayer == "P") { Console.WriteLine("PLAYER WINS!! \n\n"); scorePlayer++; }
                            else if (inputPlayer == "S") { Console.WriteLine("CPU WINS!!\n\n"); scoreCPU++; }
                            break;
                        case 2:
                            inputCPU = "P";
                            Console.WriteLine("The Computer has chosen PAPER");
                            if (inputPlayer == "P") { Console.WriteLine("DRAW!! \n\n"); }
                            else if (inputPlayer == "S") { Console.WriteLine("PLAYER WINS!! \n\n"); scorePlayer++; }
                            else if (inputPlayer == "R") { Console.WriteLine("CPU WINS!!\n\n"); scoreCPU++; }
                            break;
                        case 3:
                            inputCPU = "S";
                            Console.WriteLine("The Computer has chosen SCISSOR");
                            if (inputPlayer == "S") { Console.WriteLine("DRAW!! \n\n"); }
                            else if (inputPlayer == "R") { Console.WriteLine("PLAYER WINS!! \n\n"); scorePlayer++; }
                            else if (inputPlayer == "P") { Console.WriteLine("CPU WINS!!\n\n"); scoreCPU++; }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                    Console.WriteLine("\n\nScores:\tPlayer:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3) { Console.WriteLine("YOU WIN !!"); }
                else if (scoreCPU == 3) { Console.WriteLine("CPU WINS !!"); }
                else { }

                Console.WriteLine("Do you want to play again (Y/N) : ");
                string loop = Console.ReadLine();
                if (loop == "Y") { playAgain = true; Console.Clear(); }
                else if(loop == "N") { playAgain= false; }
                else { }
            }
        }
    }
}
