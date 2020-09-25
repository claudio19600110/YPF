using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using System.IO;
using PrinterTG2480H;
using System.Net.Sockets;
using VentanaMantenimiento;

namespace YPF.GUI
{
    public partial class SesionIniciada : Form
    {
        private List<Playero> playeros;
        private string seleccionado;
        public SesionIniciada()
        {
            InitializeComponent();
            MostrarPantallaCompleta();
        }

        private void SesionIniciada_Load(object sender, EventArgs e)
        {
            MostrarPantallaCompleta();
        }

        private void MostrarPantallaCompleta()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public void CargarDatos(List<Playero> nomina, string dni)
        {
            this.playeros = nomina;
            this.seleccionado = dni;
            this.llenaDatos();


        }



        public void llenaDatos()
        {
            foreach (Playero item in this.playeros)
            {
                if (item.Dni == this.seleccionado)
                {
                    this.lblDNI.Text = item.Dni;
                    this.lblApellido.Text = item.Apellido;
                    this.lblNombre.Text = item.Nombre;
                    break;
                }
            }
        }

        private void btnMadrugada_Click(object sender, EventArgs e)
        {
            string dineroIngresado = Pagar(sender, e);

            bool flag = int.TryParse(dineroIngresado, out int dineroInt);

            if (dineroInt > 0 && flag == true)
            {
                Deposito d;
                d = EscribeArchivo(dineroInt.ToString(), "MANANA");
                ImprimeTicket(d);

                MensajeExitoso me = new MensajeExitoso();
                me.ShowDialog();
                this.Close();

            }
            else
            {
                this.Close();
            }
        }

        private void btnTarde_Click(object sender, EventArgs e)
        {
            string dineroIngresado = Pagar(sender, e);

            bool flag = int.TryParse(dineroIngresado, out int dineroInt);

            if (dineroInt > 0 && flag == true)
            {
                Deposito d;
                d =EscribeArchivo(dineroInt.ToString(), "TARDE");
                ImprimeTicket(d);

                MensajeExitoso me = new MensajeExitoso();
                me.ShowDialog();
                this.Close();

            }
            else
            {
                this.Close();
            }
        }

        private void btnNoche_Click(object sender, EventArgs e)
        {
            string dineroIngresado = Pagar(sender, e);
            //string dineroIngresado = "5000";
            bool flag = int.TryParse(dineroIngresado, out int dineroInt);

            if (dineroInt > 0 && flag == true)
            {
                
                Deposito d;
                d = EscribeArchivo(dineroInt.ToString(), "NOCHE");

                ImprimeTicket(d);
                MensajeExitoso me = new MensajeExitoso();
                me.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private Deposito EscribeArchivo(string monto, string turno)
        {
            Playero playeroElejido = Validaciones.PlayeroExiste(this.playeros, seleccionado, "");


            DateTime diaHora = DateTime.Now;

            Deposito d = new Deposito(monto, turno, diaHora, playeroElejido);
            Archivos.GenerarCSV(Directory.GetCurrentDirectory() + "\\utils\\informeSalida.csv", d.CadenaParaGuardar());
            return d;
        }


        public void ImprimeTicket(Deposito depo)
        {
            //saldo, plataDepositada, mensajes
            //float montoTotalDeuda =TotalDeuda(deudaSujeto);
            //float plata = float.Parse(plataDepositada.ToString());
            //int saldo = plataDepositada - montoTotalDeuda;
            //float saldo = plataDepositada - montoTotalDeuda;

            PrintSpooler spooler = PrintSpooler.getInstance();
            VueltoTemplate vueltoTemplate = new VueltoTemplate(depo.montoToInt(), depo.Id, depo);
            spooler.Print(vueltoTemplate.ObtenerTemplate());
        }


        private string Pagar(object sender, EventArgs e)
        {
            string dineroIngresado = "0";
            try
            {
                bool flag = true;
                if (flag)
                {
                    string msg = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?><payment><command>cash</command><amount>" + 32000 + "</amount><appId>12345678</appId><timeout>300</timeout></payment>";
                    dineroIngresado = Connect("127.0.0.1", msg);
                }
                else
                {
                    this.lblDNI.Text = "Error";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dineroIngresado;
        }


        public string Connect(String server, String message)
        {
            string dineroIngresado = "-1";
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 4040;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                //Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[1000];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                if (responseData.Contains("insertedAmount"))
                {
                    int inicio = responseData.IndexOf("<insertedAmount>") + "<insertedAmount>".Length;
                    int fin = responseData.IndexOf("</insertedAmount>");
                    //this.txtPlataIngresada.Text = responseData.Substring(inicio, fin - inicio);
                    Console.WriteLine(responseData.Substring(inicio, fin - inicio));
                }
                if (responseData.Contains("monto"))
                {
                    int inicio = responseData.IndexOf("<monto>") + "<monto>".Length;
                    int fin = responseData.IndexOf("</monto>");
                    dineroIngresado = responseData.Substring(inicio, fin - inicio);
                }
                else
                {
                    //this.txtPlataIngresada.Text = "Error ó Timeout";
                    Console.WriteLine("Error ó Timeout");
                }

                // Close everything.
                stream.Close();
                client.Close();

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dineroIngresado;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
