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
    public partial class Pasajes_HorisbergerMatias : Form
    {
        public ViajesRegistrados viajes;
        private GrupoFamiliar pasajerosAuxiliar = new GrupoFamiliar();

        public Pasajes_HorisbergerMatias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pasajes_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridView();
            fecNacimiento.MaxDate = DateTime.Now;
            fecEmision.MaxDate = DateTime.Now;
            fecCaducidad.MinDate = DateTime.Now;
            cmbValijas.SelectedIndex = 0;
        }

        /// <summary>
        /// setup de la grilla
        /// </summary>
        private void SetupDataGridView()
        {

            dataViajes.ColumnCount = 11;

            dataViajes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataViajes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataViajes.ColumnHeadersDefaultCellStyle.Font = new Font(dataViajes.Font, FontStyle.Bold);

            dataViajes.Name = "dataViajes";
            dataViajes.Size = new Size(821, 306);
            dataViajes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataViajes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataViajes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataViajes.GridColor = Color.Black;
            dataViajes.RowHeadersVisible = false;

            dataViajes.Columns[0].Name = "Origen";
            dataViajes.Columns[1].Name = "Destino";
            dataViajes.Columns[2].Name = "Fecha de Salida";
            dataViajes.Columns[3].Name = "Crucero";
            dataViajes.Columns[4].Name = "Camarotes Turistas Disponibles";
            dataViajes.Columns[5].Name = "Camarotes Premium Disponibles";
            dataViajes.Columns[6].Name = "Costo Total Turista";
            dataViajes.Columns[7].Name = "Costo Total Premium";
            dataViajes.Columns[8].Name = "Peso Disponible en Bodega";
            dataViajes.Columns[9].Name = "Duración";
            dataViajes.Columns[10].Name = "Id";
            dataViajes.Columns[3].DefaultCellStyle.Font = new Font(dataViajes.DefaultCellStyle.Font, FontStyle.Italic);

            dataViajes.AllowUserToResizeColumns = false;
            dataViajes.AllowUserToAddRows = false;
            dataViajes.AllowUserToResizeRows = false;
            dataViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataViajes.MultiSelect = false;
            //dataViajes.Dock = DockStyle.Fill;

            /*dataViajes.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);*/
        }

        /// <summary>
        /// rellenon la grilla con viajes
        /// </summary>
        private void PopulateDataGridView()
        {
            foreach (Viajes item in viajes.viajes)
            {
                dataViajes.Rows.Add(item.MostrarViajeEnGrilla());
            }

            dataViajes.Columns[0].DisplayIndex = 0;
            dataViajes.Columns[1].DisplayIndex = 1;
            dataViajes.Columns[2].DisplayIndex = 2;
            dataViajes.Columns[3].DisplayIndex = 3;
            dataViajes.Columns[4].DisplayIndex = 4;
            dataViajes.Columns[5].DisplayIndex = 5;
            dataViajes.Columns[6].DisplayIndex = 6;
            dataViajes.Columns[7].DisplayIndex = 7;
            dataViajes.Columns[8].DisplayIndex = 8;
            dataViajes.Columns[9].DisplayIndex = 9;
            dataViajes.Columns[10].DisplayIndex = 10;

            dataViajes.Columns[0].Width = 200;
            dataViajes.Columns[1].Width = 200;
            dataViajes.Columns[2].Width = 125;
            dataViajes.Columns[3].Width = 95;
            dataViajes.Columns[4].Width = 100;
            dataViajes.Columns[5].Width = 100;
            dataViajes.Columns[6].Width = 150;
            dataViajes.Columns[7].Width = 150;
            dataViajes.Columns[8].Width = 80;
            dataViajes.Columns[9].Width = 60;
            dataViajes.Columns[10].Width= 10;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// agrego a la lista de pasajeros confirmados el pasajero con los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (Validaciones(grpEquipaje) == true && Validaciones(grpPasajero) == true && Validaciones(grpPasaporte) == true && Validaciones(grpPrecio) == true)
            {
                /*int viajeId = Convert.ToInt32(dataViajes.CurrentRow.Cells["Id"].Value);

                foreach (Viajes item in viajes.viajes)
                {
                    if (item.Id == viajeId)
                    {
                        if (button1.Text == "TURISTA")
                        { 
                            if (item.CantCamTurista + listPasajeros.Items.Count + 1 > item.Crucero.cantCamTurista)
                            {
                                MessageBox.Show("No hay suficientes camarotes turista disponibles.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                        else
                        {
                            if (button1.Text == "PREMIUM" && item.CantCamPremium >= item.Crucero.cantCamPremium)
                            {
                                MessageBox.Show("No hay camarotes disponibles para la clase premium.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            }
                        }
                    }
                }*/

                
                EClase clase;

                if(button1.Text == "TURISTA")
                {
                    clase = EClase.Turista;
                }
                else
                {
                    clase = EClase.Premium;
                }

                Pasajero pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), new Pasaporte(int.Parse(txtDNI.Text), txtSexo.Text,
                    fecNacimiento.Value, txtNacionalidad.Text, txtProvincia.Text, txtCodigoPais.Text, fecEmision.Value, fecCaducidad.Value, txtNumeroPasaporte.Text), 
                    clase, checkBox1.Checked, Convert.ToDouble(txtPesoBolso.Text), Convert.ToDouble(txtPesoVal1.Text), Convert.ToDouble(txtPesoVal2.Text));

                pasajerosAuxiliar.pasajeros.Add(pasajero);
                pasajerosAuxiliar.precioNetoAPagar = pasajerosAuxiliar.precioNetoAPagar + Convert.ToDouble(txtNeto.Text);
                button1.Enabled = false;
                dataViajes.Enabled = false;
                ActualizarLista(); 
                Limpiar();
                
            }
        }

        /// <summary>
        /// actualiza la lista de pasajeros
        /// </summary>
        private void ActualizarLista()
        {
            listPasajeros.Items.Clear();

            foreach(Pasajero item in pasajerosAuxiliar.pasajeros)
            {
                listPasajeros.Items.Add(item.ToString());
                txtCostoTotal.Text = pasajerosAuxiliar.precioNetoAPagar.ToString();
            }

            if(listPasajeros.Items.Count == 4)
            {
                lblError.Visible = true;
                BloquearControles();
            }
        }

        /// <summary>
        /// limpio todos los controles de datos
        /// </summary>
        private void Limpiar()
        {
            foreach (Control item in grpPasajero.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in grpPasaporte.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in grpEquipaje.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "0";
                }
            }

            cmbValijas.SelectedIndex = 0;
        }

        
        /// <summary>
        /// valido que los controles tengan valores validos
        /// </summary>
        /// <param name="groupbox"></param>
        /// <returns></returns>
        private bool Validaciones(GroupBox groupbox)
        {
            bool retorno=true;

            foreach (Control item in groupbox.Controls)
            {
                if (item is TextBox && item.Visible == true && item.Text == "")
                {
                    MessageBox.Show("Existe un campo vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retorno = false;
                    break;
                }

                if (item is TextBox && (item.Name == "txtPesoBolso" || item.Name == "txtPesoVal1" || item.Name == "txtPesoVal2") && (Convert.ToInt32(item.Text) > 25 || Convert.ToInt32(item.Text) < 0 ))
                {
                    MessageBox.Show("El peso del equipaje no es válido (0-25)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        /// <summary>
        /// permito la edicion de los controles de valores del form
        /// </summary>
        private void PermitirEdicion()
        {
            foreach (Control item in grpPasajero.Controls)
            {
                if(item is TextBox || item is DateTimePicker)
                {
                    item.Enabled = true;
                }
            }

            foreach (Control item in grpPasaporte.Controls)
            {
                if (item is TextBox || item is DateTimePicker)
                {
                    item.Enabled = true;
                }
            }

            foreach (Control item in grpEquipaje.Controls)
            {
                if (item is TextBox || item is CheckBox || item is ComboBox)
                {
                    item.Enabled = true;
                }
            }

            foreach (Control item in grpPrecio.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                }
            }

            foreach(Control item in grpListaPasajeros.Controls)
            {
                if(item is TextBox || item is ListBox)
                {
                    item.Enabled = true;
                }
            }
        }

        /// <summary>
        /// bloqueo la edicion de los controles de valores del form
        /// </summary>
        private void BloquearControles()
        {
            foreach (Control item in grpPasajero.Controls)
            {
                if (item is TextBox || item is DateTimePicker)
                {
                    item.Enabled = false;
                }
            }

            foreach (Control item in grpPasaporte.Controls)
            {
                if (item is TextBox || item is DateTimePicker)
                {
                    item.Enabled = false;
                }
            }

            foreach (Control item in grpEquipaje.Controls)
            {
                if (item is TextBox || item is CheckBox)
                {
                    item.Enabled = false;
                }
            }

            foreach (Control item in grpPrecio.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }

            foreach (Control item in grpListaPasajeros.Controls)
            {
                if (item is TextBox || item is ListBox)
                {
                    item.Enabled = true;
                }
            }
        }

        /// <summary>
        /// actualizo cantidad de pesos ingresables al cambiar de numero de valijas elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbValijas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbValijas.SelectedIndex)
            {
                case 0:
                    lblPesoVal1.Visible = false;
                    lblPesoVal2.Visible = false;
                    txtPesoVal1.Visible = false;
                    txtPesoVal2.Visible = false;
                    
                break;

                case 1:
                    lblPesoVal1.Visible = true;
                    lblPesoVal2.Visible = false;
                    txtPesoVal1.Visible = true;
                    txtPesoVal2.Visible = false;
                    txtPesoVal1.Text = "0";
                break;

                case 2:
                    lblPesoVal1.Visible = true;
                    lblPesoVal2.Visible = true;
                    txtPesoVal1.Visible = true;
                    txtPesoVal2.Visible = true;
                    txtPesoVal1.Text = "0";
                    txtPesoVal2.Text = "0";
                break;
            }
        }

        /// <summary>
        /// cambio de clase, y por ende la cantidad de valijas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            cmbValijas.SelectedIndex = 0;
            
            if(button1.Text == "TURISTA")
            {
                button1.Text = "PREMIUM";
                cmbValijas.Items.Add("2");
                txtCosto.Text = dataViajes.CurrentRow.Cells["Costo Total Premium"].Value.ToString();
            }
            else
            {
                button1.Text = "TURISTA";
                cmbValijas.Items.RemoveAt(2);
                txtCosto.Text = dataViajes.CurrentRow.Cells["Costo Total Turista"].Value.ToString();
            }

            txtNeto.Text = (Convert.ToDouble(txtCosto.Text) + ((Convert.ToDouble(txtCosto.Text) * 21) / 100) + ((Convert.ToDouble(txtCosto.Text) * 4) / 100)).ToString();
        }

        /// <summary>
        /// dejo ver y modificar el peso del bolso de mano dependiendo de si lo requiere el usuario o no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtPesoBolso.Visible = true;
                lblBolsoMano.Visible = true;
            }
            else
            {
                txtPesoBolso.Visible = false;
                lblBolsoMano.Visible = false;
            }
        }

        /// <summary>
        /// actualizo datos en el groupbox de datos del viaje elegido al hacer click en la grilla de viajes disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCrucero.Text = dataViajes.CurrentRow.Cells["Crucero"].Value.ToString();
            txtOrigen.Text = dataViajes.CurrentRow.Cells["Origen"].Value.ToString();
            txtDestino.Text = dataViajes.CurrentRow.Cells["Destino"].Value.ToString();
            txtFecha.Text = dataViajes.CurrentRow.Cells["Fecha de Salida"].Value.ToString();
            txtCamarotes.Text = (Convert.ToInt32(dataViajes.CurrentRow.Cells["Camarotes Premium Disponibles"].Value) + Convert.ToInt32(dataViajes.CurrentRow.Cells["Camarotes Turistas Disponibles"].Value)).ToString();
            txtBodega.Text = dataViajes.CurrentRow.Cells["Peso Disponible en Bodega"].Value.ToString();

            if (button1.Text == "TURISTA")
            {
                txtCosto.Text = dataViajes.CurrentRow.Cells["Costo Total Turista"].Value.ToString();
            }
            else
            {
                txtCosto.Text = dataViajes.CurrentRow.Cells["Costo Total Premium"].Value.ToString();
            }
            txtNeto.Text = (Convert.ToDouble(txtCosto.Text) + ((Convert.ToDouble(txtCosto.Text) * 21) / 100) + ((Convert.ToDouble(txtCosto.Text) * 4) / 100)).ToString();

            PermitirEdicion();
        }

        /// <summary>
        /// añado los pasajeros al viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int viajeId;
            string destino="";
            string crucero="";
            string fecha="";

            if(listPasajeros.Items.Count > 0)
            {
                viajeId = Convert.ToInt32(dataViajes.CurrentRow.Cells["Id"].Value);

                foreach(Viajes item in viajes.viajes)
                {
                    if(item.Id == viajeId)
                    {
                        if (button1.Text == "TURISTA")
                        {
                            if (item.CantCamTurista + listPasajeros.Items.Count > item.Crucero.cantCamPremium)
                            {
                                MessageBox.Show("No hay suficientes camarotes turista disponibles.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                item.CantCamTurista += listPasajeros.Items.Count;
                            }
                        }
                        else
                        {
                            if (item.CantCamPremium + listPasajeros.Items.Count > item.Crucero.cantCamPremium)
                            {
                                MessageBox.Show("No hay suficientes camarotes premium disponibles.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                item.CantCamPremium += listPasajeros.Items.Count;
                            }
                        }

                        item.GrupoFamiliar.Add(pasajerosAuxiliar);
                        
                        destino = item.Destino.ToString();
                        crucero = item.Crucero.nombre;
                        fecha = item.Fecha.ToString();

                        MessageBox.Show("Pasajero(s) añadido(s) al viaje hacia " + destino + "\nCrucero: " + crucero + " Fecha: " + fecha, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe cargar al menos un pasajero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPesoBolso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPesoVal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPesoVal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            if (panelAyuda.Visible == true)
            {
                panelAyuda.Visible = false;
            }
            else
            {
                panelAyuda.Visible = true;
            }
        }

        private void btnCerrarAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea abandonar la operación?", "El progreso no se guardará.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listPasajeros.SelectedIndex != -1)
            {
                listPasajeros.Items.RemoveAt(listPasajeros.SelectedIndex);
                txtNeto.Text = "";
            }
        }
    }
}
