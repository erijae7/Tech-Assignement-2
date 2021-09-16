using System;

namespace Tech_Assignement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user user what grade they expect to get in ISM 4300
            Console.WriteLine("What grade do you expect to get in ISM 4300? Enter a value 0-100");

            //Use try catch logic to confirm valid input
            try
            {
                string inputdata = Console.ReadLine();
                int inputscore = int.Parse(inputdata);
                if (inputscore < 0 || inputscore > 100)
                {
                    Console.WriteLine("Please run again and enter a score between 0-100");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);

                    // Process valid interger response
                    if
                        (inputscore >= 90)
                        Console.WriteLine("You will receive an A");
                    else if
                        (inputscore >= 80)
                        Console.WriteLine("You will receive an B");
                    else if
                        (inputscore >= 70)
                        Console.WriteLine("You will receive an C");
                    else if
                        (inputscore >= 60)
                        Console.WriteLine("You will receive an D");
                    else if
                        (inputscore >= 50)
                        Console.WriteLine("You will receive an F");
                }
            }
            catch
            {
                Console.WriteLine("Please run again and enter a score between 0-3");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
                //end of catch for invalid input
            }

          }
    }
}




