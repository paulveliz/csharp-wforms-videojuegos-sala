using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos.reportes.modelos
{
    public class Inventario
    {
        public int Id { get; set; }
        public string Videojuego { get; set; }
        public int Existencias { get; set; }
        public int Estatus { get; set; }
    }
}
