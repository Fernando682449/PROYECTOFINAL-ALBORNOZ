using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Tarea
    {
        public int Id { get; set; }
        public DateTime fecha_inicio { get; set; }
        public string Detalle { get; set; }
        public int Puntos { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public int IdCurso { get; set; }
    }
}
