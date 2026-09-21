using Microsoft.Data.SqlClient;
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
using System.Windows.Forms.Design;


namespace View
{
    public partial class frmGestiónUsuarios : Form
    {
        private UsuarioEntidad _currentUser;
        public frmGestiónUsuarios()
        {
            UsuarioEntidad user = new UsuarioEntidad();
            InitializeComponent();
            dgListUser.CellFormatting += dataGridView1_CellFormatting;
            dgListUser.DataSource = new UsuarioController().ViewAllUsers();
        }
        public frmGestiónUsuarios(UsuarioEntidad currentUser)
        {
            _currentUser = currentUser;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgListUser.Columns[e.ColumnIndex];

            if (column.DataPropertyName == nameof(UsuarioEntidad.id_Roles)
                && e.Value is RolesEntidad role)
            {
                e.Value = role.id_Roles.ToString(); // texto: se muestra correctamente
                e.FormattingApplied = true;
            }
        }

        /*
        private void btnSearchId_Click(object sender, EventArgs e)
        {
            UsuarioEntidad userSearch = new UsuarioEntidad();
            try
            {
                dgListUser.DataSource = userSearch.ViewAllUsers();

                if (txtSearchId.Text == string.Empty)
                    return;

                if (!int.TryParse(txtSearchId.Text, out _))
                {
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido (número entero).", "Búsqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using SelectQuery selectQuery = new SelectQuery();
                    string sql = @"SELECT * FROM Usuario WHERE id_Usuario = @IdUser";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@IdUser", SqlDbType.BigInt) { Value = Convert.ToInt64(this.txtSearchId.Text)}
                    };

                    SqlDataReader result = selectQuery.ExecuteSelect(sql, parameters);
                    List<User> userList = new List<User>();
                    while (result.Read())
                    {
                        int id_Rol = Convert.ToInt32(result["id_Roles"]);
                        userList.Add(new User(id_Rol)
                        {
                            IdUser = Convert.ToInt64(result["id_usuario"]),
                            Username = result.GetString(1),
                            Email = result.GetString(2),
                            Password = result.GetString(3),
                            DateRegisterUser = DateOnly.FromDateTime(result.GetDateTime(4)),
                        
                        });           
                    }
                    dgListUser.DataSource = userList;
                    

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el usuario: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message, "Búsqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        */
        private void ManageUserView_Load(object sender, EventArgs e)
        {

            try
            {
                UsuarioEntidad userTable = new UsuarioEntidad();

                dgListUser.AutoGenerateColumns = false;
                dgListUser.Columns[0].HeaderText = "ID Usuario";
                dgListUser.Columns[1].HeaderText = "Nombre de usuario";
                dgListUser.Columns[2].HeaderText = "Correo";
                dgListUser.Columns[3].HeaderText = "Contraseña";
                dgListUser.Columns[4].HeaderText = "Fecha de registro";
                dgListUser.Columns[5].HeaderText = "Rol";

                dgListUser.DataSource = new UsuarioController().ViewAllUsers();
                dgListUser.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al mostrar usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgListUser.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario primero.");
                return;
            }

            // Obtenemos del datagridview y convertirlos a un objeto user
            UsuarioEntidad selectedUser = (UsuarioEntidad)dgListUser.CurrentRow.DataBoundItem;

            // validamos que exista un usuario seleccionado
            if (selectedUser == null)
            {
                MessageBox.Show("No se pudo obtener el usuario seleccionado.");
                return;
            }

            // Mandamos el usuario seleccionado al formulario 
            frmActualizarInformacionUsuario editInformation = new frmActualizarInformacionUsuario(selectedUser);
            editInformation.StartPosition = FormStartPosition.CenterScreen;

            editInformation.ShowDialog();
            this.Show();

            UsuarioEntidad user = new UsuarioEntidad();
            dgListUser.DataSource = new UsuarioController().ViewAllUsers();
        }

        private void dgListUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgListUser.CurrentRow != null)
            {
                _currentUser = (UsuarioEntidad)dgListUser.CurrentRow.DataBoundItem;
            }
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {

        }
    }
}
