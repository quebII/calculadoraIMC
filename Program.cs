using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your height in meters? Ex.: 1,65");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("What is your weight in Kg? Ex.: 70,3");
            float weight = Convert.ToSingle(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("{0}, your height is {1} and your weight is {2}", name, height, weight);
            Console.WriteLine("Your BMI is {0}", bmi);
        }
    }
}