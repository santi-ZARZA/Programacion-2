using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Double numero = 0;

            Double maximo = 0;
            Double minimo = 0;
            Double promedio = 0;

            for(i=0;i<5;i++)
            {
                Console.WriteLine("ingrese un numero: ");

                numero = int.Parse(Console.ReadLine());

                if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if(numero>maximo)
                    {
                        maximo = numero;
                    }
                    else
                    {
                        if(numero < minimo)
                        {
                            minimo = numero;
                        }
                    }
                }


                promedio += numero;
            }



            Console.WriteLine("Maximo: {0}\nMinimo: {1}\nPromedio: {2}",maximo,minimo,promedio/5);
            Console.ReadKey();

        }
    }
}
