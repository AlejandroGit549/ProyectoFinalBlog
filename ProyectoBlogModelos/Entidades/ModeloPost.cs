using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloPost
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
        public virtual ICollection<ModeloAttachmentsPost> AttachmentsPosts { get; set; } = new List<ModeloAttachmentsPost>();
        public virtual ICollection<ModeloComment> Comments { get; set; } = new List<ModeloComment>();
        public ModeloPost()
        {
            
        }

    }
}
