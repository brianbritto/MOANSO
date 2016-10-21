using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Alumno {
        private string nombre;

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        private string dni;

        public string Dni {
            get { return dni; }
            set { dni = value; }
        }

        public Alumno(string nombre, string dni) {
            this.nombre = nombre;
            this.dni = dni;
        }

    }
}
