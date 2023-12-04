using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Comment
{
    public int Id { get; set; }

    public int Post { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Post PostNavigation { get; set; } = null!;
}
