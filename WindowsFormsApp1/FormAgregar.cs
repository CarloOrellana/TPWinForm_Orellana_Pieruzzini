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
    public partial class FormAgregar : Form
    {
        private CatologoArticulo p = new CatologoArticulo();
        
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            MessageBox.Show("Cancelaste la Carga");
        }

        public void AgregarArt(string codigo, string nombre, string descripcion, string idMarca, string idCategoria, string Imagen, string precio)
        {
            p.Agregar(codigo, nombre, descripcion, Convert.ToInt32(idMarca), Convert.ToInt32(idCategoria), Imagen, Convert.ToDecimal(precio));
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarArt(tBCodigo.Text, tBNombre.Text, tBDesc.Text, cBMarca.Text, cBCategoria.Text, tBImagen.Text, tBPrecio.Text);
                MessageBox.Show("Se agrego Correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo Agregar el Articulo");
            }
            Dispose();
        }
    }
}
