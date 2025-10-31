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
    public partial class frmListAlumnos : Form
    {
        public frmListAlumnos()
        {
            InitializeComponent();
        }

        private void frmListAlumnos_Load(object sender, EventArgs e)//El evento load es para cargar antes algo del formulario
        {
            lstSinEntrega.Items.Add("Romo Zamarripa Claudia");
            lstSinEntrega.Items.Add("Salinas Vazquez Rogelio");
            lstSinEntrega.Items.Add("Medina Rosales Esteban");
            lstSinEntrega.Items.Add("Guadarrama Arevalo Rosa");
            lstSinEntrega.Items.Add("Garcia Salgado Arturo");
        }

        private void btnConEntrega_Click(object sender, EventArgs e)
        {
            if (lstSinEntrega.SelectedItem != null)
            {
                lstConEntrega.Items.Add(lstSinEntrega.SelectedItem.ToString());
                lstSinEntrega.Items.RemoveAt(lstSinEntrega.SelectedIndex);
                txtTotal.Text=lstConEntrega.Items.Count.ToString();
            }
        }

        private void btnSinEntrega_Click(object sender, EventArgs e)
        {
            if(lstConEntrega.SelectedItem != null)
            {
                lstSinEntrega.Items.Add(lstConEntrega.SelectedItem.ToString());
                lstConEntrega.Items.RemoveAt(lstConEntrega.SelectedIndex);
                txtTotal.Text=lstConEntrega.Items.Count.ToString();
            }
        }
    }
}
