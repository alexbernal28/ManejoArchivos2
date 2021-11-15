using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoArchivos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //configuracion  de algunos parametros del openFileDialog
            // directorio inicial donde se abrira
            openFileDialog1.InitialDirectory = "C:\\";
            // filtro de archivos.
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

            // codigo para abrir el cuadro de dialogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = openFileDialog1.FileName;
                    textBox1.Text = str_RutaArchivo;
                    string str_textoArchivo = leerArchivo(str_RutaArchivo);
                    textBox2.Text = str_textoArchivo;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public string leerArchivo(string str_ruta)
        {
            string str_textoArchivo = System.IO.File.ReadAllText(@"" + str_ruta);
            return str_textoArchivo;
        }
    }
}
