using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using Controller;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
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
        private string connectionString = "Server=localhost;Database=Eco_Community;Trusted_Connection=True;TrustServerCertificate=True;";
        public frmPuntosRegistrados()
        {
            InitializeComponent();
            InicializarMapa();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }


        private async void InicializarMapa()
        {
            try
            {
                // Inicializa el motor de Edge interno en el control
                await wv2Map.EnsureCoreWebView2Async(null);

                // Busca el archivo mapa.html que configuraste en el directorio bin
                string rutaHtml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mapa.html");

                if (!File.Exists(rutaHtml))
                {
                    MessageBox.Show("No se encontró el archivo mapa.html en: " + rutaHtml, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Carga el mapa en pantalla
                wv2Map.CoreWebView2.Navigate(rutaHtml);

                // EVENTO CLAVE: Cuando el HTML termine de cargar por completo, inyectamos los datos
                wv2Map.NavigationCompleted += async (s, e) =>
                {
                    if (e.IsSuccess)
                    {
                        // Esperamos un segundo extra para asegurar que window.onload corrió en el navegador
                        await Task.Delay(1000);
                        await LoadPointsToMap();
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el mapa: " + ex.Message);
            }

        }
        public void RefreshTable()
        {
            InformacionSitioEntidad siteInformation = new InformacionSitioEntidad();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // dataGridView1.DataSource = siteInformation.ViewAllPoints();
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

        private async Task LoadPointsToMap()
        {
            

            List<(InformacionSitioEntidad, string)> puntos = new InformacionSitioController().ViewAllPoints();
            List<CatalogoResiduosEntidad> waste = new CatalogoResiduosController().ViewAllWaste();

            MessageBox.Show("Cantidad de puntos encontrados: " + puntos.Count);
            

            var puntosMapa = puntos.Select(p => new
            {
                p.Item1,
                p.Item2

                /*                puntos -- Funcionamiento de items, al ser una tupla de datos, los items identifican sin la necesidad de desenvolver el objeto completo
                 ├── [0]
                 │    ├── Item1 → InformacionSitioEntidad
                 │    └── Item2 → "Managua"
                 │
                 ├── [1]
                 │    ├── Item1 → InformacionSitioEntidad
                 │    └── Item2 → "Masaya"
                 │
                 └── [2]
                      ├── Item1 → InformacionSitioEntidad
                      └── Item2 → "Tipitapa"puntos
                 ├── [0]
                 │    ├── Item1 → InformacionSitioEntidad
                 │    └── Item2 → "Managua"
                 │
                 ├── [1]
                 │    ├── Item1 → InformacionSitioEntidad
                 │    └── Item2 → "Masaya"
                 │
                 └── [2]
                      ├── Item1 → InformacionSitioEntidad
                      └── Item2 → "Tipitapa"*/

            }).ToList();

            var catalog = waste.Select(w => new
            {
                w.tipoResiduo
            }).ToList();

            var datosMapa = new
            {
                Points = puntosMapa,
                WasteCatalog = catalog
            };

            string json = JsonSerializer.Serialize(datosMapa);

            string script = $@"
                var datosMapa = {json};

                var listaPuntos = datosMapa.Points;
                var catalogoResiduos = datosMapa.WasteCatalog;

                var tiposResiduos = catalogoResiduos
                    .map(function(residuo) {{
                        return residuo.TypeWaste;
                    }})
                    .join(', ');

                listaPuntos.forEach(function(punto) {{
                    var lat = Number(punto.Latitude);
                    var lng = Number(punto.Length);

                    if (isNaN(lat) || isNaN(lng)) {{
                        console.log('Coordenadas inválidas:', punto);
                        return;
                    }}

                    var marker = L.marker([lat, lng]).addTo(mapa);

                    var contenidoPopup = '';
                    contenidoPopup += '<b>Punto ambiental</b><br>';
                    contenidoPopup += '<b>ID:</b> ' + punto.IdSiteInformation + '<br>';
                    contenidoPopup += '<b>Tipo:</b> ' + punto.TypeSite + '<br>';
                    contenidoPopup += '<b>Dirección:</b> ' + punto.Address + '<br>';
                    contenidoPopup += '<b>Barrio:</b> ' + punto.NeighborhoodName + '<br>';
                    contenidoPopup += '<b>Tipos de Residuos:</b> ' + tiposResiduos + '<br>';
                    contenidoPopup += '<b>Latitud:</b> ' + punto.Latitude + '<br>';
                    contenidoPopup += '<b>Longitud:</b> ' + punto.Length;

                    marker.bindPopup(contenidoPopup);
                }});

        mapa.invalidateSize();
    ";

            await wv2Map.CoreWebView2.ExecuteScriptAsync(script);
        }

        private async void PointsRegisteredView_Load(object sender, EventArgs e)
        {
            InformacionSitioEntidad points = new InformacionSitioEntidad();
            await wv2Map.EnsureCoreWebView2Async();

            wv2Map.CoreWebView2.PermissionRequested += (sender, e) =>
            {
                if (e.PermissionKind == CoreWebView2PermissionKind.Geolocation)
                {
                    e.State = CoreWebView2PermissionState.Allow;
                }
            };

            string carpetaHtml = Application.StartupPath;

            wv2Map.CoreWebView2.SetVirtualHostNameToFolderMapping(
                "appassets.example",
                carpetaHtml,
                CoreWebView2HostResourceAccessKind.Allow
            );

            wv2Map.CoreWebView2.Navigate("https://appassets.example/Mapa.html");

            InformacionSitioEntidad pointsTable = new InformacionSitioEntidad();


            dataGridView1.AutoGenerateColumns = true;
          //  dataGridView1.DataSource = pointsTable.ViewAllPoints();

            dataGridView1.Columns["NeighborhoodId"].Visible = false;
            dataGridView1.Columns["NeighborhoodName"].HeaderText = "Barrio";
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InformacionSitioEntidad selectedPoint = (InformacionSitioEntidad)dataGridView1.CurrentRow.DataBoundItem;
            txtNeighborhood.Text = new BarrioController().ObtenerNombreBarrio(selectedPoint.id_Barrio);

            txtIdPoints.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtTypeSite.Text = dataGridView1.SelectedCells[1].Value.ToString();
            rchtxtAdreess.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtLatitude.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtLength.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdPoints.Text == string.Empty)
                return;

            if (txtTypeSite.Text.Trim() == dataGridView1.CurrentRow.Cells["TypeSite"].Value.ToString().Trim()
            && rchtxtAdreess.Text.Trim() == dataGridView1.CurrentRow.Cells["Address"].Value.ToString().Trim()
            && txtLatitude.Text.Trim() == dataGridView1.CurrentRow.Cells["Length"].Value.ToString().Trim()
            && txtLength.Text.Trim() == dataGridView1.CurrentRow.Cells["Latitude"].Value.ToString().Trim())
            {
                MessageBox.Show("No se ha realizado ningún cambio", "Validando actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /*
            try
            {
                using UpdateCommand updateCommand = new UpdateCommand();
                string sql = @"Update InformacionSitio SET tipoSitio = @TypeSite, direccion = @Address, 
                latitud = @Latitude, length = @Length WHERE id_InformacionSitio = @IdSiteInformation";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@IdSiteInformation", SqlDbType.BigInt) {Value = txtIdPoints.Text },
                new SqlParameter("@TypeSite", SqlDbType.VarChar, 80) {Value = txtTypeSite.Text},
                new SqlParameter("@Address", SqlDbType.VarChar, 500) {Value = rchtxtAdreess.Text},
                new SqlParameter("@Latitude", SqlDbType.Decimal) {Value = txtLatitude.Text},
                new SqlParameter("Length", SqlDbType.Decimal) {Value = txtLength.Text}
                };

                int result = updateCommand.ExecuteUpdate(sql, parameters);
                MessageBox.Show("Cambios realizados correctamente", "Cambios realizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "No se pudo actualizar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
                int id = int.Parse(txtIdPoints.Text);
                int detailsSite = Delete_Details(id);
                /*
                try
                {
                    using DeleteCommand deleteCommand = new DeleteCommand();
                    string sql = @"Delete FROM informacionSitio 
                     WHERE id_InformacionSitio = @IdSiteInformation";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@IdSiteInformation", SqlDbType.BigInt) {Value = txtIdPoints.Text}
                    };


                    int result = deleteCommand.ExecuteDelete(sql, parameters);
                    MessageBox.Show("Punto eliminado correctamente", "Eliminación de punto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar este punto: " + ex.Message, "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

        }
        private int Delete_Details(int id)
        {/*
            try
            {
                using DeleteCommand deleteCommand = new DeleteCommand();
                string sql = @"DELETE FROM DetalleClasificacionSitio 
                    WHERE id_InformacionSitio = @IdSiteInformation";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@IdSiteInformation", SqlDbType.Int)
                    {
                        Value = id
                    }
                };

                int rowsAffected = deleteCommand.ExecuteDelete(sql, parameters);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la información del sitio: " + ex.Message);
            }*/
            return 0;
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
