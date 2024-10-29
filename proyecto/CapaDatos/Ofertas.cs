using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Ofertas
    {
        public int ID_OFERTA { get; set; }
        public int ID_ASOCIADO { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Publicacion { get; set; }
        public string Estado { get; set; }
        public string Tipo_Oferta { get; set; }
    }
}
