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
    public partial class Asignatura : Form
    {
        public Asignatura()
        {
            InitializeComponent();
        }
        //instanciar la clase a traves del objeto
        Capa_NEGOCIO_UAC_POO.Asignatura Asignatura1 = new Capa_NEGOCIO_UAC_POO.Asignatura();
        private void button5_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombrecurso = txtNombreCurso.Text;
            string facultad = txtFacultad.Text;
            int horario = int.Parse(txtHorario.Text);
            string docente = txtDocente.Text;
            Asignatura1.NombreCurso = nombrecurso;
            Asignatura1.Facultad = facultad;
            Asignatura1.Horario = horario;
            Asignatura1.Docente = docente;
            MessageBox.Show("se han registrado exitosamente los datos de Asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //mostrar los datos almacenados en el objeto 1
            string nombrecurso = Asignatura1.NombreCurso;
            string facultad = Asignatura1.Facultad;
            int horario = Asignatura1.Horario;
            string docente = Asignatura1.Docente;
            MessageBox.Show("NombreCurso: " + nombrecurso + "Facultad: " + facultad  + "Horario: " + horario + "Docente: " + docente);
        }

        private void Enseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Asignatura1.Enseñar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Asignatura1.Explicar());
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Asignatura1.Asistencia());
        }
    }
}
