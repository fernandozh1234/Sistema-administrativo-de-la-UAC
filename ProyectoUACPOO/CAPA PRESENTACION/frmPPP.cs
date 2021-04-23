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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        Capa_NEGOCIO_UAC_POO.PPP ppp1 = new Capa_NEGOCIO_UAC_POO.PPP();
            private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombredelsuperior = txtNombredelSuperior.Text;
            string puestodetrabajo = txtPuestodeTrabajo.Text;
            int horadeingreso = int.Parse(txtHoradeIngreso.Text);
            string localdeltrabajo = txtLocaldeTrabajo.Text;
            ppp1.Nombredelsuperior = nombredelsuperior;
            ppp1.PuestodeTrabajo = puestodetrabajo;
            ppp1.HoradeIngreso = horadeingreso;
            ppp1.LocaldelTrabajo = localdeltrabajo;
            MessageBox.Show("se han registrado exitosamente los datos de PPP 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombredelsuperior = ppp1.Nombredelsuperior;
            string puestodetrabajo = ppp1.PuestodeTrabajo;
            int horadeingreso = ppp1.HoradeIngreso;
            string localdetrabajo = ppp1.LocaldelTrabajo;
            MessageBox.Show("Nombre del superior: " + nombredelsuperior + "Puesto de Trabajo: " + puestodetrabajo + "Hora de Ingreso: " + horadeingreso + "Local del Trabajo: " + localdetrabajo);
        }

        private void btnDesarrollar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.DesarrollarHabilidades());
        }

        private void btnFortalecer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.FortalecerFormacionAcadémica());
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.RenovarContrato());
        }
    }
}
