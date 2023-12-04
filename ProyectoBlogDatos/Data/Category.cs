using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Category
{
    public int Id { get; set; }

    public string Category1 { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
