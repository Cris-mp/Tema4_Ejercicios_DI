using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio3_DI
{
    public partial class Form2 : Form
    {
        
        public Form2(string imagenPath)
        {
            InitializeComponent();

            try
            {
                this.Text = imagenPath.Substring(imagenPath.LastIndexOf("\\") + 1);
                Image img = new Bitmap(imagenPath);
                this.pbFondo.SizeMode = PictureBoxSizeMode.AutoSize;
                this.pbFondo.Image = img;
                this.ClientSize = img.Size;
                this.pbFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (ArgumentException) {            
            };
            
        }
    }
}
