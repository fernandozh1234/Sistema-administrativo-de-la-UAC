using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_NEGOCIO_UAC_POO
{
    public class Alumno
    {
        //atributos
        private string nombres;
        private string apellidos;
        private string lugarnacimiento;
        private int edad;
        //porpiedades
        public string Nombres
        {
            get { return nombres; } //lectura del atributo
            set { nombres = value; } //escritura del atributo
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string LugarNacimiento
        {
            get { return this .lugarnacimiento; }
            set { this .lugarnacimiento = value; }
        }
        //métodos u operaciones
        public string Estudiar()
        {
            return "no se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "no se ha implementado";
        }
        public string AporbarExamen()
        {
            return "no se ha implementado";
        }
        


    }
}
