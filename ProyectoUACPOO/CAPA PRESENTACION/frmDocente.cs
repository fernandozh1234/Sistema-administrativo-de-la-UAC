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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {

        }
        //instanciar la clase a traves del objeto
        Capa_NEGOCIO_UAC_POO.Docente docente1 = new Capa_NEGOCIO_UAC_POO.Docente();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarnacimiento = txtLugarNacimiento.Text;
            docente1.Nombres = nombres;
            docente1.Apellidos = apellidos;
            docente1.Edad = edad;
            docente1.LugarNacimiento = lugarnacimiento;
            MessageBox.Show("se han registrado exitosamente los datos del Docente1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //mostrar los datos almacenados en el objeto 1
            string nombres = docente1.Nombres;
            string apellidos = docente1.Apellidos;
            int edad = docente1.Edad;
            string LugarNacimiento = docente1.LugarNacimiento;
            MessageBox.Show("Nombres: " + nombres + 
                "Apellidos: " + apellidos + 
                "Edad: " + edad + "LugarNacimiento: " +
                "" + LugarNacimiento);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion estudiar
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion estudiar
            MessageBox.Show(docente1.Desaprobar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion estudiar
            MessageBox.Show(docente1.Aprobar());
        }
    }
}
