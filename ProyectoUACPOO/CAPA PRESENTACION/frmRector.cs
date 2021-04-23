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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        Capa_NEGOCIO_UAC_POO.Rector rector1 = new Capa_NEGOCIO_UAC_POO.Rector();
        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string lugarnacimiento = txtLugarNacimiento.Text;
            int edad = int.Parse(txtEdad.Text);
            rector1.Nombre = nombres;
            rector1.Apellido = apellidos;
            rector1.LugarNacimiento = lugarnacimiento;
            rector1.Edad = edad;
            MessageBox.Show("se han registrado exitosamente los datos del Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombres = rector1.Nombre;
            string apellidos = rector1.Apellido;
            string LugarNacimiento = rector1.LugarNacimiento;
            int edad = rector1.Edad;
            MessageBox.Show("Nombres: " + nombres + "Apellidos: " + apellidos + "LugarNacimiento: " + LugarNacimiento +  "Edad: " + edad );
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Contratar());
        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Despedir());
        }

        private void btnSubirlapensiondelaU_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.SubirlaPensiondelaU());
        }
    }
}
