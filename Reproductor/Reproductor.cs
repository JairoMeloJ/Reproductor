using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Reproductor : Form
    {
        private string ruta = "";

        public Reproductor() => InitializeComponent();

        private void Biblioteca_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                Video.Text = ruta;
                axWindowsMediaPlayer1.URL = ruta;
            }
        }
    }
}
