﻿using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProducto))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Productos ...");

            new frmProducto() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmClientes))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Clientes ...");

            new frmClientes() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVenta))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas ...");

            new frmVenta() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del programa?",
                                 "Cerrar Programa",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVenta))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas ...");

            new frmVenta() { MdiParent = this }.Show();

            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}
