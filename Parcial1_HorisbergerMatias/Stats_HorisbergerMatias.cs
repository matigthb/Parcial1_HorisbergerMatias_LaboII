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
    public partial class Stats_HorisbergerMatias : Form
    {
        private List<Destino> destinos = Destino.ObtenerDestinos();
        public ViajesRegistrados viajes;
        private List<Cruceros> cruceros = Cruceros.ObtenerCruceros();

        public Stats_HorisbergerMatias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stats_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            SetupDestinos();
            GrillaDestinos();
            //GrillaPasajeros();
            
        }

        /// <summary>
        /// setup para los filtros que conllevan destinos
        /// </summary>
        private void SetupDestinos()
        {

            dataDestinos.ColumnCount = 2;

            dataDestinos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataDestinos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataDestinos.ColumnHeadersDefaultCellStyle.Font = new Font(dataDestinos.Font, FontStyle.Bold);

            dataDestinos.Name = "dataDestinos";
            dataDestinos.Size = new Size(617, 381);
            dataDestinos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataDestinos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataDestinos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataDestinos.GridColor = Color.Black;
            dataDestinos.RowHeadersVisible = false;

            dataDestinos.Columns[0].Name = "Destino";
            dataDestinos.Columns[1].Name = "Facturacion Total";

            dataDestinos.Columns[0].DefaultCellStyle.Font = new Font(dataDestinos.DefaultCellStyle.Font, FontStyle.Italic);

            dataDestinos.AllowUserToResizeColumns = false;
            dataDestinos.AllowUserToAddRows = false;
            dataDestinos.AllowUserToResizeRows = false;
            dataDestinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDestinos.MultiSelect = false;
            //dataViajes.Dock = DockStyle.Fill;

            /*dataViajes.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);*/
        }

        /// <summary>
        /// setup para el filtro que conlleva cruceros
        /// </summary>
        private void SetupCruceros()
        {

            dataDestinos.ColumnCount = 2;

            dataDestinos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataDestinos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataDestinos.ColumnHeadersDefaultCellStyle.Font = new Font(dataDestinos.Font, FontStyle.Bold);

            dataDestinos.Name = "dataDestinos";
            dataDestinos.Size = new Size(617, 381);
            dataDestinos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataDestinos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataDestinos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataDestinos.GridColor = Color.Black;
            dataDestinos.RowHeadersVisible = false;

            dataDestinos.Columns[0].Name = "Crucero";
            dataDestinos.Columns[1].Name = "Total en Horas";

            dataDestinos.Columns[0].DefaultCellStyle.Font = new Font(dataDestinos.DefaultCellStyle.Font, FontStyle.Italic);

            dataDestinos.AllowUserToResizeColumns = false;
            dataDestinos.AllowUserToAddRows = false;
            dataDestinos.AllowUserToResizeRows = false;
            dataDestinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDestinos.MultiSelect = false;
            //dataViajes.Dock = DockStyle.Fill;

            /*dataViajes.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);*/
        }

        /// <summary>
        /// setup para el filtro que conlleva pasajeros
        /// </summary>
        private void SetupPasajeros()
        {

            dataDestinos.ColumnCount = 2;

            dataDestinos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataDestinos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataDestinos.ColumnHeadersDefaultCellStyle.Font = new Font(dataDestinos.Font, FontStyle.Bold);

            dataDestinos.Name = "dataDestinos";
            dataDestinos.Size = new Size(617, 381);
            dataDestinos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataDestinos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataDestinos.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataDestinos.GridColor = Color.Black;
            dataDestinos.RowHeadersVisible = false;

            dataDestinos.Columns[0].Name = "Pasajeros";
            dataDestinos.Columns[1].Name = "Cantidad de Viajes";

            dataDestinos.Columns[0].DefaultCellStyle.Font = new Font(dataDestinos.DefaultCellStyle.Font, FontStyle.Italic);

            dataDestinos.AllowUserToResizeColumns = false;
            dataDestinos.AllowUserToAddRows = false;
            dataDestinos.AllowUserToResizeRows = false;
            dataDestinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDestinos.MultiSelect = false;
            //dataViajes.Dock = DockStyle.Fill;

            /*dataViajes.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);*/
        }

        /// <summary>
        /// relleno grilla de destinos
        /// </summary>
        private void GrillaDestinos()
        {
            double totalDestino;

            dataDestinos.Rows.Clear();

            foreach (Destino item in destinos)
            {
                totalDestino = 0;
                foreach(Viajes viaje in viajes.viajes)
                {
                    
                    if(viaje.Destino == item)
                    {
                        foreach (GrupoFamiliar grupo in viaje.GrupoFamiliar)
                        {
                            totalDestino = totalDestino + grupo.precioNetoAPagar;
                        }
                    }

                }

                dataDestinos.Rows.Add(RowDestinos(item, totalDestino));
            }

            dataDestinos.Columns[0].DisplayIndex = 0;
            dataDestinos.Columns[1].DisplayIndex = 1;

            dataDestinos.Columns[0].Width = 200;
            dataDestinos.Columns[1].Width = 200;

            dataDestinos.Sort(dataDestinos.Columns["Facturacion Total"], ListSortDirection.Descending);
        }

        /// <summary>
        /// relleno grilla separados por region
        /// </summary>
        private void GrillaPorRegion()
        {
            double totalDestino;
            double totalRegional=0;

            dataDestinos.Rows.Clear();

            foreach (Destino item in destinos)
            {
                if(item.eRegional == ERegional.Si)
                {
                    totalDestino = 0;
                    foreach (Viajes viaje in viajes.viajes)
                    {

                        if (viaje.Destino == item)
                        {
                            foreach (GrupoFamiliar grupo in viaje.GrupoFamiliar)
                            {
                                totalDestino = totalDestino + grupo.precioNetoAPagar;
                            }
                        }
                    }

                    if(totalDestino > 0)
                    {
                        totalRegional = totalRegional + totalDestino;
                        dataDestinos.Rows.Add(RowDestinos(item, totalDestino));
                    }
                }
            }

            string[] row = { "TOTAL REGIONAL", totalRegional.ToString() };

            dataDestinos.Rows.Add(row);

            totalRegional = 0;

            foreach (Destino item in destinos)
            {
                if (item.eRegional == ERegional.No)
                {
                    totalDestino = 0;
                    foreach (Viajes viaje in viajes.viajes)
                    {

                        if (viaje.Destino == item)
                        {
                            foreach (GrupoFamiliar grupo in viaje.GrupoFamiliar)
                            {
                                totalDestino = totalDestino + grupo.precioNetoAPagar;
                            }
                        }
                    }

                    if (totalDestino > 0)
                    {
                        totalRegional = totalRegional + totalDestino;
                        dataDestinos.Rows.Add(RowDestinos(item, totalDestino));
                    }
                }
            }

            string[] row2 = { "TOTAL EXTRA REGIONAL", totalRegional.ToString() };

            dataDestinos.Rows.Add(row2);

            dataDestinos.Columns[0].DisplayIndex = 0;
            dataDestinos.Columns[1].DisplayIndex = 1;

            dataDestinos.Columns[0].Width = 200;
            dataDestinos.Columns[1].Width = 200;
        }

        /// <summary>
        /// relleno grilla por cruceros y total de horas viajadas
        /// </summary>
        private void GrillaCruceros()
        {
            int horasTotal;

            dataDestinos.Rows.Clear();

            foreach (Cruceros item in cruceros)
            {
                horasTotal = 0;
                foreach (Viajes viaje in viajes.viajes)
                { 
                    if (viaje.Crucero == item)
                    {
                        horasTotal = horasTotal + viaje.Duracion;
                    }
                }
                dataDestinos.Rows.Add(RowCruceros(item, horasTotal));
            }


            dataDestinos.Columns[0].DisplayIndex = 0;
            dataDestinos.Columns[1].DisplayIndex = 1;

            dataDestinos.Columns[0].Width = 200;
            dataDestinos.Columns[1].Width = 200;
        }

        /// <summary>
        /// relleno grilla por pasajeros y cantidad de viajes
        /// </summary>
        private void GrillaPasajeros()
        {
            int contador;

            foreach(Viajes item in viajes.viajes)
            {
                foreach(GrupoFamiliar grupo in item.GrupoFamiliar)
                {
                    foreach(Pasajero pasajero in grupo.pasajeros)
                    {
                        contador = 0;
                        contador++;
                        dataDestinos.Rows.Add(RowPasajeros(pasajero, contador));
                    }
                    
                }
            }

            dataDestinos.Columns[0].DisplayIndex = 0;
            dataDestinos.Columns[1].DisplayIndex = 1;

            dataDestinos.Columns[0].Width = 400;
            dataDestinos.Columns[1].Width = 200;
        }

        /// <summary>
        /// metodo para mostrar una linea de destinos en la grilla
        /// </summary>
        /// <param name="destino"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private string[] RowDestinos(Destino destino, double total)
        {
            string[] row = { destino.ToString(), total.ToString()};

            return row;
        }

        /// <summary>
        /// metodo para mostrar una linea de cruceros en la grilla
        /// </summary>
        /// <param name="crucero"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private string[] RowCruceros(Cruceros crucero, int total)
        {
            string[] row = { crucero.nombre, total.ToString() };

            return row;
        }

        /// <summary>
        /// metodo para mostrar una linea de pasajeros en la grilla
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private string[] RowPasajeros(Pasajero pasajero, int total)
        {
            string[] row = { pasajero.ToString(), total.ToString() };

            return row;
        }

        /// <summary>
        /// filtro por region
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "REGIONAL Y EXTRA REGIONAL";
            SetupDestinos();
            GrillaPorRegion();
        }

        /// <summary>
        /// filtro por destinos y facturacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "DESTINOS FACTURACIÓN";
            SetupDestinos();
            GrillaDestinos();
        }

        /// <summary>
        /// filtro por cruceros y horas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "CRUCEROS HORAS";
            SetupCruceros();
            GrillaCruceros();
        }

        /// <summary>
        /// filtros por pasajeros y viajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "PASAJEROS VIAJES";
            SetupPasajeros();
            GrillaPasajeros();
        }
    }
}
