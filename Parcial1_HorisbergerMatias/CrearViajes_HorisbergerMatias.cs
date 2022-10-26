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
            fecFecha.MinDate = DateTime.Now;
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

            foreach(Destino item in destinos)
            {
                if(item.eRegional == ERegional.Si)
                {
                    regionales.Add(item);
                }
            }

            foreach (Destino item in destinos)
            {
                if (item.eRegional == ERegional.No)
                {
                    extraRegionales.Add(item);
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

            if (cmbCrucero.Text != "" && cmbOrigen.Text != "" && cmbDestino.Text != "")
            {

                if (chkRegional.Checked == true)
                {
                    viajeNuevo = new Viajes(viajesDatos.viajes[viajesDatos.viajes.Count - 1].Id + 1, this.cmbOrigen.Text, regionales[cmbDestino.SelectedIndex], this.fecFecha.Value.Date, cruceros[cmbCrucero.SelectedIndex], Viajes.DeterminarDuracionRegional(), 0, 0, 57, ERegional.Si, new List<GrupoFamiliar>(), 0);
                }
                else
                {
                    viajeNuevo = new Viajes(viajesDatos.viajes[viajesDatos.viajes.Count - 1].Id + 1, this.cmbOrigen.Text, extraRegionales[cmbDestino.SelectedIndex], this.fecFecha.Value.Date, cruceros[cmbCrucero.SelectedIndex], Viajes.DeterminarDuracionExtraRegional(), 0, 0, 120, ERegional.No, new List<GrupoFamiliar>(), 0);
                }

                viajesDatos.viajes.Add(viajeNuevo);

                if(MessageBox.Show("Viaje agregado correctamente, Desea agregar otro?", "Operación exitosa.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    frm.viajes = viajesDatos;
                    frm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No todos los datos están completos.", "Cuidado!",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void chkRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbDestino.Text = "";
            this.cmbDestino.Items.Clear();

            if (this.chkExtraRegional.Checked == false && this.chkRegional.Checked == false)
            {
                this.cmbDestino.Enabled = false;
            }
            else
            {
                if (this.chkRegional.Checked == true)
                {
                    this.cmbDestino.Enabled = true;
                    this.chkExtraRegional.Checked = false;
                    foreach (Destino item in regionales)
                    {
                        cmbDestino.Items.Add(item.ToString());
                    }
                }
            }
        }

        private void chkExtraRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbDestino.Text = "";
            this.cmbDestino.Items.Clear();

            if (this.chkExtraRegional.Checked == false && this.chkRegional.Checked == false)
            {
                this.cmbDestino.Enabled = false;
            }
            else
            {
                if (this.chkExtraRegional.Checked == true)
                {
                    this.cmbDestino.Enabled = true;
                    this.chkRegional.Checked = false;
                    foreach (Destino item in extraRegionales)
                    {
                        cmbDestino.Items.Add(item.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
