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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        Capa_NEGOCIO_UAC_POO.JefePractica jefePractica1 = new Capa_NEGOCIO_UAC_POO.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarnacimiento = txtLugarNacimiento.Text;
            jefePractica1.Nombres = nombres;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Edad = edad;
            jefePractica1.LugarNacimiento = lugarnacimiento;
            MessageBox.Show("se han registrado exitosamente los datos de JefedePractica1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //mostrar los datos almacenados en el objeto 1
            string nombres = jefePractica1.Nombres;
            string apellidos = jefePractica1.Apellidos;
            int edad = jefePractica1.Edad;
            string LugarNacimiento = jefePractica1.LugarNacimiento;
            MessageBox.Show("Nombres: " + nombres + "Apellidos: " + apellidos + "Edad: " + edad + "LugarNacimiento: " + LugarNacimiento);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Calificar());
        }

        private void btnGuiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Guiar());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Ordenar());
        }
    }
}
