using Controller;
using Microsoft.VisualBasic.ApplicationServices;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{

    public partial class frmInformacionSitios : Form
    {
        private OpenFileDialog openNewFile;
        private UsuarioEntidad _user;
        private long _idUsuario;
        public frmInformacionSitios(UsuarioEntidad user, long id_Usuario)
        {
            InitializeComponent();


            cmbNeighborhood.SelectedIndexChanged -= cmbNeighborhood_SelectedIndexChanged;
            cmbDistrict.SelectedIndexChanged -= cmbDistrict_SelectedIndexChanged_1;

            // Mantener únicamente el cambio manual de distrito
            cmbDistrict.SelectionChangeCommitted -= cmbDistrict_SelectionChangeCommitted;
            cmbDistrict.SelectionChangeCommitted += cmbDistrict_SelectionChangeCommitted;

            LoadTypeWaste();
            this.Shown += frmSolicitudesRegistradas_Shown;
            this.Load += frmBeta_Load;


            LoadDistrict();
            _idUsuario = id_Usuario;
            _user = user;

            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DataSource = new SolicitudesController().ListarSolicitudes();

        }
        private void frmSolicitudesRegistradas_Shown(object? sender, EventArgs e)
        {
            ListarSolicitudeBusqueda();
            limpiandoFormulario = true;

            try
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;

                LimpiarCampos();
            }
            finally
            {
                limpiandoFormulario = false;
            }
        }

        private List<int> GetSelectedTypeWasteIds()
        {
            List<int> selectedIds = new List<int>();

            foreach (DataRowView item in ckListTypeWaste.CheckedItems)
            {
                selectedIds.Add(Convert.ToInt32(item["id_CatalogoResiduos"]));
            }
            return selectedIds;
        }

        private DataTable listWaste;
        private void LoadTypeWaste()
        {
            try
            {
                // Desvincular datos anteriores
                ckListTypeWaste.DataSource = null;

                // Instanciar el controlador
                CatalogoResiduosController controllerResiduo = new CatalogoResiduosController();

                // Obtener los residuos
                listWaste = controllerResiduo.ListarCatalogo();

                // Comprobar que se obtuvieron datos
                if (listWaste == null || listWaste.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron tipos de residuos.");
                    return;
                }

                ckListTypeWaste.DataSource = listWaste;
                ckListTypeWaste.DisplayMember = "tipoResiduo";
                ckListTypeWaste.ValueMember = "id_CatalogoResiduos";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los residuos: " + ex.Message);
            }
        }

        private DataTable listDistrict;
        private void LoadDistrict()
        {
            cmbDistrict.Items.Clear();

            DistritoController controller = new DistritoController();
            listDistrict = controller.ListarDistritos();

            cmbDistrict.DataSource = listDistrict;
            cmbDistrict.DisplayMember = "nombre_Distrito";
            cmbDistrict.ValueMember = "id_Distrito";
        }

        private void ListarSolicitudeBusqueda()
        {
            SolicitudesController controller = new SolicitudesController();

            dataGridView1.DataSource =
                controller.ListarSolicitudesPorBusqueda_IdUsuario(_user.id_Usuario);

            if (dataGridView1.Columns.Contains("id_Solicitud"))
            {
                dataGridView1.Columns["id_Solicitud"].Visible = false;
            }

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos(out BarrioEntidad selectedNeighborhood, out List<int> idsSeleccionados)
        {
            selectedNeighborhood = null;
            idsSeleccionados = GetSelectedTypeWasteIds();

            // VALIDAR BARRIO
            if (cmbNeighborhood.SelectedIndex == -1 || cmbNeighborhood.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un barrio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Obtener el ID real seleccionado del ComboBox
            int idBarrio = Convert.ToInt32(cmbNeighborhood.SelectedValue);

            // Recuperar el objeto BarrioEntidad
            BarrioController barrioController = new BarrioController();

            selectedNeighborhood = barrioController.ObtenerIdBarrio(idBarrio);

            if (selectedNeighborhood == null)
            {
                MessageBox.Show("No se pudo obtener la información del barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // VALIDAR DEMÁS CAMPOS
            if (cmbTypeSite.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rchtxtAddress.Text) ||
                cmbDistrict.SelectedIndex == -1 || listViewFile.Items.Count == 0 ||
                ckListTypeWaste.CheckedItems.Count == 0)
            {
                MessageBox.Show("Complete todos los campos para enviar la solicitud.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void CopiarArchivosAdjuntos()
        {
            string carpetaDestino = Path.Combine(Application.StartupPath, "ArchivosAdjuntos");

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            for (int i = 0; i < listViewFile.Items.Count; i++)
            {
                string rutaOriginal = listViewFile.Items[i].SubItems[3].Text;

                FileInfo info = new FileInfo(rutaOriginal);

                string nombreArchivo = info.Name;
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                File.Copy(rutaOriginal, rutaDestino, true);

                // Esto actualiza la ruta para guardar en BD la ruta controlada,
                // no la ruta vieja del archivo original.
                listViewFile.Items[i].SubItems[3].Text = rutaDestino;
            }
        }
        private long RegistrarSitio(BarrioEntidad selectedNeighborhood)
        {
            InformacionSitioEntidad siteInformation = new InformacionSitioEntidad
            {
                tipoSitio = cmbTypeSite.Text,
                direccion = rchtxtAddress.Text,
                id_Barrio = selectedNeighborhood.id_Barrio

            };

            try
            {
                return new InformacionSitioController().InsertarInformacionSitio(siteInformation, siteInformation.id_Barrio);
            }
            catch
            {
                MessageBox.Show("Error al registrar info... Ya sabes donde es LOL 👀👀");
                return 0;
            }

        }
        private void RegistrarDetallesClasificacion(long id_InformacionSitio, List<int> idsSeleccionados)
        {
            // Obtenemos los valores obtenidos al hacer check en el catálogo
            idsSeleccionados = GetSelectedTypeWasteIds();

            if (cmbNeighborhood.SelectedIndex == -1 || cmbNeighborhood.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un barrio.");
                return;
            }

            int idBarrio = Convert.ToInt32(cmbNeighborhood.SelectedValue);
            BarrioEntidad selectedNeighborhood = new BarrioController().ObtenerIdBarrio(idBarrio);

            // Obtenemos el valor de la instancia actual del sitio 
            InformacionSitioEntidad siteInformation = new InformacionSitioEntidad
            {
                tipoSitio = cmbTypeSite.Text,
                direccion = rchtxtAddress.Text,
                id_Barrio = selectedNeighborhood.id_Barrio
            };

            // Detalle Clasificación sitio.
            DetalleClasificacionSitioEntidad detailsInformation = new DetalleClasificacionSitioEntidad();
            new DetalleClasificacionSitioController().InsertarDetallesClasificacion(id_InformacionSitio, idsSeleccionados);
        }
        private void RegistrarDetalleUsuarioSitio(long idInformationSite, long id_Usuario)
        {
            DetalleSitiosEntidad detailsUserSite = new DetalleSitiosEntidad();
            new DetalleSitiosController().InsertarDetallesSitios(detailsUserSite, idInformationSite, _user.id_Usuario);
        }
        private long RegistrarSolicitud(long idInformationSite)
        {
            SolicitudesEntidad request = new SolicitudesEntidad();
            long idUser = _user.id_Usuario;

            long id_Solicitud = new SolicitudesController().InsertarSolicitudes(request, idUser, idInformationSite);
            return id_Solicitud;
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

            string nombreNuevo = Guid.NewGuid().ToString() + extension;
            string rutaCompleta = Path.Combine(carpetaCompleta, nombreNuevo);

            File.Copy(rutaOriginal, rutaCompleta, true);

            // ESTO es lo que guardaremos en SQL
            string rutaRelativa = Path.Combine(carpetaRelativa, nombreNuevo);
            return rutaRelativa;
        }
        private void RegistrarMultimedia(long idRequest)
        {
            for (int i = 0; i < listViewFile.Items.Count; i++)
            {
                MultimediaEntidad multimedia = new MultimediaEntidad();

                multimedia.nombre_ArchivoMultimedia = listViewFile.Items[i].SubItems[0].Text;
                multimedia.tipo_ArchivoMultimedia = listViewFile.Items[i].SubItems[1].Text;
                multimedia.tamaño_ArchivoMultimedia = listViewFile.Items[i].SubItems[2].Text;
                multimedia.ruta_ArchivoMultimedia = GuardarArchivoEnAplicacion(listViewFile.Items[i].SubItems[3].Text, idRequest);

                int idExtension = ObtenerIdExtension(multimedia.tipo_ArchivoMultimedia);
                new MultimediaController().InsertarMultimedia(multimedia, idRequest, idExtension);

            }

        }
        private int ObtenerIdExtension(string extension)
        {
            ExtensionController controller = new ExtensionController();
            DataTable dt = controller.ObtenerExtensiones();

            foreach (DataRow fila in dt.Rows)
            {
                string extensionBD = fila["tipo_Extension"].ToString();

                if (extensionBD.Trim().TrimStart('.')
                    .Equals(extension.Trim().TrimStart('.'),
                            StringComparison.OrdinalIgnoreCase))
                {
                    return Convert.ToInt32(fila["id_Extension"]);
                }
            }

            throw new Exception("La extensión no existe en la base de datos: " + extension);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewFile.SelectedItems.Count == 0)
            {
                return;
            }
            for (int i = 0; i < listViewFile.Items.Count; i++)
            {
                DialogResult result = MessageBox.Show("Estás seguro que deseas eliminar el archivo", "Validación de archivos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    listViewFile.SelectedItems[i].Remove();
                    break;
                }
                else
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                return;
            }

            // Construimos el filtro automáticamente
            string filtro = string.Join(";", extensiones.Select(x => "*" + x));

            using OpenFileDialog openNewFile = new OpenFileDialog();

            openNewFile.Filter = $"Archivos permitidos|{filtro}";
            openNewFile.Title = "Seleccionar archivos";

            if (listViewFile.Items.Count >= 10)
            {
                MessageBox.Show("Lo sentimos, no puedes agregar más de 10 archivos", "Error de adjunción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (openNewFile.ShowDialog() == DialogResult.OK)
            {
                string extensionArchivo =
                    Path.GetExtension(openNewFile.FileName);

                if (!extensiones.Contains(
                    extensionArchivo,
                    StringComparer.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La extensión no está permitida.");
                    return;
                }

                FileInfo fileInformation = new FileInfo(openNewFile.FileName);
                foreach (string file in openNewFile.FileNames)
                {
                    string nameFile = fileInformation.Name;
                    string extension = fileInformation.Extension;
                    string ruteFile = GuardarArchivoEnAplicacion(fileInformation.FullName, idSolicitudSeleccionada);
                    long bytesFile = fileInformation.Length;
                    DateOnly dateAttach = DateOnly.FromDateTime(DateTime.Now);


                    ListViewItem item = new ListViewItem(nameFile);
                    item.SubItems.Add(extension);

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

                    item.SubItems.Add(size.ToString("0.00") + " " + unit);
                    item.SubItems.Add(ruteFile);
                    item.SubItems.Add(dateAttach.ToString());

                    listViewFile.Items.Add(item);
                }
            }
        }

        private void cmbDistrict_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Verificar si el objeto es seleccionado
            if (cmbDistrict.SelectedItem is not DataRowView rowView)
                return;

            int idDistrict = Convert.ToInt32(rowView["id_Distrito"]);
            DataTable listNeighborhoods = new BarrioController().ListarBarriosPorDistrito(idDistrict);

            // Permitir acceso directo a las propiedades del objeto
            cmbNeighborhood.DataSource = listNeighborhoods;
            cmbNeighborhood.DisplayMember = "nombre_Barrio";
            cmbNeighborhood.ValueMember = "id_Barrio";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private long idSolicitudSeleccionada = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                // Seleccionar toda la fila
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;

                // Obtener el ID de la solicitud
                object valorId = dataGridView1.Rows[e.RowIndex].Cells["id_Solicitud"].Value;

                if (valorId == null || valorId == DBNull.Value)
                    return;

                idSolicitudSeleccionada = Convert.ToInt64(valorId);

                // Obtener el ID de la información del sitio
                SolicitudesController solicitudController = new SolicitudesController();

                long idInformacionSitio = solicitudController.ObtenerIdDelSitio_PorIdSolicitud(idSolicitudSeleccionada);

                if (idInformacionSitio <= 0)
                {
                    MessageBox.Show("No se encontró la información del sitio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener información del sitio
                InformacionSitioController informacionController = new InformacionSitioController();

                InformacionSitioEntidad informacion = informacionController.ObtenerInformacionSitio_IdInformacionSitio(idInformacionSitio);

                // Cargar tipo de sitio
                cmbTypeSite.Text = informacion.tipoSitio;

                // Cargar dirección
                rchtxtAddress.Text = informacion.direccion;

                // Obtener el barrio
                BarrioController barrioController = new BarrioController();
                BarrioEntidad barrio = barrioController.ObtenerIdBarrio(informacion.id_Barrio);

                cmbDistrict.SelectedValue = barrio.id_Distrito;
                CargarBarrios(barrio.id_Distrito);
                cmbNeighborhood.SelectedValue = barrio.id_Barrio;

                // Obtener los tipos de residuos
                DetalleClasificacionSitioController detalleController = new DetalleClasificacionSitioController();

                List<int> idsResiduos = detalleController.ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(idInformacionSitio);

                // Desmarcar todos los residuos
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    ckListTypeWaste.SetItemChecked(i, false);
                }

                // Marcar los residuos correspondientes
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    DataRowView data_Catalogo = (DataRowView)ckListTypeWaste.Items[i];
                    int id_Residuo = Convert.ToInt32(data_Catalogo["id_CatalogoResiduos"]);

                    if (idsResiduos.Contains(id_Residuo))
                    {
                        ckListTypeWaste.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error detallado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out BarrioEntidad selectedNeighborhood, out List<int> idsSeleccionados))
            {
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro que deseas enviar la solicitud?", "Envío de solicitud", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
            );

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Envío cancelado", "Envío de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            // Copiar archivos adjuntos
            CopiarArchivosAdjuntos();

            // Registrar información del sitio
            long idInformationSite = RegistrarSitio(selectedNeighborhood);

            if (idInformationSite <= 0)
            {
                MessageBox.Show(
                    "No se pudo registrar la información del sitio.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Registrar tipos de residuos
            RegistrarDetallesClasificacion(
                idInformationSite,
                idsSeleccionados
            );

            // Registrar relación entre usuario y sitio
            RegistrarDetalleUsuarioSitio(
                idInformationSite,
                _user.id_Usuario
            );

            // Registrar solicitud
            long idRequest = RegistrarSolicitud(
                idInformationSite
            );

            


            // Registrar archivos multimedia
            RegistrarMultimedia(idRequest);

            MessageBox.Show(
                "Solicitud enviada correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario
            rchtxtAddress.Clear();

            dataGridView1.ClearSelection();

            listViewFile.Items.Clear();

            // Actualizar DataGridView
            ListarSolicitudeBusqueda();
            

            // Realizar persistencia de la información agregada al formulario
           // string archivo = Path.Combine(Environment.user)


        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    // Verificar que haya una solicitud seleccionada
                    if (idSolicitudSeleccionada <= 0)
                    {
                        MessageBox.Show("Selecciona la solicitud que deseas actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    // Verificar tipo de sitio
                    if (cmbTypeSite.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecciona el tipo de sitio.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    // Verificar dirección
                    if (string.IsNullOrWhiteSpace(rchtxtAddress.Text))
                    {
                        MessageBox.Show("Ingresa la dirección.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Obtener barrio seleccionado
                    if (cmbNeighborhood.SelectedIndex == -1 || cmbNeighborhood.SelectedValue == null)
                    {
                        MessageBox.Show("Seleccione un barrio.");
                        return;
                    }

                    int idBarrio = Convert.ToInt32(cmbNeighborhood.SelectedValue);
                    // Verificar tipos de residuos
                    List<int> idsSeleccionados = GetSelectedTypeWasteIds();

                    if (idsSeleccionados.Count == 0)
                    {
                        MessageBox.Show("Selecciona al menos un tipo de residuo.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    // Confirmar actualización
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas actualizar esta solicitud?", "Actualizar solicitud", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resultado != DialogResult.OK)
                        return;

                    // Obtener el ID de InformacionSitio
                    SolicitudesController solicitudController = new SolicitudesController();

                    long idInformacionSitio =
                        solicitudController.ObtenerIdDelSitio_PorIdSolicitud(
                            idSolicitudSeleccionada
                        );

                    if (idInformacionSitio <= 0)
                    {
                        MessageBox.Show(
                            "No se encontró la información del sitio.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    // Actualizar tipo de sitio, dirección y barrio
                    InformacionSitioController informacionController = new InformacionSitioController();

                    bool informacionActualizada = informacionController.ActualizarInformacionSitio(idInformacionSitio, cmbTypeSite.Text, rchtxtAddress.Text, idBarrio);

                    if (!informacionActualizada)
                    {
                        MessageBox.Show("No se pudo actualizar la información del sitio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    // Actualizar tipos de residuos
                    DetalleClasificacionSitioController detalleController = new DetalleClasificacionSitioController();

                    detalleController.ActualizarDetallesClasificacion(idInformacionSitio, idsSeleccionados);

                    MessageBox.Show("Solicitud actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    // Volver a cargar el DataGridView
                    ListarSolicitudeBusqueda();

                    // Limpiar selección
                    dataGridView1.ClearSelection();
                    idSolicitudSeleccionada = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la solicitud: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            dataGridView1.ClearSelection();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Selecciona la solicitud que deseas eliminar.", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idSolicitudSeleccionada <= 0)
            {
                MessageBox.Show("Selecciona la solicitud que deseas eliminar.", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que deseas eliminar la solicitud del sistema?",
                "Verificación de información",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.OK)
                return;

            try
            {
                InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad();
                long id_InformacionSitio = new SolicitudesController().ObtenerIdDelSitio_PorIdSolicitud(idSolicitudSeleccionada);

                // Primero eliminamos los archivos multimedia relacionados
                new MultimediaController().EliminarMultimedia_PorIdSolicitud(idSolicitudSeleccionada);

                // Después eliminamos la solicitud
                new SolicitudesController().EliminarSolicitudes(idSolicitudSeleccionada);

                // Eliminación de Detalles del sitio
                new DetalleSitiosController().EliminarDetallesSitios_PorIdInformacionSitio(id_InformacionSitio);

                // Eliminación de los detalles de clasificación del sitio.
                DetalleClasificacionSitioController detalleClasificacionSitio = new DetalleClasificacionSitioController();
                List<int> ListaResiduos = detalleClasificacionSitio.ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(id_InformacionSitio);

                detalleClasificacionSitio.EliminarDetallesClasificacion(id_InformacionSitio, ListaResiduos);

                // Eliminación de la información del sitio 
                InformacionSitioController informacionSitioController = new InformacionSitioController();
                informacionSitioController.EliminarInformacionSitio(informacionSitio, id_InformacionSitio);

                MessageBox.Show("Solicitud eliminada correctamente.", "Confirmación de eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Actualizar DataGridView
                ListarSolicitudeBusqueda();

                // Limpiar selección
                idSolicitudSeleccionada = 0;
                dataGridView1.ClearSelection();

                rchtxtAddress.Clear();
                cmbTypeSite.SelectedIndex = -1;
                listViewFile.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la solicitud: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                limpiandoFormulario = true;

                // Quitar completamente la selección del DataGridView
                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                // Ya no existe una solicitud seleccionada
                idSolicitudSeleccionada = 0;

                // Limpiar controles
                cmbTypeSite.SelectedIndex = -1;
                rchtxtAddress.Clear();

                cmbDistrict.SelectedIndex = -1;
                cmbNeighborhood.SelectedIndex = -1;

                // Desmarcar residuos
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    ckListTypeWaste.SetItemChecked(i, false);
                }

                // Si quieres limpiar también archivos
                listViewFile.Items.Clear();
            }
            finally
            {
                limpiandoFormulario = false;
            }


        }
        private bool limpiandoFormulario = false;
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            // Si estamos limpiando, no cargar nuevamente la fila
            if (limpiandoFormulario)
                return;

            if (dataGridView1.CurrentRow == null)
                return;

            if (dataGridView1.CurrentRow.IsNewRow)
                return;

            // Verificar que el ID no sea nulo
            if (dataGridView1.CurrentRow.Cells["id_Solicitud"].Value == null ||
                dataGridView1.CurrentRow.Cells["id_Solicitud"].Value == DBNull.Value)
                return;

            try
            {
                // Obtener el ID de la solicitud seleccionada
                object valorId = dataGridView1.CurrentRow.Cells["id_Solicitud"].Value;

                if (valorId == null || valorId == DBNull.Value)
                    return;

                idSolicitudSeleccionada = Convert.ToInt64(valorId);

                // Obtener el ID de la información del sitio
                SolicitudesController solicitudController = new SolicitudesController();

                long idInformacionSitio = solicitudController.ObtenerIdDelSitio_PorIdSolicitud(idSolicitudSeleccionada);

                if (idInformacionSitio <= 0)
                    return;

                // Obtener información del sitio
                InformacionSitioController informacionController = new InformacionSitioController();

                InformacionSitioEntidad informacion = informacionController.ObtenerInformacionSitio_IdInformacionSitio(idInformacionSitio);

                if (informacion == null)
                    return;

                // Cargar tipo de sitio
                cmbTypeSite.Text = informacion.tipoSitio;

                // Cargar dirección
                rchtxtAddress.Text = informacion.direccion;

                // Obtener barrio
                BarrioController barrioController = new BarrioController();

                BarrioEntidad barrio = barrioController.ObtenerIdBarrio(informacion.id_Barrio);

                if (barrio != null)
                {
                    // Seleccionar distrito
                    cmbDistrict.SelectedValue = barrio.id_Distrito;

                    // Seleccionar barrio
                    cmbNeighborhood.SelectedValue = barrio.id_Barrio;
                }

                // Obtener tipos de residuos
                DetalleClasificacionSitioController detalleController =
                    new DetalleClasificacionSitioController();

                List<int> idsResiduos =
                    detalleController.ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(
                        idInformacionSitio
                    );

                // Desmarcar todos
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    ckListTypeWaste.SetItemChecked(i, false);
                }

                // Marcar los residuos correspondientes
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    DataRowView data_Catalogo = (DataRowView)ckListTypeWaste.Items[i];

                    int id_Residuo = Convert.ToInt32(data_Catalogo["id_CatalogoResiduos"]);

                    if (idsResiduos.Contains(id_Residuo))
                    {
                        ckListTypeWaste.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error detallado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void frmBeta_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            cmbDistrict.SelectedIndex = -1;
            cmbTypeSite.SelectedIndex = -1;
            cmbNeighborhood.SelectedIndex = -1;

            rchtxtAddress.Clear();

            ckListTypeWaste.SelectedIndex = -1;

            for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
            {
                ckListTypeWaste.SetItemChecked(i, false);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpUbicacion_Enter(object sender, EventArgs e)
        {

        }

        private void tlpSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpAcciones_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCancelData_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbNeighborhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            if (dataGridView1.CurrentRow.IsNewRow)
                return;

            try
            {
                // Obtener el ID de la solicitud seleccionada
                object valorId = dataGridView1.CurrentRow.Cells["id_Solicitud"].Value;

                if (valorId == null || valorId == DBNull.Value)
                    return;

                idSolicitudSeleccionada = Convert.ToInt64(valorId);

                // Obtener el ID de la información del sitio
                SolicitudesController solicitudController = new SolicitudesController();

                long idInformacionSitio = solicitudController.ObtenerIdDelSitio_PorIdSolicitud(idSolicitudSeleccionada);

                if (idInformacionSitio <= 0)
                    return;

                // Obtener información del sitio
                InformacionSitioController informacionController = new InformacionSitioController();

                InformacionSitioEntidad informacion = informacionController.ObtenerInformacionSitio_IdInformacionSitio(idInformacionSitio);

                if (informacion == null)
                    return;

                // Cargar tipo de sitio
                cmbTypeSite.Text = informacion.tipoSitio;

                // Cargar dirección
                rchtxtAddress.Text = informacion.direccion;

                // Obtener barrio
                BarrioController barrioController = new BarrioController();

                BarrioEntidad barrio = barrioController.ObtenerIdBarrio(informacion.id_Barrio);

                if (barrio != null)
                {
                    // Seleccionar distrito
                    cmbDistrict.SelectedValue = barrio.id_Distrito;

                    // Seleccionar barrio
                    cmbNeighborhood.SelectedValue = barrio.id_Barrio;
                }

                // Obtener tipos de residuos
                DetalleClasificacionSitioController detalleController =
                    new DetalleClasificacionSitioController();

                List<int> idsResiduos =
                    detalleController.ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(
                        idInformacionSitio
                    );

                // Desmarcar todos
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    ckListTypeWaste.SetItemChecked(i, false);
                }

                // Marcar los residuos correspondientes
                for (int i = 0; i < ckListTypeWaste.Items.Count; i++)
                {
                    DataRowView data_Catalogo = (DataRowView)ckListTypeWaste.Items[i];

                    int id_Residuo = Convert.ToInt32(data_Catalogo["id_CatalogoResiduos"]);

                    if (idsResiduos.Contains(id_Residuo))
                    {
                        ckListTypeWaste.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error detallado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpUbicacion_Enter_1(object sender, EventArgs e)
        {

        }

        private void listViewFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }
        private void CargarBarrios(int idDistrict)
        {
            DataTable listNeighborhoods =
                new BarrioController().ListarBarriosPorDistrito(idDistrict);

            cmbNeighborhood.DataSource = null;
            cmbNeighborhood.DisplayMember = "nombre_Barrio";
            cmbNeighborhood.ValueMember = "id_Barrio";
            cmbNeighborhood.DataSource = listNeighborhoods;
            cmbNeighborhood.SelectedIndex = -1;
        }

        private void cmbDistrict_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDistrict.SelectedItem is not DataRowView rowView)
                return;

            int idDistrict = Convert.ToInt32(rowView["id_Distrito"]);

            CargarBarrios(idDistrict);
        }
    }
}