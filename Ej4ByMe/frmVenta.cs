using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej4ByMe
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Shown(object sender, EventArgs e)
        {
            AfterOffice After = ((Form1)this.MdiParent).After;

            comboBox1.DataSource = After.Barriles;
            comboBox1.DisplayMember = "nombre";

            comboBox2.DataSource = After.Recipientes;
            comboBox2.DisplayMember = "nombre";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfterOffice After = ((Form1)this.MdiParent).After;
            After.generarVenta((Barril)comboBox1.SelectedItem,(Recipiente)comboBox2.SelectedItem);
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfterOffice After = ((Form1)this.MdiParent).After;
            Barril barril;
            barril = (Barril)comboBox1.SelectedItem;

            label3.Text = "Precio:" + barril.Cerveza.Precio;

        }
    }
}
