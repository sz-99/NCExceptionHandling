using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExceptionHandling
{
    public class UserData
    {
        public static string GetName()
        {
            Console.WriteLine("Please give us your full name.");
            string? result = Console.ReadLine();
            if (result is null || !result.Contains(" ") || result[0] == ' ' || result[^1] == ' ') 
            {
                Console.WriteLine("Name invalid, please try again.");
                result = GetName();
            }
            
            return result;
        }

        public static int GetAge()
        {
            Console.WriteLine("Enter your age: ");
            string? input = Console.ReadLine();
            int age = 0;
            bool valid = Int32.TryParse(input, out age);
            if (!valid || age < 0 || age > 120)
            {
                Console.WriteLine("Age is not valid. Please try again.");
                age = GetAge();
            }
            return age;
        }

        internal static double GetHeight()
        {
            Console.WriteLine("Enter your height (in metres): ");
            string? input = Console.ReadLine();
            double height = 0;
            bool valid = Double.TryParse(input, out height);
            if (!valid || height < 0 || height > 2.72)
            {
                Console.WriteLine("Height is invalid, please try again.");
                height = GetHeight();
            }
            return height;
        }
        internal static double GetWeight()
        {
            Console.WriteLine("Enter your weight (in kg): ");
            string? input = Console.ReadLine();
            double weight = 0;
            bool valid = Double.TryParse(input, out weight);
            if (!valid || weight < 0 || weight > 650)
            {
                Console.WriteLine("Weight is invalid, please try again.");
                weight = GetWeight();
            }
            return weight;
        }

        internal static Employed GetEmployment()
        {
            Console.WriteLine("Are you employed? Please input \"Y\" or \"N\"");
            Employed result = Employed.NO;
            string input = Console.ReadLine();

            if (input.ToUpper() != "Y" && input.ToUpper() != "N")
            {
                Console.WriteLine("Employment input was invalid, please try again.");
                result = GetEmployment();
            }
            if (input.ToUpper() == "Y") result = Employed.YES;
            return result;
        }

        internal static Occupation GetOccupation()
        {

            Console.WriteLine("What is your occupation?: ");
            
            string input = Console.ReadLine();
            Occupation result = Occupation.other;
            switch (input.ToLower())
                {
                    case "student":
                        result = Occupation.student;
                        break;
                    case "engineer":
                        result = Occupation.engineer;
                        break;
                    case "teacher":
                        result = Occupation.teacher;
                        break;
                    case "sales":
                        result = Occupation.ceo;
                        break;
                    case "ceo":
                        result = Occupation.ceo;
                        break;

                    default:
                        result = Occupation.other;
                        break;
                }
           


            return result;
        }

        internal static bool GetStudentStatus()
        {
            Console.WriteLine("Are you a student? Please input \"Y\" or \"N\"");
            bool result = false;
            string input = Console.ReadLine();

            if (input.ToUpper() != "Y" && input.ToUpper() != "N")
            {
                Console.WriteLine("Student status was invalid, please try again.");
                result = GetStudentStatus();
            }
            if (input.ToUpper() == "Y") result = true;
            return result;
        }

    }
}
