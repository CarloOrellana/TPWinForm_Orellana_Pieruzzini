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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;    //centrar pantalla.
            this.ClientSize = new Size(820, 490);

            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\MUNDOVIOLETA.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CatologoArticulo cargar = new CatologoArticulo();
            

            try
            {
                cBMarca.DataSource = cargar.ListarMarca();
                cBMarca.DisplayMember = "Descripcion";
                cBMarca.ValueMember = "Id";
                cBMarca.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                //throw ex;
            }
            CatologoArticulo auxcargar = new CatologoArticulo();
            try
            {
                cBCategoria.DataSource = auxcargar.ListarCategoria();
                cBCategoria.DisplayMember = "Descripcion";
                cBCategoria.ValueMember = "Id";
                cBCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
 
        private void tBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 46) e.Handled = true;
        }
    }
}
