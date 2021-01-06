using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class FullRenta
    {
        public Renta Renta { get; set; }
        public List<RentaDetalle> Detalles { get; set; }
        public FullRenta(Renta renta, List<RentaDetalle> detalles)
        {
            this.Renta = renta;
            this.Detalles = detalles;
        }
    }
}
