namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListadoArticulos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListadoArticulos
            // 
            this.btnListadoArticulos.Location = new System.Drawing.Point(75, 60);
            this.btnListadoArticulos.Name = "btnListadoArticulos";
            this.btnListadoArticulos.Size = new System.Drawing.Size(148, 28);
            this.btnListadoArticulos.TabIndex = 0;
            this.btnListadoArticulos.Text = "Listado de Articulos\r\n";
            this.btnListadoArticulos.UseVisualStyleBackColor = true;
            this.btnListadoArticulos.Click += new System.EventHandler(this.btnListadoArticulos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(75, 134);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(148, 28);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Detalle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(400, 134);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(148, 28);
            this.bModificar.TabIndex = 4;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(400, 207);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(148, 28);
            this.bntEliminar.TabIndex = 5;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(400, 60);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(148, 28);
            this.bAgregar.TabIndex = 6;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListadoArticulos);
            this.Name = "Form1";
            this.Text = "Catalogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListadoArticulos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bntEliminar;
        private System.Windows.Forms.Button bAgregar;
    }
}

