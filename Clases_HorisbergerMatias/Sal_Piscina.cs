using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Sal_Piscina : Salones
    {
        protected double profundidad;
        protected double largo;
        protected double ancho;

        public Sal_Piscina(double profundidad, double largo, double ancho, int cantidad) : base(cantidad)
        {
            this.profundidad = profundidad;
            this.largo = largo;
            this.ancho = ancho;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Piscinas de {this.largo}m x {this.ancho}m x {this.profundidad}: {base.Mostrar()}");

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
