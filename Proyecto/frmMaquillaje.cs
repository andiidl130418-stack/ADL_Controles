using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADL_Controles
{
    public partial class frmMaquillaje : Form
    {
        public frmMaquillaje()
        {
            InitializeComponent();
        }
        public struct ProductoMaquillaje
        {
            public int Id;
            public string Nombre;
            public string Marca;
            public string Categoria;
            public string Tono;
            public decimal Precio;
            public string Calificacion;
        }

        private ProductoMaquillaje[] inventario = new ProductoMaquillaje[10];
        private int almacen = 0;
        private int indiceSeleccionado = -1;
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNom.Clear();
            txtMarca.Clear();
            cbCate.SelectedIndex = -1;
            txtTono.Clear();
            txtPrecio.Clear();

            rbBueno.Checked = false;
            rbMalo.Checked = false;
            rbPM.Checked = false;

            lstProductos.ClearSelected(); 
            indiceSeleccionado = -1;
            txtID.Focus();
        }
        private string ObtenerCalificacion()
        {
            if (rbBueno.Checked) return "Bueno";
            if (rbMalo.Checked) return "Malo";
            if (rbPM.Checked) return "Puede Mejorar";
            return "Sin calificar"; 
        }
        private void ActualizarLista()
        {
            lstProductos.Items.Clear(); 

            for (int i = 0; i < almacen; i++)
            {
                
                lstProductos.Items.Add(inventario[i].Id + " - " + inventario[i].Nombre);
            }
        }
        private void frmMaquillaje_Load(object sender, EventArgs e)
        {

        }
        private void btnRe_Click(object sender, EventArgs e)
        {
            if (almacen >= 10) { MessageBox.Show("Inventario lleno."); return; }
            if (string.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("El ID es obligatorio."); 
            return; }

            int idProducto;
            decimal precioProducto;

            if (!int.TryParse(txtID.Text, out idProducto))
            {
                MessageBox.Show("Error: El ID debe ser un numero.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precioProducto))
            {
                MessageBox.Show("Error: El Precio debe ser un numero.");
                return;
            }

            for (int i = 0; i < almacen; i++)
            {
                if (inventario[i].Id == idProducto)
                {
                    MessageBox.Show("Error: Este ID ya existe.");
                    return;
                }
            }

            ProductoMaquillaje nuevoProducto = new ProductoMaquillaje();
            nuevoProducto.Id = idProducto; 
            nuevoProducto.Nombre = txtNom.Text;
            nuevoProducto.Marca = txtMarca.Text;
            nuevoProducto.Categoria = cbCate.Text;
            nuevoProducto.Tono = txtTono.Text;
            nuevoProducto.Precio = precioProducto; 
            nuevoProducto.Calificacion = ObtenerCalificacion();

            inventario[almacen] = nuevoProducto;
            almacen++;

            if (!lstProductos.Visible)
            {
                lstProductos.Visible = true;
            }

            ActualizarLista();
            LimpiarCampos();
            MessageBox.Show("Producto registrado");
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (cbConsul.SelectedItem == null || string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                MessageBox.Show("Selecciona un tipo de consulta y escribe un valor.");
                return;
            }

            string tipoConsulta = cbConsul.SelectedItem.ToString();
            string valorBusqueda = txtBusqueda.Text;
            bool encontrado = false;

            for (int i = 0; i < almacen; i++)
            {
                if (tipoConsulta == "ID" && inventario[i].Id.ToString() == valorBusqueda)
                {
                    lstProductos.SelectedIndex = i; 
                    encontrado = true;
                    break;
                }
                else if (tipoConsulta == "Nombre" && inventario[i].Nombre.Equals(valorBusqueda, StringComparison.OrdinalIgnoreCase))
                {
                    lstProductos.SelectedIndex = i; 
                    encontrado = true;
                    break; 
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún producto.");
                lstProductos.ClearSelected(); 
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado < 0)
                {
                    MessageBox.Show("Por favor, selecciona un producto de la lista para eliminar.");
                    return;
                }

                if (MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = indiceSeleccionado; i < almacen - 1; i++)
                    {
                        inventario[i] = inventario[i + 1];
                    }
                    almacen--; 

                    ActualizarLista();
                    LimpiarCampos();
                    MessageBox.Show("Producto eliminado.");
                }
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            if (indiceSeleccionado < 0)
            {
                MessageBox.Show("Selecciona un producto de la lista para editar.");
                return;
            }

            int idProducto;
            decimal precioProducto;

            if (!int.TryParse(txtID.Text, out idProducto))
            {
                MessageBox.Show("Error: El ID debe ser un numero.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precioProducto))
            {
                MessageBox.Show("Error: El Precio debe ser un numero.");
                return;
            }

           
            inventario[indiceSeleccionado].Id = idProducto;
            inventario[indiceSeleccionado].Nombre = txtNom.Text;
            inventario[indiceSeleccionado].Marca = txtMarca.Text;
            inventario[indiceSeleccionado].Categoria = cbCate.Text;
            inventario[indiceSeleccionado].Tono = txtTono.Text;
            inventario[indiceSeleccionado].Precio = precioProducto;
            inventario[indiceSeleccionado].Calificacion = ObtenerCalificacion();

            ActualizarLista();
            LimpiarCampos();
            MessageBox.Show("Producto actualizado.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            indiceSeleccionado = lstProductos.SelectedIndex;

            
            if (indiceSeleccionado >= 0)
            {
                
                ProductoMaquillaje productoSeleccionado = inventario[indiceSeleccionado];
                txtID.Text = productoSeleccionado.Id.ToString();
                txtNom.Text = productoSeleccionado.Nombre;
                txtMarca.Text = productoSeleccionado.Marca;
                cbCate.Text = productoSeleccionado.Categoria;
                txtTono.Text = productoSeleccionado.Tono;
                txtPrecio.Text = productoSeleccionado.Precio.ToString("0.00");

                if (productoSeleccionado.Calificacion == "Bueno")
                {
                    rbBueno.Checked = true;
                }
                else if (productoSeleccionado.Calificacion == "Malo")
                {
                    rbMalo.Checked = true;
                }
                else if (productoSeleccionado.Calificacion == "Puede Mejorar")
                {
                    rbPM.Checked = true;
                }
            }
        }
    }
}
