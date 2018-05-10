using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4ByMe
{
    public class AfterOffice
    {



        #region props

        private List<Recipiente> recipientes = new List<Recipiente>();
        private List<Venta> ventas = new List<Venta>();
        private List<Barril> barriles = new List<Barril>();
        private Cerveza rubiaNacional;
        private Cerveza negraNacional;
        private Cerveza rubiaInternacional;

        private float recaudacion;
        private int cantidadVentas;


        public List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }
        public List<Recipiente> Recipientes
        {
            get { return recipientes; }
            set { recipientes = value; }
        }

        public Cerveza RubiaNacional
        {
            get { return rubiaNacional; }
        }
        public Cerveza NegraNacional
        {
            get { return negraNacional; }
        }
        public Cerveza RubiaInternacional
        {
            get { return rubiaInternacional; }
        }
        public int CantidadVentas
        {
            get { return cantidadVentas; }
            set { cantidadVentas = value; }
        }


        public float Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }

        public List<Barril> Barriles
        {
            get { return barriles; }
            set { barriles = value; }
        }
        #endregion



        public AfterOffice()
        {
            rubiaNacional = new Cerveza("Rubia Nacional");
            rubiaNacional.Precio = 50;
            negraNacional = new Cerveza("Negra nacional");
            negraNacional.Precio = 58;
            rubiaInternacional = new Cerveza("Rubia internacional");
            rubiaNacional.Precio = 65;

            Chopp chopp = new Chopp();
            chopp.Nombre = "Chopp";
            chopp.Capacidad = 0.75f;
            Vaso vaso = new Vaso();
            vaso.Nombre = "Vaso";
            vaso.Capacidad = 0.5f;
            Jarra jarra = new Jarra();
            jarra.Nombre = "Jarra";
            jarra.Capacidad = 3.0f;

            recipientes.Add(chopp);
            recipientes.Add(vaso);
            recipientes.Add(jarra);





        }

        public Barril crearBarril(Cerveza cerveza, float capacidad, string nombre)
        {
            Barril barril = new Barril();
            barril.Nombre = nombre;
            barril.Cerveza = cerveza;
            barril.Capacidad = capacidad;
            barriles.Add(barril);

            return barril;
        }


        public void generarVenta(Barril barril, Recipiente vaso) {

            this.recaudacion += vaso.Capacidad * barril.Cerveza.Precio;

            Venta venta = new Venta();
            venta.Barril = barril;
            venta.Recipiente = vaso;
            venta.registrarVenta();

            ventas.Add(venta);
        }

    }
}