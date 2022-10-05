using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class Cruceros
    {
        public string matricula;/// <summary>
        /// matricula del crucero
        /// </summary>
        public string nombre;/// <summary>
        /// nombre del crucero
        /// </summary>
        public int cantCamarotes;/// <summary>
        /// cantidad de camarotes que existen en el crucero
        /// </summary>
        public int cantCamPremium;/// <summary>
        /// cantidad de camarotes premium que existen en el crucero
        /// </summary>
        public int cantCamTurista;/// <summary>
        /// cantidad de camarotes turistas que existen en el crucero
        /// </summary>
        public int capBodega;/// <summary>
        /// capacidad de la bodega del crucero en kilogramos
        /// </summary>
        public List<Salones> listaSalones;/// <summary>
        /// lista descriptiva de salones disponibles en el crucero
        /// </summary>

        
        public Cruceros()
        {
            this.matricula = "00000000";
            this.nombre = "Sin Crucero";
            this.cantCamarotes = 0;
            this.cantCamPremium = 0;
            this.cantCamTurista = 0;
            this.capBodega = 0;
        }/// <summary>
        /// constructor por defecto de cruceros
        /// </summary>
        /// <returns></returns>

        public static List<Cruceros> ObtenerCruceros()
        {
            List<Cruceros> cruceros = new List<Cruceros>()
            {
                new Cruceros(){ matricula = "B1520135", nombre="Hinata", cantCamarotes=200, cantCamPremium=70, cantCamTurista=130, capBodega=1000, 
                listaSalones = new List<Salones>(){new Sal_Comedor(18,1), new Sal_CanchaDeVoley(18, 9, 2), new Sal_Casino(6, 30, 1), new Sal_Piscina(2, 4, 3,3)}},

                new Cruceros(){ matricula = "C165AR54", nombre="Kageyama", cantCamarotes=400, cantCamPremium=140, cantCamTurista=260, capBodega=1500, 
                    listaSalones = new List<Salones>(){new Sal_Comedor(47, 1), new Sal_Casino(2, 15, 3), new Sal_Piscina(3, 5, 4,1),  new Sal_Piscina(2.5, 3.5, 2,1)}},

                new Cruceros(){ matricula = "MT44799H", nombre="Daichi", cantCamarotes=300, cantCamPremium=105, cantCamTurista=195, capBodega=1100, 
                    listaSalones = new List<Salones>(){new Sal_Comedor(40, 1), new Sal_CanchaDeVoley(18, 9, 1), new Sal_Casino(0, 40, 1), new Sal_Casino(4, 20, 1), new Sal_Piscina(2.7, 3.60, 4.20,2)}},

                new Cruceros(){ matricula = "L7TIQ6XB", nombre="Nishinoya", cantCamarotes=360, cantCamPremium=126, cantCamTurista=234, capBodega=1200, 
                    listaSalones = new List<Salones>(){new Sal_Comedor(45, 1), new Sal_Casino(3, 30, 1), new Sal_Piscina(2, 4, 3,3), new Sal_Cafeteria(new TimeSpan(6,00,00), new TimeSpan(21,00,00), 2)}},

                new Cruceros(){ matricula = "BA100018", nombre="Tanaka", cantCamarotes=420, cantCamPremium=147, cantCamTurista=273, capBodega=1300, 
                    listaSalones = new List<Salones>(){new Sal_Comedor(70, 1), new Sal_CanchaDeVoley(18, 9, 2), new Sal_Casino(7, 50, 1), new Sal_Piscina(3.5, 5, 6,1), new Sal_Cafeteria(new TimeSpan(7,00,00), new TimeSpan(22,30,00), 2)}},

                new Cruceros(){ matricula = "ED121AA7", nombre="Tsukishima", cantCamarotes=500, cantCamPremium=175, cantCamTurista=425, capBodega=1200, 
                    listaSalones = new List<Salones>(){new Sal_Comedor(63, 1), new Sal_Casino(6, 30, 1), new Sal_Piscina(2, 4, 3,3)}},

                new Cruceros(){ matricula = "PW444WKS", nombre="Yamaguchi", cantCamarotes=260, cantCamPremium=91, cantCamTurista=169, capBodega=1500, 
                    listaSalones = new List<Salones>(){new Sal_Comedor(25, 1), new Sal_CanchaDeVoley(18, 9, 1), new Sal_Casino(4, 25, 2), new Sal_Piscina(2, 4, 3,4)}}
            };

            return cruceros;
        }/// <summary>
        /// lista de cruceros hardcodeada
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return base.ToString();
        }/// <summary>
        /// override de tostring
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>

        public static bool operator ==(Cruceros c1, Cruceros c2)
        {
            return (c1.nombre == c2.nombre);
        }/// <summary>
        /// operador igual-igual para determinar que dos obj de tipo crucero son iguales si comparten un mismo nombre
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>

        public static bool operator !=(Cruceros c1, Cruceros c2)
        {
            return !(c1.nombre == c2.nombre);
        }/// <summary>
        /// operador distinto, inverso al igual-igual, requerido por el compilador
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }/// <summary>
        /// override de metodo equals
        /// </summary>
        /// <returns></returns>

        public override int GetHashCode()///override gethashcode
        {
            return base.GetHashCode();
        }
    }
}
