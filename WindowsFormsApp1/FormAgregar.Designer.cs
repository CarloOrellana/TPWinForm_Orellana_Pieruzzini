namespace WindowsFormsApp1
{
    partial class FormAgregar
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.tBImagen = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBCodigo = new System.Windows.Forms.TextBox();
            this.cBMarca = new System.Windows.Forms.ComboBox();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lImagenUrl = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(14, 278);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(257, 278);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBPrecio);
            this.groupBox1.Controls.Add(this.tBImagen);
            this.groupBox1.Controls.Add(this.tBDesc);
            this.groupBox1.Controls.Add(this.tBNombre);
            this.groupBox1.Controls.Add(this.tBCodigo);
            this.groupBox1.Controls.Add(this.cBMarca);
            this.groupBox1.Controls.Add(this.cBCategoria);
            this.groupBox1.Controls.Add(this.lPrecio);
            this.groupBox1.Controls.Add(this.lImagenUrl);
            this.groupBox1.Controls.Add(this.lMarca);
            this.groupBox1.Controls.Add(this.lCategoria);
            this.groupBox1.Controls.Add(this.lDescripcion);
            this.groupBox1.Controls.Add(this.lNombre);
            this.groupBox1.Controls.Add(this.lCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(158, 192);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(116, 20);
            this.tBPrecio.TabIndex = 13;
            // 
            // tBImagen
            // 
            this.tBImagen.Location = new System.Drawing.Point(158, 163);
            this.tBImagen.Name = "tBImagen";
            this.tBImagen.Size = new System.Drawing.Size(116, 20);
            this.tBImagen.TabIndex = 12;
            // 
            // tBDesc
            // 
            this.tBDesc.Location = new System.Drawing.Point(158, 74);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(116, 20);
            this.tBDesc.TabIndex = 11;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(158, 45);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(116, 20);
            this.tBNombre.TabIndex = 10;
            // 
            // tBCodigo
            // 
            this.tBCodigo.Location = new System.Drawing.Point(158, 16);
            this.tBCodigo.Name = "tBCodigo";
            this.tBCodigo.Size = new System.Drawing.Size(116, 20);
            this.tBCodigo.TabIndex = 9;
            // 
            // cBMarca
            // 
            this.cBMarca.FormattingEnabled = true;
            this.cBMarca.Location = new System.Drawing.Point(158, 133);
            this.cBMarca.Name = "cBMarca";
            this.cBMarca.Size = new System.Drawing.Size(116, 21);
            this.cBMarca.TabIndex = 8;
            // 
            // cBCategoria
            // 
            this.cBCategoria.FormattingEnabled = true;
            this.cBCategoria.Location = new System.Drawing.Point(158, 103);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(116, 21);
            this.cBCategoria.TabIndex = 7;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(24, 193);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio";
            // 
            // lImagenUrl
            // 
            this.lImagenUrl.AutoSize = true;
            this.lImagenUrl.Location = new System.Drawing.Point(24, 164);
            this.lImagenUrl.Name = "lImagenUrl";
            this.lImagenUrl.Size = new System.Drawing.Size(64, 13);
            this.lImagenUrl.TabIndex = 5;
            this.lImagenUrl.Text = "ImagenURL";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(24, 135);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 4;
            this.lMarca.Text = "Marca";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(24, 106);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 3;
            this.lCategoria.Text = "Categoria";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(24, 77);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 2;
            this.lDescripcion.Text = "Descripcion";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(24, 48);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(24, 19);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(40, 13);
            this.lCodigo.TabIndex = 0;
            this.lCodigo.Text = "Codigo";
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "FormAgregar";
            this.Text = "Agregar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lImagenUrl;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.TextBox tBImagen;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBCodigo;
        private System.Windows.Forms.ComboBox cBMarca;
        private System.Windows.Forms.ComboBox cBCategoria;
    }
}