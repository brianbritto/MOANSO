using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Principal {
        static void Main(string[] args) {
            Principal principal = new Principal();
            Grupo grupo = principal.registrarGrupo();
            principal.inscribirAlumnos(grupo);
            principal.registrarNotas(grupo);
            principal.reportarNotas(grupo);
        }

        private Grupo registrarGrupo() {
            Console.WriteLine("REGISTRO DEL GRUPO");
            Console.Write("Numero de grupo: ");
            string numerogrupo = Console.ReadLine();
            Console.Write("Fecha de inicio de grupo: ");
            string fechainicio = Console.ReadLine();
            Console.Write("Fecha de fin de grupo: ");
            string fechafin = Console.ReadLine();
            Console.Write("Limite de inscritos del grupo: ");
            int limiteinscritos = int.Parse(Console.ReadLine());
            Console.Write("Nombre del Curso: ");
            string nombrecurso = Console.ReadLine();
            Console.Write("Descripcion del Curso: ");
            string descripcioncurso = Console.ReadLine();
            Console.Write("Nombre del docente: ");
            string nombredocente = Console.ReadLine();
            Console.Write("Profesion del docente: ");
            string profesiondocente = Console.ReadLine();

            Curso curso = new Curso(nombrecurso, descripcioncurso);
            Docente docente = new Docente(nombredocente,profesiondocente);
            Grupo grupo = new Grupo(numerogrupo,fechainicio,fechafin,limiteinscritos,docente,curso);

            return grupo;
        }

        private void inscribirAlumnos(Grupo grupo) {
            Console.WriteLine();
            Console.WriteLine("INSCRIPCION DE ALUMNOS");
            for (int i = 1; i <= grupo.LimiteInscritos; i++) {
                Console.WriteLine("--Item #{0} ---------------", i);
                Console.Write("Fecha de inscripcion: ");
                string fechainscripcion = Console.ReadLine();
                Console.Write("Nombre del alumno : ");
                string nombrealumno = Console.ReadLine();
                Console.Write("DNI del alumno: ");
                string dnialumno = Console.ReadLine();

                Alumno alumno = new Alumno(nombrealumno,dnialumno);
                grupo.agregarInscripcion(fechainscripcion, alumno);

            }
        }

        private void registrarNotas(Grupo grupo) {
            Console.WriteLine();
            Console.WriteLine("REGISTRO DE NOTAS");
            List<Inscripcion> inscripciones = grupo.getInscripciones(); 
            for (int i = 1; i <= grupo.LimiteInscritos; i++) {
                Console.WriteLine("--Item #{0} ---------------", i);
                Alumno alumno = inscripciones[i].Alumno;
                Console.WriteLine("Nombre del alumno: "+alumno.Nombre);
                Console.Write("Nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());

                inscripciones[i].agregarEvaluacion(nota1);
                inscripciones[i].agregarEvaluacion(nota2);

            }
        }

        private void reportarNotas(Grupo grupo) {
            Console.WriteLine();
            Console.WriteLine("REPORTE DEL NOTAS");
            Console.WriteLine("=================");
            Console.WriteLine("Numero de grupo: " + grupo.Numero);
            Console.WriteLine("Nombre del curso: " + grupo.Curso.Nombre);
            Console.WriteLine("Nombre de docente: " + grupo.Docente.Nombre);
            Console.WriteLine();
            Console.WriteLine("LISTA DE ALUMNOS INSCRITOS");
            int i = 0;
            foreach (Inscripcion inscripcion in grupo.getInscripciones()) {
                i++;
                Console.WriteLine("--Item #{0} ---------------", i);
                Console.WriteLine("Nombre del alumno: " + inscripcion.Alumno.Nombre);
                int j = 0;
                foreach (Evaluacion evaluacion in inscripcion.getEvaluaciones()) {
                    j++;
                    Console.WriteLine("Nota "+j+": " + evaluacion.Nota);
                }
                Console.WriteLine("Promedio: " + inscripcion.calcularPromedio());

            }
            Console.WriteLine();
            Console.WriteLine("ESTADISTICA DEL GRUPO");
            Console.WriteLine("Total de alumnos inscritos: " + grupo.calcularTotalInscritos());
            Console.WriteLine("Total de alumnos aprobados: " + grupo.calcularTotalAprobados());
            Console.WriteLine("Total de alumnos desaprobados: " + grupo.calcularTotalDesaprobados());
            Console.WriteLine("Promedio general del grupo: " + grupo.calcularPromedioGeneral());
        }

    }
}
