using System;
using System.Collections;
using System.Collections.Generic;

namespace Clases_HorisbergerMatias
{
    public class Usuario
    {
        /// <summary>
        /// id del usuario
        /// </summary>
        public string usuarioId;

        /// <summary>
        /// password del usuario
        /// </summary>
        public string usuarioPass;

        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="usuarioPass"></param>
        public Usuario(string usuarioId, string usuarioPass)
        {
            this.usuarioId = usuarioId;
            this.usuarioPass = usuarioPass;
        }

        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Usuario()
        {
            this.usuarioId = "";
            this.usuarioPass = "";
        }

        /// <summary>
        /// metodo para obtener la lista de usuarios hardcodeada
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario(){ usuarioId = "matias12", usuarioPass="karasuno"},
                new Usuario(){ usuarioId = "matias23", usuarioPass="karasunoa"},
                new Usuario(){ usuarioId = "1", usuarioPass="1"},
                new Usuario(){ usuarioId = "matias45", usuarioPass="karasunoa"}
                
            };

            return usuarios;
        }

        /// <summary>
        /// operador igual-igual que al comparar un objeto tipo usuario contra una string toma como parametro el ID de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        public static bool operator ==(Usuario usuario, string usuarioId)
        {
            return (usuario.usuarioId == usuarioId);
        }
       
        /// <summary>
        /// operador distinto, contrario al igual-igual, requerido por el compilador
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        public static bool operator !=(Usuario usuario, string usuarioId)
        {
            return !(usuario.usuarioId == usuarioId);
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
