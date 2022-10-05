using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Sal_Cafeteria : Salones
    {
        /// <summary>
        /// horario de apertura de la cafeteria
        /// </summary>
        protected TimeSpan apertura;
        /// <summary>
        /// horario de cierre de la cafeteria
        /// </summary>
        protected TimeSpan cierre;

        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="apertura"></param>
        /// <param name="cierre"></param>
        /// <param name="cantidad"></param>
        public Sal_Cafeteria(TimeSpan apertura, TimeSpan cierre, int cantidad) : base(cantidad)
        {
            this.apertura = apertura;
            this.cierre = cierre;
        }

        /// <summary>
        /// override de metodo virtual mostrar heredado de la clase padre abstracta salones
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cafeterías que abren a las {this.apertura} y cierran a las {this.cierre}: {base.Mostrar()}");

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
