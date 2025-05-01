using System;


namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report");
            Console.WriteLine("What is your name ?");
            string name=Console.ReadLine();
            Console.WriteLine("What course are you in ?");
            string course=Console.ReadLine();
            Console.WriteLine("What page number ?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything ?  Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share ? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide ? Please be specifics");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyhours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyhours);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            







        }
    }
}
