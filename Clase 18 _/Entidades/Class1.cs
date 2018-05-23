using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public enum EPuesto
    {
        Arquero,Defensa,Medio,Delantero
    }

    public class Jugador
    {
        protected string _nombre;
        protected string _apellido;
        protected EPuesto _puesto;

        public string Nombre 
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public EPuesto Puesto
        {
            get
            {
                return this._puesto;
            }
        }

        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._puesto = puesto;
        }


        public override string ToString()
        {
            return (this._nombre + "-" + this._apellido + "-" + this._puesto + "\n");
        }


        public static bool TraerUno(string cadena, Jugador x, out Jugador Jug)
        {
            Jug = null;
            bool retorno = false;
            string cadenaAUX = "";

            if((AdministradorDeArchivos.Leer(cadena,out cadenaAUX)!= false))
            {
                string[] aux = cadenaAUX.Split('\n');

                foreach (string item in aux)
                {
                    string []aux_2 = item.Split('-');

                    if (x.Nombre == aux_2[0] && x.Apellido == aux_2[1] && x.Puesto.ToString() == aux_2[2])
                    {
                        Jug = new Jugador(aux_2[0], aux_2[1], ((EPuesto)Enum.Parse(aux_2[2]));
                        retorno = true;
                        break;
                    }
                }

            }

            return retorno;
        }


    }

    public static class AdministradorDeArchivos
    {
        public static bool Escribir(string ruta, string cadena, bool Append_or_Endline)
        {
            bool retorno;

            try
            {
                StreamWriter escribe = new StreamWriter(ruta, Append_or_Endline);

                escribe.WriteLine(cadena);

                escribe.Close();

                retorno = true;
            }
            catch(Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool Leer(string ruta, out string retornoCadena)
        {
            bool retorno;

            try
            {

                StreamReader lee = new StreamReader(ruta);

                retornoCadena = lee.ReadToEnd();

                retorno = true;
            }
            catch(Exception)
            {
                retorno = false;
                retornoCadena = null;
            }

            return retorno;
        }                               
    }
}
