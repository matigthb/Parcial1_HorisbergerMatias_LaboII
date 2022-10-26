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
    public partial class Pasajeros_HorisbergerMatias : Form
    {
        /// <summary>
        /// viaje elegido
        /// </summary>
        public Viajes viajeElegido;

        /// <summary>
        /// lista de pasajeros auxiliar
        /// </summary>
        public List<Pasajero> auxiliarPasajeros = new List<Pasajero>();

        public Pasajeros_HorisbergerMatias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pasajeros_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            MostrarPasajeros();
        }

        /// <summary>
        /// metodo para mostrar pasajeros en el textbox
        /// </summary>
        private void MostrarPasajeros()
        {
            textBox1.Text = viajeElegido.Destino + " , desde " + viajeElegido.Origen; 
            foreach(GrupoFamiliar item in viajeElegido.GrupoFamiliar)
            {
                foreach(Pasajero pasajero in item.pasajeros)
                {
                    listBox1.Items.Add(pasajero.ToString());
                    auxiliarPasajeros.Add(pasajero);
                }
            }
        }

        /// <summary>
        /// click del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// cambio de info detalle de pasaporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                richTextBox1.Text = "";

                richTextBox1.Text = auxiliarPasajeros[listBox1.SelectedIndex].pasaporte.ToString();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
