namespace WindowsFormsApp1
{
    partial class FormDetalle
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
            this.dGVDetalle = new System.Windows.Forms.DataGridView();
            this.bDetalle = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.pBArticulo = new System.Windows.Forms.PictureBox();
            this.lDesc = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.tBMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDetalle
            // 
            this.dGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDetalle.Location = new System.Drawing.Point(33, 23);
            this.dGVDetalle.Name = "dGVDetalle";
            this.dGVDetalle.Size = new System.Drawing.Size(755, 150);
            this.dGVDetalle.TabIndex = 0;
            this.dGVDetalle.SelectionChanged += new System.EventHandler(this.dGVDetalle_SelectionChanged);
            // 
            // bDetalle
            // 
            this.bDetalle.Location = new System.Drawing.Point(9, 23);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.Size = new System.Drawing.Size(18, 150);
            this.bDetalle.TabIndex = 1;
            this.bDetalle.Text = "Detall e";
            this.bDetalle.UseVisualStyleBackColor = true;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(51, 200);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre";
            // 
            // pBArticulo
            // 
            this.pBArticulo.Location = new System.Drawing.Point(331, 194);
            this.pBArticulo.Name = "pBArticulo";
            this.pBArticulo.Size = new System.Drawing.Size(457, 190);
            this.pBArticulo.TabIndex = 3;
            this.pBArticulo.TabStop = false;
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Location = new System.Drawing.Point(51, 242);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(63, 13);
            this.lDesc.TabIndex = 4;
            this.lDesc.Text = "Descripcion";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(51, 284);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 5;
            this.lMarca.Text = "Marca";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(51, 326);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(37, 13);
            this.lPrecio.TabIndex = 6;
            this.lPrecio.Text = "Precio";
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(141, 200);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(163, 20);
            this.tBNombre.TabIndex = 7;
            // 
            // tBDesc
            // 
            this.tBDesc.Location = new System.Drawing.Point(141, 241);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(163, 20);
            this.tBDesc.TabIndex = 8;
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(141, 323);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(163, 20);
            this.tBPrecio.TabIndex = 9;
            // 
            // tBMarca
            // 
            this.tBMarca.Location = new System.Drawing.Point(141, 282);
            this.tBMarca.Name = "tBMarca";
            this.tBMarca.Size = new System.Drawing.Size(163, 20);
            this.tBMarca.TabIndex = 10;
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBMarca);
            this.Controls.Add(this.tBPrecio);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.pBArticulo);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.dGVDetalle);
            this.Name = "FormDetalle";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDetalle;
        private System.Windows.Forms.Button bDetalle;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.PictureBox pBArticulo;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.TextBox tBMarca;
    }
}