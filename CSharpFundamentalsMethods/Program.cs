using System;

namespace CSharpFundamentalsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 1
            {
                Celsius celsius = new Celsius();
                celsius.Temperature = 30;

                Fahrenheit fahrenheit = celsius.ToFahrenheit();
                Console.WriteLine(fahrenheit.Temperature);

                celsius = fahrenheit.ToCelsius();
                Console.WriteLine(celsius.Temperature);
            }
            #endregion

            #region Exercice 2
            {
                EQ2D equation = new EQ2D();
                equation.A = 4;
                equation.B = 4;
                equation.C = 1;

                if(equation.Resoudre(out double? X1, out double? X2))
                {
                    Console.WriteLine($"X1 : {X1.Value} - X2 : {X2.Value}");
                }
                else
                {
                    Console.WriteLine("Pas de résultat");
                }
            }
            #endregion
        }
    }
}
