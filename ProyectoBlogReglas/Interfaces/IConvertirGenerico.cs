using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogReglas.Interfaces
{
    public interface IConvertirGenerico<T,M> where T : class
    {
        M Convert(T obj);
    }
}
