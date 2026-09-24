using Controller;
using Microsoft.Web.WebView2.Core;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace View
{
    public partial class frmPuntoRegistrados : Form
    {
        public frmPuntoRegistrados()
        {
            InitializeComponent();
            InitializeMap();
            this.Load += form1_Load;
            dgvPuntos.CellFormatting += dataGridView1_CellFormatting;
            dgvPuntos.CellClick += dataGridView1_CellClick;
            this.Shown += frmPuntosRegistrados_Shown;

            dgvPuntos.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvPuntos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dgvPuntos.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private async void InitializeMap()
        {
            try
            {
                string rutaHtml = Path.Combine(
                    AppContext.BaseDirectory,
                    "Maps",
                    "mapa.html"
                );

                if (!File.Exists(rutaHtml))
                {
                    MessageBox.Show(
                        $"No se encontró mapa.html.\n\nRuta buscada:\n{rutaHtml}",
                        "Archivo no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                await wv2Map.EnsureCoreWebView2Async();

                wv2Map.Source = new Uri(rutaHtml, UriKind.Absolute);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefreshTable()
        {
            CargarPuntos();
        }
        private void frmPuntosRegistrados_Shown(object? sender, EventArgs e)
        {
            CargarPuntos();
        }
        private void CargarPuntos()
        {
            InformacionSitioController controller = new InformacionSitioController();

            var datos = controller.ViewAllPoints();

            var datosGrid = datos.Select(x => new
            {
                Id = x.Item1.id_InformacionSitio,
                TipoSitio = x.Item1.tipoSitio,
                Direccion = x.Item1.direccion,
                Latitud = x.Item1.latitud,
                Longitud = x.Item1.length,
                Barrio = x.Item2
            }).ToList();

            dgvPuntos.DataSource = null;
            dgvPuntos.Columns.Clear();

            dgvPuntos.AutoGenerateColumns = true;
            dgvPuntos.DataSource = datosGrid;

            dgvPuntos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPuntos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPuntos.RowHeadersVisible = false;

            dgvPuntos.BackgroundColor = Color.White;
            dgvPuntos.BorderStyle = BorderStyle.None;

            dgvPuntos.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPuntos.ColumnHeadersHeight = 38;
            dgvPuntos.RowTemplate.Height = 34;

            dgvPuntos.Visible = true;

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvPuntos.Columns[e.ColumnIndex];

            if (column.DataPropertyName == nameof(InformacionSitioEntidad.id_Barrio)
                && e.Value is BarrioEntidad neighborhood)
            {
                e.Value = neighborhood.id_Barrio.ToString(); // texto: se muestra correctamente
                e.FormattingApplied = true;
            }
        }
        private async void form1_Load(object sender, EventArgs e)
        {
            await wv2Map.EnsureCoreWebView2Async();

            string carpetaHtml = Path.Combine(
                Application.StartupPath,
                "Maps"
            );

            wv2Map.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "appassets.example",
                carpetaHtml,
                CoreWebView2HostResourceAccessKind.Allow
            );

            wv2Map.CoreWebView2.NavigationCompleted += async (s, args) =>
            {

                if (!args.IsSuccess)
                {
                    MessageBox.Show(
                        "Falló la navegación: " +
                        args.WebErrorStatus
                    );

                    return;
                }

                await LoadPointsToMap();
            };

            wv2Map.CoreWebView2.Navigate(
                "https://appassets.example/mapa.html"
            );
        }

        private async Task LoadPointsToMap()
        {
            InformacionSitioEntidad siteInformation = new InformacionSitioEntidad();
            List<(InformacionSitioEntidad Sitio, string NombreBarrio)> puntos = new InformacionSitioController().ViewAllPoints();

            var puntosMapa = puntos.Select(p => new
            {
                p.Sitio.id_InformacionSitio,
                p.Sitio.tipoSitio,
                p.Sitio.direccion,
                p.Sitio.id_Barrio,
                p.Sitio.latitud,
                p.Sitio.length
            }).ToList();

            string json = JsonSerializer.Serialize(puntosMapa);

            string script = $@"
            var listaPuntos = {json};

            listaPuntos.forEach(function(punto) {{

                var lat = Number(punto.latitud);
                var lng = Number(punto.length);

                if (isNaN(lat) || isNaN(lng)) {{
                    console.log('Coordenadas inválidas:', punto);
                    return;
                }}

                var marker = L.marker([lat, lng]).addTo(mapa);

                var contenidoPopup = '';
                contenidoPopup += '<b>Punto ambiental</b><br>';
                contenidoPopup += '<b>ID:</b> ' + punto.id_InformacionSitio + '<br>';
                contenidoPopup += '<b>Tipo:</b> ' + punto.tipoSitio + '<br>';
                contenidoPopup += '<b>Dirección:</b> ' + punto.direccion + '<br>';
                contenidoPopup += '<b>Barrio:</b> ' + punto.id_Barrio + '<br>';
                contenidoPopup += '<b>Latitud:</b> ' + punto.latitud + '<br>';
                contenidoPopup += '<b>Longitud:</b> ' + punto.length;

                marker.bindPopup(contenidoPopup);
            }});

            mapa.invalidateSize();";

            await wv2Map.CoreWebView2.ExecuteScriptAsync(script);
        }


        private bool pointsLoaded = false;
        private async void wv2Map_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!e.IsSuccess || pointsLoaded)
                return;

            pointsLoaded = true;

            await Task.Delay(1000);

            await LoadPointsToMap();
        }
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {// Evita error al tocar encabezados
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvPuntos.Rows[e.RowIndex];

            txtIdPunto.Text =
                fila.Cells["Id"].Value?.ToString();

            textBox1.Text =
                fila.Cells["TipoSitio"].Value?.ToString();

            txtDireccion.Text =
                fila.Cells["Direccion"].Value?.ToString();

            txtLatitud.Text =
                fila.Cells["Latitud"].Value?.ToString();

            txtLongitud.Text =
                fila.Cells["Longitud"].Value?.ToString();

            txtBarrio.Text =
                fila.Cells["Barrio"].Value?.ToString();
        }


        // Arreglar consulta de SQL (Llave compuesta) 
        private void Delete_Details()
        {
            try
            {
                long id_InformacionSitio = long.Parse(txtIdPunto.Text);
                new InformacionSitioController().GetID_InformacionSitio(id_InformacionSitio);

                List<int> idS_CatalogoResiduos = new DetalleClasificacionSitioController().GetIds_CatalogoResiduosByInformacion(id_InformacionSitio);
                new DetalleClasificacionSitioController().DeleteDetailsClasificacion(id_InformacionSitio, idS_CatalogoResiduos);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar los detalles de la clasificación del sitio: " + ex.Message);
            }

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtIdPunto.Clear();
            textBox1.Clear();
            txtDireccion.Clear();
            txtLatitud.Clear();
            txtLongitud.Clear();
            txtBarrio.Clear();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPunto.Text))
            {
                MessageBox.Show("Seleccione un sitio primero.");
                return;
            }

            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad()
            {
                id_InformacionSitio = long.Parse(txtIdPunto.Text)
            };


            dgvPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuntos.MultiSelect = false;

            if (txtIdPunto.Text == string.Empty)
                return;

            if (dgvPuntos.SelectedRows.Count == 0)
                return;

            var verificate =
                MessageBox.Show("¨¿Estás seguro que deseas eliminar este punto del mapa?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (verificate == DialogResult.OK)
            {
                // Validar la eliminación del valor de la tabla detalle de sitios (Información sitio y usuarios)
                new DetalleSitiosController().Delete(informacionSitio.id_InformacionSitio);

                // Eliminación de clasificación de sitios (Información sitio y catálogo de residuos)
                Delete_Details();

                // Obtener el id de la solicitud asociado con el sitio
                long id_Solicitud = new SolicitudesController().GetID_Solicitud(informacionSitio.id_InformacionSitio);

                // Eliminación de archivos asociados con la solicitud del usuario.
                new MultimediaController().DeleteMultimedia(id_Solicitud);

                // Eliminación de solicitudes asociadas con el sitio 
                new SolicitudesController().DeletebyInformacionSitio(informacionSitio.id_InformacionSitio);


                // Eliminación de información del sitio 
                new InformacionSitioController().DeleteInformacion(informacionSitio, informacionSitio.id_InformacionSitio);
                MessageBox.Show("Registro eliminado correctamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIdPunto.Clear();
            textBox1.Clear();
            txtDireccion.Clear();
            txtLatitud.Clear();
            txtLongitud.Clear();
            txtBarrio.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdPunto.Text == string.Empty)
                return;

            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad()
            {
                id_InformacionSitio = long.Parse(txtIdPunto.Text),
                tipoSitio = textBox1.Text,
                direccion = txtDireccion.Text,
                latitud = decimal.Parse(txtLatitud.Text),
                length = decimal.Parse(txtLongitud.Text),
            };

            if (textBox1.Text.Trim() == dgvPuntos.CurrentRow.Cells["TipoSitio"].Value.ToString().Trim()
            && txtDireccion.Text.Trim() == dgvPuntos.CurrentRow.Cells["Direccion"].Value.ToString().Trim()
            && txtLongitud.Text.Trim() == dgvPuntos.CurrentRow.Cells["Longitud"].Value.ToString().Trim()
            && txtLatitud.Text.Trim() == dgvPuntos.CurrentRow.Cells["Latitud"].Value.ToString().Trim())
            {
                MessageBox.Show("No se ha realizado ningún cambio", "Validando actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                var verificate = MessageBox.Show("¨¿Estás seguro que deseas actualizar este punto del mapa?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (verificate == DialogResult.OK)
                {
                    new InformacionSitioController().UpdateInformacion(informacionSitio, informacionSitio.id_InformacionSitio);
                    MessageBox.Show("Cambios realizados correctamente", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtIdPunto.Clear();
            textBox1.Clear();
            txtDireccion.Clear();
            txtLatitud.Clear();
            txtLongitud.Clear();
            txtBarrio.Clear();
            dgvPuntos.ClearSelection();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtIdPunto.Text == string.Empty)
                return;
            if (txtLatitud.Text == "" || txtLongitud.Text == "" || txtLatitud.Text == "-" || txtLongitud.Text == "-")
            {
                MessageBox.Show(
                    "Ingrese una latitud y longitud válidas",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad()
            {
                id_InformacionSitio = long.Parse(txtIdPunto.Text),
                tipoSitio = textBox1.Text,
                direccion = txtDireccion.Text,
                latitud = decimal.Parse(txtLatitud.Text),
                length = decimal.Parse(txtLongitud.Text),
            };

            if (textBox1.Text.Trim() == dgvPuntos.CurrentRow.Cells["TipoSitio"].Value.ToString().Trim()
            && txtDireccion.Text.Trim() == dgvPuntos.CurrentRow.Cells["Direccion"].Value.ToString().Trim()
            && txtLongitud.Text.Trim() == dgvPuntos.CurrentRow.Cells["Longitud"].Value.ToString().Trim()
            && txtLatitud.Text.Trim() == dgvPuntos.CurrentRow.Cells["Latitud"].Value.ToString().Trim())
            {
                MessageBox.Show("No se ha realizado ningún cambio", "Validando actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                var verificate = MessageBox.Show("¨¿Estás seguro que deseas actualizar este punto del mapa?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (verificate == DialogResult.OK)
                {
                    new InformacionSitioController().UpdateInformacion(informacionSitio, informacionSitio.id_InformacionSitio);
                    MessageBox.Show("Cambios realizados correctamente", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                    dgvPuntos.ClearSelection();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPunto.Text))
            {
                MessageBox.Show("Seleccione un sitio primero.");
                return;
            }

            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad()
            {
                id_InformacionSitio = long.Parse(txtIdPunto.Text)
            };


            dgvPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuntos.MultiSelect = false;

            if (txtIdPunto.Text == string.Empty)
                return;

            if (dgvPuntos.SelectedRows.Count == 0)
                return;

            var verificate =
                MessageBox.Show("¨¿Estás seguro que deseas eliminar este punto del mapa?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (verificate == DialogResult.OK)
            {
                // Validar la eliminación del valor de la tabla detalle de sitios (Información sitio y usuarios)
                new DetalleSitiosController().Delete(informacionSitio.id_InformacionSitio);

                // Eliminación de clasificación de sitios (Información sitio y catálogo de residuos)
                Delete_Details();

                // Obtener el id de la solicitud asociado con el sitio
                long id_Solicitud = new SolicitudesController().GetID_Solicitud(informacionSitio.id_InformacionSitio);

                // Eliminación de archivos asociados con la solicitud del usuario.
                new MultimediaController().DeleteMultimedia(id_Solicitud);

                // Eliminación de solicitudes asociadas con el sitio 
                new SolicitudesController().DeletebyInformacionSitio(informacionSitio.id_InformacionSitio);


                // Eliminación de información del sitio 
                new InformacionSitioController().DeleteInformacion(informacionSitio, informacionSitio.id_InformacionSitio);
                MessageBox.Show("Registro eliminado correctamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
                dgvPuntos.ClearSelection();
            }
        }
        private void grpAcciones_Enter(object sender, EventArgs e)
        {

        }

        private void pnlListadoHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wv2Map_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
