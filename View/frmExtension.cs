using Controller;
using Microsoft.Web.WebView2.Core;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmExtension : Form
    {
        ExtensionController controller = new ExtensionController();
        public frmExtension()
        {
            InitializeComponent();
            ConfigurarColumnas();
            ListarExtensiones();
        }
        private void ConfigurarColumnas()
        {
            dgvExtension.AutoGenerateColumns = false;

            colIdExtension.DataPropertyName = "id_Extension";
            colTipoExtension.DataPropertyName = "tipo_Extension";
        }

        private void ListarExtensiones()
        {
            try
            {
                dgvExtension.DataSource = controller.ListarExtensiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las extensiones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void frmExtension_Load(object sender, EventArgs e)
        {

        }

        private void dgvExtension_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvExtension.Rows[e.RowIndex];

            txtIdExtension.Text = fila.Cells[colIdExtension.Index].Value?.ToString() ?? "";
            txtExtension.Text = fila.Cells[colTipoExtension.Index].Value?.ToString() ?? "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdExtension.Text))
            {
                ListarExtensiones();
                return;
            }

            if (!int.TryParse(txtIdExtension.Text, out int idExtension))
            {
                MessageBox.Show("Ingrese un ID válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable resultado = controller.BuscarExtensionById(idExtension);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna extensión con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvExtension.DataSource = null;
                    txtExtension.Clear();
                    return;
                }

                dgvExtension.DataSource = resultado;
                dgvExtension.ClearSelection();

                txtExtension.Text = resultado.Rows[0]["tipo_Extension"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la extensión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExtension.Text))
            {
                MessageBox.Show("Ingrese el nombre de la extensión.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExtension.Focus();
                return;
            }

            try
            {
                string tipoExtension = txtExtension.Text.Trim();

                if (controller.ExtensionExiste(tipoExtension))
                {
                    MessageBox.Show("Esa extensión ya existe, intenta de nuevo.", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ExtensionEntidad extension = new ExtensionEntidad()
                {
                    tipo_Extension = tipoExtension
                };

                controller.Insert(extension);

                MessageBox.Show("Extensión registrada correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la extensión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdExtension.Text, out int idExtension))
            {
                MessageBox.Show("Seleccione una extensión válida para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta extensión?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.OK)
                return;

            try
            {
                SolicitudesController solicitudesController = new SolicitudesController();
                MultimediaController multimediaController = new MultimediaController();

                // Obtener las solicitudes que utilizan esta extensión
                List<long> listaSolicitudes = solicitudesController.ObtenerIdsSolicitudes_PorIdExtension(idExtension).Distinct().ToList();
                // 35, 40

                // Eliminar los archivos multimedia de la extensión
                multimediaController.DeleteMultimedia_PorExtension(idExtension);

                foreach (long id_Solicitud in listaSolicitudes)
                {
                    // Verificar si la solicitud todavía tiene archivos
                    int cantidadArchivos = multimediaController.CountMultimediaByRequestId(id_Solicitud);

                    // Si tiene otros archivos, conservar la solicitud
                    if (cantidadArchivos > 0)
                        continue;

                    // Obtener el sitio asociado
                    long id_InformacionSitio = solicitudesController.ObtenerIdDelSitio_ByRequest(id_Solicitud);

                    if (id_InformacionSitio <= 0)
                        throw new Exception("No se encontró el sitio de la solicitud.");

                    // Eliminar detalles del sitio
                    DetalleSitiosController detalleSitiosController = new DetalleSitiosController();
                    detalleSitiosController.Delete(id_InformacionSitio);

                    // Obtener residuos del sitio
                    DetalleClasificacionSitioController detalleClasificacion = new DetalleClasificacionSitioController();

                    List<int> lista_Catalogo = detalleClasificacion.GetIds_CatalogoResiduosByInformacion(id_InformacionSitio);

                    // Eliminar clasificación
                    detalleClasificacion.DeleteDetailsClasificacion(id_InformacionSitio, lista_Catalogo);

                    // Eliminar solicitud
                    solicitudesController.DeleteRequest(id_Solicitud);

                    // Eliminar información del sitio
                    InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad();

                    InformacionSitioController informacionSitioController = new InformacionSitioController();
                    informacionSitioController.DeleteInformacion(informacionSitio, id_InformacionSitio);
                }

                // Eliminar finalmente la extensión
                controller.Delete(idExtension);
                MessageBox.Show("Extensión eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar la extensión.\n\n" + ex.Message,
                    "Error de eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdExtension.Clear();
            txtExtension.Clear();
            dgvExtension.ClearSelection();

            ListarExtensiones();

            txtExtension.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdExtension.Text, out int idExtension))
            {
                MessageBox.Show("Seleccione una extensión válida para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtExtension.Text))
            {
                MessageBox.Show("Ingrese el nombre de la extensión.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExtension.Focus();
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar esta extensión?",
                "Confirmar actualización",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.OK)
                return;

            try
            {
                controller.Update(idExtension, txtExtension.Text.Trim());

                MessageBox.Show("Extensión actualizada correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la extensión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvExtension_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar la fila seleccionada
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvExtension.Rows[e.RowIndex];

            // Evitar seleccionar filas nuevas
            if (fila.IsNewRow)
                return;

            // Cargar información en los TextBox
            txtIdExtension.Text =
                fila.Cells[colIdExtension.Index].Value?.ToString() ?? "";

            txtExtension.Text =
                fila.Cells[colTipoExtension.Index].Value?.ToString() ?? "";
        }
    }
}
