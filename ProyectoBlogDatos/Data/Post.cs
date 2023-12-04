using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Post
{
    public int Id { get; set; }

    public int Category { get; set; }

    public int Autor { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public bool? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<AttachmentsPost> AttachmentsPosts { get; set; } = new List<AttachmentsPost>();

    public virtual User AutorNavigation { get; set; } = null!;

    public virtual Category CategoryNavigation { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
