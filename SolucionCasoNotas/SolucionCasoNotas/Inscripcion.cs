using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Inscripcion {
        private string fecha;

        public string Fecha {
            get { return fecha; }
            set { fecha = value; }
        }

        private Alumno alumno;

        internal Alumno Alumno {
            get { return alumno; }
            set { alumno = value; }
        }

        private List<Evaluacion> evaluaciones;

        public Inscripcion(string fecha, Alumno alumno) {
            this.fecha = fecha;
            this.alumno = alumno;
            evaluaciones = new List<Evaluacion>();
        }

        public List<Evaluacion> getEvaluaciones() {
            return evaluaciones;
        }

        public void agregarEvaluacion(double nota) {
            evaluaciones.Add(new Evaluacion(nota));
        }

        public double calcularPromedio() {
            double suma = 0;
            foreach (Evaluacion e in evaluaciones) {
                suma += e.Nota;
            }

            return suma / evaluaciones.Count;
        }

        public bool estaAprobado() {
            return calcularPromedio() >= 12;
        }
        
    }
}
