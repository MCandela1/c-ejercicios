using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO6
{
    internal class Rectangulo: figura
    {
        private int _ladoA;
        private int _ladoB;

        public Rectangulo()
        {
            this.colorRelleno = color.blanco;
            this.ladoA = 1;
            this.ladoB = 1;
            this.posicion = ubicacion.centro;
        }

        public Rectangulo(color colorRelleno, int ladoA, int ladoB, ubicacion posicion)
        {
            this.colorRelleno = colorRelleno;
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.posicion = posicion;
        }

        public int ladoA
        {
            get { return this._ladoA; }
            set
            {
                if (value > 0)
                {
                    this._ladoA = value;
                }
            }
        }

        public int ladoB
        {
            get { return this._ladoB; }
            set
            {
                if (value > 0)
                {
                    this._ladoB = value;
                }
            }
        }
    }
}
