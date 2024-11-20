using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exercise2
    {
        public static void HealthInsuranceDataInput()
        {
            Console.WriteLine("\n--- Thank you for choosing Blummin Health insurance! ---\n");
            Console.WriteLine("Please input your data:");

            // Name
            string name = UserData.GetName();

            // Age
            int age = UserData.GetAge();

            // Height
            double height = UserData.GetHeight();

            // Weight
            double weight = UserData.GetWeight();

            // Employment
            Console.WriteLine("Are you employed?: ");
            string employed = Console.ReadLine();

            // Occupation
            Console.WriteLine("What is your occupation?: ");
            string occupation = Console.ReadLine();

            // Student
            Console.WriteLine("Are you a student?: ");
            string isStudent = Console.ReadLine();

            Console.WriteLine("\nThank you, " + name + ", for providing your information!");
            Console.WriteLine("Your Blummin monthly subscription is: £"
                    + CalculateSubscriptionCharge(Int32.Parse(age), Double.Parse(height), Double.Parse(weight), occupation, bool.Parse(isStudent)));
        }

        private static double CalculateSubscriptionCharge(int age, double height, double weight, string occupation, bool isStudent)
        {
            List<double> factors = new List<double>()
        {
            0.5D, // Base rate
            CalculateAgeFactor(age),
            CalculateHeightFactor(height),
            CalculateWeightFactor(weight),
            occupation.ToLower() == "doctor" ? 0.9D : 1.0D,
            isStudent ? 0.8D : 1.0D
        };

            return factors.Aggregate(1.0, (a, b) => a * b);
        }

        private static double CalculateAgeFactor(int age)
        {
            return Math.Max(100 + (age - 18) * 5, 1);
        }

        private static double CalculateHeightFactor(double height)
        {
            return Math.Abs(Math.Pow(height, 2) - 2);
        }

        private static double CalculateWeightFactor(double weight)
        {
            return 2 * weight;
        }
    }
}
