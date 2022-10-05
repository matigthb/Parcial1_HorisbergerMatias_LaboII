using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class GrupoFamiliar
    {
        public List<Pasajero> pasajeros;/// <summary>
        /// lista de pasajeros dentro de un grupo familiar
        /// </summary>
        public double precioNetoAPagar;/// <summary>
        /// precio neto total a pagar en conjunto del grupo familiar
        /// </summary>

        public GrupoFamiliar()
        {
            this.pasajeros = new List<Pasajero>();
            this.precioNetoAPagar = 0;
        }/// <summary>
        /// constructor por defecto
        /// </summary>
        /// <param name="pasajeros"></param>
        /// <param name="precioNetoAPagar"></param>

        public GrupoFamiliar(List<Pasajero> pasajeros, double precioNetoAPagar)
        {
            this.pasajeros = pasajeros;
            this.precioNetoAPagar = precioNetoAPagar;
        }/// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return base.ToString();
        }/// <summary>
        /// override metodo tostring
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }/// <summary>
        /// override metodo equals
        /// </summary>
        /// <returns></returns>

        public override int GetHashCode()///override gethashcode
        {
            return base.GetHashCode();
        }
    }
}
