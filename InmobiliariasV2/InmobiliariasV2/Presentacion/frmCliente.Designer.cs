
namespace InmobiliariasV2.Presentacion
{
    partial class frmCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdListOrdApll = new System.Windows.Forms.RadioButton();
            this.rbdOrdPorIng = new System.Windows.Forms.RadioButton();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.rbdClienteComprador = new System.Windows.Forms.RadioButton();
            this.rbdClienteVenta = new System.Windows.Forms.RadioButton();
            this.lstClienteComp = new System.Windows.Forms.ListBox();
            this.lstClienteVenta = new System.Windows.Forms.ListBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdListOrdApll);
            this.groupBox1.Controls.Add(this.rbdOrdPorIng);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMensajes);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.rbdClienteComprador);
            this.groupBox1.Controls.Add(this.rbdClienteVenta);
            this.groupBox1.Controls.Add(this.lstClienteComp);
            this.groupBox1.Controls.Add(this.lstClienteVenta);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // rbdListOrdApll
            // 
            this.rbdListOrdApll.AutoSize = true;
            this.rbdListOrdApll.Location = new System.Drawing.Point(209, 325);
            this.rbdListOrdApll.Name = "rbdListOrdApll";
            this.rbdListOrdApll.Size = new System.Drawing.Size(192, 19);
            this.rbdListOrdApll.TabIndex = 22;
            this.rbdListOrdApll.Text = "Clientes ordenados por apellido";
            this.rbdListOrdApll.UseVisualStyleBackColor = true;
            this.rbdListOrdApll.CheckedChanged += new System.EventHandler(this.rbdListOrdApll_CheckedChanged);
            // 
            // rbdOrdPorIng
            // 
            this.rbdOrdPorIng.AutoSize = true;
            this.rbdOrdPorIng.Checked = true;
            this.rbdOrdPorIng.Location = new System.Drawing.Point(12, 325);
            this.rbdOrdPorIng.Name = "rbdOrdPorIng";
            this.rbdOrdPorIng.Size = new System.Drawing.Size(189, 19);
            this.rbdOrdPorIng.TabIndex = 21;
            this.rbdOrdPorIng.TabStop = true;
            this.rbdOrdPorIng.Text = "Clientes ordenados por Ingreso";
            this.rbdOrdPorIng.UseVisualStyleBackColor = true;
            this.rbdOrdPorIng.CheckedChanged += new System.EventHandler(this.rbdOrdPorIng_CheckedChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(129, 146);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 23);
            this.txtCedula.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cedula";
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(43, 167);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(10, 15);
            this.lblMensajes.TabIndex = 18;
            this.lblMensajes.Text = ".";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(326, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(326, 52);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 16;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(326, 87);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(326, 23);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // rbdClienteComprador
            // 
            this.rbdClienteComprador.AutoSize = true;
            this.rbdClienteComprador.Location = new System.Drawing.Point(207, 185);
            this.rbdClienteComprador.Name = "rbdClienteComprador";
            this.rbdClienteComprador.Size = new System.Drawing.Size(86, 19);
            this.rbdClienteComprador.TabIndex = 13;
            this.rbdClienteComprador.Text = "Comprador";
            this.rbdClienteComprador.UseVisualStyleBackColor = true;
            // 
            // rbdClienteVenta
            // 
            this.rbdClienteVenta.AutoSize = true;
            this.rbdClienteVenta.Location = new System.Drawing.Point(43, 185);
            this.rbdClienteVenta.Name = "rbdClienteVenta";
            this.rbdClienteVenta.Size = new System.Drawing.Size(75, 19);
            this.rbdClienteVenta.TabIndex = 12;
            this.rbdClienteVenta.Text = "Vendedor";
            this.rbdClienteVenta.UseVisualStyleBackColor = true;
            // 
            // lstClienteComp
            // 
            this.lstClienteComp.FormattingEnabled = true;
            this.lstClienteComp.ItemHeight = 15;
            this.lstClienteComp.Location = new System.Drawing.Point(207, 210);
            this.lstClienteComp.Name = "lstClienteComp";
            this.lstClienteComp.Size = new System.Drawing.Size(120, 94);
            this.lstClienteComp.TabIndex = 11;
            this.lstClienteComp.Click += new System.EventHandler(this.lstClienteComp_Click);
            // 
            // lstClienteVenta
            // 
            this.lstClienteVenta.FormattingEnabled = true;
            this.lstClienteVenta.ItemHeight = 15;
            this.lstClienteVenta.Location = new System.Drawing.Point(43, 210);
            this.lstClienteVenta.Name = "lstClienteVenta";
            this.lstClienteVenta.Size = new System.Drawing.Size(120, 94);
            this.lstClienteVenta.TabIndex = 10;
            this.lstClienteVenta.Click += new System.EventHandler(this.lstClienteVenta_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(129, 117);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(129, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 363);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.RadioButton rbdClienteComprador;
        private System.Windows.Forms.RadioButton rbdClienteVenta;
        private System.Windows.Forms.ListBox lstClienteComp;
        private System.Windows.Forms.ListBox lstClienteVenta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbdListOrdApll;
        private System.Windows.Forms.RadioButton rbdOrdPorIng;
    }
}