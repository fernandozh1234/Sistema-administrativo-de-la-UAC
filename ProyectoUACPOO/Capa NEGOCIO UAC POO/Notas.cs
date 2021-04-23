using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_NEGOCIO_UAC_POO
{
    public class Notas
    {
        //atributos
        private int unidad1;
        private int unidad2;
        private int unidad3;
        private int ponderado;
        //porpiedades
        public int Unidad1
        {
            get { return unidad1; } //lectura del atributo
            set { unidad1 = value; } //escritura del atributo
        }
        public int Unidad2
        {
            get { return unidad2; }
            set { unidad2 = value; }
        }
        public int Unidad3
        {
            get { return unidad3; }
            set { unidad3 = value; }
        }
        public int Ponderado
        {
            get { return this.ponderado; }
            set { this.ponderado = value; }
        }
        //métodos u operaciones
        public string SubirNota()
        {
            return "no se ha implementado el metodo Subir Nota";
        }
        public string BajarNota()
        {
            return "no se ha implementado Bajar Nota";
        }
        public string AprobarSemestre()
        {
            return "no se ha implementado aprobar semestre";
        }
    }

}
