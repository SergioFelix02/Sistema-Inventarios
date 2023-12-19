namespace Sistema_Inventarios
{
    partial class frmProductos
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
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecio3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCant3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCant2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCant1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.cboLinea = new System.Windows.Forms.ComboBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboVA = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(250, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "Descuento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.btnPrimero);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 428);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(831, 85);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(745, 27);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 37);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(640, 27);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 37);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(535, 27);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(430, 27);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 37);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(325, 27);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(105, 37);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.White;
            this.btnAnterior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.Location = new System.Drawing.Point(220, 27);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(105, 37);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.White;
            this.btnUltimo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimo.Location = new System.Drawing.Point(115, 27);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(105, 37);
            this.btnUltimo.TabIndex = 1;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.White;
            this.btnPrimero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.Black;
            this.btnPrimero.Location = new System.Drawing.Point(10, 27);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(105, 37);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(251, 214);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(185, 27);
            this.txtDescuento.TabIndex = 32;
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(30, 214);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(187, 27);
            this.txtCosto.TabIndex = 27;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(30, 137);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(405, 27);
            this.txtDescripcion.TabIndex = 26;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(30, 62);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 27);
            this.txtId.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 267);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 19);
            this.label12.TabIndex = 49;
            this.label12.Text = "Precio de Lista:";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio1.Location = new System.Drawing.Point(30, 295);
            this.txtPrecio1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(187, 27);
            this.txtPrecio1.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(247, 267);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "Precio de Mayoreo:";
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio2.Location = new System.Drawing.Point(252, 295);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(184, 27);
            this.txtPrecio2.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(463, 270);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 19);
            this.label14.TabIndex = 53;
            this.label14.Text = "Precio de Menudeo:";
            // 
            // txtPrecio3
            // 
            this.txtPrecio3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio3.Location = new System.Drawing.Point(468, 298);
            this.txtPrecio3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio3.Name = "txtPrecio3";
            this.txtPrecio3.Size = new System.Drawing.Size(181, 27);
            this.txtPrecio3.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Nombre Corto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(254, 62);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 27);
            this.txtNombre.TabIndex = 54;
            // 
            // imgProducto
            // 
            this.imgProducto.Location = new System.Drawing.Point(700, 26);
            this.imgProducto.Margin = new System.Windows.Forms.Padding(4);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(138, 117);
            this.imgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProducto.TabIndex = 56;
            this.imgProducto.TabStop = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.White;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.Black;
            this.BtnAceptar.Location = new System.Drawing.Point(700, 146);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(138, 38);
            this.BtnAceptar.TabIndex = 57;
            this.BtnAceptar.Text = "Abrir Foto";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Valor Agregado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(679, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "Caducidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Cantidad Reorden:";
            // 
            // txtCant3
            // 
            this.txtCant3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant3.Location = new System.Drawing.Point(465, 373);
            this.txtCant3.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant3.Name = "txtCant3";
            this.txtCant3.Size = new System.Drawing.Size(184, 27);
            this.txtCant3.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Cantidad Min:";
            // 
            // txtCant2
            // 
            this.txtCant2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant2.Location = new System.Drawing.Point(251, 370);
            this.txtCant2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant2.Name = "txtCant2";
            this.txtCant2.Size = new System.Drawing.Size(185, 27);
            this.txtCant2.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cantidad Max:";
            // 
            // txtCant1
            // 
            this.txtCant1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant1.Location = new System.Drawing.Point(30, 370);
            this.txtCant1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant1.Name = "txtCant1";
            this.txtCant1.Size = new System.Drawing.Size(187, 27);
            this.txtCant1.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(463, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "Linea:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(463, 188);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 19);
            this.label15.TabIndex = 71;
            this.label15.Text = "Existencia:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(465, 217);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(184, 27);
            this.txtExistencia.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(679, 196);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 73;
            this.label16.Text = "Ubicacion:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(681, 224);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(170, 27);
            this.txtUbicacion.TabIndex = 72;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(461, 111);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 19);
            this.label17.TabIndex = 75;
            this.label17.Text = "Proveedor";
            // 
            // dtpCaducidad
            // 
            this.dtpCaducidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCaducidad.Location = new System.Drawing.Point(684, 380);
            this.dtpCaducidad.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCaducidad.Name = "dtpCaducidad";
            this.dtpCaducidad.Size = new System.Drawing.Size(167, 27);
            this.dtpCaducidad.TabIndex = 76;
            // 
            // cboLinea
            // 
            this.cboLinea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLinea.FormattingEnabled = true;
            this.cboLinea.Location = new System.Drawing.Point(465, 62);
            this.cboLinea.Margin = new System.Windows.Forms.Padding(4);
            this.cboLinea.Name = "cboLinea";
            this.cboLinea.Size = new System.Drawing.Size(187, 29);
            this.cboLinea.TabIndex = 77;
            // 
            // cboProveedor
            // 
            this.cboProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(465, 139);
            this.cboProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(187, 29);
            this.cboProveedor.TabIndex = 78;
            // 
            // cboVA
            // 
            this.cboVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVA.FormattingEnabled = true;
            this.cboVA.Items.AddRange(new object[] {
            "G",
            "E"});
            this.cboVA.Location = new System.Drawing.Point(684, 305);
            this.cboVA.Margin = new System.Windows.Forms.Padding(4);
            this.cboVA.Name = "cboVA";
            this.cboVA.Size = new System.Drawing.Size(170, 29);
            this.cboVA.TabIndex = 79;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(877, 538);
            this.Controls.Add(this.cboVA);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.cboLinea);
            this.Controls.Add(this.dtpCaducidad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCant3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCant2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCant1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.imgProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrecio3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrecio3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox imgProducto;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCant3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCant2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCant1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpCaducidad;
        private System.Windows.Forms.ComboBox cboLinea;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboVA;
    }
}