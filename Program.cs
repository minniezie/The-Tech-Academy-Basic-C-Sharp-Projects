using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{

    class Program

    {
        // 1. Create an interface called IQuittable
        interface IQuittable
        {
            // Define a void method called Quit()
            void Quit();
        }


        // 2. Have your Employee class inherit the IQuittable interface
        class Employee : IQuittable
        {
            // Properties of the Employee class
            public string FirstName { get; set; } // Employee's first name
            public string LastName { get; set; }  // Employee's last name
            public int Id { get; set; }   // Employee's unique identifier


            // Implement the Quit() method from the IQuittable interface
            public void Quit()
            {
                // Implementation of the Quit() method: display a message to the console
                Console.WriteLine("Employee has quit the company.");
            }
        }
         
        
            static void Main(string[] args)
            {
                // 3. Use polymorphism to create an object of type IQuittable
                IQuittable quittable = new Employee(); // Create an Employee object and assign it to an IQuittable interface


                // Call the Quit() method on the IQuittable object
                quittable.Quit(); // Execute the Quit() method, which will display the message


                Console.ReadLine(); // Keep the console window open until a key is pressed
            }
        }
    }



