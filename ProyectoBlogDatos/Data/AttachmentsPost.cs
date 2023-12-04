using System;
using System.Collections.Generic;

namespace ProyectoBlogDatos.Data;

public partial class AttachmentsPost
{
    public int Id { get; set; }

    public int Post { get; set; }

    public int Attachment { get; set; }

    public virtual Attachment AttachmentNavigation { get; set; } = null!;

    public virtual Post PostNavigation { get; set; } = null!;
}
