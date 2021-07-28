using System;

namespace basicTempCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do you wish to know the temperature in Celsius or in Fahrenheit?");
            string celOrFar = Console.ReadLine();

            if (celOrFar == "Fahrenheit")
            {

                // User inputs degrees Celsius
                Console.WriteLine("What is the current temperature in degrees Celsius?");

                // Take the degree value and store it as a string
                string degrees = Console.ReadLine();

                // Convert the degrees string to a mathematically manipulatable double
                int celsiusDouble = Convert.ToInt32(degrees);

                // Convert the celsius decimal to a Fahrenheit double
                int degreesFahrenheit = (celsiusDouble * 9 / 5) + 32;

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
            else if (celOrFar == "Celsius")
            {
                // User inputs degrees Fahrenheit
                Console.WriteLine("What is the current temperature in degrees Fahrenheit?");

                // Take the degree value and store it as a string
                string degreesFahr = Console.ReadLine();

                // Convert the degrees string to a mathematically manipulatable double
                int fahrDouble = Convert.ToInt32(degreesFahr);

                // Convert the celsius decimal to a Fahrenheit double
                int degreesCelsius = (fahrDouble - 32) * 5/9;

                // Print Fahrenheit output
                Console.WriteLine($"The temperature, therefore, is {degreesCelsius} C");

                // May switch to a switch statement soon
                if (degreesCelsius < 14)
                {
                    Console.WriteLine("Cold today, is it not?");
                }
                else if (degreesCelsius > 14 && degreesCelsius < 22)
                {
                    Console.WriteLine("Pretty mild today. Be sure to wear a sweater outside.");
                }
                else if (degreesCelsius > 22)
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
}
