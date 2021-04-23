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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //instanciar la clase a traves de un objeto
        Capa_NEGOCIO_UAC_POO.Alumno alumno1 = new Capa_NEGOCIO_UAC_POO.Alumno();


        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = int.Parse(txtEdad.Text); 
            string lugarnacimiento = txtLugarNacimiento.Text;
            alumno1.Nombres = nombres;
            alumno1.Apellidos = apellidos;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarnacimiento;
            MessageBox.Show("se han registrado exitosamente los datos del Alumno 1");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //mostrar los datos almacenados en el objeto 1
            string nombres = alumno1.Nombres;
            string apellidos = alumno1.Apellidos;
            int edad = alumno1.Edad;
            string LugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Nombres: " + nombres + "Apellidos: " + apellidos + "Edad: " + edad + "LugarNacimiento: "+ LugarNacimiento ); 
         

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion estudiar
            MessageBox.Show(alumno1.Estudiar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion trabajar
            MessageBox.Show(alumno1.Trabajar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //mostrar el metodo u operacion aprobar examen
            MessageBox.Show(alumno1.AporbarExamen());
        }
    }
}
