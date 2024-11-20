using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tema4_Ejercicio5_DI
{
    public partial class Form1 : Form
    {
        string nombre;
        int contador;
        Icon icono1;
        Icon icono2;
        public Form1()
        {
            InitializeComponent();
            nombre = this.Text;
            contador = nombre.Length;
            icono1 = Properties.Resources.icoMouse;
            icono2 = Properties.Resources.tomberi;
            this.Icon = icono1;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (!lbxA.Items.Contains(txtAnadir.Text))
            {
                lbxA.Items.Add(txtAnadir.Text);
            }
            lbxA_Count();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = lbxA.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbxA.Items.RemoveAt(lbxA.SelectedIndices[i]);
                
            }
            lbxA_Count();
        }

        private void btnAtoB_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lbxA.SelectedIndices.Count; i++)
            {
                lbxB.Items.Add(lbxA.SelectedItems[i]);
            }
            for (int i = lbxA.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbxA.Items.Remove(lbxA.SelectedItems[i]);
            }
            lbxA_Count();
            tool.SetToolTip(this.lbxB, "Elementos: "+lbxB.Items.Count);
        }

        private void btbBtoA_Click(object sender, EventArgs e)
        {
            if (lbxB.SelectedItem != null)
            {
                lbxA.Items.Add(lbxB.SelectedItem);
                lbxB.Items.Remove(lbxB.SelectedItem);
                lbxA_Count();
            }
            tool.SetToolTip(this.lbxB, "Elementos: " + lbxB.Items.Count);

        }

        private void lbxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIndices.Text = "Indices Selecionados: ";
            foreach (var item in lbxA.SelectedIndices)
            {
                lblIndices.Text += item.ToString()+", ";
            }
            lblIndices.Text = lblIndices.Text.Trim().Trim(',');
        }

        private void lbxA_Count()
        {
            lblElementos.Text = "Elementos: " + lbxA.Items.Count;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = nombre.Substring(contador);
            if (contador == 0)
            {
                contador = nombre.Length - 1;

                if (this.Icon == icono1)
                {
                    this.Icon = icono2;
                }
                else
                {
                    this.Icon = icono1;
                }
            }
            contador--;
           
        }
    }
}
