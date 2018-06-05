using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class AdministraDeArchivos
    {
            public static Boolean Escribir(string path, string whatToWrite, bool appendOrOverwrite)
            {
                Boolean retorno = false;
                StreamWriter auxGuardado;

                if ((auxGuardado = new StreamWriter(path, appendOrOverwrite)) != null)
                {
                    auxGuardado.WriteLine(whatToWrite);
                    retorno = true;
                }
                auxGuardado.Close();

                return retorno;
            }

            public static Boolean Leer(string path, out string readText)
            {
                Boolean retorno = false;

                StreamReader auxLectura = new StreamReader(path);
                if ((readText = auxLectura.ReadToEnd()) != null)
                { retorno = true; }
                auxLectura.Close();
                return retorno;
            }
    }
}
