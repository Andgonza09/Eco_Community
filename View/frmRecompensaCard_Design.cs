using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmRecompensaCard_Design : UserControl
    {
        public frmRecompensaCard_Design()
        {
            InitializeComponent();
        }
        public void CargarDatos(int id_Recompensa, string descripcion_Recompensa, string descripcion_Mision, string tipoRecompensa)
        {
            lblNRecompensa.Text = "Nº Recompensa: " + id_Recompensa.ToString();
            lblDescripcion.Text = "Descripcion Recompensa: " + descripcion_Recompensa;
            lblMisionAsociada.Text = "Misión asociada: " + descripcion_Mision;
            lblTipoRecompensa.Text = "Tipo Recompensa: " + tipoRecompensa;
        }
        private void frmRecompensaCard_Design_Load(object sender, EventArgs e)
        {

        }

        private void lblMisionAsociada_Click(object sender, EventArgs e)
        {

        }

        private void lblNRecompensa_Click(object sender, EventArgs e)
        {

        }
    }
}
