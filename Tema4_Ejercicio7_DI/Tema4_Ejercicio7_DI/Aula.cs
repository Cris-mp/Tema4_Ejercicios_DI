using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Ejercicio7_DI
{
    enum Asignaturas
    {
        Pociones, Quidditch, Criaturas, ArtesOscuras
    }
    internal class Aula
    {
        static Random rdn = new Random();
        private string[] alumnos;
        public int[,] notas;

        //esto me da alumnos
        public string this[int indice]
        {
            set
            {
                alumnos[indice] = value;
            }
            get
            {
                return alumnos[indice];
            }
        }
        //esto me da notas
        public int this[int alumno, int asignatura]
        {
            set
            {
                notas[alumno, asignatura] = value;
            }
            get
            {
                return notas[alumno, asignatura];
            }
        }

        public string[] Alumnos
        {
            get
            {
                return alumnos;
            }
        }

        public Aula(string[] alumnos)
        {
            notas = new int[alumnos.Length, Enum.GetNames(typeof(Asignaturas)).Length];

            int i = 0;
            this.alumnos = new string[alumnos.Length];

            for (int j = 0; j < notas.GetLength(0); j++)
            {
                for (int k = 0; k < notas.GetLength(1); k++)
                {
                    notas[j, k] = rdn.Next(0, 11);
                }
            }
            foreach (string alumno in alumnos)
            {
                this.alumnos[i++] = alumno.Trim().ToUpper();
            }
        }

        public Aula(string alumnos) : this(alumnos.Split(','))
        {
        }

        public double MediaAula()
        {
            double acu = 0;
            foreach (int nota in notas)
            {
                acu += nota;
            }
            return acu / notas.Length;
        }

        public double MediaAlumno(int indice)
        {
            double suma = 0;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                suma += notas[indice, i];
            }
            return suma / notas.GetLength(1);
        }

        public double MediaAsignatura(int indice)
        {
            double suma = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                suma += notas[i, indice];
            }
            return suma / notas.GetLength(0);
        }


        public void MaxMin(int indice, out int max, out int min)
        {
            max = 0;
            min = 10;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (notas[indice, i] > max)
                {
                    max = notas[indice, i];
                }
                if (notas[indice, i] < min)
                {
                    min = notas[indice, i];
                }

            }
        }
    }
}
