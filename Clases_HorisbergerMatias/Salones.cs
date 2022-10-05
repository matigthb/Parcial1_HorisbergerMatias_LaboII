using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public abstract class Salones
    {
        /// <summary>
        /// cantidad de salones
        /// </summary>
        protected int cantidad;

        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="cantidad"></param>
        public Salones(int cantidad)
        {
            this.cantidad = cantidad;
        }

        
        /*public static Salones operator +(Salones salon, int cantidad)
        {
            salon.cantidad = cantidad;

            return salon;
        }*/

        /// <summary>
        /// metodo virtual mostrar
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.cantidad}");

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
