
using CodeFirstNewDatabaseSample; // For [Table], [Column], etc.
using System;
using System.Collections.Concurrent; // For ConcurrentDictionary and other collections
using System.Collections.Generic;
using System.Collections.Generic; // For List<T> and other collections
using System.ComponentModel.DataAnnotations; // For data annotations like [Key], [Required], etc.
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity; // Ensure you have Entity Framework installed
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow; // Ensure you have the Dataflow package installed


namespace CodeFirstNewDatabaseSample
{


    public class student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }

       
}
    }

internal class Program
{
    private static void Main(string[] args)
    {
       
        {
            var student = new student();

            student.StudentID = 1;
            student.StudentName = "Michael";
            student.DateOfBirth = new DateTime(2002, 1, 1);
            student.Height = 1.75m; // Height in meters
            student.Weight = 70.5f; // Weight in kilograms
            student.RowVersion = new byte[] { 1, 2, 3, 4 };


        }
        Console.WriteLine("Student created successfully!");



        Console.ReadLine();
    }
}

