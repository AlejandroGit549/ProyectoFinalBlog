using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloUser
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public bool? Status { get; set; }

        public int Profile { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<ModeloPost> Posts { get; set; } = new List<ModeloPost>();
    }
}
