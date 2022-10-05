using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Sal_Comedor : Salones
    {
        protected int mesas;
        protected int personas;

        public Sal_Comedor(int mesas, int cantidad) : base(cantidad)
        {
            this.mesas = mesas;
            this.personas = mesas * 4;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Comedores 24/7 que cuentan con {this.mesas} mesas con un total de capacidad para {this.personas} personas: {base.Mostrar()}");

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
