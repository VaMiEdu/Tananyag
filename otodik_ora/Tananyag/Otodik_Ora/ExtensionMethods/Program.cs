using System;

namespace ExtensionMethods
{
    static class StringUtils
    {
        public static void ConsolraIratas(this string valami)
        {
            Console.WriteLine(valami);
        }

        public static string SzokozokAsszimilalasa(this string valami)
        {
            return valami.Replace(" ", "");
        }

    }

    static class MeasurementConverters
    {
        public static double FahrenheitToCelsius(this double value)
        {
            return (value - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenHeit(this double value)
        {
            return value * 9 / 5 + 32;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            "valami".ConsolraIratas();

            var szokozNelkul = "mondat szokozzel".SzokozokAsszimilalasa();
            var celsius = (10.0).CelsiusToFahrenHeit();

        }
    }
}
