using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        Capa_NEGOCIO_UAC_POO.Notas notas1 = new Capa_NEGOCIO_UAC_POO.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            int unidad1 = int.Parse(txtUnidad1.Text);
            int unidad2 = int.Parse(txtUnidad2.Text);
            int unidad3 = int.Parse(txtUnidad3.Text);
            int ponderado = int.Parse(txtPonderado.Text);
            notas1.Unidad1 = unidad1;
            notas1.Unidad2 = unidad2;
            notas1.Unidad3 = unidad3;
            notas1.Ponderado = ponderado;
            MessageBox.Show("se han registrado exitosamente los datos de Notas1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            int unidad1 = notas1.Unidad1;
            int unidad2 = notas1.Unidad2;
            int unidad3 = notas1.Unidad3;
            int ponderado = notas1.Ponderado;
            MessageBox.Show("Unidad1: " + unidad1 + "unidad2: " + unidad2 + "unidad3: " + unidad3 + "Ponderado: " + ponderado);
        }

        private void btnSubirNota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.SubirNota());
        }

        private void btnBajarNota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.BajarNota());
        }

        private void btnAprobarSemestre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.AprobarSemestre());
        }
    }
}
