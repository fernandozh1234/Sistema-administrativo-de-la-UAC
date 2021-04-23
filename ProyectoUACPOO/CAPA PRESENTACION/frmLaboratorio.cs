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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        Capa_NEGOCIO_UAC_POO.Laboratorio laboratorio1 = new Capa_NEGOCIO_UAC_POO.Laboratorio();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string herramientas = txtHerramientas.Text;
            string capacidad = txtCapacidad.Text;
            string muestras = txtMuestras.Text;
            string docente = txtDocente.Text;
            laboratorio1.Herramientas = herramientas;
            laboratorio1.Capacidad = capacidad;
            laboratorio1.Muestras = muestras;
            laboratorio1.Docente = docente;
            MessageBox.Show("se han registrado exitosamente los datos de Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string herramientas = laboratorio1.Herramientas;
            string capacidad = laboratorio1.Capacidad;
            string muestras = laboratorio1.Muestras;
            string docente = laboratorio1.Docente;
            MessageBox.Show("Herramientas: " + herramientas + "Capacidad: " + capacidad + "Muestras: " + muestras + "Docente: " + docente);
        }

        private void btnObservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Observar());
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Analizar());
        }

        private void btnConclusiones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Conclusiones());
        }
    }
}
