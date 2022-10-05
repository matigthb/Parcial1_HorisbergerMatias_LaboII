using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Sal_Casino : Salones
    {
        protected int ruletas;
        protected int maquinas;
        public Sal_Casino(int ruletas, int maquinas, int cantidad) : base(cantidad)
        {
            this.ruletas = ruletas;
            this.maquinas = maquinas;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Casino con {this.ruletas} ruletas y {this.maquinas} maquinas: {base.Mostrar()}");

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
