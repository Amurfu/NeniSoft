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
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {
        private Inventario producto;
        public bool R = false;
        // cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();         
        }
        // cuando es modificar producto
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            producto = new Inventario
            {
                idProducto = idProducto
            }.GetById();
            txtDescripcion.Text = producto.descripcion;
            txtUnidadMedida.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            txtMarca.Text = producto.marca;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    if (new Inventario
                    {
                        descripcion = txtDescripcion.Text,
                        unidadMedida = txtUnidadMedida.Text,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = txtMarca.Text
                    }.Add() > 0)
                    {
                        R = true;
                        XtraMessageBox.Show("Producto Insertado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = txtUnidadMedida.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = txtMarca.Text;
                    if (producto.Update()>0)
                    {
                        R = true;
                        XtraMessageBox.Show("Producto Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                
                
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {

        }

        private bool Validar()
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

        private void frmNMProducto_Load_1(object sender, EventArgs e)
        {

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtUnidadMedida_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmNMProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (R == false)
                if (XtraMessageBox.Show("¿Desea cerrar el formulario?", "Nenisoft-NM",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
        }
    }
    }
