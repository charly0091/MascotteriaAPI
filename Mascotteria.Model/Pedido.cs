using System;
using System.Collections.Generic;

namespace Mascotteria.Model;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public string? NumeroFactura { get; set; }

    public int? IdProveedor { get; set; }

    public DateTime? FechaPedido { get; set; }

    public decimal? Total { get; set; }

    public decimal? CantidadPagada { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
