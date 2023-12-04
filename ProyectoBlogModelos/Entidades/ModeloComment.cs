using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloComment
    {
        public int Id { get; set; }

        public int Post { get; set; }

        public string? Message { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
        public ModeloComment()
        {
            
        }
    }
}
