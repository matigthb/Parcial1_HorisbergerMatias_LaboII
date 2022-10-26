using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Viajes
    {
        /// <summary>
        /// id del viaje
        /// </summary>
        private int id;

        /// <summary>
        /// origen del viaje
        /// </summary>
        private string origen;

        /// <summary>
        /// destino del viaje, variable tipo destino
        /// </summary>
        private Destino destino;

        /// <summary>
        /// fecha de salida del viaje
        /// </summary>
        private DateTime fecha;

        /// <summary>
        /// crucero enlazado al viaje
        /// </summary>
        private Cruceros crucero;

        /// <summary>
        /// duracion del viaje en horas
        /// </summary>
        private int duracion;

        /// <summary>
        /// cantidad de camarotes premium comprados del viaje
        /// </summary>
        private int cantCamPremium;

        /// <summary>
        /// cantidad de camarotes turistas comprados en el viaje
        /// </summary>
        private int cantCamTurista;

        /// <summary>
        /// costo de la clase turista del viaje
        /// </summary>
        private float costoTurista;

        /// <summary>
        /// costo de la clase premium del viaje
        /// </summary>
        private float costoPremium;

        /// <summary>
        /// enumerado de regional para determinar si el viaje es regional o no.
        /// </summary>
        private ERegional eRegional;

        /// <summary>
        /// lista de grupos familiares que compraron pasajes a este viaje
        /// </summary>
        private List<GrupoFamiliar> grupoFamiliar;

        /// <summary>
        /// peso total de equipaje entre todos los grupos familiares
        /// </summary>
        private double pesoTotalEquipajes;

        /// <summary>
        /// GETTERS Y SETTERS
        /// </summary>
        public string Origen { get => origen; set => origen = value; }
        public Destino Destino { get => destino; set => destino = value; }
           
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Cruceros Crucero { get => crucero; set => crucero = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int CantCamPremium { get => cantCamPremium; set => cantCamPremium = value; }
        public int CantCamTurista { get => cantCamTurista; set => cantCamTurista = value; }
        public float CostoTurista { get => costoTurista; set => costoTurista = value; }
        public float CostoPremium { get => costoPremium; set => costoPremium = value; }
        public ERegional ERegional { get => eRegional; set => eRegional = value; }
        public double PesoTotalEquipajes { get => pesoTotalEquipajes; set => pesoTotalEquipajes = value; }
        public int Id { get => id; set => id = value; }
        public List<GrupoFamiliar> GrupoFamiliar { get => grupoFamiliar; set => grupoFamiliar = value; }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Viajes()
        {

            this.origen = "";
            this.destino = new Destino("Sin destino", "Sin pais", ERegional.No);
            this.fecha = new DateTime(01, 01, 01, 00, 00, 00);
            this.crucero = new Cruceros();
            this.duracion = 0;
            this.cantCamTurista = 0;
            this.cantCamPremium = 0;
            this.costoTurista = 0;
            this.costoPremium = 0;
            this.eRegional = ERegional.Si;
            this.grupoFamiliar = new List<GrupoFamiliar>();
            this.pesoTotalEquipajes = 0;
            
        }

        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="fecha"></param>
        /// <param name="crucero"></param>
        /// <param name="duracion"></param>
        /// <param name="cantCamTurista"></param>
        /// <param name="cantCamPremium"></param>
        /// <param name="costoTurista"></param>
        /// <param name="eRegional"></param>
        /// <param name="grupoFamiliar"></param>
        /// <param name="pesoTotalEquipajes"></param>
        public Viajes(int id, string origen, Destino destino, DateTime fecha, Cruceros crucero, int duracion,
        int cantCamTurista, int cantCamPremium, float costoTurista, ERegional eRegional, List<GrupoFamiliar> grupoFamiliar, double pesoTotalEquipajes = 0) : this()
        {
            this.id = id;
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
            this.crucero = crucero;
            this.duracion = duracion;
            this.cantCamPremium = cantCamPremium;
            this.cantCamTurista = cantCamTurista;
          
            this.costoTurista = costoTurista * duracion;
            this.costoPremium = (this.costoTurista * 100 / 20) + (costoTurista * duracion);
          
            this.eRegional = eRegional;
            this.grupoFamiliar = grupoFamiliar;
            this.pesoTotalEquipajes = pesoTotalEquipajes;

        }

        /// <summary>
        /// calculo para determinar el costo premium total recibiendo el costo total turista
        /// </summary>
        /// <param name="costoTurista"></param>
        /// <returns></returns>
        public static float DeterminarCostoPremiumTotal(float costoTurista)
        {
            float resultado;
            float aumentoPremium;

            aumentoPremium = (costoTurista * 20) / 100;
            resultado = costoTurista + aumentoPremium;

            return resultado;
        }

        /// <summary>
        /// calculo para determinar el total turista en viajes REGIONALES recibiendo la duracion del viaje en horas
        /// </summary>
        /// <param name="duracion"></param>
        /// <returns></returns>
        public static float DeterminarCostoTuristaTotalR(int duracion)
        {
            float resultado;

            resultado = 57 * duracion;

            return resultado;
        }


        /// <summary>
        /// determina el total turista en viajes EXTRA REGIONALES recibiendo la duracion del viaje en horas
        /// </summary>
        /// <param name="duracion"></param>
        /// <returns></returns>
        public static float DeterminarCostoTuristaTotalER(int duracion)
        {
            float resultado;

            resultado = 120 * duracion;

            return resultado;
        }


        /// <summary>
        /// determina la duracion de el viaje regional aleatoriamente dentro del rango pedido
        /// </summary>
        /// <returns></returns>
        public static int DeterminarDuracionRegional()
        {
            Random random = new Random();

            int duracion = random.Next(72, 360);

            return duracion;
        }

        /// <summary>
        /// determina la duracion de el viaje extra regional aleatoriamente dentro del rango pedido
        /// </summary>
        /// <returns></returns>
        public static int DeterminarDuracionExtraRegional()
        {
            Random random = new Random();

            int duracion = random.Next(480, 720);

            return duracion;
        }

        
        /// <summary>
        /// devuelve el array de strings para mostrar en la grilla un viaje
        /// </summary>
        /// <returns></returns>
        public string[] MostrarViajeEnGrilla()
        {
            float costoTurista;
            float costoPremium;

            if(this.eRegional == ERegional.Si)
            {
                costoTurista = DeterminarCostoTuristaTotalR(this.duracion);
            }
            else
            {
                costoTurista = DeterminarCostoTuristaTotalER(this.duracion);
            }
            costoPremium = DeterminarCostoPremiumTotal(costoTurista);

            string[] row = { this.origen, 
            this.destino.ToString(), 
            this.fecha.ToString(),
            this.crucero.nombre, 
            (this.crucero.cantCamTurista - this.cantCamTurista).ToString(),
            (this.crucero.cantCamPremium - this.cantCamPremium).ToString(),
            costoTurista.ToString(), costoPremium.ToString(),
            this.duracion.ToString() + "Hs",
            (this.crucero.capBodega - this.pesoTotalEquipajes).ToString() + "Kg", this.id.ToString()};

            return row;
        }

        /// <summary>
        /// override metodo equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

      
        /// <summary>
        /// override metodo gethashcode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
