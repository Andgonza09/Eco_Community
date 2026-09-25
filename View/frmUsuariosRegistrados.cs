using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace View
{
    public partial class frmUsuariosRegistrados : Form
    {
        public frmUsuariosRegistrados()
        {
            InitializeComponent();
            lblRegistros.Text = $"{dgvUsuarios.Rows.Count} usuario(s) registrado(s)";
            this.Shown += frmUsuarioRegistrados_shown;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

        }
        private long id_UsuarioSeleccionado = 0;
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            id_UsuarioSeleccionado = Convert.ToInt64(fila.Cells[colIdUsuario.Index].Value);

            // Evita error al presionar el encabezado
            if (e.RowIndex < 0)
                return;

            // Obtenemos del datagridview y convertirlos a un objeto user
            fila = dgvUsuarios.CurrentRow;

            UsuarioEntidad selectedUser = new UsuarioEntidad()
            {
                id_Usuario = Convert.ToInt64(fila.Cells[colIdUsuario.Index].Value),
                nombre_Usuario = fila.Cells[colNombreUsuario.Index].Value?.ToString() ?? "",
                contraseña_Usuario = fila.Cells[colContrasena.Index].Value?.ToString() ?? "",
                correo_Usuario = fila.Cells[colCorreo.Index].Value?.ToString() ?? "",
                fecha_Registro = (DateOnly)fila.Cells[colFechaRegistro.Index].Value,

            };
            string rol = fila.Cells[colRol.Index].Value?.ToString() ?? "";
            // Llenar los campos
            txtNameUsuario.Text = selectedUser.nombre_Usuario;
            txtContrasena.Text = selectedUser.contraseña_Usuario;
            txtCorreo.Text = selectedUser.correo_Usuario;
            comboBox1.Text = rol;
        }

        public void RefreshTable()
        {
            CargarUsuarios();
        }
        private void frmUsuarioRegistrados_shown(object? sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            UsuarioController controller = new UsuarioController();
            // Si no escribió nada, mostrar todos
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                var datos = controller.ViewAllUsers();
                var datosGridTodos = datos.Select(x => new
                {
                    Id = x.Item1.id_Usuario,
                    Nombre = x.Item1.nombre_Usuario,
                    Contrasena = x.Item1.contraseña_Usuario,
                    Correo = x.Item1.correo_Usuario,
                    FechaRegistro = x.Item1.fecha_Registro,
                    Rol = x.Item1.id_Roles == 1 ? "Administrador" : "Usuario Estándar"
                }).ToList();

                // Vincular columnas del diseñador
                colIdUsuario.DataPropertyName = "Id";
                colNombreUsuario.DataPropertyName = "Nombre";
                colContrasena.DataPropertyName = "Contrasena";
                colCorreo.DataPropertyName = "Correo";
                colFechaRegistro.DataPropertyName = "FechaRegistro";
                colRol.DataPropertyName = "Rol";

                dgvUsuarios.AutoGenerateColumns = false;

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = datosGridTodos;


                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                CargarUsuarios();
            }
            if (dgvUsuarios.CurrentRow == null)
            {
                return;
            }

            // Si escribió algo, validar que sea número
            if (!long.TryParse(txtSearchId.Text, out long id_Usuario))
            {
                return;
            }
            else
            {
                var datos = controller.BuscarUsuarioById(id_Usuario);
                var datosGrid = datos.Select(x => new
                {
                    Id = x.Item1.id_Usuario,
                    Nombre = x.Item1.nombre_Usuario,
                    Contrasena = x.Item1.contraseña_Usuario,
                    Correo = x.Item1.correo_Usuario,
                    FechaRegistro = x.Item1.fecha_Registro,
                    Rol = x.Item1.id_Roles == 1 ? "Administrador" : "Usuario Estándar"
                }).ToList();

                dgvUsuarios.DataSource = null;
                dgvUsuarios.Columns.Clear();
                dgvUsuarios.AutoGenerateColumns = true;
                dgvUsuarios.DataSource = datosGrid;

                dgvUsuarios.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvUsuarios.RowHeadersVisible = false;

                dgvUsuarios.BackgroundColor = Color.White;
                dgvUsuarios.BorderStyle = BorderStyle.None;

                dgvUsuarios.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;

                dgvUsuarios.ColumnHeadersHeight = 38;
                dgvUsuarios.RowTemplate.Height = 34;

                dgvUsuarios.Visible = true;
            }

            // validamos que exista un usuario seleccionado
            if (dgvUsuarios.CurrentRow == null)
            {
                return;
            }
            // Obtenemos del datagridview y convertirlos a un objeto user
            DataGridViewRow fila = dgvUsuarios.CurrentRow;

            UsuarioEntidad selectedUser = new UsuarioEntidad()
            {
                id_Usuario = Convert.ToInt64(fila.Cells[colIdUsuario.Index].Value),
                nombre_Usuario = fila.Cells[colNombreUsuario.Index].Value?.ToString() ?? "",
                contraseña_Usuario = fila.Cells[colContrasena.Index].Value?.ToString() ?? "",
                correo_Usuario = fila.Cells[colCorreo.Index].Value?.ToString() ?? "",
                fecha_Registro = (DateOnly)fila.Cells[colFechaRegistro.Index].Value
            };
        }


        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            txtNameUsuario.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Estás seguro que deseas eliminar el usuario del sistema?",
               "Verificación de información",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question
           );

            if (resultado == DialogResult.OK)
            {
                // Eliminación de usuario
                new UsuarioController().Delete(id_UsuarioSeleccionado);
                MessageBox.Show("Solicitud eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            int id_Roles;

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol.");
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Administrador")
            {
                id_Roles = 1;
            }
            else
            {
                id_Roles = 2;
            }

            UsuarioEntidad usuario = new UsuarioEntidad()
            {
                nombre_Usuario = txtNameUsuario.Text,
                contraseña_Usuario = txtContrasena.Text,
                correo_Usuario = txtCorreo.Text,
                id_Roles = id_Roles
            };
            try
            {

                int Cantidad = controller.UsuarioExiste(txtCorreo.Text, txtNameUsuario.Text);

                if (Cantidad > 0)
                {
                    MessageBox.Show("Usuario ya existente, intenta de nuevo", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    controller.Insert(usuario, id_Roles);
                    MessageBox.Show("Registro exitoso", "Usuario agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error de inserción: " + ex.Message, ex);
            }
        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tlpSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }
        private void frmUsuariosRegistrados_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el usuario del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                // Eliminación de usuario
                new DetalleConsultaArchivoController().Delete(id_UsuarioSeleccionado);
                new DetalleSitiosController().DeleteUserInformation(id_UsuarioSeleccionado);
                new UsuarioController().Delete(id_UsuarioSeleccionado);
                MessageBox.Show("Solicitud eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
                dgvUsuarios.ClearSelection();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            int id_Roles;

            if (comboBox1.SelectedItem == null || txtNameUsuario.Text == "" || txtContrasena.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Completa todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Administrador")
            {
                id_Roles = 1;
            }
            else
            {
                id_Roles = 2;
            }

            UsuarioEntidad usuario = new UsuarioEntidad()
            {
                nombre_Usuario = txtNameUsuario.Text,
                contraseña_Usuario = txtContrasena.Text,
                correo_Usuario = txtCorreo.Text,
                id_Roles = id_Roles
            };
            try
            {

                int Cantidad = controller.UsuarioExiste(txtCorreo.Text, txtNameUsuario.Text);

                if (Cantidad > 0)
                {
                    MessageBox.Show("Usuario ya existente, intenta de nuevo", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    controller.Insert(usuario, id_Roles);
                    MessageBox.Show("Registro exitoso", "Usuario agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                    dgvUsuarios.ClearSelection();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error de inserción: " + ex.Message, ex);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            txtNameUsuario.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            dgvUsuarios.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
