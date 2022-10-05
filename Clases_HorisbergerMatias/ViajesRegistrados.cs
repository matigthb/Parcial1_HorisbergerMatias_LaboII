using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_HorisbergerMatias
{
    public class ViajesRegistrados
    {
        /// <summary>
        /// lista de cruceros
        /// </summary>
        private static List<Cruceros> cruceros = Cruceros.ObtenerCruceros();

        /// <summary>
        /// lista de destinos
        /// </summary>
        private static List<Destino> destinos = Destino.ObtenerDestinos();

        /// <summary>
        /// hardcodeo de lista de pasajeros para un viaje
        /// </summary>
        public static List<Pasajero> pasajeros = new List<Pasajero>()
        {
            new Pasajero("Juan", "Perez", 18, new Pasaporte(45228119, "Masculino", new DateTime(2003,11,14), "Argentino", "Bs. As.", "ARG", new DateTime (2018,5,12),  new DateTime (2024,5,12), "AAF030299"), EClase.Premium, true, 9, 10.5, 16),
            new Pasajero("Martin", "Palermo", 30, new Pasaporte(45228119, "Masculino", new DateTime(1992,10,12), "Chileno", "Santiago", "Chile", new DateTime (2022,6,02),  new DateTime (2028,6,02), "AAF654456"), EClase.Turista, false, 0, 14, 13)
        };

        /// <summary>
        /// hardcodeo de lista de pasajeros para otro viaje
        /// </summary>
        public static List<Pasajero> pasajeros2 = new List<Pasajero>()
        {
            new Pasajero("Tomas", "Lopez", 18, new Pasaporte(45228119, "Masculino", new DateTime(2003,11,14), "Argentino", "Bs. As.", "ARG", new DateTime (2018,5,12),  new DateTime (2024,5,12), "AAF030299"), EClase.Premium, true, 9, 10.5, 16),
            new Pasajero("Andres", "Martinez", 30, new Pasaporte(45228119, "Masculino", new DateTime(1992,10,12), "Chileno", "Santiago", "Chile", new DateTime (2022,6,02),  new DateTime (2028,6,02), "AAF654456"), EClase.Premium, false, 0, 14, 13),
            new Pasajero("Andrea", "Martinez", 30, new Pasaporte(45652313, "Femenino", new DateTime(1992,10,12), "Chilena", "Santiago", "Chile", new DateTime (2022,7,02),  new DateTime (2028,7,02), "AAF789546"), EClase.Premium, true, 8, 10, 20)
        };

        /// <summary>
        /// lista de viajes hardcodeada
        /// </summary>
        public List<Viajes> viajes = new List<Viajes>()
        {
            new Viajes() {Id = 1000, Origen= "Buenos Aires (Argentina)", Destino=destinos[9], Fecha=new DateTime(2022, 10, 29, 10, 30, 00), Crucero = cruceros[0], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=102, CantCamPremium=62, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(){ new GrupoFamiliar (pasajeros, 173000)}, PesoTotalEquipajes = 880},
            new Viajes() {Id = 1001, Origen= "Buenos Aires (Argentina)", Destino=destinos[6], Fecha=new DateTime(2022, 11, 3, 4, 00, 00), Crucero = cruceros[1], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=95, CantCamPremium=50, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 650.30},
            new Viajes() {Id = 1002, Origen= "Buenos Aires (Argentina)", Destino=destinos[17], Fecha=new DateTime(2022, 12, 30, 8, 30, 00), Crucero = cruceros[2], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=88, CantCamPremium=33, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 664},
            new Viajes() {Id = 1003, Origen= "Buenos Aires (Argentina)", Destino=destinos[11], Fecha=new DateTime(2022, 11, 14, 9, 30, 00), Crucero = cruceros[3], Duracion = Viajes.DeterminarDuracionRegional(), CantCamTurista=126, CantCamPremium=88, CostoTurista = 57, ERegional = ERegional.Si, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 830},
            new Viajes() {Id = 1004, Origen= "Buenos Aires (Argentina)", Destino=destinos[16], Fecha=new DateTime(2022, 11, 11, 10, 30, 00), Crucero = cruceros[4], Duracion = Viajes.DeterminarDuracionRegional(), CantCamTurista=120, CantCamPremium=90, CostoTurista = 57, ERegional = ERegional.Si, GrupoFamiliar = new List<GrupoFamiliar>(){ new GrupoFamiliar (pasajeros2, 227000)}, PesoTotalEquipajes = 900},
            new Viajes() {Id = 1005, Origen= "Buenos Aires (Argentina)", Destino=destinos[14], Fecha=new DateTime(2022, 11, 11, 10, 30, 00), Crucero = cruceros[6], Duracion = Viajes.DeterminarDuracionRegional(), CantCamTurista=93, CantCamPremium=90, CostoTurista = 57, ERegional = ERegional.Si, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 736.55},
            new Viajes() {Id = 1006, Origen= "Buenos Aires (Argentina)", Destino=destinos[13], Fecha=new DateTime(2022, 11, 11, 10, 30, 00), Crucero = cruceros[2], Duracion = Viajes.DeterminarDuracionRegional(), CantCamTurista=75, CantCamPremium=90, CostoTurista = 57, ERegional = ERegional.Si, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 977.33},
            new Viajes() {Id = 1007, Origen= "Buenos Aires (Argentina)", Destino=destinos[10], Fecha=new DateTime(2022, 10, 23, 6, 30, 00), Crucero = cruceros[5], Duracion =Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=110, CantCamPremium=43, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 770},
            new Viajes() {Id = 1008, Origen= "Buenos Aires (Argentina)", Destino=destinos[15], Fecha=new DateTime(2022, 10, 23, 6, 30, 00), Crucero = cruceros[1], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=90, CantCamPremium=43, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 888.11},
            new Viajes() {Id = 1009, Origen= "Buenos Aires (Argentina)", Destino=destinos[1], Fecha=new DateTime(2022, 12, 20, 6, 30, 00), Crucero = cruceros[0], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=86, CantCamPremium=51, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 725.92},
            new Viajes() {Id = 1010, Origen= "Buenos Aires (Argentina)", Destino=destinos[2], Fecha=new DateTime(2022, 12, 30, 6, 30, 00), Crucero = cruceros[3], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=108, CantCamPremium=70, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 804.41},
            new Viajes() {Id = 1011, Origen= "Buenos Aires (Argentina)", Destino=destinos[0], Fecha=new DateTime(2023, 1, 3, 6, 30, 00), Crucero = cruceros[6], Duracion = Viajes.DeterminarDuracionExtraRegional(), CantCamTurista=125, CantCamPremium=55, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 789.31},
            new Viajes() {Id = 1012, Origen= "Buenos Aires (Argentina)", Destino=destinos[17], Fecha=new DateTime(2022, 9, 12, 9, 30, 00), Crucero = cruceros[4], Duracion = Viajes.DeterminarDuracionExtraRegional(),  CantCamTurista=38, CantCamPremium=16, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 820.61},
            new Viajes() {Id = 1013, Origen= "Buenos Aires (Argentina)", Destino=destinos[1], Fecha=new DateTime(2022, 8, 6, 9, 30, 00), Crucero = cruceros[3], Duracion = Viajes.DeterminarDuracionExtraRegional(),  CantCamTurista=38, CantCamPremium=16, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 802.15},
            new Viajes() {Id = 1014, Origen= "Buenos Aires (Argentina)", Destino=destinos[10], Fecha=new DateTime(2022, 8, 29, 9, 30, 00), Crucero = cruceros[5], Duracion = Viajes.DeterminarDuracionExtraRegional(),  CantCamTurista=38, CantCamPremium=16, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 963.44},
            new Viajes() {Id = 1015, Origen= "Buenos Aires (Argentina)", Destino=destinos[0], Fecha=new DateTime(2022, 7, 22, 9, 30, 00), Crucero = cruceros[0], Duracion = Viajes.DeterminarDuracionExtraRegional(),  CantCamTurista=38, CantCamPremium=16, CostoTurista = 120, ERegional = ERegional.No, GrupoFamiliar = new List<GrupoFamiliar>(), PesoTotalEquipajes = 798}
        };

        /// <summary>
        /// override metodo tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
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
