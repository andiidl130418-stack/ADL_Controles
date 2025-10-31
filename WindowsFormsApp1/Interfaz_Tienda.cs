using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Interfaz_Tienda : Form
    {
        public Interfaz_Tienda()
        {
            InitializeComponent();
        }

        private void Interfaz_Tienda_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM productos WHERE codigo LIKE '" + codigo + "' LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtID.Text = reader.GetInt32(0).ToString();
                        txtCodigo.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtDescripcion.Text = reader.GetString(3);
                        txtPrecioPublico.Text = reader.GetDecimal(4).ToString();
                        txtExistencias.Text = reader.GetInt32(5).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = txtCodigo.Text;
                String nombre = txtNombre.Text;
                String descripcion = txtDescripcion.Text;
                double precio_publico = double.Parse(txtPrecioPublico.Text);
                int existencias = int.Parse(txtExistencias.Text);
                if (codigo != "" && nombre != "" && descripcion != "" && precio_publico > 0 && existencias > 0)
                {
                    string sql = "INSERT INTO productos (codigo, nombre, descripcion, precio_publico, existencias) VALUES ('" + codigo + "', '" + nombre + "', '" + descripcion + "', '" + precio_publico + "', '" + existencias + "')";
                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        txtID.Text = "";
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtPrecioPublico.Text = "";
                        txtExistencias.Text = "";
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Usar TryParse para validación numérica
            if (!double.TryParse(txtPrecioPublico.Text, out double precio_publico) ||
                !int.TryParse(txtExistencias.Text, out int existencias) ||
                !int.TryParse(txtID.Text, out int id)) // Asegurar que el ID es un número
            {
                MessageBox.Show("Verifique que el ID, el Precio y las Existencias sean números válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (id == 0 || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe buscar y seleccionar un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usamos el ID para asegurar que solo se actualice una fila (es la clave primaria)
            string sql = "UPDATE productos SET codigo=@codigo, nombre=@nombre, descripcion=@descripcion, " +
                         "precio_publico=@precio_publico, existencias=@existencias WHERE id=@id";

            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.conexion();
                conexion.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@id", id); // Clave para el WHERE
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio_publico", precio_publico);
                comando.Parameters.AddWithValue("@existencias", existencias);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro modificado exitosamente.");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro con el ID: " + id + " para actualizar.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar en la BD: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error general: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idTexto = txtID.Text;

            if (!int.TryParse(idTexto, out int id))
            {
                MessageBox.Show("Debe buscar un producto para obtener el ID válido a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar el producto con ID: {id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            string sql = "DELETE FROM productos WHERE id=@id";

            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.conexion();
                conexion.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@id", id); // Asignar el parámetro

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro eliminado.");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro con el ID: " + id + " para eliminar.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar en la BD: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error general: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void limpiar()
        {
            txtID.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioPublico.Text = "";
            txtExistencias.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioPublico.Text = "";
            txtExistencias.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

