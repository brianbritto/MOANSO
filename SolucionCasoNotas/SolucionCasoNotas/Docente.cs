using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Docente {
        private string nombre;

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        private string profesion;

        public string Profesion {
            get { return profesion; }
            set { profesion = value; }
        }

        public Docente(string nombre, string profesion) {
            this.nombre = nombre;
            this.profesion = profesion;
        } 
        
    }
}
