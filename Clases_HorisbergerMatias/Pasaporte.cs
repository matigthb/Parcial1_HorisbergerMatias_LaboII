using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Pasaporte
    {
        /// <summary>
        /// numero de pasaporte
        /// </summary>
        private string numeroPasaporte;

        /// <summary>
        /// dni del pasajero
        /// </summary>
        private int dni;

        /// <summary>
        /// sexo del pasajero
        /// </summary>
        private string sexo;

        /// <summary>
        /// fecha de nacimiento del pasajero
        /// </summary>
        private DateTime fechaNacimiento;

        /// <summary>
        /// nacionalidad del pasajero
        /// </summary>
        private string nacionalidad;
        
        /// <summary>
        /// provincia de nacimiento del pasajero
        /// </summary>
        private string provinciaNacimiento;

        /// <summary>
        /// codigo de pais de nacimiento del pasajero
        /// </summary>
        private string codigoPaisNacimiento;

        /// <summary>
        /// fecha de expedicion de pasaporte
        /// </summary>
        private DateTime fechaExpedicion;

        /// <summary>
        /// fecha de caducidad del pasaporte
        /// </summary>
        private DateTime fechaCaducidad;

        /// <summary>
        /// GETTERS Y SETTERS
        /// </summary>
        public string NumeroPasaporte { get => numeroPasaporte; set => numeroPasaporte = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string ProvinciaNacimiento { get => provinciaNacimiento; set => provinciaNacimiento = value; }
        public string CodigoPaisNacimiento { get => codigoPaisNacimiento; set => codigoPaisNacimiento = value; }
        public DateTime FechaExpedicion { get => fechaExpedicion; set => fechaExpedicion = value; }
        public DateTime FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }

        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="provinciaNacimiento"></param>
        /// <param name="codigoPaisNacimiento"></param>
        /// <param name="fechaExpedicion"></param>
        /// <param name="fechaCaducidad"></param>
        /// <param name="numeroPasaporte"></param>
        public Pasaporte(int dni, string sexo, DateTime fechaNacimiento, string nacionalidad, string provinciaNacimiento, string codigoPaisNacimiento, DateTime fechaExpedicion, DateTime fechaCaducidad, string numeroPasaporte)
        {
            this.dni = dni;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;
            this.provinciaNacimiento = provinciaNacimiento;
            this.codigoPaisNacimiento = codigoPaisNacimiento;
            this.fechaExpedicion = fechaExpedicion;
            this.fechaCaducidad = fechaCaducidad;
            this.numeroPasaporte = numeroPasaporte;
        }

        /// <summary>
        /// override metodo tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.dni}\n");
            sb.AppendLine($"Sexo: {this.sexo}\n");
            sb.AppendLine($"Fecha Nacimiento: {this.fechaNacimiento}\n");
            sb.AppendLine($"Nacionalidad: {this.nacionalidad}\n");
            sb.AppendLine($"Provincia de Nacimiento: {this.provinciaNacimiento}\n");
            sb.AppendLine($"Codigo de Pais de Nacimiento: {this.codigoPaisNacimiento}\n");
            sb.AppendLine($"Fecha de expedicion de Pasaporte: {this.fechaExpedicion}\n");
            sb.AppendLine($"Fecha de caducidad de Pasaporte: {this.fechaCaducidad}\n");
            sb.AppendLine($"Numero de Pasaporte: {this.numeroPasaporte}\n");

            return sb.ToString();
        }

        /// <summary>
        /// override del metodo equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// override del metodo gethashcode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
