using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Opcion1EmanuelBarreto
{
    public class Recepcion
    {
        public String nroRemitoCliente { get; set; }
        public int cuit { get; set; }
        public String codProducto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public int nroCaja { get; set; }
    }
}
