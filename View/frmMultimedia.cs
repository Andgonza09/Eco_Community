using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;



namespace View
{
    public partial class frmMultimedia : Form
    {
        public frmMultimedia()
        {
            InitializeComponent();
            dgvMultimedia.AutoGenerateColumns = false;
            dgvMultimedia.DataSource = new MultimediaController().ListAllMultimedia();
            dgvMultimedia.CellClick += dgvMultimedia_CellContentClick;
            this.Load += frmMultimedia_Load;

        }
        private void CamposLimpios()
        {
            txtIdMultimedia.Clear();
            txtArchivo.Clear();
            txtTamano.Clear();
            txtRuta.Clear();
            dtpFechaAdjuncion.Value = DateTime.Now;
            txtUsuario.Clear();
            txtSolicitud.Clear();
        }


        private void dgvMultimedia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvMultimedia.Rows[e.RowIndex];
            txtIdMultimedia.Text = Convert.ToInt64(fila.Cells[colIdMultimedia.Index].Value).ToString();
            txtArchivo.Text = fila.Cells[colArchivo.Index].Value?.ToString() ?? "";
            txtTamano.Text = fila.Cells[colTamañoArchivo.Index].Value?.ToString() ?? "";
            txtRuta.Text = fila.Cells[colRutaArchivo.Index].Value?.ToString() ?? "";
            dtpFechaAdjuncion.Value = Convert.ToDateTime(fila.Cells[colFechaAdjunción.Index].Value);
            txtUsuario.Text = fila.Cells[colNombreUsuario.Index].Value?.ToString() ?? "";
            txtSolicitud.Text = fila.Cells[colIdSolicitud.Index].Value?.ToString() ?? "";

            // Extensión 

            string extension =
                fila.Cells[colExtension.Index].Value?.ToString() ?? "";

            int indice =
                cmbExtension.FindStringExact(extension);

            if (indice >= 0)
            {
                cmbExtension.SelectedIndex = indice;
            }

