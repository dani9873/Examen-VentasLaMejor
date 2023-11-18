using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaIEACLA;

namespace VentasLaMejor
{
    
    public partial class frmVentas : Form
    {
        int _idCliente = 0, _idProducto = 0, _existencia = 0 ;
        double _precio = 0;

        private void frmVentas_Load(object sender, EventArgs e)
        {
            txtCodigoVenta.Text = ObtenerCodigoVentas();
            txtFecha.Value = DateTime.Today;
            txtNIT.Focus();
            txtNIT.Select();
        }

        private void txtNIT_Leave(object sender, EventArgs e)
        {
            string nitBuscar = txtNIT.Text.Trim();

            if (string.IsNullOrEmpty(nitBuscar))
            {
                txtNombre.Clear();
                txtDireccion.Clear();
                _idCliente = 0;
                return;
            }

            string instruccion = "SELECT tblClientes.IdCliente, tblClientes.NIT, [tblClientes].[Apellidos]+', '+[tblClientes].[Nombres] AS NombreCompleto, tblClientes.Direccion " +
                                 " FROM tblClientes " +
                                 $"WHERE(((tblClientes.NIT) ='{nitBuscar}') AND((tblClientes.Eliminado) = False));  ";

            BD.conexion.EjecutarSELECT(instruccion);

            if (BD.conexion.DioError)
            {
                MessageBox.Show(BD.conexion.DescripcionError);
            }
            else
            {
                DataTable tabla = BD.conexion.DevolverTabla;
                if (tabla != null)
                {
                    if (tabla.Rows.Count > 0)
                    {
                        _idCliente = int.Parse(tabla.Rows[0]["IdCliente"].ToString());
                        txtNombre.Text = tabla.Rows[0]["NombreCompleto"].ToString();
                        txtDireccion.Text = tabla.Rows[0]["Direccion"].ToString();
                        txtCodigoProducto.Select();
                        txtCodigoProducto.Focus();              
                    }
                    else
                    {
                        txtNombre.Clear();
                        txtDireccion.Clear();
                        _idCliente = 0;
                        MessageBox.Show("El NIT no existe");
                        txtNIT.Select();
                        txtNIT.Focus();
                    }
                }
                else
                {
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    _idCliente = 0;
                    MessageBox.Show("El NIT no existe");
                    txtNIT.Select();
                    txtNIT.Focus();
                }
                
            }
        }
        private void LimpiarDatosProductos()
        {
            _idProducto = 0;
            txtCantidad.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            lblTotal.Text = string.Format("{0:###,##0.00}");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtCodigoProducto.Text.Trim();
            string instruccion = string.Empty;
            if (string.IsNullOrEmpty(codigoBuscar))
            {
                LimpiarDatosProductos();
                return;
            }
            instruccion = "SELECT tblProductos.IdProducto, tblProductos.CodigoProducto, tblProductos.Descripcion AS Producto, tblProductos.Precio, tblProductos.Existencia " +
" FROM tblProductos " +
$"WHERE(((tblProductos.CodigoProducto) ='{codigoBuscar}') AND((tblProductos.Eliminado) = False));";
            BD.conexion.EjecutarSELECT(instruccion);

            if (BD.conexion.DioError)
            {
                MessageBox.Show(BD.conexion.DescripcionError);
            }
            else
            {
                DataTable tabla = BD.conexion.DevolverTabla;
                if (tabla != null)
                {
                    if (tabla.Rows.Count > 0)
                    {
                        _idProducto = int.Parse(tabla.Rows[0]["IdProducto"].ToString());
                        txtProducto.Text = tabla.Rows[0]["Producto"].ToString();
                        txtPrecio.Text = string.Format("{ 0:###,##0.00}", double.Parse(tabla.Rows[0]["Precio"].ToString()));
                        _existencia = int.Parse(tabla.Rows[0]["Existencia"].ToString());
                        _precio = double.Parse(tabla.Rows[0]["Precio"].ToString());
                        lblTotal.Text = string.Format("{0:###,##0.00}", 0);
                        txtCantidad.Select();
                        txtCantidad.Focus();
                    }
                    else
                    {
                        LimpiarDatosProductos();
                        MessageBox.Show("El codigo de producto no existe");
                        txtNIT.Select();
                        txtNIT.Focus();
                    }
                }
                else
                {
                    LimpiarDatosProductos();
                    MessageBox.Show("El codigo de producto no existe");
                    txtNIT.Select();
                    txtNIT.Focus();
                }

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                lblTotal.Text = string.Format("{0:###,##0.00}", 0);
            }
            else
            {
                if (_existencia < double.Parse(txtCantidad.Text))
                {
                    MessageBox.Show("No hay suficiente existencia");
                    lblTotal.Text = string.Format("{0:###,##0.00}", 0);
                    txtCantidad.Clear();
                    txtCantidad.Select();
                    txtCantidad.Focus();
                    return;
                }
                double total = _precio * double.Parse(txtCantidad.Text);
                lblTotal.Text = "Q" + string.Format("{0:###,##0.00}", total);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_idCliente != 0 && _idProducto != 0 && int.Parse(txtCantidad.Text) != 0 )
            {
                campoBaseDeDatos campoCodigoVenta = new campoBaseDeDatos();
                campoCodigoVenta.ValorCampo = txtCodigoVenta.Text.Trim();
                campoCodigoVenta.TipoCampo = tipoCampo.texto;
                campoCodigoVenta.NombreCampo = "CodigoVenta";

                campoBaseDeDatos CampoIdcliente = new campoBaseDeDatos();
                CampoIdcliente.ValorCampo = _idProducto.ToString();
                campoCodigoVenta.TipoCampo = tipoCampo.texto;
                CampoIdcliente.NombreCampo = "IdProducto";

                campoBaseDeDatos campoIpProducto = new campoBaseDeDatos();
                campoIpProducto.ValorCampo = txtCodigoVenta.Text.Trim();
                campoIpProducto.TipoCampo = tipoCampo.texto;
                campoIpProducto.NombreCampo = "CodigoVenta";

                campoBaseDeDatos campoCodigoVenta = new campoBaseDeDatos();
                campoCodigoVenta.ValorCampo = txtCodigoVenta.Text.Trim();
                campoCodigoVenta.TipoCampo = tipoCampo.texto;
                campoCodigoVenta.NombreCampo = "CodigoVenta";

                campoBaseDeDatos campoCodigoVenta = new campoBaseDeDatos();
                campoCodigoVenta.ValorCampo = txtCodigoVenta.Text.Trim();
                campoCodigoVenta.TipoCampo = tipoCampo.texto;
                campoCodigoVenta.NombreCampo = "CodigoVenta";

                BD.conexion.AsignarDatos("tblVentas");
            }
        }

        public frmVentas()
        {
            InitializeComponent();
        }

        private string ObtenerCodigoVentas()
        {
            int cv = 0;
            string CodigoVenta = string.Empty;
            BD.conexion.DevolverUnDato("tblVentas", "CodigoVentas","IdVentas>0");

            CodigoVenta = BD.conexion.DatoDevuelto;
            if (string.IsNullOrEmpty(CodigoVenta))
            {
                cv = 1;
            }
            else
            {
                cv = int.Parse(CodigoVenta) + 1;
            }
            CodigoVenta = cv.ToString();

            return CodigoVenta;
                
        }

    }
}
