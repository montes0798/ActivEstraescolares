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
    public partial class FormUsuarios : Form
    {
        ModeloUsuario usuarioDatos = new ModeloUsuario();
        string operacion = "Insertar";

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            MostrarTablaUsuarios();
            ListarGeneros();
            ListarPuestos();
        }

        private void ListarGeneros()
        {
            ComboboxGenero.DataSource = usuarioDatos.ListaGenero();
            ComboboxGenero.DisplayMember = "Genero";
            ComboboxGenero.ValueMember = "IdGenero";
        }

        private void ListarPuestos()
        {
            ComboboxPuesto.DataSource = usuarioDatos.ListaPuesto();
            ComboboxPuesto.DisplayMember = "NombreTipoUsuario";
            ComboboxPuesto.ValueMember = "IdTipoUsuario";
        }

        private void MostrarTablaUsuarios()
        {
            ModeloUsuario usuarioDatosMostrar = new ModeloUsuario();
            DGVUsuarios.DataSource = usuarioDatosMostrar.MostrarUsuarios();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PanelGuardar.Visible = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                PanelGuardar.Visible = true;
                TxtMatricula.Enabled = false;
                TxtMatricula.Text = DGVUsuarios.CurrentRow.Cells[0].Value.ToString();
                TxtUsuario.Text = DGVUsuarios.CurrentRow.Cells[1].Value.ToString();
                TxtNombre.Text = DGVUsuarios.CurrentRow.Cells[2].Value.ToString();
                TxtAPat.Text = DGVUsuarios.CurrentRow.Cells[3].Value.ToString();
                TxtAMat.Text = DGVUsuarios.CurrentRow.Cells[4].Value.ToString();
                ComboboxGenero.Text = DGVUsuarios.CurrentRow.Cells[5].Value.ToString();
                DateNacimiento.Value = Convert.ToDateTime(DGVUsuarios.CurrentRow.Cells[6].Value);
                TxtTel.Text = DGVUsuarios.CurrentRow.Cells[7].Value.ToString();
                TxtEmail.Text = DGVUsuarios.CurrentRow.Cells[8].Value.ToString();
                ComboboxPuesto.Text = DGVUsuarios.CurrentRow.Cells[9].Value.ToString();
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
                    usuarioDatos.InsertarUsuarios(Convert.ToInt32(TxtMatricula.Text), TxtUsuario.Text, TxtContrasena.Text,
                            TxtNombre.Text, TxtAPat.Text, TxtAMat.Text, Convert.ToInt32(ComboboxGenero.SelectedValue),
                            DateNacimiento.Value, TxtTel.Text, TxtEmail.Text, Convert.ToInt32(ComboboxPuesto.SelectedValue));
                    MessageBox.Show("Registro exitoso");
                    PanelGuardar.Visible = false;
                    MostrarTablaUsuarios();
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
                    usuarioDatos.ModificarUsuarios(Convert.ToInt32(TxtMatricula.Text), TxtUsuario.Text, TxtContrasena.Text,
                            TxtNombre.Text, TxtAPat.Text, TxtAMat.Text, Convert.ToInt32(ComboboxGenero.SelectedValue),
                            DateNacimiento.Value, TxtTel.Text, TxtEmail.Text, Convert.ToInt32(ComboboxPuesto.SelectedValue));
                    MessageBox.Show("Modificacion exitosa");
                    PanelGuardar.Visible = false;
                    MostrarTablaUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al modificar\n" + ex);
                }
            }
            Reset();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            PanelGuardar.Visible = false;
            Reset();
        }

        private void ComboboxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Busqueda(DataGridView dgv, string nombre, TextBox textbox)
        {
            DataTable dt = new DataTable();
            dt = DGVUsuarios.DataSource as DataTable;
            DataView vista = new DataView();
            vista = dt.DefaultView;
            string filtro = "CONVERT(" + "[" + nombre + "]" + ", System.String) LIKE '%" + textbox.Text.Trim() + "%'";
            vista.RowFilter = filtro;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Busqueda(DGVUsuarios, ComboboxBuscar.Text, TxtBuscar);
        } 

        public void Reset()
        {
            TxtMatricula.Clear();
            TxtUsuario.Clear();
            TxtNombre.Clear();
            TxtAPat.Clear();
            TxtAMat.Clear();
            ComboboxGenero.SelectedItem = -1;
            DateNacimiento.Text = DateTime.Now.ToString();
            TxtTel.Clear();
            TxtEmail.Clear();
            ComboboxBuscar.SelectedItem = -1;
        }
    }
}