            MostrarArchivoSeleccionado(txtRuta.Text);
        }
        private void frmMultimedia_Load(object sender, EventArgs e)
        {
            CargarExtensiones();
            CamposLimpios();
        }
        private void CargarExtensiones()
        {
            ExtensionController controller =
                new ExtensionController();

            DataTable dt =
                controller.ObtenerExtensiones();

            cmbExtension.DataSource = dt;

            cmbExtension.DisplayMember =
                "tipo_Extension";

            cmbExtension.ValueMember =
                "id_Extension";

            cmbExtension.SelectedIndex = -1;
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ListMultimedia()
        {
            MultimediaController controller = new MultimediaController();
            dgvMultimedia.DataSource = controller.ListAllMultimedia();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    ListMultimedia();
                    return;
                }

                if (!long.TryParse(txtBuscar.Text, out long id_Solicitud))
                {
                    MessageBox.Show("Ingresa un ID numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MultimediaController controller = new MultimediaController();
                DataTable resultado = controller.search_ByIdRequest((long.Parse(txtBuscar.Text)));

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna solicitud con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvMultimedia.DataSource = resultado;
            }
            catch (Exception ex)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtIdMultimedia.Clear();
            txtArchivo.Clear();
            txtTamano.Clear();
            txtRuta.Clear();
            dtpFechaAdjuncion.Value = DateTime.Now;
            txtUsuario.Clear();
            txtSolicitud.Clear();
            cmbExtension.SelectedIndex = -1;
        }
        public List<(string, string, string, int, DateOnly)> CambioArchivo()
        {
            if (dgvMultimedia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un registro para cambiar sus datos.");
                return new List<(string, string, string, int, DateOnly)>();
            }
            if (string.IsNullOrWhiteSpace(txtArchivo.Text) || string.IsNullOrWhiteSpace(txtRuta.Text))
            {
                MessageBox.Show("Por favor, selecciona un archivo antes de guardar.");
                return new List<(string, string, string, int, DateOnly)>();

            }
            ;
            ExtensionController controller = new ExtensionController();

            // Obtenemos las extensiones de la base de datos
            DataTable dt = controller.ObtenerExtensiones();
            List<string> extensiones = new List<string>();

            foreach (DataRow fila in dt.Rows)
            {
                string extension = fila["tipo_Extension"].ToString() ?? "";

                if (!string.IsNullOrWhiteSpace(extension))
                {
                    extension = "." + extension.Trim().TrimStart('.');

                    if (!extensiones.Contains(extension, StringComparer.OrdinalIgnoreCase))
                    {
                        extensiones.Add(extension);
                    }
                }
            }

            // Validamos que existan extensiones registradas
            if (extensiones.Count == 0)
            {
                MessageBox.Show("No existen extensiones permitidas.");
                return new List<(string, string, string, int, DateOnly)>();
            }

            // Construimos el filtro automáticamente
            string filtro = string.Join(";", extensiones.Select(x => "*" + x));

            using OpenFileDialog openNewFile = new OpenFileDialog();

            openNewFile.Filter = $"Archivos permitidos|{filtro}";
            openNewFile.Title = "Seleccionar archivos";


            if (openNewFile.ShowDialog() == DialogResult.OK)
            {
                string extensionArchivo =
                    Path.GetExtension(openNewFile.FileName);

                if (!extensiones.Contains(
                    extensionArchivo,
                    StringComparer.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La extensión no está permitida.");
                    return new List<(string, string, string, int, DateOnly)>();
                }

                FileInfo fileInformation = new FileInfo(openNewFile.FileName);

                string nameFile = fileInformation.Name;
                string extension = fileInformation.Extension;
                string ruteFile = GuardarArchivoEnAplicacion(fileInformation.FullName, long.Parse(txtSolicitud.Text));
                long bytesFile = fileInformation.Length;
                DateOnly dateAttach = DateOnly.FromDateTime(DateTime.Now);

                double size = bytesFile;
                string unit = "Bytes";

                // Cuando el tamaño pasa por cada división va disminuyendo su tamaño y cambiando los bytes del archivo
                if (size >= 1024)
                {
                    size /= 1024;
                    unit = "KB";
                }

                if (size >= 1024)
                {
                    size /= 1024;
                    unit = "MB";
                }

                if (size >= 1024)
                {
                    size /= 1024;
                    unit = "GB";
                }

                txtTamano.Text = size.ToString("0.00") + " " + unit;
                txtArchivo.Text = nameFile;
                txtRuta.Text = ruteFile;
                dtpFechaAdjuncion.Value = DateTime.Now;

                if (dgvMultimedia.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un registro.");
                    return new List<(string, string, string, int, DateOnly)>();
                }

                // Obtenemos la extensión DEL ARCHIVO NUEVO
                string extensionSeleccionada = Path.GetExtension(openNewFile.FileName);
                int indice = cmbExtension.FindStringExact(extensionSeleccionada);

                if (indice >= 0)
                {
                    cmbExtension.SelectedIndex = indice;
                }
                else
                {
                    MessageBox.Show("La extensión del archivo no está registrada.");
                }

            }
            return new List<(string, string, string, int, DateOnly)>
            {
                (txtArchivo.Text, txtTamano.Text, txtRuta.Text, cmbExtension.SelectedIndex, DateOnly.FromDateTime(dtpFechaAdjuncion.Value))
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambioArchivo();
        }
        private string ObtenerRutaCompleta(string ruta)
        {
            // Si ya es una ruta completa, la devolvemos tal cual
            if (Path.IsPathRooted(ruta))
            {
                return ruta;
            }

            // Si es una ruta relativa, la combinamos con la carpeta de ejecución
            return Path.Combine(
                AppContext.BaseDirectory,
                ruta
            );
        }

        private void MostrarArchivoSeleccionado(string ruta)
        {
            picVistaPrevia.Image?.Dispose();
            picVistaPrevia.Image = null;

            if (string.IsNullOrWhiteSpace(ruta))
            {
                lblVistaPrevia.Text =
                    "Selecciona un archivo para visualizarlo.";

                return;
            }

            string rutaCompleta =
                ObtenerRutaCompleta(ruta);

            if (!System.IO.File.Exists(rutaCompleta))
            {
                lblVistaPrevia.Text =
                    "El archivo no se encuentra disponible.";

                return;
            }

            string extension =
                Path.GetExtension(rutaCompleta).ToLower();

            if (extension == ".png" ||
                extension == ".jpg" ||
                extension == ".jpeg" ||
                extension == ".bmp" ||
                extension == ".gif")
            {
                using (Image imagen =
                    Image.FromFile(rutaCompleta))
                {
                    picVistaPrevia.Image =
                        new Bitmap(imagen);
                }

                picVistaPrevia.SizeMode =
                    PictureBoxSizeMode.Zoom;

                lblVistaPrevia.Text =
                    Path.GetFileName(rutaCompleta);
            }
            else
            {
                lblVistaPrevia.Text =
                    "Vista previa no disponible para este tipo de archivo.\n" +
                    "Utiliza 'Abrir archivo' para visualizarlo.";
            }
        }

        private void picVistaPrevia_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRuta.Text))
            {
                MessageBox.Show(
                    "Selecciona un archivo."
                );

                return;
            }

            string rutaCompleta =
                ObtenerRutaCompleta(txtRuta.Text);

            if (!System.IO.File.Exists(rutaCompleta))
            {
                MessageBox.Show(
                    "No se encontró el archivo."
                );

                return;
            }

            Process.Start(
                new ProcessStartInfo()
                {
                    FileName = rutaCompleta,
                    UseShellExecute = true
                }
            );
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRuta.Text))
            {
                MessageBox.Show(
                    "Selecciona un archivo."
                );

                return;
            }

            string rutaCompleta =
                ObtenerRutaCompleta(txtRuta.Text);

            if (!System.IO.File.Exists(rutaCompleta))
            {
                MessageBox.Show(
                    "No se encontró el archivo."
                );

                return;
            }

            Process.Start(
                new ProcessStartInfo()
                {
                    FileName = "explorer.exe",
                    Arguments =
                        $"/select,\"{rutaCompleta}\"",

                    UseShellExecute = true
                }
            );
        }

        private void grpVistaPrevia_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMultimedia.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un registro.");
                    return;
                }

                if (txtArchivo.Text == dgvMultimedia.CurrentRow.Cells[colArchivo.Index].Value?.ToString())
                {
                    MessageBox.Show("No se ha seleccionado un nuevo archivo para actualizar.");
                    return;
                }

                if (cmbExtension.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona una extensión.");
                    return;
                }

                int idExtension = Convert.ToInt32(cmbExtension.SelectedValue);

                MultimediaController multimedia = new MultimediaController();

                multimedia.UpdateMultimedia(long.Parse(txtIdMultimedia.Text), txtArchivo.Text, txtRuta.Text, txtTamano.Text, idExtension, DateOnly.FromDateTime(dtpFechaAdjuncion.Value));
                MessageBox.Show("Actualización exitosa.", "Cambios realizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListMultimedia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar.\n" + "Detalles: " + ex.Message
                );
            }
        }
        private string GuardarArchivoEnAplicacion(string rutaOriginal, long idSolicitud)
        {
            string carpetaRelativa = Path.Combine(
                "Multimedia",
                $"solicitud_{idSolicitud}"
            );

            string carpetaCompleta = Path.Combine(
                AppContext.BaseDirectory,
                carpetaRelativa
            );

            Directory.CreateDirectory(carpetaCompleta);

            string extension =
                Path.GetExtension(rutaOriginal);

            string nombreNuevo =
                Guid.NewGuid().ToString() + extension;

            string rutaCompleta = Path.Combine(
                carpetaCompleta,
                nombreNuevo
            );

            File.Copy(
                rutaOriginal,
                rutaCompleta,
                true
            );

            // ESTO es lo que guardaremos en SQL
            string rutaRelativa = Path.Combine(carpetaRelativa, nombreNuevo);
            return rutaRelativa;
        }

        private void dgvMultimedia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMultimedia.CurrentRow == null)
                return;

            DataGridViewRow fila =
                dgvMultimedia.CurrentRow;

            txtIdMultimedia.Text =
                fila.Cells[colIdMultimedia.Index]
                .Value?.ToString() ?? "";

            txtArchivo.Text =
                fila.Cells[colArchivo.Index]
                .Value?.ToString() ?? "";

            txtRuta.Text =
                fila.Cells[colRutaArchivo.Index]
                .Value?.ToString() ?? "";

            txtTamano.Text =
                fila.Cells[colTamañoArchivo.Index]
                .Value?.ToString() ?? "";

            // La columna contiene ".png", ".jpg", etc.
            string extension =
                fila.Cells[colExtension.Index]
                .Value?.ToString() ?? "";

            int indice =
                cmbExtension.FindStringExact(extension);

            if (indice >= 0)
            {
                cmbExtension.SelectedIndex = indice;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMultimedia.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un registro.");
                    return;
                }

                long idSolicitud =long.Parse(txtSolicitud.Text);
                long idMultimedia = long.Parse(txtIdMultimedia.Text);
                int cantidadMultimedia = new MultimediaController().CountMultimediaByRequestId(idSolicitud);


                // SI ES EL ÚLTIMO ARCHIVO
                if (cantidadMultimedia == 1)
                {
                    var respuesta = MessageBox.Show("¿Estás seguro que deseas eliminar este archivo multimedia?\n\n" + "Ten en cuenta que al ser el último archivo multimedia, " + "la solicitud también será eliminada.",
                        "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (respuesta != DialogResult.OK)
                        return;


                    // Obtenemos la información del sitio
                    long idInformacionSitio = new SolicitudesController().GetIdInformacionSitio(idSolicitud);


                    // Eliminar detalles de clasificación
                    DetalleClasificacionSitioController detalleClasificacion = new DetalleClasificacionSitioController();
                    detalleClasificacion.DeleteDetailsClasificacion(idInformacionSitio,detalleClasificacion.GetIds_CatalogoResiduosByInformacion(idInformacionSitio));


                    // Eliminar detalles del sitio
                    DetalleSitiosController detalleSitio = new DetalleSitiosController();
                    detalleSitio.Delete(idInformacionSitio);

                    //  Eliminamos Multimedia
                    MultimediaController multimedia = new MultimediaController();
                    multimedia.DeleteMultimedia_ByRequest(idSolicitud);

                    //  Eliminamos Solicitud
                    SolicitudesController solicitudes = new SolicitudesController();
                    solicitudes.DeleteRequest(idSolicitud);

                    

                    // Finalmente la información del sitio
                    InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad();
                    InformacionSitioController sitios = new InformacionSitioController();
                    sitios.DeleteInformacion(informacionSitio, idInformacionSitio);


                    MessageBox.Show("El archivo multimedia y la solicitud " + "fueron eliminados exitosamente.",
                        "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListMultimedia();
                    return;
                }

                
                // Si la solicitud tiene más de un archivo multimedia, solo eliminamos el archivo multimedia seleccionado
                var respuestaNormal = MessageBox.Show("¿Estás seguro de eliminar este archivo multimedia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaNormal != DialogResult.Yes)
                    return;

                MultimediaController multimediaNormal = new MultimediaController();
                multimediaNormal.DeleteMultimediaById(idMultimedia);

                MessageBox.Show("Archivo multimedia eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListMultimedia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el archivo multimedia.\n" + "Detalles: " + ex.Message);
            }
        }
    }
}
