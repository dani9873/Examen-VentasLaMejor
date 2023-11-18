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
    public partial class frmListadoProductosCompleto : Form
    {
        public frmListadoProductosCompleto()
        {
            InitializeComponent();
        }

        private void frmListadoProductosCompleto_Load(object sender, EventArgs e)
        {
            CargoProductos();
        }
        private void CargoProductos()
        {
            string instruccion = "SELECT tblProductos.IdProducto, tblProductos.CodigoProducto, tblProductos.Descripcion AS Producto, tblMarcas.Descripcion AS Marca " +
                                 " FROM tblMarcas INNER JOIN tblProductos ON tblMarcas.IdMarca = tblProductos.IdMarca " +
" WHERE(((tblProductos.Eliminado) = False)); " ;

            BD.conexion.EjecutarSELECT(instruccion);


            if (BD.conexion.DioError)
            {
                MessageBox.Show(BD.conexion.DescripcionError);
            }
            else
            {
                DataTable tabla = BD.conexion.DevolverTabla;
                dgvProductos.DataSource = tabla;
                bsProductos.DataSource = tabla;
            }
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Empty;
            string dato = txtDato.Text.Trim();

            if ( string.IsNullOrEmpty(dato))
            {
                bsProductos.RemoveFilter();
            }
            else
            {
                if (rbCodigo.Checked)
                {
                    filtro = $"CodigoProducto Like '{dato  }*'";
                }
                else
                {
                    filtro = $"Producto Like '{dato  }*'";
                }
                bsProductos.Filter = filtro;
            }
            dgvProductos.DataSource = bsProductos;
        }
    }
}
