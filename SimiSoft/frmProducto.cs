using DevExpress.XtraEditors;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
namespace SimiSoft
{
    public partial class frmProducto : DevExpress.XtraEditors.XtraForm
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Inventario().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto
            {
                Text = "Nuevo Producto"
            }.ShowDialog();
            productoBindingSource.DataSource = new Inventario().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto"))
            {
                Text = "Modificar Producto " + (int)gvProductos.GetFocusedRowCellValue("idProducto")
            }.ShowDialog();
            productoBindingSource.DataSource = new Inventario().GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView View = (ColumnView)gcProductos.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if(rhFound > 0) {

                DialogResult result = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Eliminar producto", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {

                    new Inventario
                    {
                        idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto")
                    }.Delete();
                    productoBindingSource.DataSource = new Inventario().GetAll();
                    gvProductos.BestFitColumns();

                }
                else
                {

                }
            }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productoBindingSource.DataSource = new Inventario().GetAll();
            gvProductos.BestFitColumns();
        }
    }
}