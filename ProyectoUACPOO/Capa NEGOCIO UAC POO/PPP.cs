using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_NEGOCIO_UAC_POO
{
    public class PPP
    {
        //atributos
        private string nombredelsuperior;
        private string puestodetrabajo;
        private string localdeltrabajo;
        private int horadeingreso;
        //porpiedades
        public string Nombredelsuperior
        {
            get { return nombredelsuperior; } //lectura del atributo
            set { nombredelsuperior = value; } //escritura del atributo
        }
        public string PuestodeTrabajo
        {
            get { return puestodetrabajo; }
            set { puestodetrabajo = value; }
        }
        public int HoradeIngreso
        {
            get { return horadeingreso; }
            set { horadeingreso = value; }
        }
        public string LocaldelTrabajo
        {
            get { return this.localdeltrabajo; }
            set { this.localdeltrabajo = value; }
        }
        //métodos u operaciones
        public string DesarrollarHabilidades()
        {
            return "no se ha implementado el metodo Desarrollar Habilidades";
        }
        public string FortalecerFormacionAcadémica()
        {
            return "no se ha implementado el método FortalecerFormacionAcadémica";
        }
        public string RenovarContrato()
        {
            return "no se ha implementado el método RenovarContrato";
        }
    }
}
