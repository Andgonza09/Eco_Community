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
    public partial class frmMisiones : Form
    {
        private long _id_Usuario;
        public frmMisiones(long id_Usuario)
        {
            InitializeComponent();
            _id_Usuario = id_Usuario;
        }
        private void CargarMisiones()
        {
            flowLayoutPanel1.Controls.Clear();

            MisionesController misiones = new MisionesController();
            DataTable dt = misiones.ListarMisiones_Tarjetas();

            foreach (DataRow fila in dt.Rows)
            {
                frmMisionesCard_Design tarjeta = new frmMisionesCard_Design();

                tarjeta.CargarDatos(Convert.ToInt32(fila["id_Mision"]),
                fila["descripcion"].ToString() ?? "",
                (Convert.ToInt32(fila["puntaje"])),
                _id_Usuario);

                flowLayoutPanel1.Controls.Add(tarjeta);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMisiones_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;

            flowLayoutPanel1.Margin = new Padding(0);

            CargarMisiones();

            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.PerformLayout();

        }

    }
}
