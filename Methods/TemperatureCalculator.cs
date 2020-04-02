using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class TemperatureCalculator
    {
        static void Celcius(double t, out double kelvin, out double fahrenheit)
        {
            fahrenheit = t*9/5+32;
            kelvin = t+273.15;
        }

        static void Kelvin(double t, out double celcius, out double fahrenheit)
        {
            celcius = t-273.15;
            fahrenheit = ((t-273.15)*9/5)+32;
        }

        static void Fahrenheit(double t, out double celcius, out double kelvin)
        {
            celcius = (t-32)*5/9;
            kelvin = ((t - 32) * 5/ 9)+273.15;
        }

        public void CalculateTemperature()
        {
            Console.WriteLine("Type 1 to convert Celcius, 2 to convert Kelvins and 3 to convert Fahrenheids");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("Temperature in Celcius is:");
                    double t1 = Convert.ToDouble(Console.ReadLine());
                    double kelvin1, fahrenheit1;
                    Celcius(t1, out kelvin1, out fahrenheit1);
                    Console.WriteLine("Kelvins {0}, Fahrenheits {1}", kelvin1, fahrenheit1);

                    break;
                case 2:
                    Console.Write("Temperature in Kelvins is:");
                    double t2 = Convert.ToDouble(Console.ReadLine());
                    double celcius2, fahrenheit2;
                    Kelvin(t2, out celcius2, out fahrenheit2);
                    Console.WriteLine("Celciues {0}, Fahrenheits {1}", celcius2, fahrenheit2);
                    break;

                case 3:
                    Console.Write("Temperature in Fahrenheids is:");
                    double t3 = Convert.ToDouble(Console.ReadLine());
                    double kelvin3, fahrenheit3;
                    Kelvin(t3, out kelvin3, out fahrenheit3);
                    Console.WriteLine("Celciues {0}, Fahrenheits {1}", kelvin3, fahrenheit3);
                    break;
            }
            Console.WriteLine("Would you like to calculate again? [y/n]");
            if (Console.ReadLine() == "y")
            {
                CalculateTemperature();
            }
            else if (Console.ReadLine() == "n")
            {
                Console.WriteLine("exit");
            }



        }

    }
}
