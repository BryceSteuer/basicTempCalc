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
                
                switch (degreesFahrenheit) 
                {
                    case < 45:
                        Console.WriteLine("Cold today, is it not?");
                        break;
                    case > 45:
                    case < 65:
                        Console.WriteLine("Pretty mild today. Be sure to wear a sweater outside.");
                        break;
                    case > 65:
                    case < 85:
                        Console.WriteLine("It is fairly warm today. Why not take a walk?");
                        break;
                    case > 85:
                        Console.WriteLine("Very warm today. Avoid overexertion if possible!");
                        break;
                    default:
                        Console.WriteLine("Enjoy your day!");
                        break;
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

                // switch statements to determine msg based on degrees Celsius
                switch (degreesCelsius) 
                {
                    case < 14:
                        Console.WriteLine("Cold today, is it not?");
                        break;
                    case > 14:
                    case < 22:
                        Console.WriteLine("Pretty mild today. Be sure to wear a sweater outside.");
                        break;
                    case > 22:
                    case < 26:
                        Console.WriteLine("It is fairly warm today. Why not take a walk?");
                        break;
                    case > 26:
                        Console.WriteLine("Very warm today. Avoid overexertion if possible!");
                        break;
                    default:
                        Console.WriteLine("Enjoy your day!");
                        break;
                }
            }
        }
    }
}
