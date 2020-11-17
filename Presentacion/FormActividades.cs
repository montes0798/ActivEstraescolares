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
    public partial class FormActividades : Form
    {
        ModeloActividad actividadModelo = new ModeloActividad();
        string operacion = "Insertar";

        public FormActividades()
        {
            InitializeComponent();
        }

        private void FormActividades_Load(object sender, EventArgs e)
        {
            MostrarTablaActividad();
        }

        private void MostrarTablaActividad()
        {
            ModeloActividad actividadModeloMostrar = new ModeloActividad();
            DGVActividad.DataSource = actividadModeloMostrar.MostrarActividad();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PanelDatos.Enabled = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DGVActividad.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                PanelDatos.Enabled = true;
                TxtId.Text = DGVActividad.CurrentRow.Cells[0].Value.ToString();
                TxtId.Enabled = false;
                TxtNombre.Text = DGVActividad.CurrentRow.Cells[1].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione el registro a editar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "Insertar")
            {
                try
                {
                    actividadModelo.InsertarActividad(Convert.ToInt32(TxtId.Text), TxtNombre.Text);
                    MessageBox.Show("Registro exitoso");                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El registro no se llevo a cabo \n" + ex);
                }
            }
            else if (operacion == "Modificar")
            {
                try
                {
                    actividadModelo.InsertarActividad(Convert.ToInt32(TxtId.Text), TxtNombre.Text);
                    MessageBox.Show("Registro exitoso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al modificar\n" + ex);
                }
            }
            PanelDatos.Enabled = false;
            MostrarTablaActividad();
            Reset();
        }

        public void Reset()
        {
            TxtId.Clear();
            TxtNombre.Clear();
        }
    }
}
