using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1Bis
{
    internal class Cuadrado
    {
        private string _color;
        private int _lado;

        public Cuadrado()
        {
            this.color = "Blanco";
            this.lado = 10;
        }

        public Cuadrado(string col, int lad)
        {
            this.color = col;
            this.lado = lad;
        }

        public string color
        {
            get { return this._color; }
            set { 
                if (value == "negro" || value == "blanco" || value == "rojo")
                {
                    this._color = value;
                }
            } 
        }

        public int lado
        {
            get { return this._lado; }
            set {
                if (value > 0)
                {
                    this._lado = value;
                }
            }
        }


    }
}
