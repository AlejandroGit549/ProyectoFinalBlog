using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloCategory
    {
        public int Id { get; set; }

        public string Category1 { get; set; } = null!;

        public string? Description { get; set; }

        public bool? Status { get; set; }
        public ModeloCategory()
        {
                
        }
    }
}
