using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{

    //Create a class

    class MathOperations 

    {
        // Create a void method that takes two integers as parameters

        public void PerformOperation(int num1, int num2) 

        {

            // Do a math operation on the first integer (e.g., multiply by 5) 

            int result = num1 * 5; 


            // Display the second integer to the screen

            Console.WriteLine("The second number is: " + num2);

        }

    }

     class Program

    {
        static void Main(string[] args)

        {
            // Instantiate the class in the Main() method

            MathOperations mathOps = new MathOperations(); 


            // Call the method, passing in two numbers

            mathOps.PerformOperation(10, 20); // Passing 10 and 20 as arguments 


            //  Call the method, specifying the parameters by name

            mathOps.PerformOperation(num2: 30, num1: 5); // Specifying parameters by name


            // Keep the console window open until a key is pressed

            Console.ReadKey();

        }

    }
} 