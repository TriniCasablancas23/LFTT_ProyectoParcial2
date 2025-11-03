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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            NombrePlay.Text = "Bienvenido a tu playlist '" + PlaylistArray.PlaylistName + "'";
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void IrAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar Agregar = new Agregar();
            Agregar.ShowDialog();
            this.Show();
        }

        private void IrConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas Consultas = new Consultas();
            Consultas.ShowDialog();
            this.Show();
        }

        private void IrCambiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cambios Cambios = new Cambios();
            Cambios.ShowDialog();
            this.Show();
        }

        private void IrBorrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrar Borrar = new Borrar();
            Borrar.ShowDialog();
            this.Show();
        }

        private void salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
