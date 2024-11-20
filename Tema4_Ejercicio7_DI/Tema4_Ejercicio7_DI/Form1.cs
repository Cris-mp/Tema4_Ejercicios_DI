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

namespace Tema4_Ejercicio7_DI
{
    public partial class Form1 : Form
    {
        Aula aula;

        public Form1()
        {
            InitializeComponent();

            StreamReader sr;
            using (sr = new StreamReader(Environment.GetEnvironmentVariable("homepath")+"\\alumnos.txt"))
            {
                aula = new Aula(sr.ReadToEnd());
            }

            this.Size = new System.Drawing.Size(625,200+(40*(aula.Alumnos.Length+1)));

            for (int i = 0; i < Enum.GetNames(typeof(Asignaturas)).Length; i++)
            {
                cbxAsignatura.Items.Add(Enum.GetNames(typeof(Asignaturas))[i]);
            }
            for (int i = 0; i < aula.Alumnos.Length; i++)
            {
                cbxAlumno.Items.Add(aula.Alumnos[i]);
            }

            int x = 20, y = 80;
            int j = 0, k=0;
            for (int i = 0; i < (aula.Alumnos.Length+1)*5; i++)
            {
                Label lbl = new Label();

                if (i == 0)
                {
                lbl.Text = "";
                }
                else
                {
                    if (i < 5)
                    {
                        lbl.Text = Enum.GetNames(typeof(Asignaturas))[i-1];
                        lbl.Font = new Font("Comic Sans MS.", 10, FontStyle.Bold);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                        lbl.Text = aula.Alumnos[j];
                        lbl.Font = new Font("Comic Sans MS.", 10, FontStyle.Bold);
                            lbl.TextAlign = ContentAlignment.MiddleRight;
                            j++;
                            k = 0;

                        }
                        else
                        {
                            lbl.Text = aula.notas[j-1, k].ToString();
                            lbl.BackColor = Color.White;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.MouseEnter += Lbl_MouseEnter;
                            lbl.MouseLeave += Lbl_MouseLeave;
                            tlp.SetToolTip(lbl, string.Format("{0}\n{1}",Enum.GetNames(typeof(Asignaturas))[k], aula.Alumnos[j - 1]));
                            k++;
                        }

                    }
                }

                
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(110, 30);
                x += 115;
                if ((i + 1) % 5 == 0)
                {
                    x = 20;
                    y += 40;
                }
                this.Controls.Add(lbl);
            }

            lblMaxMin.Text = string.Format("NOTA MAXIMA Y MINIMA\nMax:\nMin:");
            lblInfo.Text = string.Format("INFORMACIÓN\nMedia tabla: {0:0.00}\nMedia {1}: {2}\nMedia {3}: {4}", aula.MediaAula(),"alumno","","asignatura","");
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.White;
        }

        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Yellow;
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = string.Format("INFORMACIÓN\nMedia tabla: {0:0.00}\n", aula.MediaAula());

            if (cbxAlumno.SelectedItem != null)
            {
                lblInfo.Text += string.Format("Media {0}: {1:0.00}\n", cbxAlumno.SelectedItem.ToString(), aula.MediaAlumno(cbxAlumno.SelectedIndex));
                int max, min;
                aula.MaxMin(cbxAlumno.SelectedIndex, out max,out min);
                lblMaxMin.Text = string.Format("NOTA MAXIMA Y MINIMA\n{2}\nMax: {0}\nMin: {1}",max,min, cbxAlumno.SelectedItem.ToString());
            }
            else
            {
                lblInfo.Text += string.Format("Media {0}: {1}\n", "alumno", "");
            }
            if(cbxAsignatura.SelectedItem != null)
            {
                lblInfo.Text += string.Format("Media {0}: {1:0.00}\n", cbxAsignatura.SelectedItem.ToString(), aula.MediaAsignatura(cbxAsignatura.SelectedIndex));
            }
            else
            {
                lblInfo.Text += string.Format("Media {0}: {1}\n", "asignatura", "");
            }
        }
    }
}
