using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Eventos
    {
        public int ID_EVENTO { get; set; }
        public int ID_ASOCIADO { get; set; }
        public string Nombre_Evento { get; set; }
        public DateTime Fecha_Evento { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string Estado_Evento { get; set; }
    }
}
