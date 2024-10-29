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

        private async void MostrarRoles_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttp();
            List<Roles> Lista = JsonConvert.DeserializeObject<List<Roles>>(respuesta);
            Pantalla.DataSource = Lista;
        }
        private async Task<string> GettHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:7126/api/Roles/Listar");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void MostrarCurso_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttpCursos();
            List<Curso> Lista = JsonConvert.DeserializeObject<List<Curso>>(respuesta);
            Pantalla.DataSource = Lista;
        }
        private async Task<string> GettHttpCursos()
        {
            WebRequest request = WebRequest.Create("https://localhost:7126/api/Curso/Listar");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void Tareas_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttpTareas();
            List<Tarea> Lista = JsonConvert.DeserializeObject<List<Tarea>>(respuesta);
            Pantalla.DataSource = Lista;
        }
        private async Task<string> GettHttpTareas()
        {
            WebRequest request = WebRequest.Create("https://localhost:7126/api/Tareas/Listar");
        WebResponse response = await request.GetResponseAsync();
        StreamReader leer = new StreamReader(response.
            GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private async void MostrarUsuarios_Click(object sender, EventArgs e)
        {
            string respuesta = await GettHttpUsuarios();
            List<Usuarios> Lista = JsonConvert.DeserializeObject<List<Usuarios>>(respuesta);
            Pantalla.DataSource = Lista;
        }

        private async Task<string> GettHttpUsuarios()
        {
            WebRequest request = WebRequest.Create("https://localhost:7126/api/Usuarios/Listar");
            WebResponse response = await request.GetResponseAsync();
            StreamReader leer = new StreamReader(response.
                GetResponseStream());
            return await leer.ReadToEndAsync();
        }

        private void Pantalla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

