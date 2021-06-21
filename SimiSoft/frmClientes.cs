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
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
       
        public int caso { get; set; }
        public frmClientes()
        {
            InitializeComponent();
         
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            caso=1;
           
            new frmNMCliente
            {
                Text = "Nuevo Cliente"
            }.ShowDialog();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
            
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            caso = 2;
            new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
            {
                Text = "Modificar Cliente " + (int)gvClientes.GetFocusedRowCellValue("idCliente")
            }.ShowDialog();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView View = (ColumnView)gcClientes.FocusedView;
            int rhFound = View.FocusedRowHandle;
            View.FocusedRowHandle = rhFound;
            if (rhFound > 0)
            {

                DialogResult result = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Eliminar Cliente", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) { 

                new Cliente
                {
                    idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente")
                }.Delete();
                clienteBindingSource.DataSource = new Cliente().GetAll();
                gvClientes.BestFitColumns();
                }
                else
                {

                }
            }
        
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }
    }
}