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
    public partial class frmRFC : Form
    {
        public frmRFC()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtRFC.Clear();
            dateTimeFN.Value = DateTime.Now; // Restablece la fecha a hoy.
            txtNombre.Focus(); // Pone el cursor en el primer campo.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validar que el campo de nombre no esté vacío.
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre Completo' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Preparar y dividir el nombre.
            // Se convierte a mayúsculas y se quitan espacios extra.
            string nombreNormalizado = txtNombre.Text.Trim().ToUpper();
            string[] partes = nombreNormalizado.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Se valida que haya al menos apellido y nombre.
            if (partes.Length < 2)
            {
                MessageBox.Show("El formato del nombre es incorrecto. Se necesita al menos un apellido y un nombre.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Asignar las partes del nombre según el formato simple.
            string apellidoPaterno = partes[0];
            // Si hay 2 partes, es Apellido y Nombre. Si hay 3 o más, es ApellidoPaterno, ApellidoMaterno, Nombre.
            string apellidoMaterno = (partes.Length >= 3) ? partes[1] : "";
            string nombre = (partes.Length >= 3) ? partes[2] : partes[1];

            // 4. Construir el RFC siguiendo las reglas.
            string rfc = "";

            // Regla 1: Primera letra del apellido paterno.
            rfc += apellidoPaterno[0];

            // Regla 2: Primera vocal interna del apellido paterno.
            char primeraVocal = '\0'; // Caracter nulo por defecto
            for (int i = 1; i < apellidoPaterno.Length; i++)
            {
                if ("AEIOU".Contains(apellidoPaterno[i]))
                {
                    primeraVocal = apellidoPaterno[i];
                    break; // Se detiene al encontrar la primera vocal
                }
            }
            rfc += (primeraVocal == '\0') ? 'X' : primeraVocal; // Si no encuentra vocal, usa 'X'.

            // Regla 3: Inicial del apellido materno. Si no hay, se usa 'X'.
            rfc += string.IsNullOrEmpty(apellidoMaterno) ? 'X' : apellidoMaterno[0];

            // Regla 4: Inicial del primer nombre.
            rfc += nombre[0];

            // Regla 5: Fecha de nacimiento en formato AAMMDD.
            DateTime fecha = dateTimeFN.Value;
            rfc += fecha.ToString("yyMMdd");

            // Regla 6: Homoclave (valor de relleno).
            rfc += "XXX";

            // 5. Mostrar el resultado.
            txtRFC.Text = rfc;
        }

        private void frmRFC_Load(object sender, EventArgs e)
        {

        }
    }
}
