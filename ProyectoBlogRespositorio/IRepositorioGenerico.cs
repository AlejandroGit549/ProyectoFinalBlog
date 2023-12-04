﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogRespositorio
{
    public interface IRepositorioGenerico<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity? Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        void Save();
    }
}