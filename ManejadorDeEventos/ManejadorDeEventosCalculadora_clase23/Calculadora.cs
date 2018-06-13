using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeEventosCalculadora_clase23
{
    public class Calculadora
    {
        public static Double Operar(double num1, double num2, string operador)
        {
            double retorno = 0;

            switch (operador)
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case"-":
                    retorno = num1 - num2;
                    break;
                case"*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    if(num2 != 0) { retorno = num1 / num2; }
                    else { retorno = -1; }
                    break;
                default:
                    break;
            }

            return retorno;
        }
    }
}
