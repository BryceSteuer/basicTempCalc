using System;

namespace celsiusConversion
{
  class Program
  {
    static void Main(string[] args)
    {

        // User inputs degrees Celsius
        Console.WriteLine("What is the current temperature in degrees Celsius?");

        // Take the degree value and store it as a string
        string degrees = Console.ReadLine();

        // Convert the degrees string to a mathematically manipulatable double
        Convert.ToDouble(degrees);

        // Convert the celsius double to a Fahrenheit double
        double degreesFahrenheit = (degrees * 9/5) + 32;

        // Print Fahrenheit output
        Console.WriteLine($"The temperature, therefore, is {degreesFahrenheit} F");
          
          // May switch to a switch statement soon
          if (degreesFahrenheit < 45)
          {
            Console.WriteLine("Cold today, is it not?");
          }
          else if (degreesFahrenheit > 45 && degreesFahrenheit < 75)
          {
            Console.WriteLine("Pretty mild today. Be sure to wear a sweater outside.");
          }
          else if (degreesFahrenheit > 75)
          {
            Console.WriteLine("Very warm today. Avoid overexertion if possible!");
          }
          else 
          {
             Console.WriteLine("Enjoy your day!");
          }
    }                  
    }
}

