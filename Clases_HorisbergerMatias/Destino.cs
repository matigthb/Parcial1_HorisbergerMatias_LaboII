using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Destino
    {
        public string ciudad;/// <summary>
        /// ciudad del destino
        /// </summary>
        public string pais;/// <summary>
        /// pais del destino
        /// </summary>
        public ERegional eRegional;/// <summary>
        /// enumerado de si es regional o no el destino. unicas opciones= ERegional.Si / ERegional.No
        /// </summary>
        /// <param name="ciudad"></param>
        /// <param name="pais"></param>
        /// <param name="eRegional"></param>

        public Destino(string ciudad, string pais, ERegional eRegional)
        {
            this.ciudad = ciudad;
            this.pais = pais;
            this.eRegional = eRegional;
        }/// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <returns></returns>

        public static List<Destino> ObtenerDestinos()
        {
            List<Destino> destinos = new List<Destino>()
            {
                new Destino("Acapulco", "México", ERegional.No),//0
                new Destino("Atenas", "Grecia", ERegional.No),//1
                new Destino("Bangkok", "Tailandia", ERegional.No),//2
                new Destino("Cartagena", "Colombia", ERegional.Si),//3
                new Destino("Isla de Pascua", "Chile", ERegional.Si),//4
                new Destino("Isla Galápagos", "Ecuador", ERegional.Si),//5
                new Destino("La Habana", "Cuba", ERegional.No),//6
                new Destino("Lima", "Perú", ERegional.Si),//7
                new Destino("Montevideo", "Uruguay", ERegional.Si),//8
                new Destino("Miami", "EE.UU.", ERegional.No),//9
                new Destino("Nueva York", "EE.UU.", ERegional.No),//10
                new Destino("Puerto Madryn" ,"Argentina", ERegional.Si),//11
                new Destino("Recife", "Brasil", ERegional.Si),//12
                new Destino("Río de Janeiro", "Brasil", ERegional.Si),//13
                new Destino("Santiago", "Chile", ERegional.Si),//14
                new Destino("Taipei", "Taiwán", ERegional.No),//15
                new Destino("Ushuaia", "Argentina", ERegional.Si),//16
                new Destino("Venecia", "Italia", ERegional.No)//17
            };

            return destinos;
        }/// <summary>
        /// lista hardcodeada de destinos
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>


        public static bool operator ==(Destino d1, Destino d2)
        {
            return ((d1.ciudad == d2.ciudad) && (d1.pais == d2.pais));
        }/// <summary>
        /// operador igual-igual que determina que dos objetos de tipo destino son iguales si comparten ciudad y pais
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>

        public static bool operator !=(Destino d1, Destino d2)
        {
            return !((d1.ciudad == d2.ciudad) && (d1.pais == d2.pais));
        }/// <summary>
        /// operador distinto, contrario al igual-igual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.ciudad} ({this.pais})");
            
            return sb.ToString();
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
