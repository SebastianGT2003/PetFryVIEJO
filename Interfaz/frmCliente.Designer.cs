namespace Interfaz
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
            this.tlpFormCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.tlpFormCliente.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFormCliente
            // 
            this.tlpFormCliente.ColumnCount = 2;
            this.tlpFormCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tlpFormCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFormCliente.Controls.Add(this.txtCorreo, 1, 4);
            this.tlpFormCliente.Controls.Add(this.txtNombre, 1, 1);
            this.tlpFormCliente.Controls.Add(this.lblDocumento, 0, 0);
            this.tlpFormCliente.Controls.Add(this.lblNombre, 0, 1);
            this.tlpFormCliente.Controls.Add(this.lblCorreo, 0, 4);
            this.tlpFormCliente.Controls.Add(this.txtDocumento, 1, 0);
            this.tlpFormCliente.Controls.Add(this.flpOpciones, 1, 5);
            this.tlpFormCliente.Controls.Add(this.lblDireccion, 0, 3);
            this.tlpFormCliente.Controls.Add(this.lblTelefono, 0, 2);
            this.tlpFormCliente.Controls.Add(this.txtDireccion, 1, 3);
            this.tlpFormCliente.Controls.Add(this.txtTelefono, 1, 2);
            this.tlpFormCliente.Location = new System.Drawing.Point(14, 16);
            this.tlpFormCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpFormCliente.Name = "tlpFormCliente";
            this.tlpFormCliente.RowCount = 6;
            this.tlpFormCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpFormCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpFormCliente.Size = new System.Drawing.Size(354, 249);
            this.tlpFormCliente.TabIndex = 0;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Location = new System.Drawing.Point(140, 173);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "Correo electrónico de contacto";
            this.txtCorreo.Size = new System.Drawing.Size(211, 27);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(140, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre completo";
            this.txtNombre.Size = new System.Drawing.Size(211, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(47, 10);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(87, 20);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(70, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(51, 167);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(83, 40);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento.Location = new System.Drawing.Point(140, 6);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PlaceholderText = "Número de documento";
            this.txtDocumento.Size = new System.Drawing.Size(211, 27);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // flpOpciones
            // 
            this.flpOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOpciones.Controls.Add(this.btnAgregar);
            this.flpOpciones.Controls.Add(this.btnCancelar);
            this.flpOpciones.Location = new System.Drawing.Point(140, 211);
            this.flpOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpOpciones.Size = new System.Drawing.Size(211, 34);
            this.flpOpciones.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 31);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(30, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(62, 137);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(67, 97);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(140, 133);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Dirección de residencia";
            this.txtDireccion.Size = new System.Drawing.Size(211, 27);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(140, 93);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Número de contacto";
            this.txtTelefono.Size = new System.Drawing.Size(211, 27);
            this.txtTelefono.TabIndex = 3;
            // 
            // frmCliente
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(382, 281);
            this.Controls.Add(this.tlpFormCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar cliente";
            this.tlpFormCliente.ResumeLayout(false);
            this.tlpFormCliente.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpFormCliente;
        private Label lblDocumento;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCorreo;
        private TextBox txtDocumento;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private FlowLayoutPanel flpOpciones;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}