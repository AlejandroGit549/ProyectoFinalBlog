using ProyectoBlogModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogReglas.Interfaces
{
    public interface IOperacionesBasicas<in T> where T : class
    {
        ModeloRespuesta GetAll();
        ModeloRespuesta Get(int Id);
        ModeloRespuesta Update(T data);
        ModeloRespuesta Delete(T data);
        ModeloRespuesta Add(T data);
        ModeloRespuesta GetAll(dynamic filters);
    }
}
