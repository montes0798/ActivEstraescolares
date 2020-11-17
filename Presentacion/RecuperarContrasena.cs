using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class RecuperarContrasena : Form
    {
        public RecuperarContrasena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new ModeloUsuario();
            var resultado = usuario.recuperarContrasena(TxtUsuario.Text);
            LblAvisoContrasena.Visible = true;
            LblAvisoContrasena.Text = resultado;
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RecuperarContrasena_Load(object sender, EventArgs e)
        {
            
        }
    }
}
