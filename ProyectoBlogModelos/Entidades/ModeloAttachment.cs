using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloAttachment
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Url { get; set; } = null!;

        public string? Description { get; set; }
        public List<ModeloAttachmentsPost> AttachmentsPosts { get; set; } = new List<ModeloAttachmentsPost>();
        public ModeloAttachment()
        {
                
        }

    }
}
