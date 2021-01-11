﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuegos.reportes.modelos
{
    public class RentaOficial
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public String Usuario { get; set; }
        public String Cliente { get; set; }
        public decimal Total { get; set; }
        public int Estatus { get; set; }
    }
}
