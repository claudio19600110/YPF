using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Playero
    {
        private static int constId = 1;
        private string id;
        private string estado;//POR AHORA SIEMPRE 0
        private string nombre;
        private string apellido;
        private string dni;

        public Playero(string nombre, string apellido, string dni)
        {
            this.Id = constId++.ToString();
            this.Estado = "0";
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        

        public static bool parseo(List<string[]> listado, out List<Playero> playeros)
        {
            bool retorno = false;
            bool flag = false;
            playeros = new List<Playero>();

            foreach (string[] item in listado)
            {
                if(flag == true)
                {
                    string a = ConvertStringArrayToString(item);
                    string[] datos = a.Split(';');

                    Playero p = new Playero(datos[1], datos[2], datos[0]);
                    playeros.Add(p);
                    retorno = true;

                }
                else
                {
                    flag = true;
                }


            }
          


            return retorno;
        }

        public static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }


        #region Setter y Getters
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        #endregion

    }
}
