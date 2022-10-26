using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_HorisbergerMatias;

namespace Parcial1_HorisbergerMatias
{
    public partial class Menu_HorisbergerMatias : Form
    {
        public string usuarioId;
        private ViajesRegistrados viajesRegistrados = new ViajesRegistrados();

        public Menu_HorisbergerMatias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            lblUsuario.Text = usuarioId;
            lblFecha.Text = now.ToLongDateString();
        }

        /// <summary>
        ///  muestro el form de viajes disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Viajes_HorisbergerMatias frm = new Viajes_HorisbergerMatias();

            frm.viajes = viajesRegistrados;

            frm.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// muestro el form de ver cruceros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ViewCruceros_HorisbergerMatias frm = new ViewCruceros_HorisbergerMatias();

            frm.viajes = viajesRegistrados;
            frm.Show();
        }

        /// <summary>
        /// muestro el form de vender pasajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Pasajes_HorisbergerMatias frm = new Pasajes_HorisbergerMatias();

            frm.viajes = viajesRegistrados;
            frm.ShowDialog();
        }

        /// <summary>
        /// muestro el form de estadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Stats_HorisbergerMatias frm = new Stats_HorisbergerMatias();

            frm.viajes = viajesRegistrados;
            frm.ShowDialog();
        }

        private void btnAyudaViajes_Click(object sender, EventArgs e)
        {
            if(panelAyuda.Visible == true)
            {
                panelAyuda.Visible = false;
            }
            else
            {
                panelAyuda.Visible = true;
                lblAyuda.Text = "Pantalla para visualizar viajes disponibles, poder crearlos y visualizar pasajeros.";
            }
        }

        private void btnCerrarAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
        }

        private void btnAyudaCruceros_Click(object sender, EventArgs e)
        {
            if (panelAyuda.Visible == true)
            {
                panelAyuda.Visible = false;
            }
            else
            {
                panelAyuda.Visible = true;
                lblAyuda.Text = "Pantalla para visualizar cruceros con toda su información, incluyendo estado.";
            }
        }

        private void btnAyudaPasajes_Click(object sender, EventArgs e)
        {
            if (panelAyuda.Visible == true)
            {
                panelAyuda.Visible = false;
            }
            else
            {
                panelAyuda.Visible = true;
                lblAyuda.Text = "Pantalla para visualizar vender pasajes, ingresando los datos de el/los pasajero(s) a ingresar.";
            }
        }

        private void btnAyudaEstadisticas_Click(object sender, EventArgs e)
        {
            if (panelAyuda.Visible == true)
            {
                panelAyuda.Visible = false;
            }
            else
            {
                panelAyuda.Visible = true;
                lblAyuda.Text = "Pantalla para visualizar estadísticas históricas de la empresa.";
            }
        }

        private void Menu_HorisbergerMatias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
