using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Programa:frmlLogin
 * Descripcion:Formulario que pide al usuario ingresar un usuario y contraseña para ingresar.
 * Desarrollador:Andrea Dueñas de Luna.
 * Fecha:02/09/2025
*/
namespace ADL_Controles
{
    public partial class frmlLogin : Form
    {
        public frmlLogin()
        {
            InitializeComponent();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="andy"&&textBox2.Text=="andy")
            {
                pictureBox2.Visible=true;
            }
            lblBien.Visible=true;
        }

        private void frmlLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
