﻿using System;
using System.Data.Entity;
using System.Linq;

namespace module_05
{
    public class Sqlrepository<T> : IRepository<T> where T : class
    {
        private DbContext _ctx;
        private DbSet<T> _set;

        public Sqlrepository(DbContext ctx)
        {
            _ctx = ctx;
            _set = _ctx.Set<T>();
        }

        public void Add(T newEntity)
        {
            _set.Add(newEntity);
        }

        public void Delete(T newEntity)
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}