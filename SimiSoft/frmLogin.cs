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
	public partial class frmLogin : DevExpress.XtraEditors.XtraForm
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				if (new Usuario
				{
					username = txtUsuario.Text,
					password = txtPassword.Text
				}.Login() != null)
				{
					Misc.actualiza = true;
					XtraMessageBox.Show("Bienvenido", "NeniDB");
					DialogResult = DialogResult.OK;
				}
				else
				{
					XtraMessageBox.Show("Error en las credenciales");
					txtUsuario.EditValue = null;
					txtPassword.EditValue = null;
					txtUsuario.Focus();
				}
			}
		}

		private bool Validar()
		{
			var ban = false;
			if (string.IsNullOrEmpty(txtUsuario.Text))
			{
				txtUsuario.ErrorText = "Ingresa el usuario";
				txtUsuario.Focus();
				ban = true;
			}
			if (string.IsNullOrEmpty(txtPassword.Text))
			{
				txtPassword.ErrorText = "Ingresa la contraseña";
				if (!ban)
				{
					txtPassword.Focus();
					ban = true;
				}
				
			}

			return !ban;
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (Misc.actualiza == false)
				if (XtraMessageBox.Show("¿Desea cerrar el programa?", "Nenisoft",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
		}

    
     

        
    }
}