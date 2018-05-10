using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4ByMe
{
    public class Barril
    {

        private Cerveza cerveza;
        private float litrosServido;
        private float dineroRecaudado;
        private float capacidad;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        public float DineroRecaudado
        {
            get { return dineroRecaudado; }
            set { dineroRecaudado = value; }
        }


        public float LitrosServido
        {
            get { return litrosServido; }
            set { litrosServido = value; }
        }

        public Cerveza Cerveza
        {
            get { return cerveza; }
            set { cerveza = value; }
        }
    }
}