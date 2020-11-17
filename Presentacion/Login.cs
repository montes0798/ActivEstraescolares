using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;

namespace Presentacion
{
    public partial class Login : Form
    {
        //Variables necesarias para mover por pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //Funcionalidad boton cerrar
        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Funcionalidad boton minimizar
        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Placeholder Usuario
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.DimGray;
            }
        }

        //Placeholder contraseña
        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "CONTRASEÑA")
            {
                TxtContrasena.Text = "";
                TxtContrasena.ForeColor = Color.Black;
                TxtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "CONTRASEÑA";
                TxtContrasena.ForeColor = Color.DimGray;
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }

        //Metodo para moverpor pantalla
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //Boton acceder y conexion a base de datos
        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "USUARIO")
            {
                if(TxtContrasena.Text != "CONTRASEÑA")
                {
                    //Instancia del modelo usuario de la capa de dominio
                    ModeloUsuario usuario = new ModeloUsuario();
                    //Variable para el retorno de los datos de usuario
                    var validarLogin = usuario.LoginUsuario(TxtUsuario.Text, TxtContrasena.Text);
                    if (validarLogin == true)
                    {
                        FormPrincipal menu = new FormPrincipal();
                        menu.Show();
                        menu.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MensajeError("Nombre de usuario y/o contraseña incorrecto");
                    }
                }
                else
                {
                    MensajeError("Ingrese la contraseña");
                }
            }
            else
            {
                MensajeError("Ingrese el nombre de usuario");
            }
        }

        private void MensajeError(string msg)
        {
            LblAviso.Text = msg;
            LblAviso.Visible = true;
            iconoAviso.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            TxtUsuario.Text = "USUARIO";
            TxtUsuario.ForeColor = Color.DimGray;
            TxtContrasena.Text = "CONTRASEÑA";
            TxtContrasena.ForeColor = Color.DimGray;
            TxtContrasena.UseSystemPasswordChar = false;
            LblAviso.Visible = false;
            iconoAviso.Visible = false;
            this.Show();
        }

        private void LnkContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperar = new RecuperarContrasena();
            recuperar.Show();
        }

        private void ChckContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckContrasena.Checked==true && TxtContrasena.Text == "CONTRASEÑA")
            {
                TxtContrasena.ForeColor = Color.DimGray;
                TxtContrasena.UseSystemPasswordChar = false;
            }
            else if(ChckContrasena.Checked == true && TxtContrasena.Text != "CONTRASEÑA")
                TxtContrasena.UseSystemPasswordChar = false;
            else if(ChckContrasena.Checked == false && TxtContrasena.Text != "CONTRASEÑA")
                TxtContrasena.UseSystemPasswordChar = true;

        }
    }
}
