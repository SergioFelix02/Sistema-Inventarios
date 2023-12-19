namespace Sistema_Inventarios
{
    partial class frmFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtDatosPersonales = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboProdFact = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pctFotoProducto = new System.Windows.Forms.PictureBox();
            this.opcionesProd = new System.Windows.Forms.GroupBox();
            this.btnModificarProd = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.totalesProd = new System.Windows.Forms.Panel();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlBtns = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.txtNumLetra = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProducto)).BeginInit();
            this.opcionesProd.SuspendLayout();
            this.totalesProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.controlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.txtDatosPersonales);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 180);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1053, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(844, 67);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(249, 27);
            this.dtpFecha.TabIndex = 12;
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(844, 13);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(203, 27);
            this.txtFolio.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(174, 123);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(568, 52);
            this.txtObservaciones.TabIndex = 10;
            // 
            // txtDatosPersonales
            // 
            this.txtDatosPersonales.BackColor = System.Drawing.SystemColors.Window;
            this.txtDatosPersonales.Enabled = false;
            this.txtDatosPersonales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosPersonales.Location = new System.Drawing.Point(174, 65);
            this.txtDatosPersonales.Multiline = true;
            this.txtDatosPersonales.Name = "txtDatosPersonales";
            this.txtDatosPersonales.ReadOnly = true;
            this.txtDatosPersonales.Size = new System.Drawing.Size(568, 52);
            this.txtDatosPersonales.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCredito);
            this.groupBox1.Controls.Add(this.rdbContado);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(772, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(179, 28);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(87, 25);
            this.rdbCredito.TabIndex = 1;
            this.rdbCredito.Text = "Credito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Checked = true;
            this.rdbContado.Location = new System.Drawing.Point(16, 28);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(100, 25);
            this.rdbContado.TabIndex = 0;
            this.rdbContado.TabStop = true;
            this.rdbContado.Text = "Contado";
            this.rdbContado.UseVisualStyleBackColor = true;
            this.rdbContado.CheckedChanged += new System.EventHandler(this.rdbContado_CheckedChanged);
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(174, 18);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(568, 29);
            this.cboCliente.Sorted = true;
            this.cboCliente.TabIndex = 7;
            this.cboCliente.Text = "Seleccionar Cliente";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(784, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Folio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(784, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos Personales:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboProdFact);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pctFotoProducto);
            this.panel2.Controls.Add(this.opcionesProd);
            this.panel2.Controls.Add(this.totalesProd);
            this.panel2.Controls.Add(this.dgvProductos);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 248);
            this.panel2.TabIndex = 1;
            // 
            // cboProdFact
            // 
            this.cboProdFact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdFact.FormattingEnabled = true;
            this.cboProdFact.Location = new System.Drawing.Point(7, 211);
            this.cboProdFact.Name = "cboProdFact";
            this.cboProdFact.Size = new System.Drawing.Size(279, 29);
            this.cboProdFact.Sorted = true;
            this.cboProdFact.TabIndex = 9;
            this.cboProdFact.Text = "Seleccionar Producto";
            this.cboProdFact.SelectedIndexChanged += new System.EventHandler(this.cboProdFact_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Producto a Facturar:";
            // 
            // pctFotoProducto
            // 
            this.pctFotoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotoProducto.Location = new System.Drawing.Point(844, 188);
            this.pctFotoProducto.Name = "pctFotoProducto";
            this.pctFotoProducto.Size = new System.Drawing.Size(65, 57);
            this.pctFotoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotoProducto.TabIndex = 3;
            this.pctFotoProducto.TabStop = false;
            // 
            // opcionesProd
            // 
            this.opcionesProd.Controls.Add(this.btnModificarProd);
            this.opcionesProd.Controls.Add(this.btnEliminarProd);
            this.opcionesProd.Controls.Add(this.btnAgregarProd);
            this.opcionesProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesProd.ForeColor = System.Drawing.Color.White;
            this.opcionesProd.Location = new System.Drawing.Point(292, 183);
            this.opcionesProd.Name = "opcionesProd";
            this.opcionesProd.Size = new System.Drawing.Size(546, 62);
            this.opcionesProd.TabIndex = 2;
            this.opcionesProd.TabStop = false;
            this.opcionesProd.Text = "Opciones";
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificarProd.Enabled = false;
            this.btnModificarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProd.ForeColor = System.Drawing.Color.Black;
            this.btnModificarProd.Location = new System.Drawing.Point(334, 20);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(95, 33);
            this.btnModificarProd.TabIndex = 2;
            this.btnModificarProd.Text = "Modificar";
            this.btnModificarProd.UseVisualStyleBackColor = false;
            this.btnModificarProd.Click += new System.EventHandler(this.btnModificarProd_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarProd.Enabled = false;
            this.btnEliminarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProd.Location = new System.Drawing.Point(234, 19);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(82, 33);
            this.btnEliminarProd.TabIndex = 1;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregarProd.Enabled = false;
            this.btnAgregarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProd.Location = new System.Drawing.Point(129, 20);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(87, 33);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // totalesProd
            // 
            this.totalesProd.Controls.Add(this.txtSubtotal);
            this.totalesProd.Controls.Add(this.txtDescuento);
            this.totalesProd.Controls.Add(this.txtIva);
            this.totalesProd.Controls.Add(this.txtTotal);
            this.totalesProd.Controls.Add(this.label9);
            this.totalesProd.Controls.Add(this.label8);
            this.totalesProd.Controls.Add(this.label7);
            this.totalesProd.Controls.Add(this.label3);
            this.totalesProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalesProd.ForeColor = System.Drawing.Color.Black;
            this.totalesProd.Location = new System.Drawing.Point(915, 3);
            this.totalesProd.Name = "totalesProd";
            this.totalesProd.Size = new System.Drawing.Size(184, 242);
            this.totalesProd.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(3, 29);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(178, 27);
            this.txtSubtotal.TabIndex = 7;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(3, 89);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(178, 27);
            this.txtDescuento.TabIndex = 6;
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.SystemColors.Window;
            this.txtIva.Enabled = false;
            this.txtIva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(3, 149);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(178, 27);
            this.txtIva.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(3, 209);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(178, 27);
            this.txtTotal.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Descuento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Descripcion,
            this.Cantidad,
            this.Descuento,
            this.Precio,
            this.Importe,
            this.Costo});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProductos.Location = new System.Drawing.Point(3, 3);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProductos.Size = new System.Drawing.Size(906, 178);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEndEdit);
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 350;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descuento
            // 
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle13;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Precio
            // 
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle14;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle15;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Visible = false;
            // 
            // controlBtns
            // 
            this.controlBtns.Controls.Add(this.btnGuardar);
            this.controlBtns.Controls.Add(this.btnEnviar);
            this.controlBtns.Controls.Add(this.btnSalir);
            this.controlBtns.Controls.Add(this.btnImprimir);
            this.controlBtns.Controls.Add(this.btnEliminar);
            this.controlBtns.Controls.Add(this.btnRegistrar);
            this.controlBtns.Controls.Add(this.btnAnterior);
            this.controlBtns.Controls.Add(this.btnSiguiente);
            this.controlBtns.Controls.Add(this.btnUltimo);
            this.controlBtns.Controls.Add(this.btnPrimero);
            this.controlBtns.Location = new System.Drawing.Point(0, 474);
            this.controlBtns.Name = "controlBtns";
            this.controlBtns.Size = new System.Drawing.Size(1103, 68);
            this.controlBtns.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(882, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 62);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Factura";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(994, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 62);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Factura";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(780, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(672, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 32);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(564, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 32);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(456, 15);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 32);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnterior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.Location = new System.Drawing.Point(348, 15);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(87, 32);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Window;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(228, 15);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(99, 32);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "&Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Window;
            this.btnUltimo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimo.Location = new System.Drawing.Point(120, 15);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(87, 32);
            this.btnUltimo.TabIndex = 1;
            this.btnUltimo.Text = "&Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = false;
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrimero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.Black;
            this.btnPrimero.Location = new System.Drawing.Point(12, 15);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(87, 32);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "&Primero";
            this.btnPrimero.UseVisualStyleBackColor = false;
            // 
            // txtNumLetra
            // 
            this.txtNumLetra.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumLetra.Location = new System.Drawing.Point(0, 439);
            this.txtNumLetra.Name = "txtNumLetra";
            this.txtNumLetra.ReadOnly = true;
            this.txtNumLetra.Size = new System.Drawing.Size(1103, 26);
            this.txtNumLetra.TabIndex = 8;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1114, 543);
            this.Controls.Add(this.txtNumLetra);
            this.Controls.Add(this.controlBtns);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion de Ventas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoProducto)).EndInit();
            this.opcionesProd.ResumeLayout(false);
            this.totalesProd.ResumeLayout(false);
            this.totalesProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.controlBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel controlBtns;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtDatosPersonales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbContado;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumLetra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox opcionesProd;
        private System.Windows.Forms.Button btnModificarProd;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.PictureBox pctFotoProducto;
        private System.Windows.Forms.ComboBox cboProdFact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Panel totalesProd;
    }
}