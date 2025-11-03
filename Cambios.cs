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
    public partial class Cambios : Form
    {
        public Cambios()
        {
            InitializeComponent();
        }

        private void Cambios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cancionnew = rolanew.Text;
            string cancionant = rolant.Text;
            bool canenc = false;

            for (int i = 0; i < PlaylistArray.Playlist.Length; i++)
            {
                if (!string.IsNullOrEmpty(PlaylistArray.Playlist[i]) && PlaylistArray.Playlist[i].Equals(cancionant, StringComparison.OrdinalIgnoreCase))
                {
                    PlaylistArray.Playlist[i] = cancionnew;
                    MessageBox.Show($"'{cancionant}' ha sido cambiada por '{cancionnew}'.", "Canción Cambiada");
                    canenc = true;
                    break;
                }
            }

            if (!canenc)
            {
                MessageBox.Show("No se encontró la canción original.");
            }

            this.Close();
        
    }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
