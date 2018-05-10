using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4ByMe
{
    public class Cerveza
    {
        private string nombre;
        private float precio;
        private int cantidadVentas;
        private float dineroRecaudado;
        private float litrosVendidos;

        public float LitrosVendidos
        {
            get { return litrosVendidos; }
            set { litrosVendidos = value; }
        }


        public float DineroRecaudado
        {
            get { return dineroRecaudado; }
            set { dineroRecaudado = value; }
        }


        public int CantidadVentas
        {
            get { return cantidadVentas; }
            set { cantidadVentas = value; }
        }


        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Cerveza(string nombre)
        {
            this.nombre = nombre;
        }

        



    }
}