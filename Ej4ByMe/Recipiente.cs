using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4ByMe
{
    public class Recipiente
    {

        protected string nombre;
        protected Cerveza cerveza;
        protected float capacidad;
        protected int cantidadVendida;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;}
        }

        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }


        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        public Cerveza Cerveza
        {
            get { return cerveza; }
            set { cerveza = value; }
        }


    }
}