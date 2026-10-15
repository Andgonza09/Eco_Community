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


//TRABAJAR EL DATAGRIED VIEW
namespace View
{
    public partial class frmUsuariosRegistrados : Form
    {
        public frmUsuariosRegistrados()
        {
            InitializeComponent();

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
            txtNameUsuario.Text = fila.Cells[colNombreUsuario.Index].Value?.ToString() ?? "";
            txtContrasena.Text = fila.Cells[colContrasena.Index].Value?.ToString() ?? "";
            txtCorreo.Text = fila.Cells[colCorreo.Index].Value?.ToString() ?? "";
            comboBox1.Text = fila.Cells[colRol.Index].Value?.ToString() ?? "";
        }

        public void RefreshTable()
        {
            //CargarUsuarios();
            ListarUsuarios();
        }
        private void frmUsuarioRegistrados_shown(object? sender, EventArgs e)
        {
            //CargarUsuarios();
            ListarUsuarios();
        }
        private void ConfigurarColumnas()
        {
            colIdUsuario.DataPropertyName = "id_Usuario";
            colNombreUsuario.DataPropertyName = "nombre_Usuario";
            colContrasena.DataPropertyName = "contraseña_Usuario";
            colCorreo.DataPropertyName = "correo_Usuario";
            colFechaRegistro.DataPropertyName = "fecha_Registro";
            colRol.DataPropertyName = "tipo_Roles";

            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void ListarUsuarios()
        {
            try
            {
                ConfigurarColumnas();

                UsuarioController controller = new UsuarioController();

                dgvUsuarios.DataSource = controller.ListarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarUsuarios()
        {
            // Guardar el ID del usuario seleccionado
            long idAnterior = id_UsuarioSeleccionado;

            UsuarioController controller = new UsuarioController();
            dgvUsuarios.DataSource = controller.ListarUsuarios();

            // Buscar nuevamente al usuario seleccionado
            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                long id = Convert.ToInt64(
                    fila.Cells[colIdUsuario.Index].Value);

                if (id == idAnterior)
                {
                    // Mantener la fila actual
                    dgvUsuarios.CurrentCell =
                        fila.Cells[colNombreUsuario.Index];

                    dgvUsuarios.ClearSelection();
                    fila.Selected = true;

                    // Conservar el ID
                    id_UsuarioSeleccionado = idAnterior;

                    break;
                }
            }
        }

        private void BuscarUsuario()
        {
            try
            {
                if (!long.TryParse(txtSearchId.Text.Trim(), out long idUsuario))
                {
                    return;
                }

                UsuarioController controller = new UsuarioController();

                dgvUsuarios.AutoGenerateColumns = false;

                dgvUsuarios.DataSource = controller.BuscarUsuarioById(idUsuario);


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el usuario: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                ListarUsuarios();
            }
            BuscarUsuario();

            if (!long.TryParse(txtSearchId.Text, out long id_Usuario))
            {
                return;
            }

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
                //fecha_Registro = (DateOnly)fila.Cells[colFechaRegistro.Index].Value
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


        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            else
            {
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
            try
            {

                //Obtener el ID del usuario seleccionado
                long idUsuario = Convert.ToInt64(dgvUsuarios.CurrentRow.Cells["colIdUsuario"].Value);

                string username = txtNameUsuario.Text;
                string password = txtContrasena.Text;
                string email = txtCorreo.Text.Trim();
                string rol = comboBox1.SelectedItem?.ToString() ?? "";

                int id_Roles;
                if (comboBox1.SelectedItem == null)
                {
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
                    id_Roles = id_Roles
                };

                if (txtNameUsuario.Text.Length < 8)
                {
                    MessageBox.Show("El nombre de usuario tiene que tener un mínimo de 8 caracteres", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtCorreo.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El correo debe de contener la terminación @gmail.com", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioController controller = new UsuarioController();
                bool actualizado = controller.UpdateUser(idUsuario, username, password, email, id_Roles);

                MessageBox.Show("Usuario actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();

                dgvUsuarios.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

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

        private void grpListado_Enter(object sender, EventArgs e)
        {

        }
    }
}
