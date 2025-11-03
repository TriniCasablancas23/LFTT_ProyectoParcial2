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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomcan = nomcantxt.Text;
            string duracion = duracion_can.Text;
            string album = album_can.Text;
            string artista = art_can.Text;
            string anio = anio_can.Text;
            string genero = gen_can.Text;

            if (string.IsNullOrWhiteSpace(nomcan))
            {
                MessageBox.Show("Por favor, introduce el nombre de una canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exito = ConsultasBD.InsertarCancion(nomcan, duracion, album, artista, anio, genero);
            if (exito)
            {
                MessageBox.Show($"'{nomcan}' se añadió a tu playlist en la base de datos.", "Canción Agregada");
            }
            else
            { 
                MessageBox.Show("No se pudo añadir la canción. Revisa la conexión y los datos.", "Error de Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void album_can_TextChanged(object sender, EventArgs e)
        {

        }

        private void art_can_TextChanged(object sender, EventArgs e)
        {

        }

        private void anio_can_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
