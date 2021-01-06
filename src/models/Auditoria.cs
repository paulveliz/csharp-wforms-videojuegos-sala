using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Auditoria
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public String Accion { get; set; }
        public String Usuario { get; set; }
        public int Estatus { get; set; }
    }
}
