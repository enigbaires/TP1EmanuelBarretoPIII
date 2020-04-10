using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Opcion1EmanuelBarreto
{
    public class Empleado : Persona
    {
        public int legajo { get; set; }
        public String cargo { get; set; }
        public String mail { get; set; }
        public int nroDeposito { get; set; }
        public int jefe { get; set; }
    }
}
