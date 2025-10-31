using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ADL_Controles

{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void estructurasRepetitivasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaExe = @"C:\Users\andii\OneDrive\Documentos\C#\ADL_ejem04_Switch\bin\Debug\ADL_ejem04_Switch.exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void ifElseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                string rutaExe = @"C:\Users\andii\OneDrive\Documentos\C#\ADL_ejem01IfElse\bin\Debug\ADL_ejem01IfElse.exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaExe = @".exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void doWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaExe = @"C:\Users\andii\OneDrive\Documentos\C#\UsoDoWhile\bin\Debug\UsoDoWhile.exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaExe = @"C:\Users\andii\OneDrive\Documentos\C#\ADL_ejem04_EstructurasRepetitivas\bin\Debug\ADL_ejem04_EstructurasRepetitivas.exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaExe = @"C:\Users\andii\OneDrive\Documentos\C#\ADL_ejem05_asteriscos\bin\Debug\ADL_ejem05_asteriscos.exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 try
            {
                string rutaExe = @".exe";
                Process.Start(rutaExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Blue;
        }

        private void moradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Purple;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Yellow;
        }

        private void otroFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmotroFormulario frmotro = new frmotroFormulario();
            //frmotro.ShowDialog();
            frmotro.Show();
        }
    }
}
