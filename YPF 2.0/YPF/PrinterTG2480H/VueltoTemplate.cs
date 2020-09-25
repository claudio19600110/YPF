using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

namespace PrinterTG2480H
{

    public class VueltoTemplate : Template
    {
        //private static string titulo = "Vuelto";
        private int monto { get; set; }
        private string codigoUnicoOperacion { get; set; }

        public VueltoTemplate(int monto, string codigoUnicoOperacion, Deposito dep)
        {
            this.monto = monto;
            this.codigoUnicoOperacion = codigoUnicoOperacion;
            this.CrearTemplate(dep);
        }

        public override StreamReader ObtenerTemplate()
        {
            // validaciones del template que se va a retornar

            return base.ObtenerTemplate();
        }

        protected override void CrearTemplate(Deposito dep)
        {
            try
            {
                string dia = dep.FechaYHora.Day.ToString() + "/" + dep.FechaYHora.Month.ToString() + "/" + dep.FechaYHora.Year.ToString();
                string hora = dep.FechaYHora.Hour.ToString() + ":" + dep.FechaYHora.Minute.ToString() + ":" + dep.FechaYHora.Second.ToString();

                AgregarLinea("");
                AgregarLinea("");
                AgregarLinea("");
                AgregarLinea("");
                AgregarLinea(""); //hasta aca no imprimir nada no se ve x la imagen
                AgregarLinea("    USTED INGRESO");
                AgregarLinea(("$" + dep.Monto).PadLeft(14, ' '));
                AgregarLinea("");
                AgregarLinea("");
                AgregarLinea("");
                AgregarLinea("DNI " +dep.Dni);
                AgregarLinea("");
                AgregarLinea("FECHA " + dia);
                AgregarLinea("");
                AgregarLinea("HORA " + hora);
                AgregarLinea("");
                AgregarLinea("OPERACIÓN Nº " + dep.Id);
                AgregarLinea("");
                AgregarLinea("TURNO " + dep.Turno);
                AgregarLinea("");
                AgregarLinea("NOMBRE " +dep.Nombre);
                AgregarLinea("");
                AgregarLinea("APELLIDO " + dep.Apellido);
                AgregarLinea("");
                AgregarLinea("");

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
