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
    public partial class frmCambiarContraseña : Form
    {
        private bool showPassword = false;
        private string _username;
        private string _password;
        private UsuarioEntidad currentUser;
        private readonly UsuarioEntidad _currentUser;

        public frmCambiarContraseña(UsuarioEntidad userRegister, string username, string password)
        {
            InitializeComponent();

            _currentUser = userRegister;
            this._username = username;
            this._password = password;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLoginUsuario loginForm = new frmLoginUsuario(_currentUser, this._username, this._password);
            loginForm.Show();
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {
            this.FormClosing += ChangePasswordView_ClosingForm;
        }
        private void ChangePasswordView_ClosingForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
                pictureBox4.Image = View.Properties.Resources.PasswordShow;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pictureBox4.Image = View.Properties.Resources.PasswordHide;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
                pictureBox4.Image = View.Properties.Resources.PasswordShow;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pictureBox4.Image = View.Properties.Resources.PasswordHide;

            }
        }
    }
}