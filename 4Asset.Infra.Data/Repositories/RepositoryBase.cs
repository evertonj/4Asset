using _4Asset.Domain.Interfaces.Repositories;
using _4Asset.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _4Asset.Infra.Data.Repositories
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

        public async Task<ICollection<TEntity>> GetAll()
        {
            return await Db.Set<TEntity>().ToListAsync();
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
