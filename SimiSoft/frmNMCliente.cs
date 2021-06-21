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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {
        public bool R = false;
        private Cliente cliente;
        public frmNMCliente()
        {
            InitializeComponent();
        }

        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                idCliente = idCliente
            }.GetById();
            txtNombre.Text = cliente.nombre;
       //     txtRazonSocial.Text = cliente.razonSocial;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();
        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresa el teléfono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresa el descuento";
                if (!ban)
                {
                    txtDescuento.Focus();
                    ban = true;
                }

            }

            return !ban;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(cliente == null) 
                { 
                    
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                    // razonSocial = txtRazonSocial.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.Text)
                    }.Add() > 0)
                    {
                       R = true;
                        XtraMessageBox.Show("Cliente Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    cliente.nombre = txtNombre.Text;
                    //cliente.razonSocial = txtRazonSocial.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.Text);                   
                    if (cliente.Update() > 0)
                    {
                        R = true;
                        XtraMessageBox.Show("Cliente Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        frmClientes C = new frmClientes();
        
        private void frmNMCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (R == false)
                if (XtraMessageBox.Show("¿Desea cerrar el formulario?", "Nenisoft-NM",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
        }

        
        

        private void frmNMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}