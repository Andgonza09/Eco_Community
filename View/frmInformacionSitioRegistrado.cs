using Microsoft.Web.WebView2.Core;
using Model.Eco_Community;
using Controller;

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

        private async void UserPointsRegisters_Load(object sender, EventArgs e)
        {
            try
            {
                await wv2Map.EnsureCoreWebView2Async();

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
