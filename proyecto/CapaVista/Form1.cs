using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Newtonsoft.Json;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void MostrarCV_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttp();
            List<CV> Lista = JsonConvert.DeserializeObject<List<CV>>(respuesta);
            Pantalla.DataSource = Lista;
        }
        private async Task<string> GettHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:7169/api/CV");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void MostrarCuotas_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttpCuotas();
            List<Asociados> Lista = JsonConvert.DeserializeObject<List<Asociados>>(respuesta);
            Pantalla.DataSource = Lista;
        }
        private async Task<string> GettHttpCuotas()
        {
            WebRequest request = WebRequest.Create("https://localhost:7169/api/Asociados");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void Asociados_Click(object sender, EventArgs e)
        {
                string respuesta = await GettHttpAsociados();
            List<Cuotas> Lista = JsonConvert.DeserializeObject<List<Cuotas>>(respuesta);
            Pantalla.DataSource = Lista;
        }
        private async Task<string> GettHttpAsociados()
        {
            WebRequest request = WebRequest.Create("https://localhost:7169/api/Cuotas");
        WebResponse response = await request.GetResponseAsync();
        StreamReader leer = new StreamReader(response.
            GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void MostrarAsistencias_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttpAsistencias();
            List<Ofertas> Lista = JsonConvert.DeserializeObject<List<Ofertas>>(respuesta);
            Pantalla.DataSource = Lista;
        }

        private async Task<string> GettHttpAsistencias()
        {
            WebRequest request = WebRequest.Create("https://localhost:7169/api/Ofertas");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.
                GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        

        private async void Eventos_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttpEventos();
            List<Eventos> lista = JsonConvert.DeserializeObject<List<Eventos>>(respuesta);
            Pantalla.DataSource = lista;
        }

        private async Task<string> GetHttpEventos()
        {
            WebRequest request = WebRequest.Create("https://localhost:7169/api/Eventos");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void Ofertas_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttpOfertas();
            List<Ofertas> lista = JsonConvert.DeserializeObject<List<Ofertas>>(respuesta);
            Pantalla.DataSource = lista;
        }
        private async Task<string> GetHttpOfertas()
        {
            WebRequest request = WebRequest.Create("https://localhost:7169/api/Ofertas");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.GetResponseStream());
            return await leer.ReadToEndAsync();
        }
        private void Pantalla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {


        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
}

