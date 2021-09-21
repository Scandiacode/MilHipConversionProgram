using System;

namespace MilHipConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double milUnit_Con1 = 5;
            double milUnit_Con2 = 3.5;
            double resultUnitInput;
            string restartChoice;


            Console.WriteLine("Welcome to the definitive MilHip conversion software.\n");
            
            do
            {

                Console.WriteLine("What is the Measurement name?");
                string wordUnitInput = Console.ReadLine();
                Console.WriteLine();

                if (wordUnitInput.Equals("foot"))
                {

                    Console.WriteLine("You have picked Foot to Meme conversion.\n");
                    
                }
                else if (wordUnitInput.Equals("meme"))
                {

                    Console.WriteLine("You have picked Meme to Foot conversion.\n");
                    
                }
                else if (wordUnitInput.Equals("inch"))
                {

                    Console.WriteLine("You have picked Inch to Fidget Spinners conversion.\n");
                    
                }
                else if (wordUnitInput.Equals("fidget spinners"))
                {

                    Console.WriteLine("You have picked Fidget Spinners to Inch conversion.\n");
                   
                }

                Console.WriteLine("Please insert the amount of the units.");
                string numUnitInput = Console.ReadLine();
                Console.WriteLine();
                double.TryParse(numUnitInput, out resultUnitInput);


                if (wordUnitInput.Equals("inch"))
                {
                    Console.WriteLine("The Conversion is: " + resultUnitInput * milUnit_Con2 + " Fidget Spinners.");
                }
                else if (wordUnitInput.Equals("fidget spinners"))
                {
                    Console.WriteLine("The Conversion is: " + resultUnitInput / milUnit_Con2 + " Inches.");
                }
                else if (wordUnitInput.Equals("foot"))
                {
                    Console.WriteLine("The Conversion is: " + resultUnitInput * milUnit_Con1 + " Memes.");
                }
                else if (wordUnitInput.Equals("meme"))
                {
                    Console.WriteLine("The Conversion is: " + resultUnitInput / milUnit_Con1 + " Feet.");
                }


                Console.WriteLine("Would you like to do another coversion? (Yes or No?) ");
                restartChoice = Console.ReadLine();
            }
            while (restartChoice.ToLower() == "yes");

        }

    }
}

