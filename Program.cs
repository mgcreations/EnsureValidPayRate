using System;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal LOW_RATE = 5.65M;
            const decimal HIGH_RATE = 49.99M;
            const decimal WEEKLY_RATE = 40M;
            decimal hourlyRate;
            decimal payRate;

            Console.Write("Enter the hourly rate: ");
            hourlyRate = Convert.ToDecimal(Console.ReadLine());

            if (hourlyRate <= LOW_RATE)
            {
                Console.WriteLine("Error: {0} is below the min rate of {1}",
                    hourlyRate.ToString("C"), LOW_RATE.ToString("C"));
                Console.Write("Enter the correct hourly rate: ");
                hourlyRate = Convert.ToDecimal(Console.ReadLine());
            }
            else if (hourlyRate >= HIGH_RATE)
            {
                Console.WriteLine("Error: {0} is above the max rate of {1}",
                    hourlyRate.ToString("C"), HIGH_RATE.ToString("C"));
                Console.Write("Enter the correct hourly rate: ");
                hourlyRate = Convert.ToDecimal(Console.ReadLine());
            }
                payRate = hourlyRate * WEEKLY_RATE;

                Console.WriteLine("Pay Rate: \t {0}", hourlyRate.ToString("C"));
                Console.WriteLine("Weekly Rate: \t {0}", payRate.ToString("C"));
            
        }
    }
}
