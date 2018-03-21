using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
           // bool bandera = false;

            Double numero = -1;
            Double cubo, cuadrado;

            Console.WriteLine("ingrese un numero: ");

            numero = Double.Parse(Console.ReadLine());

            while(numero < 1)
            {
                Console.WriteLine("!ERROR. Reingrese el numero!");
                numero = Double.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);


            Console.WriteLine("El cuadrado del numero {0} es: {1}\nEl cubo del numero {0} es: {2}", numero, cuadrado, cubo);
            Console.ReadKey();
           
        }
    }
}
