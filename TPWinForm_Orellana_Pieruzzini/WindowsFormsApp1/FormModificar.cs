using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catologo;

namespace WindowsFormsApp1
{
    public partial class FormModificar : Form
    {
        public List<Articulos> Lista { get; private set; }

        public object Y { get; private set; }

        public FormModificar()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            MessageBox.Show("Cancelaste la Modificacion");
        }

        private void tBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> Busqueda;
            CatologoArticulo BuscarArticulo = new CatologoArticulo();
            Lista = BuscarArticulo.Listar();
            try
            {
                if(tBuscar.Text==" ")
                {
                    dGVModificar.DataSource = Lista;
                    Busqueda = Lista;
                }
                else
                {
                    Busqueda = Lista.FindAll(Y => Y.Codigo.ToLower().Contains(tBuscar.Text.ToLower()));
                    dGVModificar.DataSource = Busqueda;
                }
                dGVModificar.DataSource = Busqueda;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

       private void bEditar_Click(object sender, EventArgs e)
        {
            if(dGVModificar.SelectedRows.Count>0)
            {
                tCodigo.Text = dGVModificar.CurrentRow.Cells["Codigo"].Value.ToString();
                tBNombre.Text = dGVModificar.CurrentRow.Cells["Nombre"].Value.ToString();
                tBDesc.Text = dGVModificar.CurrentRow.Cells["Descripcion"].Value.ToString();
               // cBMarca.Text = dGVModificar.CurrentRow.Cells["IdMarca"].Value.ToString();
              //  cBCategoria.Text = dGVModificar.CurrentRow.Cells["IdCategoria"].Value.ToString();
               // tBImagen.Text = dGVModificar.CurrentRow.Cells["ImagenUrl"].Value.ToString();
                tBPrecio.Text = dGVModificar.CurrentRow.Cells["Precio"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }

        }
    }
}
