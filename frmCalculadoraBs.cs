using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Programa:frmCalculadoraBS
 * Descripcion:Calculadora Basica que realiza operaciones de suma, resta, multi y division
 * Desarrollador:Andrea Dueñas de Luna.
 * Fecha:05/09/2025
*/
namespace ADL_Controles
{
    public partial class frmCalculadoraBs : Form
    {
        // Variables globales
        int num1=0,num2=0,resultado=0; // guardan los números y el resultado
        string operacion="";              // almacena la operación seleccionada (+, -, x, /)
        bool nuevaOperacion=false;        // bandera para limpiar pantalla después de mostrar un resultado

        public frmCalculadoraBs()
        {
            InitializeComponent();
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            txtNum.Text = "0";   // pantalla en cero
            num1=num2=resultado=0; // reseteamos valores
            operacion="";           // sin operación
            nuevaOperacion=false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum.Text, out num2))//solo se aceptan numeros enteros
            {
                MessageBox.Show("Número inválido");
                return; // salimos si no es un número válido
            }
            switch (operacion)
            {
                case "+":
                    resultado=num1+num2;
                    break;
                case "-":
                    resultado=num1-num2;
                    break;
                case "x":
                    resultado=num1*num2;
                    break;
                case "/":
                    if (num2 != 0) // validamos que no divida entre cero
                        resultado = num1 / num2;
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        return; // se sale del método sin mostrar nada
                    }
                    break;
                default:
                    return;
            }
            txtNum.Text=resultado.ToString();
            nuevaOperacion = true; // para limpiar pantalla al escribir el siguiente número
        }

        private void frmCalculadoraBs_Load(object sender, EventArgs e)
        {

        }

        private void btnOpera(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;

            if (!int.TryParse(txtNum.Text, out num1))
            {
                MessageBox.Show("Numero invalido");
                return;
            }

            nuevaOperacion = true; // solo marca que el siguiente número reemplaza el TextBox
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (txtNum.Text == "0" || nuevaOperacion)
            {
                txtNum.Text=boton.Text;
                nuevaOperacion=false;
            }
            else
            {
                txtNum.Text+=boton.Text;
            }
        }
    }
}
