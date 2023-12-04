using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogModelos.Entidades
{
    public class ModeloAttachmentsPost
    {
        public int Id { get; set; }

        public int Post { get; set; }

        public int Attachment { get; set; }
        public ModeloAttachmentsPost()
        {
                
        }
    }
}
