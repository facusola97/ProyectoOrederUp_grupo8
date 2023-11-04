using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioAdm inicio = new InicioAdm();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "reporte.txt");
            string contenido = "comidas";

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine(contenido);
            }

            MessageBox.Show("Se ha generado el reporte en el escritorio.", "Reporte Generado");
        }
    }
}
