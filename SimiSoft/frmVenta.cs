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

namespace SimiSoft
{
    public partial class frmVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMVenta().ShowDialog();
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //new frmNMVenta((int)gvVenta.GetFocusedRowCellValue("idVenta"))
            //{
            //    Text = "Modificar Venta " + (int)gvVenta.GetFocusedRowCellValue("idVenta")
            //}.ShowDialog();
            //ventaBindingSource.DataSource = new Venta().GetAll();
            //gvVenta.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            gvVentas.BestFitColumns();
        }

     
    }
}