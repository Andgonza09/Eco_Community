using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Eco_Community;
using View;


namespace View
{

    public partial class frmResetearContraseña : Form
    {
        private string _username;
        private string _password;
        private readonly UsuarioEntidad _currentUser;
        public frmResetearContraseña(UsuarioEntidad userRegister, string username, string password)
        {
            InitializeComponent();
            _currentUser = userRegister;
            this._username = username;
            this._password = password;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLoginUsuario loginForm = new frmLoginUsuario(_currentUser, this._username, this._password);
            loginForm.Show();
        }

        private void btnVerificateData_Click(object sender, EventArgs e)
        {
            try
            {
                bool exist = true;
                if (exist)
                {
                    MessageBox.Show("Datos validados correctamente", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmCambiarContraseña changePassForm = new frmCambiarContraseña(_currentUser, this._username, this._password);
                    changePassForm.Show();
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Ocurrió un error en el sistema", $"problemas de {ex}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Lógica
            // Si los datos coinciden, se valida la información y pasamos al siguiente menú
            // En un dado caso no se valide la información con la base de datos se muestra un mensaje que no se comprobó
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResetPasswordView_Load(object sender, EventArgs e)
        {
            this.FormClosing += ResetPasswordView_FormClosing;
        }
        private void ResetPasswordView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
