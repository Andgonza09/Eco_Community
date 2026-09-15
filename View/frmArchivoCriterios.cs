using Controller;
using Eco_Community.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmArchivoCriterios : Form
    {
        // Uso único del objeto User
        private readonly UsuarioEntidad _currentUser;
        public frmArchivoCriterios(UsuarioEntidad currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            long id_Usuario = _currentUser.id_Usuario;
            new DetalleConsultaArchivoController().Insert(id_Usuario);
            new ArchivoCriteriosController().ChargeFile();

        }

        private void GuideLocationView_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
