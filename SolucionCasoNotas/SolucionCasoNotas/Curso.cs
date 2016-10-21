using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Curso {
        private string nombre;

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;

        public string Descripcion {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Curso(string nombre, string descripcion) {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        
    }
}
