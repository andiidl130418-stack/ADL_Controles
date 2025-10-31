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
    public partial class frmEjer10 : Form
    {
        struct club
        {
            public int basquetbol;
            public int voleibol;
            public int natacion;
        }
        struct datosAlum
        {
            public int id;
            public string nombre;
            public double estatura;
            public double peso;
            public int sexo;
            public club clubs;
        }
        datosAlum[] alumnos;
        int indice;
        public frmEjer10()
        {
            InitializeComponent();
            alumnos= new datosAlum[5];
            indice=0;
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            double imc, estatura, peso;
            estatura = double.Parse(txtEs.Text);
            peso = double.Parse(txtPeso.Text);
            imc = peso / (estatura * estatura);
            MessageBox.Show("El IMC del Alumno solicitado es de:" + imc);
        }

        private void btnRegi_Click(object sender, EventArgs e)
        {
            if (indice<5)
            {
                alumnos[indice].id = int.Parse(txtId.Text);
                alumnos[indice].nombre = txtNom.Text;
                alumnos[indice].estatura = double.Parse(txtEs.Text);
                alumnos[indice].peso = double.Parse(txtPeso.Text);
                if (rbFem.Checked == true)
                    alumnos[indice].sexo = 1;
                else
                    alumnos[indice].sexo = 2;
                //Reinicia los valores del club
                alumnos[indice].clubs.basquetbol = 0;
                alumnos[indice].clubs.voleibol = 0;
                alumnos[indice].clubs.natacion = 0;

                if (chbBas.Checked == true)
                    alumnos[indice].clubs.basquetbol = 1;
                if (chbVolei.Checked == true)
                    alumnos[indice].clubs.voleibol = 1;
                if (chbNata.Checked == true)
                    alumnos[indice].clubs.natacion = 1;
                //incrementa
                indice = indice + 1;

                txtId.Text = "";
                txtNom.Text = "";
                txtEs.Text = "";
                txtPeso.Text = "";
                chbBas.Checked = false;
                chbVolei.Checked = false;
                chbNata.Checked = false;
                rbFem.Checked = false;
                rbMas.Checked = false;
                MessageBox.Show("Alumno Registrado");
            }
            else
                MessageBox.Show("Grupo Lleno");
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtEs.Text = "";
            txtPeso.Text = "";
            chbBas.Checked = false;
            chbVolei.Checked = false;
            chbNata.Checked = false;
            rbFem.Checked = false;
            rbMas.Checked = false;

        }

        private void btnMos_Click(object sender, EventArgs e)
        {
            chbBas.Checked = false;
            chbVolei.Checked = false;
            chbNata.Checked = false;
            int id = int.Parse(txtId.Text);
            for (int i = 0; i < 5; i++)
            {
                if (id == alumnos[i].id)
                {
                    txtId.Text = alumnos[i].id.ToString();
                    txtNom.Text = alumnos[i].nombre;
                    txtEs.Text = alumnos[i].estatura.ToString();
                    txtPeso.Text = alumnos[i].peso.ToString();
                    if (alumnos[i].sexo == 1)
                        rbFem.Checked = true;
                    else
                        rbMas.Checked = true;

                    if (alumnos[i].clubs.basquetbol == 1)
                        chbBas.Checked = true;
                    if (alumnos[i].clubs.voleibol == 1)
                        chbVolei.Checked = true;
                    if (alumnos[i].clubs.natacion == 1)
                        chbNata.Checked = true;
                }
            }
        }
    }
}
