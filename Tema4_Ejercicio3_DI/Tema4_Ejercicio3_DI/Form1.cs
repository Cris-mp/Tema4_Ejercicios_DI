using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio3_DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Cristina\\Dropbox\\(DI)Desenvolvemento_de_interfaces\\Tema4_Componentes\\Tema4_Ejercicios\\ImagenesEjercicio3"; //TODO: cambiar esto por una variable de entorno
                openFileDialog.Filter = "jpg files (*.jpg)|*.png|png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 4;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    Form f2 = new Form2(filePath);
                    if (chkModal.Checked)
                    {
                        f2.ShowDialog();
                    }
                    else
                    {
                        f2.Show();
                    }
                }
            }
        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked)
            {
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Finalizar Visor de imágenes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
