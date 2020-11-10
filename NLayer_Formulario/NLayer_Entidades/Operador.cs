using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
    public class Operador
    {
        private List<Prestamo> _prestamos;
        private double _comision;
        private double _porcentajeComision;

        public Operador()
        {
            _prestamos = new List<Prestamo>();
        }
        public double Comision
        {
            get {return _comision;}
            set { _comision = value; }
        }

        public double PorcentajeComision
        {
            get
            {
                double interes = 0;
                foreach (Prestamo prestamo in _prestamos)
                {
                    interes = interes + prestamo.CuotaInteres();
                }
                return interes * 0.15;
            }
        }
    }
}
