using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio6_DI
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string password = "5555";
            int contador = 0;
            Form2 f2 = new Form2();

            do {
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    if (f2.txtPin.Text != password)
                    {
                        contador++;
                        if (contador == 3)
                        {
                            this.Close();
                        }
                        f2.txtPin.Text = "";
                    }
                    
                }
                else
                {
                    this.Close();
                }
            } while (f2.txtPin.Text != password && contador<3);



            int x = 40, y = 80;
            string btns = "123456789*0#";
            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button();
                btn.Text = btns[i].ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(50, 50);
                btn.Enabled = true;
                btn.Tag = false;
                x += 60;
                if ((i + 1) % 3 == 0)
                {
                    x = 40;
                    y += 60;
                }
                btn.Click += btnClick;
                btn.MouseEnter += btnEnter;
                btn.MouseLeave += btnLeave;
                this.Controls.Add(btn);
            }
        }

        private void btnLeave(object sender, EventArgs e)
        {
            if ((bool)((Button)sender).Tag)
            {
                ((Button)sender).BackColor = Color.GreenYellow; 
            } 
            else 
            { 
                ((Button)sender).BackColor = Color.White;
            }
        }

        private void btnEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.BlueViolet;
        }

        private void btnClick(object sender, EventArgs e)
        {
            txtEscritura.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.GreenYellow;
            ((Button)sender).Tag = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEscritura.Text= "";
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.Tag = false;
                    c.BackColor = Color.White;
                }

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReset.PerformClick();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefono (Ejercicio 6 de DI)\nAutor: Cristina Míguez Piñeiro","Acerca de...",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEscritura.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Selección de directorio para almacenar datos";
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = "texto (*.txt)|*.txt|all files | (*.*)";
                saveFileDialog.ValidateNames = true;
                saveFileDialog.OverwritePrompt = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter s;
                    using (s = new StreamWriter(saveFileDialog.FileName, true))
                    {
                        s.WriteLine(this.txtEscritura.Text);
                    }
                }
            }
        }
    }


}
