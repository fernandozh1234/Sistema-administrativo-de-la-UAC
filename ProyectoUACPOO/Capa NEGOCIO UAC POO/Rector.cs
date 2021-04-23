using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_NEGOCIO_UAC_POO
{
    public class Rector
    {
        //atributos
        private string nombre;
        private string apellido;
        private string lugarnacimiento;
        private int edad;
        //porpiedades
        public string Nombre
        {
            get { return nombre; } //lectura del atributo
            set { nombre = value; } //escritura del atributo
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string LugarNacimiento
        {
            get { return lugarnacimiento; }
            set { lugarnacimiento = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        //métodos u operaciones
        public string Contratar()
        {
            return "no se ha implementado el metodo contratar";
        }
        public string Despedir()
        {
            return "no se ha implementado el metodo despedir";
        }
        public string SubirlaPensiondelaU()
        {
            return "no se ha implementado el metodo Subir la Pension de la U";
        }
    }
}
