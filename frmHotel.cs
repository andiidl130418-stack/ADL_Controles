using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADL_Controles
{
    public partial class frmHotel : Form
    {
        int[,] hotel = new int[3, 5];
        int pisoSeleccionado = -1;
        int habitacionSeleccionada = -1;

        public frmHotel()
        {
            InitializeComponent();
        }
        private void frmHotel_Load(object sender, EventArgs e)
        {
            CargarEstadoHotel();
        }

        private void CargarEstadoHotel()
        {
            // MODIFICADO: Ahora lee de tu nueva tabla 'reservas'
            string query = "SELECT numero_habitacion FROM reservas";

            try
            {
               using (MySqlConnection con = ConexionH.conexion())
             {
               con.Open();
               using (MySqlCommand cmd = new MySqlCommand(query, con))
               {
               using (MySqlDataReader reader = cmd.ExecuteReader())
               {
                 while (reader.Read())
                {
                 // "numero_habitacion" ahora contiene el Tag 1-based, ej: "3,2"
                 string tagFromDB = reader.GetString("numero_habitacion");

                 // Separamos el tag para obtener los índices
                 string[] datos = tagFromDB.Split(',');
                 if (datos.Length == 2)
                    {
                       int pisoIndex = int.Parse(datos[0]) - 1;
                       int habIndex = int.Parse(datos[1]) - 1;

                 if (pisoIndex >= 0 && pisoIndex < hotel.GetLength(0) &&habIndex >= 0 && habIndex < hotel.GetLength(1))
                    {
                       // 1. Marcamos en la matriz local
                       hotel[pisoIndex, habIndex] = 1;

                       string tagBuscado = $"{pisoIndex},{habIndex}";
                       foreach (Control c in this.Controls)
                       {
                          foreach (Control controlHijo in c.Controls)
                       {
                          if (controlHijo is Button btn && btn.Tag != null && btn.Tag.ToString() == tagBuscado)
                            {
                              btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#A35400");
                              btn.Enabled = false;
               }
              }
             }
            }
           }
          }
        }
     }
   }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estado del hotel: " + ex.Message);
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (pisoSeleccionado == -1 || habitacionSeleccionada == -1)
            {
                MessageBox.Show("Por favor, seleccione una habitación primero.");
                return;
            }

            if (hotel[pisoSeleccionado, habitacionSeleccionada] == 1)
            {
                MessageBox.Show("Esta habitación ya se encuentra ocupada. Por favor, seleccione otra.");
                return;
            }

            string nombre = txtNom.Text.Trim();
            string email = txtEma.Text.Trim();
            string telefono = txtTel.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, ingrese Nombre Completo y Email.");
                return;
            }

            MySqlConnection con = null;
            MySqlTransaction trans = null;

            try
            {
                con = ConexionH.conexion();
                con.Open();
                trans = con.BeginTransaction();

                MySqlCommand cmd = con.CreateCommand();
                cmd.Transaction = trans;

                string habitacionTag_DB = $"{pisoSeleccionado + 1},{habitacionSeleccionada + 1}";

                string habitacionTag_UI = $"{pisoSeleccionado},{habitacionSeleccionada}"; 

                cmd.CommandText = "SELECT COUNT(*) FROM reservas WHERE numero_habitacion = @habTag FOR UPDATE;";
                cmd.Parameters.AddWithValue("@habTag", habitacionTag_DB);

                long count = (long)cmd.ExecuteScalar();

                if (count > 0)
                {
                    throw new Exception("¡Demasiado tarde! Esa habitación acaba de ser reservada por alguien más.");
                }
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO reservas (nombre_huesped, email, telefono, numero_habitacion) VALUES (@nombre, @email, @tel, @habTag);";
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tel", telefono);
                cmd.Parameters.AddWithValue("@habTag", habitacionTag_DB); 

                cmd.ExecuteNonQuery();

                // Paso D: Confirmar la transacción
                trans.Commit();

                // --- 5. LÓGICA DE INTERFAZ (UI) ---
                hotel[pisoSeleccionado, habitacionSeleccionada] = 1;

                MessageBox.Show("¡Reserva realizada con éxito!");

                foreach (Control c in this.Controls)
                {
                    foreach (Control controlHijo in c.Controls)
                    {
                        if (controlHijo is Button btn && btn.Tag != null && btn.Tag.ToString() == habitacionTag_UI)
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#A35400");
                            btn.Enabled = false;
                        }
                    }
                }

                pisoSeleccionado = -1;
                habitacionSeleccionada = -1;
                txtNom.Text = "";
                txtEma.Text = "";
                txtTel.Text = "";

                VerificarSiHotelEstaLleno();
            }
            catch (MySqlException myEx)
            {
                if (trans != null) trans.Rollback();
                MessageBox.Show("Error de Base de Datos: " + myEx.Message);
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void VerificarSiHotelEstaLleno()
        {
            int habitacionesOcupadas = 0;
            int totalHabitaciones = hotel.GetLength(0) * hotel.GetLength(1);

            for (int piso = 0; piso < hotel.GetLength(0); piso++)
            {
                for (int hab = 0; hab < hotel.GetLength(1); hab++)
                {
                    if (hotel[piso, hab] == 1)
                    {
                        habitacionesOcupadas++;
                    }
                }
            }

            if (habitacionesOcupadas == totalHabitaciones)
            {
                MessageBox.Show("¡Atención! Todas las habitaciones han sido reservadas. El hotel está lleno.");
            }
        }
       
        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn.Tag == null)
            {
                MessageBox.Show("Error: Este botón no tiene una propiedad 'Tag' asignada en el diseñador.");
                return;
            }

            string[] datos = btn.Tag.ToString().Split(',');
            if (datos.Length != 2) return;

            pisoSeleccionado = int.Parse(datos[0]);
            habitacionSeleccionada = int.Parse(datos[1]);

            lblEstado.Text = $"El piso seleccionado es {pisoSeleccionado + 1}, en la Habitación {habitacionSeleccionada + 1}";
            lblEstado.Font = new Font("Berlin Sans FB Demi", 11f, FontStyle.Regular);

            int centroDelFormulario = this.ClientSize.Width / 2;
            int mitadAnchoEtiqueta = lblEstado.Width / 2;
            lblEstado.Location = new Point(centroDelFormulario - mitadAnchoEtiqueta, lblEstado.Location.Y);
            lblEstado.Visible = true;
        }
        private void label2_Click(object sender, EventArgs e)  
        {

        }
        private void lblCupo_Click(object sender, EventArgs e) 
        {

        }
        private void label9_Click(object sender, EventArgs e) 
        {

        }
        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}