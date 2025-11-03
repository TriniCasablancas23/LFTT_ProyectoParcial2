using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFTT_ProyectoParcial1
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string nomcan = nomcantxt.Text;
            if (string.IsNullOrWhiteSpace(nomcan))
            {
                MessageBox.Show("Por favor, introduce el nombre de la canción a buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_cancion.Text = "";
            duracion_can.Text = "";
            Album_can.Text = "";
            art_can.Text = "";
            anio_can.Text = "";
            gen_can.Text = "";
            DataTable dtResultado = ConsultasBD.BuscarCancion(nomcan);
            if (dtResultado != null && dtResultado.Rows.Count > 0)
            {
                DataRow cancion = dtResultado.Rows[0];
                id_cancion.Text = cancion["id"].ToString();
                duracion_can.Text = cancion["Duracion"].ToString();
                Album_can.Text = cancion["Album"].ToString();
                art_can.Text = cancion["Artista"].ToString();
                anio_can.Text = cancion["Anio"].ToString();
                gen_can.Text = cancion["Genero"].ToString();

                MessageBox.Show($"¡Se encontró la canción '{nomcan}'!", "Canción Encontrada");
            }
            else
            {
                MessageBox.Show($"No se encontró la canción '{nomcan}' en la base de datos.", "Canción No Encontrada");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(id_cancion.Text, out int idCancion))
            {
                MessageBox.Show("Primero debes buscar y cargar una canción para actualizar (el campo ID no es válido).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nomcan = nomcantxt.Text;
            string duracion = duracion_can.Text;
            string album = Album_can.Text;
            string artista = art_can.Text;
            string anio = anio_can.Text;
            string genero = gen_can.Text;
            if (string.IsNullOrWhiteSpace(nomcan))
            {
                MessageBox.Show("El nombre de la canción no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool exito = ConsultasBD.ActualizarCancion(idCancion, nomcan, duracion, album, artista, anio, genero);
            if (exito)
            {
                MessageBox.Show($"La canción '{nomcan}' (ID: {idCancion}) se ha actualizado correctamente.", "Actualización Exitosa");
                btnConsulta_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la canción. Revisa la conexión o si los datos cambiaron.", "Error de Actualización");
            }
        }
    }
}
