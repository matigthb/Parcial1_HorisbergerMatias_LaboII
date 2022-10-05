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
    public partial class Viajes_HorisbergerMatias : Form
    {
        public ViajesRegistrados viajes;
        //public bool actualizar = true;

        public Viajes_HorisbergerMatias()
        {
            InitializeComponent();
        }

        private void Viajes_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            /*if(actualizar == true)
            {
                viajes = Viajes.RellenarViajes(viajes);
            }*/

            SetupDataGridView();
            PopulateDataGridView();
        }

        /// <summary>
        /// setup de la grilla de viajes
        /// </summary>
        private void SetupDataGridView()
        {

            dataViajes.ColumnCount = 11;

            dataViajes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataViajes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataViajes.ColumnHeadersDefaultCellStyle.Font = new Font(dataViajes.Font, FontStyle.Bold);

            dataViajes.Name = "dataViajes";
            dataViajes.Location = new Point(8, 8);
            dataViajes.Size = new Size(1203, 478);
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
        /// relleno la grilla de viajes
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
            dataViajes.Columns[10].Width = 60;

        }

        private void dataViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// muestro formulario para crear viajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            CrearViajes_HorisbergerMatias frm = new CrearViajes_HorisbergerMatias();
            
            this.Hide();
            frm.viajesDatos = viajes;
            frm.ShowDialog();
        }

        /// <summary>
        /// muestro formulario de pasajeros dentro del viaje seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Pasajeros_HorisbergerMatias frm = new Pasajeros_HorisbergerMatias();
            Viajes viajeElegido = EncontrarViaje(Convert.ToInt32(dataViajes.CurrentRow.Cells["Id"].Value));

            frm.viajeElegido = viajeElegido;
            frm.ShowDialog();
        }

        /// <summary>
        /// metodo para encontrar un viaje en la lista por medio de un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Viajes EncontrarViaje(int id)
        {
            Viajes viajeEncontrado = new Viajes();

            foreach (Viajes item in viajes.viajes)
            {
                if (item.Id == id)
                {
                    viajeEncontrado = item;
                }
            }

            return viajeEncontrado;        
        }
    }
}
