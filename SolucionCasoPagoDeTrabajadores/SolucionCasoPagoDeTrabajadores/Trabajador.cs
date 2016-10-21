using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCasoPagoDeTrabajadores
{
    class Trabajador
    {
        private string nombre;
        private string dni;
        private int horasContratadas;
        private int horasTrabajadas;
        private double pagoHorasContratadas;
        private Planilla planilla;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public int HorasContratadas
        {
            get
            {
                return horasContratadas;
            }

            set
            {
                horasContratadas = value;
            }
        }

        public int HorasTrabajadas
        {
            get
            {
                return horasTrabajadas;
            }

            set
            {
                horasTrabajadas = value;
            }
        }

        public double PagoHorasContratadas
        {
            get
            {
                return pagoHorasContratadas;
            }

            set
            {
                pagoHorasContratadas = value;
            }
        }

        internal Planilla Planilla
        {
            get
            {
                return planilla;
            }

            set
            {
                planilla = value;
            }
        }

        public Trabajador(string nombre,string dni,int horasContratadas, int horasTrabajadas, double pagoHorasContratadas)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.horasContratadas = horasContratadas;
            this.horasTrabajadas = horasTrabajadas;
            this.pagoHorasContratadas = pagoHorasContratadas;
        }

        public double ingresoPorHorasContratadas()
        {
            return HorasContratadas * PagoHorasContratadas;
        }

        public double ingresoPorHorasExtras()
        {
            double horasExtras = 0;
            if (HorasTrabajadas - HorasContratadas > 0)
                horasExtras = HorasTrabajadas - HorasContratadas;

            return horasExtras * 0.5 * PagoHorasContratadas;
        }

        public double ingresoPorAguinaldo()
        {
            double ingresoAguinaldo = 0;
            if (Planilla.Aguinaldo == true)
                ingresoAguinaldo = 0.7 * ingresoPorHorasContratadas();

            return ingresoAguinaldo;
        }

        public double totalDeIngreso()
        {
            double total = ingresoPorHorasContratadas() + ingresoPorHorasExtras() + ingresoPorAguinaldo();

            return total;
        }


    }
}
