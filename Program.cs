using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the namespace for the application
namespace Operators_Assignment
{
    // Define the Employee class

    class Employee

    {


        // Properties of the Employee class: Id, FirstName, and LastName

        public int Id { get; set; } // Employee ID

        public string FirstName { get; set; } // Employee's first name

        public string LastName { get; set; } // Employee's last name



        // Overload the "==" operator to compare two Employee objects based on their Id

        public static bool operator ==(Employee emp1, Employee emp2)

        {

            // If both objects are null, they are considered equal

            if (ReferenceEquals(emp1, emp2))

            {

                return true;

            }



            // If either object is null, they are not equal

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))

            {

                return false;

            }



            // Compare the Id properties of the two Employee objects

            return emp1.Id == emp2.Id;

        }



        // Overload the "!=" operator.  It should always be overloaded when "==" is overloaded.

        public static bool operator !=(Employee emp1, Employee emp2)

        {

            // Use the overloaded "==" operator to determine inequality

            return !(emp1 == emp2);

        }



        // Override the Equals method to provide object equality comparison.

        public override bool Equals(object obj)

        {

            // Check if the passed object is an Employee object

            if (obj == null || GetType() != obj.GetType())

            {

                return false;

            }



            // Compare the Id properties

            Employee employee = (Employee)obj;

            return (Id == employee.Id);

        }



        // Override GetHashCode to ensure objects that are equal have the same hash code.

        public override int GetHashCode()

        {

            return Id;

        }

    }

class program { 

         // Main method - entry point of the console application

            static void Main(string[] args)

            {

                // Instantiate two Employee objects

                Employee employee1 = new Employee();

                employee1.Id = 1;

                employee1.FirstName = "Michael";

                employee1.LastName = "Dean";



                Employee employee2 = new Employee();

                employee2.Id = 1;

                employee2.FirstName = "Daisy";

                employee2.LastName = "Smith";



                // Compare the two Employee objects using the overloaded "==" operator

                bool areEqual = employee1 == employee2;



                // Display the result of the comparison to the console

                Console.WriteLine($"Employee1 Id: {employee1.Id}, Name: {employee1.FirstName} {employee1.LastName}");

                Console.WriteLine($"Employee2 Id: {employee2.Id}, Name: {employee2.FirstName} {employee2.LastName}");

                Console.WriteLine($"Are the two employees equal? {areEqual}");

            }
                    
        }
                    
    }
