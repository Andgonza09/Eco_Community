using Microsoft.Data.SqlClient;
using Eco_Community.Model;
using Model.Eco_Community;
using Controller;

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
    public partial class frmLoginUsuario : Form
    {
        private bool showPassword = false;

        /// <summary>
        /// Declaración de variables y objeto con el objetivo de obtener la información del objeto existente en el registro
        /// y compararlo con los datos ingresados.
        /// </summary>
        private string _username;
        private string _password;
        private readonly UsuarioEntidad _currentUser;

        public frmLoginUsuario(UsuarioEntidad currentUser, string username, string password)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this._username = username;
            this._password = password;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegistroUsuario registerform = new frmRegistroUsuario();
            registerform.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResetearContraseña resetPasswordForm = new frmResetearContraseña(_currentUser, this._username, this._password);
            resetPasswordForm.Show();

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar y ocultar la contraseña ingresada
            showPassword = !showPassword;
            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
                pictureBox4.Image = Properties.Resources.PasswordShow;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pictureBox4.Image = Properties.Resources.PasswordHide;

            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            // Cerrar formulario
            this.FormClosing += LoginView_FormClosing;
        }
        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evento de cierre
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Inicializamos el objeto user con los valores del formulario 
            UsuarioEntidad userLogin = new UsuarioEntidad()
            {
                correo_Usuario = txtEmail.Text,
                contraseña_Usuario = txtPassword.Text
            };

            try
            {
                MessageBox.Show($"{userLogin.correo_Usuario}, {userLogin.contraseña_Usuario}");
                userLogin = new UsuarioController().BuscarUsuario(userLogin.correo_Usuario, userLogin.contraseña_Usuario);

                if (userLogin == null)
                {
                    MessageBox.Show("Credenciales incorrectas");
                    return;
                }

                MessageBox.Show(
                    "Usuario encontrado:\n" +
                    "ID: " + userLogin.id_Usuario + "\n" +
                    "Nombre: " + userLogin.nombre_Usuario + "\n" +
                    "Correo: " + userLogin.correo_Usuario
                );

                frmSolicitudes solicitudesFrm = new frmSolicitudes(userLogin.id_Usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Usuario no encontrado o credenciales incorrectas.: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // inicicializamos las variables las cuales acceden directamente a los valores obtenidos de la base de datos
            string passwordUser = userLogin.contraseña_Usuario;
            string username = userLogin.nombre_Usuario;
            string emailUser = userLogin.correo_Usuario;

            MessageBox.Show($"{passwordUser}", $"{emailUser}");

            // validar si los campos están en blanco o null
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if ((txtEmail.Text == "administrador123_andres@gmail.com" && txtPassword.Text == "Admin123Andres") ||
                    (txtEmail.Text == "administrador456_joshua@gmail.com" && txtPassword.Text == "Admin456Joshua") ||
                    (txtEmail.Text == "administrador789_bryan@gmail.com" && txtPassword.Text == "Admin789Bryan"))
                {
                    MessageBox.Show("Bienvenido Admin", "Verificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmContainerAdmin containerFormAdmin = new frmContainerAdmin();
                    containerFormAdmin.Show();
                    return;
                }
                // Validar si las crendicales del formulario coinciden con los de la base de datos
                if (txtPassword.Text != passwordUser || txtEmail.Text.Trim() != emailUser)
                {
                    MessageBox.Show("Credenciales incorrectas", "Error de autentificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login exitoso", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si el login es exitoso, ocultamos este formulario y así mismo, mandar los valores obtenidos del usuario a formularios que
                    // necesiten dicha información (Mostrar label el nombre, o bien poner tener contenedores con dichos valores
                    this.Hide();
                    frmContainer containerForm = new frmContainer(userLogin, userLogin.id_Usuario, username, txtPassword.Text);
                    frmPerfilUsuario profileView = new frmPerfilUsuario(userLogin, containerForm, username, txtPassword.Text);
                    frmSolicitudes frmSolicitudes = new frmSolicitudes(userLogin.id_Usuario);
                    frmInformacionSitio frmInformacion = new frmInformacionSitio(userLogin);

                    // Mostramos el formulario principal
                    containerForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar información" + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
