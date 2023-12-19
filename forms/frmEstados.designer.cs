namespace Sistema_Inventarios
{
    partial class frmEstados
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnPrimero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(114, 69);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(354, 27);
            this.TxtNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(114, 22);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(354, 27);
            this.TxtId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnRegistrar);
            this.panel1.Controls.Add(this.BtnAnterior);
            this.panel1.Controls.Add(this.BtnSiguiente);
            this.panel1.Controls.Add(this.BtnUltimo);
            this.panel1.Controls.Add(this.BtnPrimero);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 90);
            this.panel1.TabIndex = 10;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.White;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(351, 11);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(105, 30);
            this.BtnActualizar.TabIndex = 7;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(351, 47);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 30);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(240, 47);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(105, 30);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.White;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(240, 11);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.BtnRegistrar.TabIndex = 4;
            this.BtnRegistrar.Text = "&Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.White;
            this.BtnAnterior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.Location = new System.Drawing.Point(16, 47);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(105, 30);
            this.BtnAnterior.TabIndex = 3;
            this.BtnAnterior.Text = "&Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = false;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.Color.White;
            this.BtnSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.Location = new System.Drawing.Point(127, 47);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(105, 30);
            this.BtnSiguiente.TabIndex = 2;
            this.BtnSiguiente.Text = "&Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.BackColor = System.Drawing.Color.White;
            this.BtnUltimo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimo.Location = new System.Drawing.Point(127, 11);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(105, 30);
            this.BtnUltimo.TabIndex = 1;
            this.BtnUltimo.Text = "&Ultimo";
            this.BtnUltimo.UseVisualStyleBackColor = false;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // BtnPrimero
            // 
            this.BtnPrimero.BackColor = System.Drawing.Color.White;
            this.BtnPrimero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimero.Location = new System.Drawing.Point(16, 11);
            this.BtnPrimero.Name = "BtnPrimero";
            this.BtnPrimero.Size = new System.Drawing.Size(105, 30);
            this.BtnPrimero.TabIndex = 0;
            this.BtnPrimero.Text = "&Primero";
            this.BtnPrimero.UseVisualStyleBackColor = false;
            this.BtnPrimero.Click += new System.EventHandler(this.BtnPrimero_Click);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(501, 219);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEstados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Estados";
            this.Load += new System.EventHandler(this.Frm_Estados_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnPrimero;
    }
}