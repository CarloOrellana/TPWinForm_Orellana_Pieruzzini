﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catologo;

namespace WindowsFormsApp1
{
    public partial class FormBusqueda : Form
    {
        public FormBusqueda()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;    //centrar pantalla.
            this.ClientSize = new Size(700, 370);

            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\MUNDOVIOLETA.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            CatologoArticulo catalogo = new CatologoArticulo();
            dgvLista.DataSource = catalogo.Listar();
            dgvLista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
        }
    }
}
