using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio4_DI
{
    public delegate double Operacion(double a, double b);
    public partial class Form1 : Form
    {
        Dictionary<string, Operacion> operaciones;
        double operador1;
        double operador2;
        bool boolOp1;
        bool boolOp2;
        int contador = 0;
        int minutos = 0;
        public Form1()
        {
            InitializeComponent();

            operaciones = new Dictionary<string, Operacion>();
            operaciones.Add("+", (op1, op2) => op1 + op2);
            operaciones.Add("-", (op1, op2) => op1 - op2);
            operaciones.Add("x", (op1, op2) => op1 * op2);
            operaciones.Add("·/·", (op1, op2) => op1 / op2);

        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (boolOp1 && boolOp2)
            {
                lblResultado.Text = string.Format("= {0:0.##}", operaciones[lblSigno.Text](operador1, operador2));
            }
        }

        private void operacion_CheckedChanged(object sender, EventArgs e)
        {
            lblSigno.Text = ((RadioButton)sender).Text;
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(((TextBox)sender).Text, out double num))
            {
                ((TextBox)sender).BackColor = Color.White;
                if (sender == txtOperando1)
                {
                    operador1 = num;
                    boolOp1 = true;
                }
                else
                {
                    operador2 = num;
                    boolOp2 = true;
                }
            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
                if (sender == txtOperando1)
                {
                    boolOp1 = false;
                }
                else
                {
                    boolOp2 = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador % 60 == 0)
            {
                minutos++;
                contador = 0;
            }
            this.Text = string.Format("Calculadora ({0,2:D2}:{1,2:D2})",minutos,contador);
        }
    }
}
