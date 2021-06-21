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
    public partial class frmPago : DevExpress.XtraEditors.XtraForm
    {
        public frmPago()
        {
            InitializeComponent();
        }

        
        private void frmPago_Load(object sender, EventArgs e)
        {

            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            Clean();
            txtTotal.EditValue = Misc.totalPago;
            txtSuPago.EditValue = Misc.totalPago;
            txtSuCambio.EditValue = 0;

        }
        private void Clean()
        {
            txtTotal.EditValue = null;
            txtSuPago.EditValue = null;
            txtSuCambio.EditValue = null;
            lupFPago.EditValue = 1;
        }

        private void txtSuPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (txtSuPago.EditValue != null)
                    if (Convert.ToDecimal(txtSuPago.EditValue) >= Misc.totalPago)
                    {
                        txtSuCambio.EditValue = (Misc.totalPago = Convert.ToDecimal(txtSuPago.EditValue)
                    ) * -1;
                        btnregistrar.Focus();
                    }
        }

        private void lupFPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (lupFPago.EditValue != null)
                    txtSuPago.Focus();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (lupFPago.EditValue == null)
                return;
            Misc.pago = Convert.ToDecimal(txtSuPago.EditValue);
            Misc.idFPago = Convert.ToInt32(lupFPago.EditValue);
            txtSuCambio.EditValue = (Misc.totalPago - Misc.pago) * -1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}