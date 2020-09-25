using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Validaciones
    {
        public static bool ValidarQueSeaDni(string numeroString, out string dni)
        {
            bool retorno = false;
            dni = numeroString;

            if ((numeroString.Length == 8 || numeroString.Length == 7) && int.TryParse(numeroString, out int a))
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool PlayeroExiste(List<Playero> playeros, string dni)
        {
            bool retorno = false;

            foreach (Playero item in playeros)
            {
                if (item.Dni == dni)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static Playero PlayeroExiste(List<Playero> playeros, string dni,string a)
        {
            if (a == "K") { Console.WriteLine("a"); }
            
            foreach (Playero item in playeros)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }
            return null;
        }



        public static bool PlayeroExiste(List<Playero> playeros, string dni, out Playero p)
        {
            bool retorno = false;
            p = null;
            foreach (Playero item in playeros)
            {
                if (item.Dni == dni)
                {
                    retorno = true;
                    p = item;
                    break;
                }
            }
            return retorno;
        }


    }
}
