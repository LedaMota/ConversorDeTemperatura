using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, K;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            //( c * 9 / 5 ) + 32 = F
            f = (c * 9 / 5) + 32;

            //c + 273,15 ;
            K = c + 273.15;



            Console.WriteLine(c + "graus ceucius = " + f + "graus fahrenheit");
            Console.WriteLine(c + "graus ceucius = " + K + "graus kelvin");
            Console.WriteLine("--------------------------------");
            Console.ReadKey();




        }












    }
}
