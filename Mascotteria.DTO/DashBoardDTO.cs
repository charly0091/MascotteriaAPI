﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotteria.DTO
{
    public class DashBoardDTO
    {
        public int TotalVentas { get; set; }
        public string? TotalIngresos { get; set; }
        public List<VentaSemanaDTO>? VentasUltimaSemana { get; set; }
    }
}