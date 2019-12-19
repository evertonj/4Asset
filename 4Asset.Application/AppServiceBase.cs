using FourAsset.Application.Interfaces;
using FourAsset.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace FourAsset.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void AddRange(ICollection<TEntity> entities)
        {
            _serviceBase.AddRange(entities);
        }

        public ICollection<TEntity> GetAll()
        {
            return _serviceBase.GetAll().GetAwaiter().GetResult();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            _serviceBase.Dispose();
        }

        public int SaveChanges()
        {
            return _serviceBase.SaveChanges();
        }
    }
}
