using DevExpress.XtraEditors;
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
        public frmNMVenta()
        {

            InitializeComponent();
        }

        public frmNMVenta(int idVenta)
        {
            InitializeComponent();
            venta = new Venta
            {
                idVenta = idVenta
            }.GetById();
            txtId.Text = venta.idVenta.ToString();
            dtFecha.Text = venta.fecha.ToString("MM / dd / yyyy");
            txtTotal.Text = venta.total.ToString();
            cbTipoE.Text = venta.tipoEnvio;
        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
             
          
            }
        
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(dtFecha.Text))
            {
                dtFecha.ErrorText = "Ingresa la fecha";
                dtFecha.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.ErrorText = "Ingresa el total";
                if (!ban)
                {
                    txtTotal.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(cbTipoE.Text))
            {
                cbTipoE.ErrorText = "Ingresa un tipo de envio";
                if (!ban)
                {
                    cbTipoE.Focus();
                    ban = true;
                }

            }

            return !ban;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                if (venta == null)
                {
                    if (new Venta
                    {

                        fecha = Convert.ToDateTime(dtFecha.Text),
                        total = Convert.ToDecimal(txtTotal.Text),
                        tipoEnvio = cbTipoE.Text
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    venta.fecha = Convert.ToDateTime(dtFecha.Text);
                    venta.total = Convert.ToDecimal(txtTotal.Text);
                    venta.tipoEnvio = cbTipoE.Text;

                    if (venta.Update() > 0)
                    {
                        XtraMessageBox.Show("Venta Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

            }

        }
        // public List<int> valores_permitidos = new List<int>() { 1,2,3,4,5,6,7,8,9,10,21, 13, 37, 38, 39, 40, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 46 };
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (txtTotal.Text.Contains("."))
                {
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        e.Handled = true;
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTotal.Text))
                    {
                        if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        string n = Convert.ToString(txtTotal.Text.Length);
                        int cant = Convert.ToInt32(n);
                        if (cant == 4)
                        {
                            if (!char.IsControl(e.KeyChar) && e.KeyChar != '.')
                            {
                                e.Handled = true;
                            }
                            else
                            {
                                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                            }
                        }
                        else
                        {

                            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                            {
                                e.Handled = true;
                            }
                        }

                    }
                }
            }
            }

        private void frmNMVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( MessageBox.Show("Desea cerrar el formulario?",
                                 "Salir",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }

}
