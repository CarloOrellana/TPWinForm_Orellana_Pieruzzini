namespace WindowsFormsApp1
{
    partial class FormModificar
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
            this.lCodigo = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.dGVModificar = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.tBImagen = new System.Windows.Forms.TextBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lImagen = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(167, 405);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Acepctar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(373, 405);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(39, 42);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(89, 13);
            this.lCodigo.TabIndex = 2;
            this.lCodigo.Text = "Ingrese el Codigo";
            // 
            // tBuscar
            // 
            this.tBuscar.Location = new System.Drawing.Point(153, 35);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(238, 20);
            this.tBuscar.TabIndex = 3;
            this.tBuscar.TextChanged += new System.EventHandler(this.tBuscar_TextChanged);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(416, 32);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 4;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // dGVModificar
            // 
            this.dGVModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModificar.Location = new System.Drawing.Point(12, 67);
            this.dGVModificar.Name = "dGVModificar";
            this.dGVModificar.Size = new System.Drawing.Size(776, 109);
            this.dGVModificar.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 306);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(153, 189);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(151, 20);
            this.tCodigo.TabIndex = 8;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(153, 216);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(151, 20);
            this.tBNombre.TabIndex = 9;
            // 
            // tBDesc
            // 
            this.tBDesc.Location = new System.Drawing.Point(153, 250);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(151, 20);
            this.tBDesc.TabIndex = 10;
            // 
            // tBImagen
            // 
            this.tBImagen.Location = new System.Drawing.Point(153, 338);
            this.tBImagen.Name = "tBImagen";
            this.tBImagen.Size = new System.Drawing.Size(151, 20);
            this.tBImagen.TabIndex = 11;
            this.tBImagen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(153, 369);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(151, 20);
            this.tBPrecio.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(22, 223);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 14;
            this.lNombre.Text = "Nombre";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Location = new System.Drawing.Point(22, 253);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(63, 13);
            this.lDesc.TabIndex = 15;
            this.lDesc.Text = "Descripcion";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(22, 282);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 16;
            this.lMarca.Text = "Marca";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(22, 314);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 17;
            this.lCategoria.Text = "Categoria";
            // 
            // lImagen
            // 
            this.lImagen.AutoSize = true;
            this.lImagen.Location = new System.Drawing.Point(22, 341);
            this.lImagen.Name = "lImagen";
            this.lImagen.Size = new System.Drawing.Size(42, 13);
            this.lImagen.TabIndex = 18;
            this.lImagen.Text = "Imagen";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(22, 369);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 19;
            this.lPrecio.Text = "Precio";
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lImagen);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPrecio);
            this.Controls.Add(this.tBImagen);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dGVModificar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.lCodigo);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "FormModificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.dGVModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DataGridView dGVModificar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.TextBox tBImagen;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lImagen;
        private System.Windows.Forms.Label lPrecio;
    }
}