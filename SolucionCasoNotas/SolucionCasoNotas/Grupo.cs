using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Grupo {
        private string numero;

        public string Numero {
            get { return numero; }
            set { numero = value; }
        }

        private string fechaInicio;

        public string FechaInicio {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        private string fechaFin;

        public string FechaFin {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private int limiteInscritos;

        public int LimiteInscritos {
            get { return limiteInscritos; }
            set { limiteInscritos = value; }
        }

        private Docente docente;

        internal Docente Docente {
            get { return docente; }
            set { docente = value; }
        }

        private Curso curso;

        internal Curso Curso {
            get { return curso; }
            set { curso = value; }
        }

        private List<Inscripcion> inscripciones;

        public Grupo(string numero, string fechaInicio, string fechaFin, int limiteInscritos,Docente docente,Curso curso) {
            this.numero = numero;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.limiteInscritos = limiteInscritos;
            this.docente = docente;
            this.curso = curso;
            inscripciones = new List<Inscripcion>();
        }

        public List<Inscripcion> getInscripciones() {
            return inscripciones;
        }

        public void agregarInscripcion(string fecha, Alumno alumno) {
            inscripciones.Add(new Inscripcion(fecha, alumno));
        }

        public int calcularTotalInscritos() {
            return inscripciones.Count;
        }

        public int calcularTotalAprobados() {
            int totalAprobados = 0;
            foreach (Inscripcion i in inscripciones) {
                if (i.estaAprobado()) {
                    totalAprobados++;
                }                
            }
            return totalAprobados;
        }

        public int calcularTotalDesaprobados() {
            int totalDesaprobados = 0;
            foreach (Inscripcion i in inscripciones) {
                if (!i.estaAprobado()) {
                    totalDesaprobados++;
                }
            }
            return totalDesaprobados;
        }

        public double calcularPromedioGeneral() {
            double suma = 0;
            foreach (Inscripcion i in inscripciones) {
                suma += i.calcularPromedio();
            }
            return suma/calcularTotalInscritos();
        }

    }
}
