using FourAsset.Domain.Interfaces.Repositories;
using FourAsset.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourAsset.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly FourAssetContext Db = new FourAssetContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void AddRange(ICollection<TEntity> entities)
        {
            Db.Set<TEntity>().AddRange(entities);
            Db.SaveChanges();
        }

        public ICollection<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            var dbSet = Db.Set<TEntity>();
            dbSet.Attach(obj);
            dbSet.Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            var dbSet = Db.Set<TEntity>();
            dbSet.Attach(obj);
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Db.Dispose();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
