using Controller;
using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPuntosRegistrados : Form
    {
        public frmPuntosRegistrados()
        {
            InitializeComponent();
            InitializeMap();
            this.Load += PointsRegisteredView_Load;

            this.Shown += frmPuntosRegistrados_Shown;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }
        private void frmPuntosRegistrados_Shown(object? sender, EventArgs e)
        {
            CargarPuntos();
        }
        private void CargarPuntos()
        {
            InformacionSitioController controller =
                new InformacionSitioController();

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

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.DataSource = datosGrid;

            tableLayoutPanel3.Visible = true;
            dataGridView1.Visible = true;

            dataGridView1.BringToFront();
            dataGridView1.Refresh();

            MessageBox.Show(
                $"Datos: {datosGrid.Count}\n" +
                $"Columnas: {dataGridView1.Columns.Count}\n" +
                $"Filas: {dataGridView1.Rows.Count}\n" +
                $"Grid visible: {dataGridView1.Visible}\n" +
                $"Panel visible: {tableLayoutPanel3.Visible}"
            );
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
            InformacionSitioController siteInformation = new InformacionSitioController();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = siteInformation.ViewAllPoints();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];

            if (column.DataPropertyName == nameof(InformacionSitioEntidad.id_Barrio)
                && e.Value is BarrioEntidad neighborhood)
            {
                e.Value = neighborhood.id_Barrio.ToString(); // texto: se muestra correctamente
                e.FormattingApplied = true;
            }
        }
        private async void PointsRegisteredView_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ENTRÓ AL LOAD");

            await wv2Map.EnsureCoreWebView2Async();

            MessageBox.Show("WEBVIEW2 INICIALIZADO");

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
                MessageBox.Show("NAVIGATION COMPLETED");

                if (!args.IsSuccess)
                {
                    MessageBox.Show(
                        "Falló la navegación: " +
                        args.WebErrorStatus
                    );

                    return;
                }

                MessageBox.Show("Voy a cargar los puntos");

                await LoadPointsToMap();
            };

            MessageBox.Show("VOY A NAVEGAR");

            wv2Map.CoreWebView2.Navigate(
                "https://appassets.example/mapa.html"
            );
        }

        private async Task LoadPointsToMap()
        {
            InformacionSitioEntidad siteInformation = new InformacionSitioEntidad();
            List<(InformacionSitioEntidad Sitio, string NombreBarrio)> puntos = new InformacionSitioController().ViewAllPoints();

            MessageBox.Show("Cantidad de puntos encontrados: " + puntos.Count);

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
        {
            // Evita error al tocar encabezados
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            txtIdPoints.Text =
                fila.Cells["Id"].Value?.ToString();

            txtTypeSite.Text =
                fila.Cells["TipoSitio"].Value?.ToString();

            rchtxtAdreess.Text =
                fila.Cells["Direccion"].Value?.ToString();

            txtLatitude.Text =
                fila.Cells["Latitud"].Value?.ToString();

            txtLength.Text =
                fila.Cells["Longitud"].Value?.ToString();

            txtNeighborhood.Text =
                fila.Cells["Barrio"].Value?.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtIdPoints.Text == string.Empty)
                return;

            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad()
            {
                id_InformacionSitio = long.Parse(txtIdPoints.Text),
                tipoSitio = txtTypeSite.Text,
                direccion = rchtxtAdreess.Text,
                latitud = decimal.Parse(txtLatitude.Text),
                length = decimal.Parse(txtLength.Text),
            };

            if (txtTypeSite.Text.Trim() == dataGridView1.CurrentRow.Cells["TipoSitio"].Value.ToString().Trim()
            && rchtxtAdreess.Text.Trim() == dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString().Trim()
            && txtLatitude.Text.Trim() == dataGridView1.CurrentRow.Cells["Longitud"].Value.ToString().Trim()
            && txtLength.Text.Trim() == dataGridView1.CurrentRow.Cells["Latitud"].Value.ToString().Trim())
            {
                MessageBox.Show("No se ha realizado ningún cambio", "Validando actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                new InformacionSitioController().UpdateInformacion(informacionSitio, informacionSitio.id_InformacionSitio);
                MessageBox.Show("Cambios realizados correctamente", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdPoints.Clear();
            txtTypeSite.Clear();
            rchtxtAdreess.Clear();
            txtLatitude.Clear();
            txtLength.Clear();
            txtNeighborhood.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InformacionSitioEntidad informacionSitio = new InformacionSitioEntidad()
            {
                id_InformacionSitio = long.Parse(txtIdPoints.Text),
                tipoSitio = txtTypeSite.Text,
                direccion = rchtxtAdreess.Text,
                latitud = Convert.ToDecimal(txtLatitude.Text),
                length = Convert.ToDecimal(txtLength.Text),
                id_Barrio = int.Parse(txtNeighborhood.Text),
            };


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            if (txtIdPoints.Text == string.Empty)
                return;

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var verificate =
                MessageBox.Show("¨¿Estás seguro que deseas eliminar este punto del mapa?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (verificate == DialogResult.OK)
            {
                // Validar la eliminación del valor de la tabla detalle
                Delete_Details();
                new InformacionSitioController().DeleteInformacion(informacionSitio, informacionSitio.id_InformacionSitio);
                RefreshTable();   
            }

        }

        // Arreglar consulta de SQL (Llave compuesta) 
        private void Delete_Details()
        {
            try
            {
                long id_InformacionSitio = long.Parse(txtIdPoints.Text);
                new InformacionSitioController().GetID_InformacionSitio(id_InformacionSitio);

                List<int> idS_CatalogoResiduos = new DetalleClasificacionSitioController().GetIds_CatalogoResiduosByInformacion(id_InformacionSitio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar los detalles de la clasificación del sitio: " + ex.Message);
            }
            
        }


        private void wv2Map_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
