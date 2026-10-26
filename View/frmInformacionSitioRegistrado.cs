using Controller;
using Microsoft.Web.WebView2.Core;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmInformacionSitioRegistrado : Form
    {
        public frmInformacionSitioRegistrado()
        {
            InitializeComponent();
            InitializeMap();
        }
        private async void InitializeMap()
        {
            try
            {
                // Inicializa el motor de Edge interno en el control
                await wv2Map.EnsureCoreWebView2Async(null);

                // Busca el archivo mapa.html que configuraste en el directorio bin
                string rutaHtml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Maps", "mapa.html");

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
        private async Task LoadPointsToMap()
        {
            if (wv2Map.CoreWebView2 == null)
                return;

            // Obtener puntos desde SQL Server
            var puntos = new InformacionSitioController().MostrarDetalles_PuntosRegistrados();

            var puntosMapa = puntos.Select(p => new
            {
                id_InformacionSitio = p.Item1.id_InformacionSitio,
                tipoSitio = p.Item1.tipoSitio,
                direccion = p.Item1.direccion,
                barrio = p.Item2,
                distrito = p.Item3,
                nombre_Usuario = p.Item4,
                tipoResiduos = p.Item5,
                latitud = p.Item1.latitud,
                longitud = p.Item1.length

            }).ToList();

            string json = JsonSerializer.Serialize(puntosMapa);
            string script = @"
            (function() {
                try {

                    // Verificar que el mapa esté inicializado
                    if (typeof mapa === 'undefined' || !(mapa instanceof L.Map))
                        return 'ERROR: El mapa no está listo';

                    // Eliminar marcadores anteriores
                    if (window.capaPuntosAmbientales) {
                        mapa.removeLayer(window.capaPuntosAmbientales);
                    }

                    window.capaPuntosAmbientales = L.layerGroup().addTo(mapa);

                    const listaPuntos = __PUNTOS__;
                    const limites = [];
                    let agregados = 0;

                    listaPuntos.forEach(function(punto) {

                        var lat = Number(punto.latitud);
                        var lng = Number(punto.longitud);

                        if (!Number.isFinite(lat) || !Number.isFinite(lng)) {
                            console.log('Coordenadas inválidas:', punto);
                            return;
                        }

                        if (lat < -90 || lat > 90 || lng < -180 || lng > 180)
                            return;

                        if (lat === 0 && lng === 0)
                            return;

                        var marker = L.marker([lat, lng])
                            .addTo(window.capaPuntosAmbientales);

                        var contenidoPopup = '';
                        contenidoPopup += '<b>Punto ambiental</b><br>';
                        contenidoPopup += '<b> Usuario asociado:</b> ' + punto.nombre_Usuario + '<br>';
                        contenidoPopup += '<b>Tipo de sitio:</b> ' + punto.tipoSitio + '<br>';
                        contenidoPopup += '<b>Barrio:</b> ' + punto.barrio + '<br>';

                        marker.bindPopup(contenidoPopup);

                        marker.on('click', function() {
                            if (window.chrome && window.chrome.webview) {
                                window.chrome.webview.postMessage(punto);
                            }
                        });

                        limites.push([lat, lng]);
                        agregados++;
                    });

                    mapa.invalidateSize();

                    // Centrar el mapa para mostrar todos los puntos
                    if (limites.length > 0) {
                        mapa.fitBounds(limites, {
                            padding: [40, 40],
                            maxZoom: 15
                        });
                    }

                    return 'Marcadores agregados: ' + agregados +
                           ' de ' + listaPuntos.length;

                } catch (error) {
                    return 'ERROR JAVASCRIPT: ' + error.message;
                }
            })();
            ";

            script = script.Replace("__PUNTOS__", json);

            string respuesta =
                await wv2Map.CoreWebView2.ExecuteScriptAsync(script);

            MessageBox.Show(
                JsonSerializer.Deserialize<string>(respuesta) ?? respuesta
            );
        }
        private bool pointsLoaded = false;
        private async void wv2Map_NavigationCompleted(
            object? sender,
            CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!e.IsSuccess || pointsLoaded)
                return;

            pointsLoaded = true;

            await LoadPointsToMap();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RecibirDatosMapa(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                using JsonDocument documento =
                    JsonDocument.Parse(e.WebMessageAsJson);

                JsonElement punto = documento.RootElement;

                // Obtener información del punto seleccionado
                long idSitio =
                    punto.GetProperty("id_InformacionSitio").GetInt64();

                string tipoSitio =
                    punto.GetProperty("tipoSitio").GetString();

                string barrio = punto.GetProperty("barrio").GetString();

                string distrito = punto.GetProperty("distrito").GetString();

                string direccion =
                    punto.GetProperty("direccion").GetString();

                decimal latitud =
                    punto.GetProperty("latitud").GetDecimal();

                decimal longitud =
                    punto.GetProperty("longitud").GetDecimal();

                string tipoResiduos = punto.GetProperty("tipoResiduos").GetString();

                string nombre_Usuario = punto.GetProperty("nombre_Usuario").GetString();

                txtTipoSitio.Text = tipoSitio;
                txtBarrio.Text = barrio;
                txtDistrito.Text = distrito;
                rchDireccion.Text = direccion;
                rchResiduos.Text = tipoResiduos;
                txtUsuario.Text = nombre_Usuario;

                txtLatitud.Text =
                    latitud.ToString(CultureInfo.InvariantCulture);

                txtLongitud.Text =
                    longitud.ToString(CultureInfo.InvariantCulture);


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar punto: " + ex.Message);
            }
        }

        private async void UserPointsRegisters_Load(object sender, EventArgs e)
        {
            try
            {
                await wv2Map.EnsureCoreWebView2Async();
                wv2Map.CoreWebView2.WebMessageReceived += RecibirDatosMapa;

                // Permitir geolocalización
                wv2Map.CoreWebView2.PermissionRequested += (sender, e) =>
                {
                    if (e.PermissionKind == CoreWebView2PermissionKind.Geolocation)
                    {
                        e.State = CoreWebView2PermissionState.Allow;
                    }
                };

                string carpetaMaps = Path.Combine(
                    Application.StartupPath,
                    "Maps"
                );

                string rutaMapa = Path.Combine(
                    carpetaMaps,
                    "mapa.html"
                );

                if (!File.Exists(rutaMapa))
                {
                    MessageBox.Show(
                        $"No se encontró el mapa en:\n\n{rutaMapa}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                wv2Map.CoreWebView2.SetVirtualHostNameToFolderMapping(
                    "appassets.example",
                    carpetaMaps,
                    CoreWebView2HostResourceAccessKind.Allow
                );

                wv2Map.CoreWebView2.Navigate(
                    "https://appassets.example/mapa.html"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error cargando el mapa:\n" + ex.Message
                );
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
