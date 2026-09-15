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
    public partial class frmActualizarSolicitud : Form
    {
        private UsuarioEntidad _currentUser;
        private SolicitudesEntidad _currentRequest;
        public frmActualizarSolicitud(SolicitudesEntidad currentRequest)
        {
            InitializeComponent();
            _currentRequest = currentRequest;
        }
        public frmActualizarSolicitud()
        {
            _currentRequest = new SolicitudesEntidad();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateRequestView_Load(object sender, EventArgs e)
        {
            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad();
            // llamar método de obtención de información del sitio por ID

            txtIdRequest.Text = _currentRequest.id_Solicitud.ToString();
            txtUserId.Text = _currentRequest.id_UsuarioEstandar.ToString();
            txtSiteId.Text = _currentRequest.id_InformacionSitio.ToString();

            /*
            txtUsername.Text = _currentRequest.Username.ToString();
            dtpDateRequest.Value = _currentRequest.fecha_Resolucion.ToDateTime(TimeOnly.MinValue);
            cmbStateRequest.Text = _currentRequest.StateRequest;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cmbStateRequest.SelectedIndex == -1)
            {
                MessageBox.Show("No se pueden realizar cambios debido a que no se ha actualizado el estado de la solicitud");
                return;
            }
           
            //string newStateRequest = string.Empty;
            if (cmbStateRequest.SelectedIndex >= 0)
            {
                try
                {
                    var question = MessageBox.Show("¿Estás seguros que deseas realizar cambios en la información de la solicitud?", "Actualización de datos",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (question == DialogResult.OK)
                    {
                        string newStateRequest = cmbStateRequest.Text.Trim();
                        long id_Request = long.Parse(txtIdRequest.Text);
                        bool Update = new SolicitudesController().UpdateRequest(id_Request, newStateRequest);
                            
                        if (Update)
                        {
                            MessageBox.Show("El estado de la solicitud ha sido actualizado" +
                                $"Solicitud: {newStateRequest}");
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la solicitud: " + ex.Message);
                }
            }
        }
    }
}

