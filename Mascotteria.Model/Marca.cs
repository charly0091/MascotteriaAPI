﻿using System;
using System.Collections.Generic;

namespace Mascotteria.Model;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
