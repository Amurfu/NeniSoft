
namespace SimiSoft
{
    partial class frmPago
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
            this.btnregistrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancela = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSuPago = new DevExpress.XtraEditors.TextEdit();
            this.txtSuCambio = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lupFPago = new DevExpress.XtraEditors.LookUpEdit();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSuPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupFPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(257, 174);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(90, 23);
            this.btnregistrar.TabIndex = 4;
            this.btnregistrar.Text = "Registrar Venta";
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancela.Location = new System.Drawing.Point(12, 174);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 5;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(69, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Total a pagar";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(69, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Su cambio";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(69, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Su pago";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(69, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Forma pago";
            // 
            // txtSuPago
            // 
            this.txtSuPago.Location = new System.Drawing.Point(138, 86);
            this.txtSuPago.Name = "txtSuPago";
            this.txtSuPago.Size = new System.Drawing.Size(121, 20);
            this.txtSuPago.TabIndex = 2;
            this.txtSuPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuPago_KeyPress);
            // 
            // txtSuCambio
            // 
            this.txtSuCambio.Enabled = false;
            this.txtSuCambio.Location = new System.Drawing.Point(138, 128);
            this.txtSuCambio.Name = "txtSuCambio";
            this.txtSuCambio.Size = new System.Drawing.Size(121, 20);
            this.txtSuCambio.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(138, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // lupFPago
            // 
            this.lupFPago.EditValue = "";
            this.lupFPago.Location = new System.Drawing.Point(138, 51);
            this.lupFPago.Name = "lupFPago";
            this.lupFPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupFPago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idFPago", "id FPago", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Forma Pago", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lupFPago.Properties.DataSource = this.formaPagoBindingSource;
            this.lupFPago.Properties.DisplayMember = "descripcion";
            this.lupFPago.Properties.DropDownRows = 5;
            this.lupFPago.Properties.ValueMember = "idFPago";
            this.lupFPago.Size = new System.Drawing.Size(121, 20);
            this.lupFPago.TabIndex = 6;
            this.lupFPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupFPago_KeyPress);
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataSource = typeof(SimiSoft.BML.FormaPago);
            // 
            // frmPago
            // 
            this.AcceptButton = this.btnregistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancela;
            this.ClientSize = new System.Drawing.Size(359, 209);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSuCambio);
            this.Controls.Add(this.txtSuPago);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lupFPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSuPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupFPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnregistrar;
        private DevExpress.XtraEditors.SimpleButton btnCancela;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSuPago;
        private DevExpress.XtraEditors.TextEdit txtSuCambio;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LookUpEdit lupFPago;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
    }
}