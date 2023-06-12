using System;

namespace HealthMonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Health Monitoring App!");

            // Prompt the user for their vital signs
            Console.Write("Enter your heart rate: ");
            int heartRate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your blood pressure (systolic): ");
            int systolicBP = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your blood pressure (diastolic): ");
            int diastolicBP = Convert.ToInt32(Console.ReadLine());

            // Calculate the average blood pressure
            int averageBP = (systolicBP + diastolicBP) / 2;

            // Display the results
            Console.WriteLine("\n--- Health Monitoring Results ---");
            Console.WriteLine("Heart Rate: " + heartRate);
            Console.WriteLine("Blood Pressure (Systolic): " + systolicBP);
            Console.WriteLine("Blood Pressure (Diastolic): " + diastolicBP);
            Console.WriteLine("Average Blood Pressure: " + averageBP);

            // Check if the vital signs are within normal ranges
            if (heartRate >= 60 && heartRate <= 100)
                Console.WriteLine("Heart rate is within normal range.");
            else
                Console.WriteLine("Heart rate is abnormal.");

            if (systolicBP >= 90 && systolicBP <= 120 && diastolicBP >= 60 && diastolicBP <= 80)
                Console.WriteLine("Blood pressure is within normal range.");
            else
                Console.WriteLine("Blood pressure is abnormal.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
