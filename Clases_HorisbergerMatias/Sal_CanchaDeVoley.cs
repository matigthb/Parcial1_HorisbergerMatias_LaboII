using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Sal_CanchaDeVoley : Salones
    {
        protected double largo;
        protected double ancho;

        public Sal_CanchaDeVoley(double largo, double ancho, int cantidad) : base(cantidad)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Canchas de Voley de {this.largo}m x {this.ancho}m: {base.Mostrar()}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
