using System;
using System.Collections.Generic;

namespace Mascotteria.Model;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public string? Nombre { get; set; }

    public decimal? Deuda { get; set; }

    public string? Cbu { get; set; }

    public string? Alias { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<PagoProveedor> PagoProveedores { get; set; } = new List<PagoProveedor>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
