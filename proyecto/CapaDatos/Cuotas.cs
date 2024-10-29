using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cuotas
    {
        public int ID_CUOTA { get; set; }
        public int ID_ASOCIADO { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public string Estado { get; set; }
        public string Metodo_Pago { get; set; }
    }
}
