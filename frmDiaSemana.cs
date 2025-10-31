using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Programa:frmDiaSemana
 * Descripcion:Formulario que pide al usuario ingresar un numero para 
 * dar un dia de la semana.
 * Desarrollador:Andrea Dueñas de Luna.
 * Fecha:01/09/2025
*/
namespace ADL_Controles
{
    public partial class frmDiaSemana : Form
    {
        public frmDiaSemana()
        {
            InitializeComponent();
        }

        private void btnND_Click(object sender, EventArgs e)
        {
            int dia = Convert.ToInt32(txtDia.Text);
            switch (dia)
            {
                case 1:
                    lbl1.Text="Lunes";
                    break;
                case 2:
                    lbl1.Text="Martes";
                    break;
                case 3:
                    lbl1.Text="Miercoles";
                    break;
                case 4:
                    lbl1.Text="Jueves";
                    break;
                case 5:
                    lbl1.Text="Viernes";
                    break;
                case 6:
                    lbl1.Text="Sabado";
                    break;
                case 7:
                    lbl1.Text="Domingo";
                    break;
                default:
                    lbl1.Text="Dia no existente";
                    break;
            }//llave switch
            lbl1.Visible=true;
        }//llave evento
    }
}
