using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasLaMejor
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            frmAnulaciones frmA = new frmAnulaciones();
            frmA.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmListadoProductosCompleto frma = new frmListadoProductosCompleto();
            frma.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            frmVentas siquiere = new frmVentas();
            siquiere.Show();
        }
    }
}
