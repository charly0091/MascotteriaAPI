using System;
using System.Collections.Generic;

namespace Mascotteria.Model;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdMarca { get; set; }

    public int? IdProveedor { get; set; }

    public int? Stock { get; set; }

    public decimal? Precio { get; set; }

    public decimal? PesoBolsa { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
