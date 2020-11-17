using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Transversal.Cache;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        //Variables necesarias para cambiar de color los botones
        private IconButton currentBtn;

        //Variable para guardar el formulario que se ve actualmente
        private Form formHijoActual;

        //Variables necesarias para mover el panel por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormPrincipal()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        private void ActivarBoton(object senderBtn)
        {
            if (senderBtn != null)
            {
                //Se llama al metodo de boton inactivo para cambiar los valores
                BotonInactivo();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.FromArgb(91, 25, 27);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; //se alinea el texto hacia el centro
                currentBtn.IconColor = Color.FromArgb(91, 25, 27);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; //se cambia la relacion a texto antes que imagen
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; //se alinea el icono hacia la derecha
            }
        }

        //Reestablece los valores como estaban
        private void BotonInactivo()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(91, 25, 27);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleRight; //se alinea el texto hacia la derecha
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.Overlay; //se cambia la relacion a imagen antes que texto
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; //se alinea el icono hacia la izquierda
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            if (CacheInicioSesion.tipoUsuario == Puestos.Secretaria)
            {
                BtnAgregarUsuario.Enabled = false;
                BtnActividad.Enabled = false;
                BtnGrupo.Enabled = false;
            }
            if (CacheInicioSesion.tipoUsuario == Puestos.Instructor)
            {
                BtnAgregarUsuario.Enabled = false;
                BtnActividad.Enabled = false;
                BtnConstancias.Enabled = false;
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new FormUsuarios());
        }

        private void BtnActividad_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormHijo(new FormActividades());
        }

        private void BtnGrupo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
        }

        private void BtnListas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
        }

        private void BtnConstancias_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
            else
                Reset();
        }

        private void iconInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            BotonInactivo();
            PanelPrincipal.BringToFront();
            if (formHijoActual != null)
                formHijoActual.Close();
            else
                PanelPrincipal.Show();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //Metodo para mostrar los demas formularios
        private void AbrirFormHijo(Form formHijo)
        {
            if (formHijoActual != null)
            {
                //Esto es para abrir solo un formulario a la vez
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.Size = PanelPrincipal.Size;
            formHijo.Anchor = AnchorStyles.Top;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(formHijo);
            PanelPrincipal.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTamaño_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                BtnTamaño.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                BtnTamaño.IconChar = IconChar.WindowMaximize;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CargarDatosUsuario()
        {
            LblNombre.Text = CacheInicioSesion.name;
            LblApellido.Text = CacheInicioSesion.apellidoPat + " " + CacheInicioSesion.apellidoMat;
            if (CacheInicioSesion.tipoUsuario == 1)
            {
                LblPuesto.Text = "Administrador";
            }
            if (CacheInicioSesion.tipoUsuario == 2)
            {
                LblPuesto.Text = "Secretaria";
            }
            if (CacheInicioSesion.tipoUsuario == 3)
            {
                LblPuesto.Text = "Instructor";
            }
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
