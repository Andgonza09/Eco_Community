using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmCatalogoResiduos : Form
    {
        public frmCatalogoResiduos()
        {
            InitializeComponent();
            ConfigureGrid();
            ListarCatalogo();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ConfigureGrid()
        {
            dgvCatalogo.AutoGenerateColumns = false;

            colIdCatalogo.DataPropertyName = "id_CatalogoResiduos";
            colResiduos.DataPropertyName = "tipoResiduo";
        }
        private void ListarCatalogo()
        {
            CatalogoResiduosController controller = new CatalogoResiduosController();
            dgvCatalogo.DataSource = controller.ListarCatalogo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCatalogo.Text))
                {
                    MessageBox.Show("Completa el nombre del tipo de residuo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CatalogoResiduosController controller = new CatalogoResiduosController();

                if (controller.ExisteCatalogo(txtCatalogo.Text))
                {
                    MessageBox.Show("Ese tipo de residuo ya existe, intenta de nuevo", "Verificacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CatalogoResiduosEntidad catalogo = new CatalogoResiduosEntidad()
                {
                    tipoResiduo = txtCatalogo.Text
                };

                controller.InsertarCatalogoResiduos(catalogo);
                MessageBox.Show("Registro agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarCatalogo();
                bntClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCatalogo.Text))
                {
                    MessageBox.Show("Selecciona un distrito primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCatalogo.Text))
                {
                    MessageBox.Show("Completa el nombre del tipo de residuo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCatalogo = Convert.ToInt32(txtIdCatalogo.Text);

                CatalogoResiduosController controller = new CatalogoResiduosController();
                controller.ActualizarCatalogoResiduos(idCatalogo, txtCatalogo.Text);

                MessageBox.Show("Registro actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarCatalogo();
                bntClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCatalogo.Text))
                {
                    MessageBox.Show("Selecciona un tipo de residuo primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el tipo de residuos del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado != DialogResult.OK)
                    return;


                else
                {
                    // Obtención del id del tipo de residuo actual
                    int idCatalogo = Convert.ToInt32(txtIdCatalogo.Text);

                    SolicitudesController solicitudesController = new SolicitudesController();

                    DetalleClasificacionSitioController detalleClasificacionSitio = new DetalleClasificacionSitioController();

                    InformacionSitioController informacionSitioController = new InformacionSitioController();

                    // Obtener solicitudes asociadas al residuo
                    List<long> lista_Solicitudes = solicitudesController.ObtenerIdsSolicitudes_PorIDCatalogo(idCatalogo);

                    // Obtener todos los sitios
                    var lista_Sitios = informacionSitioController.ListarTodos_Puntos();

                    foreach (var sitio in lista_Sitios)
                    {
                        long id_InformacionSitio = sitio.Item1.id_InformacionSitio;

                        // Obtener residuos del sitio
                        List<int> lista_Residuos = detalleClasificacionSitio.ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(id_InformacionSitio);

                        // Verificar si contiene el residuo seleccionado
                        if (!lista_Residuos.Contains(idCatalogo))
                            continue;

                        // Eliminar únicamente el residuo seleccionado
                        detalleClasificacionSitio.EliminarDetallesClasificacion(id_InformacionSitio, new List<int> { idCatalogo });
                        lista_Residuos = detalleClasificacionSitio.ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(id_InformacionSitio);

                        // Si existen otros residuos, conservar el sitio
                        if (lista_Residuos.Count > 0)
                            continue;

                        // Eliminar detalles del sitio
                        DetalleSitiosController detallesSitiosController = new DetalleSitiosController();
                        detallesSitiosController.EliminarDetallesSitios_PorIdInformacionSitio(id_InformacionSitio);

                        // Recorrer solicitudes asociadas
                        foreach (long id_Solicitud in lista_Solicitudes.Distinct())
                        {
                            long idSitio = solicitudesController.ObtenerIdDelSitio_PorIdSolicitud(id_Solicitud);

                            if (idSitio == id_InformacionSitio)
                            {
                                // Eliminar multimedia de la solicitud
                                MultimediaController multimediaController =
                                    new MultimediaController();

                                multimediaController.EliminarMultimedia_PorIdSolicitud(id_Solicitud);
                            }
                        }

                        // Eliminar solicitudes del sitio
                        solicitudesController.EliminarSolicitudes_PorIdInformacionSitio(id_InformacionSitio);

                        // Eliminar información del sitio
                        InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad();
                        informacionSitioController.EliminarInformacionSitio(informacionSitio, id_InformacionSitio);
                    }

                    // Eliminar residuo del catálogo
                    CatalogoResiduosController catalogoController = new CatalogoResiduosController();
                    catalogoController.EliminarCatalogoResiduos(idCatalogo);

                    MessageBox.Show("Registro eliminado correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCatalogo();
                    bntClear_Click(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtIdCatalogo.Clear();
            txtCatalogo.Clear();
            dgvCatalogo.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogoResiduosController controller = new CatalogoResiduosController();
                if (string.IsNullOrWhiteSpace(txtIdCatalogo.Text))
                {

                    ListarCatalogo();
                    return;
                }

                if (!int.TryParse(txtIdCatalogo.Text, out int idCatalogo))
                {
                    MessageBox.Show("Ingresa un ID numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable resultado = controller.BuscarResiduoPorId(idCatalogo);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún tipo de residuo con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvCatalogo.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCatalogoResiduos_Load(object sender, EventArgs e)
        {

        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvCatalogo.Rows[e.RowIndex];

            if (fila.IsNewRow)
                return;

            txtIdCatalogo.Text =
                fila.Cells[colIdCatalogo.Index].Value?.ToString() ?? "";

            txtCatalogo.Text =
                fila.Cells[colResiduos.Index].Value?.ToString() ?? "";
        }
    }
}
