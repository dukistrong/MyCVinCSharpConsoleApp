using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCVinCSharpConsoleAppLibrary
{
    public class WorkExperience
    {
        public string Company { get; set; }
        public string Period { get; set; }
        public string JobDescr1 { get; set; }
        public string JobDescr2 { get; set; }
        public string JobDescr3 { get; set; }
        public string Work { 
            get 
            {
                return $"Company {Company} in period {Period}: " +
                    $"\n\t\t-{JobDescr1}\n\t\t-{JobDescr2}\n\t\t-{JobDescr3}";
            } 
        }
        public WorkExperience(string company, string period, string jobDescr1, string jobDescr2, string jobDescr3)
        {
            Company = company;
            Period = period;
            JobDescr1 = jobDescr1;
            JobDescr2 = jobDescr2;
            JobDescr3 = jobDescr3;
        }
        public static void WorkAsDev()
        {
            Console.WriteLine($"As I am still learning to code and dont have experience as developer, \n" +
                $"would you like to see my previous work experience? (Y/N)");
        }
        public static void PrintExperience(List<WorkExperience>experience, string answer)
        {
            if(answer == "y" || answer == "Y")
            {
                Console.WriteLine("Here is the list of my previous jobs: ");
                foreach(WorkExperience e in experience)
                {
                    Console.WriteLine(e.Work);
                }
            }
            else if(answer == "n" || answer == "N")
            {
                Console.WriteLine("Ok, let's go forward");
            }
            else
            {
                Console.WriteLine($":) You checking my code");
                Console.WriteLine($"I will show you my experience but in green color:");
                foreach (WorkExperience e in experience)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(e.Work);
                }
                Console.ResetColor();
            }
        }
    }
}
