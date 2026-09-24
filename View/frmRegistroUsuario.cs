using Microsoft.Data.SqlClient;
using Eco_Community.Model;
using Model.Eco_Community;
using Controller;

namespace View
{
    public partial class frmRegistroUsuario : Form
    {
        public bool showPassword = false;

        public frmRegistroUsuario()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (!checkBox1.Checked)
                {
                    MessageBox.Show("Acepta los términos de privacidad", "No se aceptaron los términos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Inicializar la clave foránea
                // Asignamos manualmente el rol y nombre del rol que tendrá el usuario registrado en caso que no sea un administrador... (Usuario Predeterminado)

                RolesEntidad role = new RolesEntidad()
                {
                    id_Roles = 2,
                    tipo_Roles = "Usuario Estándar"
                };

                // Realizamos una instancia de la clase User para registrar al usuario con los datos ingresados en los TextBox
                UsuarioEntidad userRegister = new UsuarioEntidad()
                {
                    nombre_Usuario = txtUsername.Text.Trim(),
                    contraseña_Usuario = txtPassword.Text.Trim(),
                    correo_Usuario = txtEmail.Text.Trim(),
                    fecha_Registro = DateOnly.FromDateTime(DateTime.Now),
                };

                if (!txtEmail.Text.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Correo electrónico no válido", "Validación de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres", "Validación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    new UsuarioController().Insert(userRegister, role.id_Roles);
                    var result = MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        frmContainer containerForm = new frmContainer(userRegister, userRegister.id_Usuario, txtUsername.Text.Trim(), txtPassword.Text.Trim());
                        // Acá le pasamos el objeto a otros formularios
                        frmArchivoCriterios GuideForm = new frmArchivoCriterios(userRegister);
                        frmMenúPrincipal userStartView = new frmMenúPrincipal(userRegister, txtUsername.Text.Trim(), txtPassword.Text.Trim());
                        frmPerfilUsuario profileView = new frmPerfilUsuario(userRegister, containerForm, txtUsername.Text.Trim(), txtPassword.Text.Trim());

                        containerForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error de inserción" + ex.Message, ex);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            // Cuando hacemos click, el bool cambia de valor
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuarioEntidad userRegister = new UsuarioEntidad();
            UsuarioController usuario = new UsuarioController();
            usuario.BuscarUsuario(txtEmail.Text.Trim(), txtPassword.Text.Trim());

            this.Hide();
            frmLoginUsuario loginForm = new frmLoginUsuario(userRegister, txtEmail.Text.Trim(), txtPassword.Text.Trim());
            loginForm.Show();
        }
        private void RegisterView_Load(object sender, EventArgs e)
        {
            this.FormClosing += RegisterView_FormCLosing;
        }

        private void RegisterView_FormCLosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

    }
}
