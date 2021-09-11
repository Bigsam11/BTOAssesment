using BTOAssesment.classLibrary.Features.RecitePoem;
using System;
using System.Collections.Generic;
using Solutions.Question1;
using Solutions.Question2;
using Solutions.Question3;

namespace Solutions
{
    class Program
    {




        static void Main(string[] args)
        {

            Console.WriteLine("Choose a number from 1 to 3 to run the appropriate solution");

            string option = Console.ReadLine();

            switch (option)
            {

                case "1":
                   Solution1.Run();
                    break;
                case "2":
                    Solution2.Run();
                    break;
                case "3":
                    Solution3.Run();
                    break;
                default:
                    Console.WriteLine("No valid number from 1 to 3 was chosen");
                    break;

            } 
            


            
            

            

        }
    }
}
