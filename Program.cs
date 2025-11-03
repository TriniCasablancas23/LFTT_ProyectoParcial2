using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LFTT_ProyectoParcial1
{
    static class Program
    {
        /// Programa: LFTT_ProyectoParcial1
        /// Descripcion: En este proyecto se muestra un programa que utiliza el Famoso 'ABC'
        /// el cual es Altas, Bajas, Cambios, Consultas y que esta ambientado a una
        /// Playlist de reproduccion
        /// Autor: Liev Fabricio Torres Trinidad
        /// Fecha: 21/Sep/2025
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());

        }
    }
}