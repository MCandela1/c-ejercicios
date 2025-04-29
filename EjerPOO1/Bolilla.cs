using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1
{
    internal class Bolilla
    {
        private int _numero;
        private string _color;

        public int numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public string color
        {
            get { return this._color; }
            set { 
                if (value == "NEGRO" || value == "BLANCO" || value == "ROJO")
                {
                    this._color = value;
                }
            }
        }
    }
}
