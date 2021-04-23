using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_NEGOCIO_UAC_POO
{
    public class Asignatura
    {
        //atributos
        private string nombrecurso;
        private string facultad;
        private int horario;
        private string docente;

        //porpiedades
        public string NombreCurso
        {
            get { return nombrecurso; } //lectura del atributo
            set { nombrecurso = value; } //escritura del atributo
        }
        public string Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        public int Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }
        //métodos u operaciones
        public string Enseñar()
        {
            return "no se ha implementado el metodo enseñar";
        }
        public string Explicar()
        {
            return "no se ha implementado el metodo explicar";
        }
        public string Asistencia()
        {
            return "no se ha implementado el metodo asistencia";
        }
    }
}
