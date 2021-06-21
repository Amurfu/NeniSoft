using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimiSoft
{
    public partial class frmNMVenta : DevExpress.XtraEditors.XtraForm
    {
        private Venta venta;
        public bool R = false;
        private decimal total = 0;
        private int cantidad = 0;

        List<Inventario> listaProductos;

        public frmNMVenta()
        {
            listaProductos = new List<Inventario>();
            SplashScreenManager.ShowDefaultWaitForm("Por favor, espere", "Inicializando nueva venta ...");
            InitializeComponent();
        }

        public frmNMVenta(int idVenta)
        {
            SplashScreenManager.ShowDefaultWaitForm("Por favor, espere", "Inicializando nueva venta ...");
            InitializeComponent();

        }

        private void frmNMVenta_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
        }

        private void frmNMVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (R == false)
                if (XtraMessageBox.Show("¿Desea cerrar el formulario?", "Cerrar ventana",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                int codigo = Int32.Parse(txtCodigo.Text);
                Inventario productoNUevo = Inventario.GetById(codigo);
                if (productoNUevo != null) {
                    agregarProductoLista(productoNUevo);
                } 
                else
                    XtraMessageBox.Show("Producto no encontrado");
                cargarTabla();
                cargarTotal();
            }

        }

        private void cargarTotal()
        {
            if (listaProductos.Count > 0) {
                total = 0;
                cantidad = 0;
                foreach (Inventario obj in listaProductos)
                {
                    total += (obj.precio * obj.cantidad);
                    cantidad += obj.cantidad;
                }

                txtTotal.Text = "$"+total;
                txtCantidad.Text = ""+cantidad;
                txtCantidad.Refresh();
                txtTotal.Refresh();
            }
        }

        private void agregarProductoLista(Inventario productoNUevo)
        {
            Boolean existe = false;
            foreach (Inventario obj in listaProductos)
            {
                if (productoNUevo.idProducto == obj.idProducto) {
                    obj.cantidad++;
                    existe = true;
                }
                    
            }
            if (existe == false) {
                productoNUevo.cantidad = 1;
                listaProductos.Add(productoNUevo);
            }
               
        }

        private void cargarTabla()
        {
            DataTable dt = new DataTable();
            // first add your columns
            for (int i = 0; i < 4; i++)
            {
                dt.Columns.Add();
            }

            // and then add your rows
            foreach (Inventario obj in listaProductos) {
                var row = dt.NewRow();
                row[0] = obj.codigo;
                row[1] = obj.descripcion;
                row[2] = obj.cantidad;
                row[3] = obj.precio;
                dt.Rows.Add(row);
            }

            tablaDatos.DataSource = dt;
            tablaDatos.Refresh();
        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (validar()) {
                generarVenta();
            }
        }

        private void generarVenta()
        {
            DataRowView dataRow = lupCliente.GetSelectedDataRow() as DataRowView;
            Object objeto = lupCliente.EditValue;

            if (objeto != null)
            {
                venta = new Venta();
                venta.idCliente = Convert.ToInt32(objeto.ToString());
                venta.fecha = dtFecha.DateTime;
                venta.cantidad = this.cantidad;
                venta.total = this.total;
                venta.tipoEnvio = cbTipoE.SelectedItem.ToString();
                venta.Add();
                venta.cargarId();
                if (venta.idVenta > 0)
                    guardarListaObjetos();
                XtraMessageBox.Show("Venta generada con exito");
            }
            else {
                XtraMessageBox.Show("nulll");
            }
        }

        private void guardarListaObjetos()
        {
            List<VentaDetalle> listas = new List<VentaDetalle>();
            foreach (Inventario producto in listaProductos) {
                VentaDetalle detalle = new VentaDetalle();
                detalle.idVenta = venta.idVenta;
                detalle.idProducto = producto.idProducto;
                detalle.cantidad = producto.cantidad;
                detalle.precio = producto.precio;
                detalle.total = (producto.precio * producto.cantidad);
                detalle.Add();
            }
        }


        private bool validar()
        {
            return true;
        }

        private void dtFecha_EditValueChanged(object sender, EventArgs e)
        {

        }


        /* private bool Validar()
         {
             var ban = false;
             if (string.IsNullOrEmpty(txtDescripcion.Text))
             {
                 txtDescripcion.ErrorText = "Ingresa la descripción";
                 txtDescripcion.Focus();
                 ban = true;
             }
             if (string.IsNullOrEmpty(txtUnidadMedida.Text))
             {
                 txtUnidadMedida.ErrorText = "Ingresa la unidad de medida";
                 if (!ban)
                 {
                     txtUnidadMedida.Focus();
                     ban = true;
                 }

             }
             if (string.IsNullOrEmpty(txtCodigo.Text))
             {
                 txtCodigo.ErrorText = "Ingresa el código";
                 if (!ban)
                 {
                     txtCodigo.Focus();
                     ban = true;
                 }

             }
             if (string.IsNullOrEmpty(txtPrecio.Text))
             {
                 txtPrecio.ErrorText = "Ingresa el precio";
                 if (!ban)
                 {
                     txtPrecio.Focus();
                     ban = true;
                 }

             }
             if (string.IsNullOrEmpty(txtStock.Text))
             {
                 txtStock.ErrorText = "Ingresa el stock";
                 if (!ban)
                 {
                     txtStock.Focus();
                     ban = true;
                 }

             }
             if (string.IsNullOrEmpty(txtMarca.Text))
             {
                 txtMarca.ErrorText = "Ingresa la marca";
                 if (!ban)
                 {
                     txtMarca.Focus();
                     ban = true;
                 }

             }

             return !ban;
         }
        */
    }
}


//ColumnView View = (ColumnView)gcClientes.FocusedView;
//int rhFound = View.FocusedRowHandle;
//View.FocusedRowHandle = rhFound;
//if (rhFound > 0)
//{
//    new Cliente
//    {
//        idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente")
//    }.Delete();
//    clienteBindingSource.DataSource = new Cliente().GetAll();
//    gvClientes.BestFitColumns();
//}