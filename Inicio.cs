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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaylistArray.PlaylistName = Nombreplay.Text;

            if (string.IsNullOrEmpty(PlaylistArray.PlaylistName))
            {
                MessageBox.Show("Por favor, ingresa un nombre para la playlist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PlaylistArray.PlaylistName = Nombreplay.Text;
            this.Hide();
            Principal Principal = new Principal();
            Principal.ShowDialog();
            this.Close();
        }
    }
}
