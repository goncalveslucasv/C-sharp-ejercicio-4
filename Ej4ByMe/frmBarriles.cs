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
    public partial class frmBarriles : Form
    {
        public frmBarriles()
        {
            InitializeComponent();
        }

        private void frmBarriles_Load(object sender, EventArgs e)
        {

        }

        private void frmBarriles_Shown(object sender, EventArgs e)
        {
            AfterOffice After = ((Form1)this.MdiParent).After;

            listBox1.Items.Add(After.RubiaNacional);
            listBox1.Items.Add(After.NegraNacional);
            listBox1.Items.Add(After.RubiaInternacional);
            listBox1.DisplayMember = "nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfterOffice After = ((Form1)this.MdiParent).After;

            After.crearBarril((Cerveza)listBox1.SelectedItem, float.Parse(textBox1.Text), textBox2.Text);


            listBox2.Items.Clear();
            foreach (var item in After.Barriles)
            {
                listBox2.Items.Add(item);

            }
            listBox2.DisplayMember = "nombre";

            


        }
    }
}
