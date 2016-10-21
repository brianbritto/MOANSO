using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoNotas {
    class Evaluacion {
        private double nota;

        public double Nota {
            get { return nota; }
            set { nota = value; }
        }

        public Evaluacion(double nota) {
            this.nota = nota;
        }
    }
}
