using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? Status { get; set; }

    public int Profile { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual Profile ProfileNavigation { get; set; } = null!;

    public virtual Userinfo? Userinfo { get; set; }
}
