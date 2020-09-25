using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BibliotecaDeClases;
using PrinterTG2480H;
using YPF.GUI;

namespace YPF
{
    public partial class LogIn : Form
    {
        public List<Playero> playeros;


        public LogIn()
        {
            InitializeComponent();
            MostrarPantallaCompleta();

            string ruta = Directory.GetCurrentDirectory() + "\\utils\\Playeros.csv";
            List<string[]> listado = Archivos.parseCSV(ruta);

            bool flag = Playero.parseo(listado, out List<Playero> playerosAux);
            if (flag == true)
            {
                this.playeros = playerosAux;
            }

            string ruta2 = Directory.GetCurrentDirectory() + "\\utils\\informeSalida.csv";
            Archivos.GenerarCSV(ruta2, "Codigo de Operacion;Fecha;Hora;Nombre;Apellido;DNI;Turno;Monto");


        }





        #region Teclado

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string aux = this.txtDNI.Text;
            if(aux.Length > 0) { 
                this.txtDNI.Text = aux.Substring(0, aux.Length - 1);
            }
            if(aux.Length ==1)
            {
                this.lblError.Text = "";
            }

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.txtDNI.Text = "";
            this.lblError.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(this.txtDNI.Text.Length < 8) { 
                this.txtDNI.Text = this.txtDNI.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length < 8)
            {
                this.txtDNI.Text = this.txtDNI.Text + "0";
            }
        }

        #endregion


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool flag = Validaciones.ValidarQueSeaDni(this.txtDNI.Text, out string dni);
            if (flag == true)
            {
                if (Validaciones.PlayeroExiste(this.playeros, dni))
                {
                    SesionIniciada se = new SesionIniciada();
                    se.CargarDatos(this.playeros, dni);
                    se.ShowDialog();

                    this.lblError.Text = "";
                    this.txtDNI.Text = "";
                }
                else
                {
                    this.lblError.Text = "Ese DNI no esta registrado";
                }
            }
            else
            {
                this.lblError.Text = "DNI Incorrecto";
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            MostrarPantallaCompleta();
        }

        private void MostrarPantallaCompleta()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {

        }
    }
}
