﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class , IEntity ,new()
    {
        // isterse filtre verebilir vermesse hepsi gelir
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Uptade(T entity);
        void Delete(T entity);
    }
}
