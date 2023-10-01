using System;
using System.Collections.Generic;

namespace Mascotteria.Model;

public partial class PagoProveedor
{
    public int IdPago { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? MedioPago { get; set; }

    public decimal? Monto { get; set; }

    public int? IdProveedor { get; set; }

    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
