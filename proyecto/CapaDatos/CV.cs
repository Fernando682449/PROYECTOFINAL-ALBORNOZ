using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CV
    {
        public int ID_CV { get; set; }
        public int ID_ASOCIADO { get; set; }
        public string Ruta_CV { get; set; }
        public DateTime Fecha_Subida { get; set; }
        public string Experiencia_Profesional { get; set; }
        public string Educacion { get; set; }
        public string Habilidades { get; set; }
    }
}
