using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Profile
{
    public int Id { get; set; }

    public string Profile1 { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
