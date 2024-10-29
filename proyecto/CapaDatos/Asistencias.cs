using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Asistencias
    {
        public int ID_ASISTENCIA { get; set; }
        public int ID_EVENTO { get; set; }
        public int ID_ASOCIADO { get; set; }
        public bool Confirmado { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
