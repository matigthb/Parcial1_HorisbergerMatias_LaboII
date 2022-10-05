using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Pasajero
    {

        private string nombre;/// <summary>
        /// nombre del pasajero
        /// </summary>
        private string apellido;/// <summary>
        /// apellido del pasajero
        /// </summary>
        private int edad;/// <summary>
        /// edad del pasajero 
        /// </summary>
        public Pasaporte pasaporte;/// <summary>
        /// variable tipo pasaporte que incluye los datos del pasaporte de un pasajero
        /// </summary>
        private EClase clase;/// <summary>
                             /// enumerado de clase para determinar si se trata de pasajero premium o turista
                             /// </summary>
        private bool bolsoDeMano;/// <summary>
        /// variable booleana, true siempre que el pasajero lleve bolso de mano, false si no lo lleva.
        /// </summary>
        private double pesoBolsoDeMano;/// <summary>
        /// el peso del bolso de mano del pasajero, tipo double
        /// </summary>
        private double valija1;/// <summary>
        /// peso de la valija1 del pasajero
        /// </summary>
        private double valija2;/// <summary>
        /// peso de la valija 2
        /// </summary>


        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="pasaporte"></param>
        /// <param name="clase"></param>
        /// <param name="bolsoDeMano"></param>
        /// <param name="pesoBolsoDeMano"></param>
        /// <param name="valija1"></param>
        /// <param name="valija2"></param>
        public Pasajero(string nombre, string apellido, int edad, Pasaporte pasaporte, EClase clase, bool bolsoDeMano, double pesoBolsoDeMano, double valija1, double valija2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.pasaporte = pasaporte;
            this.clase = clase;
            this.bolsoDeMano = bolsoDeMano;
            this.pesoBolsoDeMano = pesoBolsoDeMano;
            this.valija1 = valija1;
            this.valija2 = valija2;
        }

        /// <summary>
        /// override metodo tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} {this.apellido}, DNI:{this.pasaporte.Dni}, Edad: {this.edad}");
            return sb.ToString();
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
