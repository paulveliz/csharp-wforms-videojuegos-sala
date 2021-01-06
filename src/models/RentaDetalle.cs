using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class RentaDetalle
    {
        public int Id { get; set; }
        public int RentaId { get; set; }
        public String Videojuego { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public int Estatus { get; set; }
    }
}
