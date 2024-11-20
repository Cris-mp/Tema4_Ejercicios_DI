using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio2_DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación de Diseño",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //NOTE:esto me lanza tanto el closed como el Closing
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (byte.TryParse(txtRojo.Text,out byte rojo)&& byte.TryParse(txtAzul.Text, out byte azul)&& byte.TryParse(txtVerde.Text, out byte verde))
            {
                this.BackColor=Color.FromArgb(rojo, verde, azul);
            }
         
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            ptbImagen.ImageLocation = txtPath.Text;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            if (sender == txtPath) 
            {
                this.AcceptButton = btnFondo;
            }
            else
            {
                this.AcceptButton = btnColor;
            }

        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = default;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
                //if (control.GetType() == typeof(PictureBox))
                //{
                //}
            }
                    ptbImagen.ImageLocation = default;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Button.DefaultBackColor;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightGoldenrodYellow;
        }
    }
}
