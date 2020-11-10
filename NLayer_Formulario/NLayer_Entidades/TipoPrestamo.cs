using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
   
    public class TipoPrestamo
    {
        private string _linea;
        private double _tna;

    
        public string Linea
        {
            get { return this._linea; }
            set { this._linea = value; }
        }

        public double Tna
        {
            get { return this._tna; }
            set { this._tna = value; }
        }
        public override string ToString()
        {
            return _linea + "TNA: " + _tna + "%";
        }
    }
}
