using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmActualizarInformacionUsuario : Form
    {
        private UsuarioEntidad _currentUser;

        public frmActualizarInformacionUsuario()
        {
            InitializeComponent();
            _currentUser = new UsuarioEntidad();
        }
        public frmActualizarInformacionUsuario(UsuarioEntidad currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void UpdateInformationView_Load(object sender, EventArgs e)
        {
            txtUsername.Text = _currentUser.nombre_Usuario;
            txtEmail.Text = _currentUser.correo_Usuario;
            txtPassword.Text = _currentUser.contraseña_Usuario;
            if (_currentUser.fecha_Registro != DateOnly.MinValue)
            {
                dtpRegisterDate.Value =
                    _currentUser.fecha_Registro.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dtpRegisterDate.Value = DateTime.Today;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == _currentUser.nombre_Usuario && txtEmail.Text == _currentUser.correo_Usuario && txtPassword.Text == _currentUser.contraseña_Usuario && dtpRegisterDate.Value == _currentUser.fecha_Registro.ToDateTime(TimeOnly.MinValue))
            {
                MessageBox.Show("No se han realizado cambios en el perfil.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string newUsername = string.Empty;
                string newPassword = string.Empty;
                string newEmail = string.Empty;
                string newDateOnly = string.Empty;

                // Lógica para actualizar el perfil

                newUsername = txtUsername.Text.Trim();
                newPassword = txtPassword.Text.Trim();
                newEmail = txtEmail.Text.Trim();
                newDateOnly = DateOnly.FromDateTime(dtpRegisterDate.Value).ToString("yyyy-MM-dd");

                if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrEmpty(newEmail))
                {
                    MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newUsername.Length < 8 || newPassword.Length < 8 || (!newEmail.EndsWith("@gmail.com")))
                {
                    MessageBox.Show("El nombre de usuario y la contraseña deben tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var question = MessageBox.Show("¿Estás seguro que deseas cambiar los datos del usuario?", "Gestión de usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (question == DialogResult.OK)
                {
                    MessageBox.Show("Datos actualizados correctamente", "Actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // bool updateInformation = _currentUser.UpdateUser(newUsername, newPassword, newEmail, newDateOnly);
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar actualizar los datos del usuario " + ex.Message);
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
