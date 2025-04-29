using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2POO
{
    internal class Cuadrado
    {
        private string _color;
        private int _lado;
        
        public Cuadrado()
        {
            this.color = "blanco";
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

        public int perimetro
        {
            get { 
                return this.lado * 4; }
        }

        public int superficie
        {
            get { return this.lado * this.lado; }
        }


    }
}
