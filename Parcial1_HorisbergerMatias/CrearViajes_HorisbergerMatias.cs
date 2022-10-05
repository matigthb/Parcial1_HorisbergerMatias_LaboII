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
    public partial class CrearViajes_HorisbergerMatias : Form
    {
        /// <summary>
        /// viajes registrados
        /// </summary>
        public ViajesRegistrados viajesDatos;

        /// <summary>
        /// lista de cruceros
        /// </summary>
        private List<Cruceros> cruceros = Cruceros.ObtenerCruceros();
        
        /// <summary>
        /// lista de destinos
        /// </summary>
        private List<Destino> destinos = Destino.ObtenerDestinos();

        /// <summary>
        /// lista de destinos regionales auxiliar
        /// </summary>
        private List<Destino> regionales = new List<Destino>();

        /// <summary>
        /// lista de destinos extra regionalees auxiliar
        /// </summary>
        private List<Destino> extraRegionales = new List<Destino>();

        public CrearViajes_HorisbergerMatias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// evento load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrearViajes_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            chkRegional.Checked = true;
            CargarCombos();
        }

        /// <summary>
        /// metodo para cargar los combos necesarios
        /// </summary>
        private void CargarCombos()
        {
            foreach(Cruceros item in cruceros)
            {
                cmbCrucero.Items.Add(item.nombre.ToString());
            }

            cmbOrigen.Items.Add("Buenos Aires (Argentina)");

            if(chkRegional.Checked == true)
            {
                foreach(Destino item in destinos)
                {
                    if(item.eRegional == ERegional.Si)
                    {
                        regionales.Add(item);
                        cmbDestino.Items.Add(item.ToString());
                    }
                }
            }
            else
            {
                foreach (Destino item in destinos)
                {
                    if (item.eRegional == ERegional.No)
                    {
                        extraRegionales.Add(item);
                        cmbDestino.Items.Add(item.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// agrego el viaje a la lista y cierro el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Viajes_HorisbergerMatias frm = new Viajes_HorisbergerMatias();
            Viajes viajeNuevo;

            if(cmbCrucero.Text != "" && cmbOrigen.Text != "" && cmbDestino.Text != "")
            {
                if (chkRegional.Checked == true)
                { 
                    viajeNuevo = new Viajes(viajesDatos.viajes[viajesDatos.viajes.Count].Id + 1, this.cmbOrigen.Text, regionales[cmbDestino.SelectedIndex], this.fecFecha.Value.Date, cruceros[cmbCrucero.SelectedIndex], Viajes.DeterminarDuracionRegional(),0,0,57,ERegional.Si, new List<GrupoFamiliar>(),0);
                }
                else
                {
                    viajeNuevo = new Viajes(viajesDatos.viajes[viajesDatos.viajes.Count].Id + 1, this.cmbOrigen.Text, extraRegionales[cmbDestino.SelectedIndex], this.fecFecha.Value.Date, cruceros[cmbCrucero.SelectedIndex], Viajes.DeterminarDuracionExtraRegional(),0,0,120,ERegional.No, new List<GrupoFamiliar>(),0);
                }

                viajesDatos.viajes.Add(viajeNuevo);
            }
            
            frm.viajes = viajesDatos;
            frm.Show();
            this.Close();
        }

      
    }
}
