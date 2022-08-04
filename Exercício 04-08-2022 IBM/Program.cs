using System;
using System.Globalization; 

namespace Exercício_04_08_2022_IBM {
    class Program {
        static void Main(string[] args) {

            double raio;
            double area;
            Console.WriteLine("Digite o raio, no formato 0.0");

            raio = double.Parse(Console.ReadLine());

            area = Math.Pow(raio, 2) * 3.14159;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
