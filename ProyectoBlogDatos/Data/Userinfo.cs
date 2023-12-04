using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Userinfo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string? Photo { get; set; }

    public string? Bio { get; set; }

    public string? Website { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual User IdNavigation { get; set; } = null!;
}
