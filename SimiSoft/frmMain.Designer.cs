﻿
namespace SimiSoft
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mnArchivo = new DevExpress.XtraBars.BarSubItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.mnCatalogos = new DevExpress.XtraBars.BarSubItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentas = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.sbApariencia = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // bManager
            // 
            this.bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.bManager.DockControls.Add(this.barDockControlTop);
            this.bManager.DockControls.Add(this.barDockControlBottom);
            this.bManager.DockControls.Add(this.barDockControlLeft);
            this.bManager.DockControls.Add(this.barDockControlRight);
            this.bManager.Form = this;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnArchivo,
            this.btnSalir,
            this.mnCatalogos,
            this.btnProductos,
            this.btnClientes,
            this.btnVentas,
            this.sbApariencia,
            this.barButtonItem1,
            this.barSubItem2,
            this.barButtonItem2});
            this.bManager.MainMenu = this.bar2;
            this.bManager.MaxItemId = 10;
            this.bManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnArchivo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnCatalogos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.sbApariencia, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // mnArchivo
            // 
            this.mnArchivo.Caption = "Archivo";
            this.mnArchivo.Id = 0;
            this.mnArchivo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnArchivo.ImageOptions.SvgImage")));
            this.mnArchivo.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.mnArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.mnArchivo.Name = "mnArchivo";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 1;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // mnCatalogos
            // 
            this.mnCatalogos.Caption = "Catálogos";
            this.mnCatalogos.Id = 2;
            this.mnCatalogos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnCatalogos.ImageOptions.SvgImage")));
            this.mnCatalogos.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.mnCatalogos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProductos),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClientes),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVentas)});
            this.mnCatalogos.Name = "mnCatalogos";
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 3;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 4;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnVentas
            // 
            this.btnVentas.Caption = "Ventas";
            this.btnVentas.Id = 5;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProveedores_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Ventas";
            this.barSubItem2.Id = 8;
            this.barSubItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem2.ImageOptions.SvgImage")));
            this.barSubItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Administrar";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // sbApariencia
            // 
            this.sbApariencia.Caption = "Apariencia";
            this.sbApariencia.Id = 6;
            this.sbApariencia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbApariencia.ImageOptions.SvgImage")));
            this.sbApariencia.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbApariencia.Name = "sbApariencia";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bManager;
            this.barDockControlTop.Size = new System.Drawing.Size(632, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 257);
            this.barDockControlBottom.Manager = this.bManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(632, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.bManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 232);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(632, 25);
            this.barDockControlRight.Manager = this.bManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 232);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ventas";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tabMdiManager
            // 
            this.tabMdiManager.MdiParent = this;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Ventas";
            this.barSubItem1.Id = 7;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeniSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mnArchivo;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarSubItem mnCatalogos;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnVentas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.SkinBarSubItem sbApariencia;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
    }
}

