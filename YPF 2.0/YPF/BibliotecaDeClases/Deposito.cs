using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
using System.IO;

namespace BibliotecaDeClases
{
    public class Deposito
    {
        //private static int constId = 1000;
        private string id;
        private string monto;
        private string turno;
        private DateTime fechaYHora;
        private string nombre;
        private string apellido;
        private string dni;

        public Deposito(string monto, string turno, DateTime fechaYHora, string nombre, string apellido, string dni)
        {

            //this.Id = constId++.ToString();
            string data = Archivos.LeeUltimoRegistro(Directory.GetCurrentDirectory() + "\\Operacion\\id\\cod.txt");
            bool flag = int.TryParse(data, out int idTrucha);
            this.Id = idTrucha++.ToString();
            Archivos.EliminaUltimaLinea(Directory.GetCurrentDirectory() + "\\Operacion\\id\\cod.txt");
            Archivos.Guardado(idTrucha.ToString());
            this.Monto = monto;
            this.Turno = turno;
            this.FechaYHora = fechaYHora;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public Deposito(string monto, string turno, DateTime fechaYHora, Playero playero)
        {
            //this.Id = constId++.ToString();
            string data = Archivos.LeeUltimoRegistro(Directory.GetCurrentDirectory() + "\\Operacion\\id\\cod.txt");
            bool flag = int.TryParse(data, out int idTrucha);
            this.Id = idTrucha++.ToString();
            Archivos.EliminaUltimaLinea(Directory.GetCurrentDirectory() + "\\Operacion\\id\\cod.txt");
            Archivos.Guardado(idTrucha.ToString());
            this.monto = monto;
            this.turno = turno;
            this.fechaYHora = fechaYHora;
            this.nombre = playero.Nombre;
            this.apellido = playero.Apellido;
            this.dni = playero.Dni;
        }


        public string CadenaParaGuardar()
        {
            //"500", "noche", "2020/06/25 00:00:00", "Matias", "Palmieri", "41079975"
            //Codigo de Operacion Fecha   Hora Nombre  Apellido DNI Turno Monto
            string dia = FechaYHora.Day.ToString() + "/" + FechaYHora.Month.ToString() + "/" + FechaYHora.Year.ToString();
            string hora = FechaYHora.Hour.ToString() + ":" + FechaYHora.Minute.ToString() + ":" + FechaYHora.Second.ToString();

            return this.Id + ";" + dia + ";" + hora + ";" + this.Nombre + ";" 
            + this.Apellido + ";" + this.Dni + ";" + this.Turno + ";" + this.Monto ;
        }

        public int montoToInt()
        {
            bool flag = int.TryParse(monto, out int retorno);
            if(flag== true)
            {
                return retorno;
            }
            return 0;
        }


        #region Setter y Getters
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public DateTime FechaYHora
        {
            get { return fechaYHora; }
            set { fechaYHora = value; }
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
