using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloProfile
    {
        public int Id { get; set; }

        public string Profile1 { get; set; } = null!;

        public string? Description { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<ModeloUser> Users { get; set; } = new List<ModeloUser>();
    }
}
