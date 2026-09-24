using Eco_Community.Model;
using Model.Eco_Community;
using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using View;


namespace View
{
    public partial class frmPerfilUsuario : Form
    {
        private bool _showPassword = false;
        private OpenFileDialog openFile;
        public static string ruteProfileImage = "";

        private string _currentUsername;
        private string _currentPassword;
        private frmContainer _container;
        private readonly UsuarioEntidad _currentUser;

        public frmPerfilUsuario(UsuarioEntidad currentUser, frmContainer container, string username, string password)
        {
            InitializeComponent();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            _container = container;
            _currentUser = currentUser;

            this._currentUsername = username;
            this._currentPassword = password;

            txtUsernameProfile.Text = this._currentUsername;
            txtPasswordProfile.Text = this._currentPassword;

            lblDateRegister.Text = currentUser.fecha_Registro.ToString("dd/MM/yyyy");

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ProfileView_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labUserState_Click(object sender, EventArgs e)
        {
            if (labUserState.Text == "Activa")
            {
                pictureBox13.Image = View.Properties.Resources.check;
            }
            else
            {
                pictureBox13.Image = View.Properties.Resources.exit;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pbxUserImage_Click(object sender, EventArgs e)
        {
            // Muestra la ventana para cargar un nuevo archivo en la imagen
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruteProfileImage = openFile.FileName;
                this.pbxUserImage.Image = Image.FromFile(ruteProfileImage);
                this.pbxUserImage.SizeMode = PictureBoxSizeMode.Zoom;
                this.pbxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsernameProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            if (_showPassword)
            {
                txtPasswordProfile.PasswordChar = '\0';
                pictureBox2.Image = View.Properties.Resources.PasswordShow;
            }
            else
            {
                txtPasswordProfile.PasswordChar = '*';
                pictureBox2.Image = View.Properties.Resources.PasswordHide;
            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (txtUsernameProfile.Text.Trim() == this._currentUsername && txtPasswordProfile.Text.Trim() == this._currentPassword)
            {
                MessageBox.Show("No se han realizado cambios en el perfil.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                UsuarioEntidad userRegister = new UsuarioEntidad();
                string newUsername = string.Empty;
                string newPassword = string.Empty;

                if (this._currentUsername != userRegister.nombre_Usuario || this._currentPassword != userRegister.contraseña_Usuario)
                {
                    // Lógica para actualizar el perfil

                    newUsername = txtUsernameProfile.Text.Trim();
                    newPassword = txtPasswordProfile.Text.Trim();

                    if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
                    {
                        MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (newUsername.Length < 8 || newPassword.Length < 8)
                    {
                        MessageBox.Show("El nombre de usuario y la contraseña deben tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool updateResult = new UsuarioController().UpdateUser(
                            newUsername,
                            newPassword,
                            _currentUser.correo_Usuario,
                            _currentUser.fecha_Registro.ToString("yyyy-MM-dd")
                        );

                    if (updateResult)
                    {
                        _container.UpdateUserData(newUsername, newPassword);

                        this._currentUsername = newUsername;
                        this._currentPassword = newPassword;

                        txtUsernameProfile.Text = newUsername;
                        txtPasswordProfile.Text = newPassword;
                    }

                    MessageBox.Show($"Nuevo nombre de usuario: {newUsername}\nNueva contraseña: {newPassword}", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  MessageBox.Show(updateResult ? "Perfil actualizado correctamente." : "Error al actualizar el perfil.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han realizado cambios en el perfil.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateRegister_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
