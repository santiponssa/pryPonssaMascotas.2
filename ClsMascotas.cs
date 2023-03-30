using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPonssaMascotas._2
{
    internal class ClsMascotas
    {
        // Características
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public Int32 Peso { get; set; }
        public string Sexo { get; set; }
        public Int32 Edad { get; set;}
        public string HistoriaClinica { get; set; }
        
        // Métodos
        public string ObtenerDatos()
        {
            return Nombre + " " + Especie + " " + Peso + " " +
                   Sexo + " " + Edad + " " + HistoriaClinica;
        }
         
    }
}
