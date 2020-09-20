using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catologo;
using Dominio;

namespace WindowsFormsApp1
{
    public partial class FormDetalle : Form
    {
        public List<Articulos> Lista { get; private set; }

        public FormDetalle()
        {
            InitializeComponent();
        }

        private void bDetalle_Click(object sender, EventArgs e)
        {
            if(dGVDetalle.SelectedRows.Count>0)
            {
                tBNombre.Text = dGVDetalle.CurrentRow.Cells["Nombre"].Value.ToString();
                tBDesc.Text = dGVDetalle.CurrentRow.Cells["Descripcion"].Value.ToString();
                tBPrecio.Text = dGVDetalle.CurrentRow.Cells["Precio"].Value.ToString();
                tBMarca.Text = dGVDetalle.CurrentRow.Cells["Marca"].Value.ToString();
               //pictureBox1.Image = (string)dGVDetalle.CurrentRow.Cells["ImagenUrl"].Value.ToString();
            }
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            CatologoArticulo catalogo = new CatologoArticulo();
            dGVDetalle.DataSource = catalogo.Listar();
            dGVDetalle.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGVDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
        }

        private void dGVDetalle_SelectionChanged(object sender, EventArgs e)
        {
            Articulos art = (Articulos)dGVDetalle.CurrentRow.DataBoundItem;
            pBArticulo.Load(art.Imagen);
        }
    }

}
