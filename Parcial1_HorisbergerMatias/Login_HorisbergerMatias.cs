using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_HorisbergerMatias;

namespace Parcial1_HorisbergerMatias
{

    public partial class Login_HorisbergerMatias : Form
    { 
        public Login_HorisbergerMatias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// inicio de sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = Usuario.ObtenerUsuarios();
            bool bEncontro = false;

            foreach (Usuario usuario in usuarios)
            {
                if (usuario == txtUsuario.Text)
                {
                    if(usuario.usuarioPass == txtContrasenia.Text)
                    { 
                        Menu_HorisbergerMatias frm = new Menu_HorisbergerMatias();

                        bEncontro = true;
                        frm.usuarioId = "REGISTRADO COMO "+txtUsuario.Text;
                        frm.Show();
                        this.Hide();
                        break;
                    }
                }
            }

            if(bEncontro == false)
            {
                lblError.Visible = true;
            }
        }

        private void Login_HorisbergerMatias_Load(object sender, EventArgs e)
        {
            
        }
    }
}
