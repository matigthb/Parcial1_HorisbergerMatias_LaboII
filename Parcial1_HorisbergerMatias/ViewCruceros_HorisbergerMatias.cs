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
    public partial class ViewCruceros_HorisbergerMatias : Form
    {
        private List<Cruceros> cruceros = Cruceros.ObtenerCruceros();
        public ViajesRegistrados viajes;
        int index; 

        public ViewCruceros_HorisbergerMatias()
        {
            InitializeComponent();
        }

        private void ViewCruceros_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            index = 0;
            lblCrucero.Text = cruceros[index].nombre;
            CambiarValores(cruceros[index]);
            MostrarSalones(index);
        }

        /// <summary>
        /// metodo para mostrar todos los salones de un crucero
        /// </summary>
        /// <param name="indiceCrucero"></param>
        private void MostrarSalones(int indiceCrucero)
        {
            /*foreach (Cruceros item in cruceros)
            {
                if(item.nombre == nombreCrucero)
                {
                    for(int i=0; i<item.listaSalones.Count; i++)
                    {
                        listBox1.Items.Add(item.listaSalones[i].Mostrar());
                    }
                    break;
                }
            }*/

            for (int i = 0; i < cruceros[indiceCrucero].listaSalones.Count; i++)
            {
                listBox1.Items.Add(cruceros[indiceCrucero].listaSalones[i].Mostrar());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// boton para volver al crucero anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                index = 6;
            }
            lblCrucero.Text = cruceros[index].nombre;
            CambiarValores(cruceros[index]);
            listBox1.Items.Clear();
            MostrarSalones(index);
        }

        /// <summary>
        /// boton para pasar al crucero siguiente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            index++;
            if (index == 7)
            {
                index = 0;
            }
            lblCrucero.Text = cruceros[index].nombre;
            CambiarValores(cruceros[index]);
            listBox1.Items.Clear();
            MostrarSalones(index);
        }

        /// <summary>
        /// cambio valores de los textbox
        /// </summary>
        /// <param name="crucero"></param>
        private void CambiarValores(Cruceros crucero)
        {
            txtMatricula.Text = crucero.matricula;
            txtCamPremium.Text = crucero.cantCamPremium.ToString();
            txtCamTurista.Text = crucero.cantCamTurista.ToString();
            txtCamTotal.Text = crucero.cantCamarotes.ToString();
            txtBodega.Text = crucero.capBodega.ToString()+"kg";
            LabelEstado(crucero);
        }

        /// <summary>
        /// cambio el label de estado segun la fecha de viaje
        /// </summary>
        /// <param name="crucero"></param>
        private void LabelEstado(Cruceros crucero)
        {
            DateTime fechaInicio = new DateTime();
            DateTime FechaFinal = new DateTime();
            int duracion;

            foreach (Viajes item in viajes.viajes)
            {
                fechaInicio = item.Fecha;
                duracion = item.Duracion;
                duracion = duracion / 24;
                FechaFinal = fechaInicio.AddDays(duracion);
                if (DateTime.Compare(fechaInicio, DateTime.Now) <= 0 && DateTime.Compare(FechaFinal, DateTime.Now) >= 0)
                {
                    lblEstado.BackColor = Color.Aquamarine;
                    lblEstado.Text = "En viaje";
                }
                else
                {
                    lblEstado.BackColor = Color.Green;
                    lblEstado.Text = "Activo";
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnCerrarAyuda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
