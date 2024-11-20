#define CHAR_
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio1_DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
#if CHAR
            this.KeyPress += Form1_KeyPress;
#else
            this.KeyDown += Form1_KeyDown;
#endif
            int x = 10;
            int y = 180;
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.Location = new Point(x, y);
                x += 80;
                if ((i + 1) % 5 == 0)
                {
                    x = 10;
                    y += 50;
                }
                //NOTE: El MouseClick solo se utiliza cuando quieres hacer que
                //responda solo al raton, LO HABITUAL ES USAR CLICK.
                btn.MouseMove += Form1_MouseMove;
                btn.Click += BotonesCreados_Click;
                this.Controls.Add(btn);
            }
        }

        private void BotonesCreados_Click(object sender, EventArgs e)
        {
            this.Text = ((Button)sender).Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //este this se refiere al formulario
            if (sender == this)
            {
                this.Text = "x:" + e.Location.X + ", y:" + e.Location.Y;
            }
            else
            {
                this.Text = "x:" + (((Button)sender).Location.X + e.Location.X) + ", y:" + (((Button)sender).Location.Y + e.Location.Y);
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = Color.Aqua;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = Color.Aqua;
            }
            else
            {
                btnIzquierdo.BackColor = Color.Aqua;
                btnDerecho.BackColor = Color.Aqua;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = default;
            }
            else if (e.Button == MouseButtons.Right)
            {
                btnDerecho.BackColor = default;
            }
            else
            {
                btnIzquierdo.BackColor = default;
                btnDerecho.BackColor = default;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Escape))
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyChar.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mouse Tester", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
