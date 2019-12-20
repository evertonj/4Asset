using FourAsset.Domain.Interfaces.Repositories;
using FourAsset.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FourAsset.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
        }

        public void AddRange(ICollection<TEntity> entities)
        {
            _repositoryBase.AddRange(entities);
        }

        public ICollection<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }

        public int SaveChanges()
        {
            return _repositoryBase.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _repositoryBase.Dispose();
        }

    }
}
