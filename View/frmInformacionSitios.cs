using Controller;
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
    public partial class frmInformacionSitios : Form
    {
        private OpenFileDialog openNewFile;
        private UsuarioEntidad _user;
        public frmInformacionSitios(UsuarioEntidad user)
        {
            InitializeComponent();
            LoadTypeWaste();
            this.Shown += frmSolicitudesRegistradas_Shown;
            LoadDistrict();
            _user = user;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void frmSolicitudesRegistradas_Shown(object? sender, EventArgs e)
        {
            CargarSolicitudes();
        }

        private void CargarSolicitudes()
        {
            SolicitudesController solicitudes = new SolicitudesController();

            var datos = solicitudes.ViewRequestByUser(_user.id_Usuario);

            var datosGrid = datos.Select(x => new
            {
                Id = x.Item1.id_Solicitud,
                Estado = x.Item1.estado_Solicitud,
                Fecha_Solicitud = x.Item1.fecha_Solicitud,
                Fecha_Resolucion = x.Item1.fecha_Resolucion,
                TipoSitio = x.Item2,
                Direccion = x.Item3
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.DataSource = datosGrid;

            dataGridView1.Visible = true;
            dataGridView1.Dock = DockStyle.Fill;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridView1.ColumnHeadersHeight = 38;
            dataGridView1.RowTemplate.Height = 34;
        }

        private List<int> GetSelectedTypeWasteIds()
        {
            List<int> selectedIds = new List<int>();

            foreach (CatalogoResiduosEntidad item in ckListTypeWaste.CheckedItems)
            {
                selectedIds.Add(item.id_CatalogoResiduos);
            }
            return selectedIds;
        }

        private void LoadTypeWaste()
        {
            ckListTypeWaste.Items.Clear();

            CatalogoResiduosEntidad wasteCatalog = new CatalogoResiduosEntidad();
            List<CatalogoResiduosEntidad> listWaste = new CatalogoResiduosController().ViewAllWaste();

            ckListTypeWaste.DataSource = listWaste;
            ckListTypeWaste.DisplayMember = "tipoResiduo";
            ckListTypeWaste.ValueMember = "id_CatalogoResiduos";

        }
        private void LoadDistrict()
        {
            cmbDistrict.Items.Clear();

            DistritoEntidad district = new DistritoEntidad();
            List<DistritoEntidad> listDistrict = new DistritoController().ViewAllDistrict();

            cmbDistrict.DataSource = listDistrict;
            cmbDistrict.DisplayMember = "nombre_Distrito";
            cmbDistrict.ValueMember = "id_Distrito";


        }
        public void RefreshTable()
        {

            SolicitudesController solicitudes = new SolicitudesController();

            var lista = solicitudes.ViewRequestByUser(_user.id_Usuario);

            var datosTabla = lista.Select(s => new
            {
                Id = s.Item1.id_Solicitud,
                Estado = s.Item1.estado_Solicitud,
                Fecha_Solicitud = s.Item1.fecha_Solicitud,
                Fecha_Resolucion = s.Item1.fecha_Resolucion,
                TipoSitio = s.Item2,
                Direccion = s.Item3
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datosTabla;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            cmbTypeSite.SelectedIndex = -1;
            cmbDistrict.SelectedIndex = -1;
            for (int i = ckListTypeWaste.CheckedIndices.Count - 1; i >= 0; i--)
            {
                int index = ckListTypeWaste.CheckedIndices[i];
                ckListTypeWaste.SetItemChecked(index, false);
            }
            cmbNeighborhood.SelectedIndex = -1;
            listViewFile.Items.Clear();
            rchtxtAddress.Clear();
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos(out BarrioEntidad selectedNeighborhood, out List<int> idsSeleccionados)
        {
            selectedNeighborhood = null;
            idsSeleccionados = GetSelectedTypeWasteIds();

            if (cmbNeighborhood.SelectedItem is not BarrioEntidad neighborhood)
            {
                MessageBox.Show("Seleccione un barrio.");
                return false;
            }

            selectedNeighborhood = neighborhood;

            if (cmbTypeSite.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rchtxtAddress.Text) || cmbNeighborhood.SelectedIndex == -1 ||
                cmbDistrict.SelectedIndex == -1 || listViewFile.Items.Count == 0 || ckListTypeWaste.CheckedItems.Count == 0)
            {
                MessageBox.Show("Complete todos los campos para enviar la solicitud", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                return new InformacionSitioController().Insert(siteInformation, siteInformation.id_Barrio);
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

            if (cmbNeighborhood.SelectedItem is not BarrioEntidad selectedNeighborhood)
            {
                MessageBox.Show("Seleccione un barrio.");
                return;
            }

            // Obtenemos el valor de la instancia actual del sitio 
            InformacionSitioEntidad siteInformation = new InformacionSitioEntidad
            {
                tipoSitio = cmbTypeSite.Text,
                direccion = rchtxtAddress.Text,
                id_Barrio = selectedNeighborhood.id_Barrio
            };

            Console.WriteLine($"{siteInformation.id_Barrio}");
            //  id_InformacionSitio = new InformacionSitioController().Insert(siteInformation, siteInformation.id_Barrio);

            // Detalle Clasificación sitio.
            DetalleClasificacionSitioEntidad detailsInformation = new DetalleClasificacionSitioEntidad();
            new DetalleClasificacionSitioController().Insert(id_InformacionSitio, idsSeleccionados);
        }
        private void RegistrarDetalleUsuarioSitio(long idInformationSite, long id_Usuario)
        {
            DetalleSitiosEntidad detailsUserSite = new DetalleSitiosEntidad();
            new DetalleSitiosController().Insert(detailsUserSite, idInformationSite, _user.id_Usuario);
        }
        private long RegistrarSolicitud(long idInformationSite)
        {
            SolicitudesEntidad request = new SolicitudesEntidad();
            long idUser = _user.id_Usuario;

            long id_Solicitud = new SolicitudesController().Insert(request, idUser, idInformationSite);
            return id_Solicitud;
        }
        private void RegistrarMultimedia(long idRequest)
        {
            for (int i = 0; i < listViewFile.Items.Count; i++)
            {
                MultimediaEntidad multimedia = new MultimediaEntidad();

                multimedia.nombre_ArchivoMultimedia = listViewFile.Items[i].SubItems[0].Text;
                multimedia.tipo_ArchivoMultimedia = listViewFile.Items[i].SubItems[1].Text;
                multimedia.tamaño_ArchivoMultimedia = listViewFile.Items[i].SubItems[2].Text;
                multimedia.ruta_ArchivoMultimedia = listViewFile.Items[i].SubItems[3].Text;

                int idExtension = ObtenerIdExtension(multimedia.tipo_ArchivoMultimedia);
                new MultimediaController().Insert(multimedia, idRequest, idExtension);

            }

        }
        private int ObtenerIdExtension(string extension)
        {
            extension = extension.ToLower();

            if (extension == ".png")
                return 1;

            if (extension == ".jpeg")
                return 2;

            if (extension == ".jpg")
                return 3;

            if (extension == ".pdf")
                return 4;

            if (extension == ".mp4")
                return 5;

            return 0;
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
            openNewFile = new OpenFileDialog();
            openNewFile.Multiselect = true;

            openNewFile.Filter = "Archivos permitidos|*.jpg;*.png;*jpeg;*.pdf;*.mp4;";
            openNewFile.Title = "Seleccionar archivos";

            if (listViewFile.Items.Count >= 10)
            {
                MessageBox.Show("Lo sentimos, no puedes agregar más de 5 archivos", "Error de adjunción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (openNewFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInformation = new FileInfo(openNewFile.FileName);
                foreach (string file in openNewFile.FileNames)
                {
                    string nameFile = fileInformation.Name;
                    string extension = fileInformation.Extension;
                    string ruteFile = fileInformation.FullName;
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
            if (cmbDistrict.SelectedItem is not DistritoEntidad selectedDistrict)
                return;

            int idDistrict = selectedDistrict.id_Distrito;

            BarrioEntidad neighborhood = new BarrioEntidad();
            List<BarrioEntidad> listNeighborhoods = new BarrioController().ViewAllBarrios(idDistrict);

            // Permitir acceso directo a las propiedades del objeto
            cmbNeighborhood.DisplayMember = "nombre_Barrio";
            cmbNeighborhood.ValueMember = "id_Barrio";
            cmbNeighborhood.DataSource = listNeighborhoods;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out BarrioEntidad selectedNeighborhood, out List<int> idsSeleccionados))
                return;

            var result = MessageBox.Show("¿Estás seguro que deseas enviar la solicitud?", "Envío de solicitud", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Envío cancelado", "Envío de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CopiarArchivosAdjuntos();

            // Registro de sitio -- Información Sitio
            long idInformationSite = RegistrarSitio(selectedNeighborhood);

            // Registro de detalles -- Informacion sitio y catálogo de residuos
            RegistrarDetallesClasificacion(idInformationSite, idsSeleccionados);

            // Registro de usuarios y sitios 
            RegistrarDetalleUsuarioSitio(idInformationSite, _user.id_Usuario);


            long idRequest = RegistrarSolicitud(idInformationSite);
            RegistrarMultimedia(idRequest);
            MessageBox.Show("Solicitud enviada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbTypeSite.SelectedIndex = -1;
            cmbDistrict.SelectedIndex = -1;
            for (int i = ckListTypeWaste.CheckedIndices.Count - 1; i >= 0; i--)
            {
                int index = ckListTypeWaste.CheckedIndices[i];
                ckListTypeWaste.SetItemChecked(index, false);
            }
            cmbNeighborhood.SelectedIndex = -1;
            listViewFile.Items.Clear();
            rchtxtAddress.Clear();
        }
        private long idSolicitudSeleccionada = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            idSolicitudSeleccionada =
                Convert.ToInt64(fila.Cells["ID Solicitud"].Value);
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void frmBeta_Load(object sender, EventArgs e)
        {
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
