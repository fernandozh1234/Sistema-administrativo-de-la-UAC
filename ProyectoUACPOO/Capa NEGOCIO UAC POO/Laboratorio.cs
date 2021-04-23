using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_NEGOCIO_UAC_POO
{
    public class Laboratorio
    {
        //atributos
        private string herramientas;
        private string capacidad;
        private string muestras;
        private string docente;

        //porpiedades
        public string Herramientas
        {
            get { return herramientas; } //lectura del atributo
            set { herramientas = value; } //escritura del atributo
        }
        public string Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string Muestras
        {
            get { return muestras; }
            set { muestras = value; }
        }
        public string Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }
        //métodos u operaciones
        public string Observar()
        {
            return "no se ha implementado el metodo observar";
        }
        public string Analizar()
        {
            return "no se ha implementado el metodo analizar";
        }
        public string Conclusiones()
        {
            return "no se ha implementado el metodo conclusiones";
        }
    }
}
