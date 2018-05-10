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
    public partial class Form1 : Form
    {
        public AfterOffice After = new AfterOffice();

        public Form1()
        {
            InitializeComponent();
        }

        private void cargarBarrilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarriles frm = new frmBarriles();
            frm.MdiParent = this;

            frm.Show();
        }

        private void generarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
