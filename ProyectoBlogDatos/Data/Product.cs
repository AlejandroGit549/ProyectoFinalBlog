using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double PurchasePrice { get; set; }

    public double UnitPrice { get; set; }

    public int MinStock { get; set; }

    public int MaxStock { get; set; }

    public int Stock { get; set; }

    public string? Dimensions { get; set; }

    public double? Weigth { get; set; }

    public string? Observation { get; set; }

    public byte? Status { get; set; }

    public int Category { get; set; }

    public bool? Discontinued { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Category CategoryNavigation { get; set; } = null!;
}
