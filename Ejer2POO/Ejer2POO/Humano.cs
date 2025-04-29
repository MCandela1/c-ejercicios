using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2POO
{
    internal class Humano
    {
        //propiedades
        private string _apellido;
        private DateTime _fechanac;
        private string _direccion;

        //constructor
        public Humano()
        {
            this.apellido = "Garcia";
            this.fechanac = DateTime.Today.AddDays(-1);
            this.direccion = string.Empty;
        }

        //constructor
        public Humano (string ape, DateTime fn, string dir)
        {
            this.apellido = ape;
            this.fechanac = fn;
            this.direccion = dir;
        }

        //constructor
        public Humano(string ape, DateTime fn)
        {
            this.apellido = ape;
            this.fechanac = fn;
            this.direccion = string.Empty;
        }

        //metodo de propiedad
        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        //metodo de propiedad
        public DateTime fechanac
        {
            get { return this._fechanac; }
            set {
                if (value < DateTime.Today)
                {
                    this._fechanac = value;
                }
            }
        }

        //metodo de propiedad
        public string direccion
        {
            get { return this._direccion;}
            set { this._direccion = value; }
        }

        public int edad
        {
            get { return DateTime.Today.Year - this.fechanac.Year;}
        }
    }
}
