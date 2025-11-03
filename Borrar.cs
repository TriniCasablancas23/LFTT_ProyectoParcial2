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
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();
        }

        private void Borrar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string nomcan = nomcantxt.Text;
            if (string.IsNullOrWhiteSpace(nomcan))
            {
                MessageBox.Show("Por favor, introduce el nombre de la canción a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de que quieres eliminar la canción '{nomcan}'? Esta acción es irreversible.",
                                                        "Confirmar Eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = ConsultasBD.EliminarCancion(nomcan);
                if (exito)
                {
                    MessageBox.Show($"'{nomcan}' ha sido eliminada exitosamente de la base de datos.", "Canción Eliminada");
                }
                else
                {
                    MessageBox.Show("No se encontró la canción o hubo un error al intentar eliminarla.", "Error de Eliminación");
                }
            }
            this.Close();
        }
    }
}
