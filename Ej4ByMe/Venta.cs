using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4ByMe
{
    public class Venta
    {
        private Barril barril;
        private Recipiente recipiente;

        public Recipiente Recipiente
        {
            get { return recipiente; }
            set { recipiente = value; }
        }


        public Barril Barril
        {
            get { return barril; }
            set { barril = value; }
        }

        public void registrarVenta()
        {
            barril.DineroRecaudado = recipiente.Capacidad * barril.Cerveza.Precio;
            barril.LitrosServido -= recipiente.Capacidad;
            barril.Cerveza.DineroRecaudado += recipiente.Capacidad * barril.Cerveza.Precio;
            barril.Cerveza.CantidadVentas++;
            barril.Cerveza.LitrosVendidos += recipiente.Capacidad;

            barril.Cerveza.Precio = barril.Cerveza.Precio * 1.05f;  
        }




    }
}