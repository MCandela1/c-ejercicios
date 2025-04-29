using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1
{
    internal class persona
    {
        private string _nombre;
        private int _edad;

        public string nombre
        {
            get { return this._nombre;}
            set { this._nombre = value;}
        }

        public int edad
        {
            get { return this._edad;}
            set { 
                if (value > 0 && value < 150)
                {
                    this._edad = value;
                }
            }
        }

    }
}
