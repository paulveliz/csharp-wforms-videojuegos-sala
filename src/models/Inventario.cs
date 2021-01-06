using models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Inventario
    {
        public int Id { get; set; }
        public videojuegos Videojuego { get; set; }
        public int Existencias { get; set; }
        public int Estatus { get; set; }
    }
}
