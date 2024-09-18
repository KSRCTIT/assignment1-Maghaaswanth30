using System;

class Program
{
    static void Main()
    {
        // Define eligibility criteria
        const int minimumAge = 18;
        const int maximumAge = 30;
        const double minimumPassPercentage = 65.0;

        // Input: Age and Percentage
        Console.Write("Enter your age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Please enter a valid age: ");
        }

        Console.Write("Enter your percentage in 10th standard: ");
        double percentage;
        while (!double.TryParse(Console.ReadLine(), out percentage) || percentage < 0 || percentage > 100)
        {
            Console.Write("Please enter a valid percentage (0-100): ");
        }

        // Eligibility Check
        if (age > minimumAge && age <= maximumAge && percentage >= minimumPassPercentage)
        {
            Console.WriteLine("You are eligible to apply.");
        }
        else
        {
            Console.WriteLine("You are not eligible to apply.");
        }
    }
}