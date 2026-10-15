using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmRecompensa : Form
    {
        public frmRecompensa()
        {
            InitializeComponent();
        }
        private void CargarRecompensas()
        {
            flowLayoutPanel1.Controls.Clear();

            RecompensaController recompensa = new RecompensaController();
            DataTable dt = recompensa.ListarRecompensas();

            foreach (DataRow fila in dt.Rows)
            {
                frmRecompensaCard_Design tarjeta = new frmRecompensaCard_Design();

                tarjeta.CargarDatos(Convert.ToInt32(fila["id_Recompensa"]),
                fila["descripcionRecompensa"].ToString() ?? "",
                fila["descripcion"].ToString() ?? "",
                fila["tipoRecompensa"].ToString() ?? "")
                ;

                flowLayoutPanel1.Controls.Add(tarjeta);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmRecompensa_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;

            flowLayoutPanel1.Margin = new Padding(0);

            CargarRecompensas();

            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.PerformLayout();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
