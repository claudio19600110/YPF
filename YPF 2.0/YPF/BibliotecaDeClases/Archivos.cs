using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace BibliotecaDeClases
{
    public class Archivos
    {
        /// <summary>
        /// Metodo implentado de la interfaz IArchivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a ser guardado</param>
        /// <returns>true si funciono false si no</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, false, UTF8Encoding.ASCII))
                {
                    sw.WriteLine(datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }


        /// <summary>
        /// Metodo implentado de la interfaz IArchivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a devolver es un parametro de tipo OUT</param>
        /// <returns>true si funciono false si no</returns>
        public static bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();
            datos = "";

            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                    }

                    retorno = true;
                    datos = sb.ToString();
                    Console.WriteLine("\n\nDatos Recuperados");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        //Desestimado
        public static bool Leer2(string archivo, out string datos)
        {
            //string mySheet = @"C:\Users\Software - PC\Desktop\YPF\YPF\YPF_LogIn\bin\Debug\utils\Playero.xlsx";
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = C:/Users/Software - PC/Desktop/YPF/YPF/YPF_LogIn/bin/Debug/utils/Playero.xlsx ;Extended Properties = \"Excel 8.0;HDR = Yes\"";
            /// XDocument sl = new XDocument();

            try { 
            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);

            conector.Open();

            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("select * from [Hoja1$]",conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            conector.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("asddasd");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Source);
            }

            datos = "";
            return true;
        }



        public static List<string[]> parseCSV(string path)
        {
            List<string[]> parsedData = new List<string[]>();
            
            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(',');
                    parsedData.Add(row);
                }
            }
            return parsedData;
        }

        // para crear el archivo
        public static void GenerarCSV(string ruta, string cadena)
        {
            using (StreamWriter mylogs = File.AppendText(ruta))         //se crea el archivo
            {

                //DateTime dateTime = new DateTime();
                //dateTime = DateTime.Now;
                //string strDate = Convert.ToDateTime(dateTime).ToString("yyMMdd");

                mylogs.WriteLine(cadena );

                mylogs.Close();
            }
        }


        public static string LeeUltimoRegistro(string archivo)
        {
            string lastLine = File.ReadLines(archivo).Last();
            return lastLine;
        }

        public static void EliminaUltimaLinea(string archivo)
        {
            List<string> lines = File.ReadAllLines(archivo).ToList();

            File.WriteAllLines(archivo, lines.GetRange(0, lines.Count - 1).ToArray());
        }

        public static void Guardado(string queGuardo)
        {
            Archivos archivo = new Archivos();

            //string path = Directory.GetCurrentDirectory();
            //path += "\\archivoSalida.txt";
            string path = Directory.GetCurrentDirectory() + "\\Operacion\\id\\cod.txt";
            archivo.Guardar(path, queGuardo);
        }


    }
}
