using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class Attachment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AttachmentsPost> AttachmentsPosts { get; set; } = new List<AttachmentsPost>();
}
