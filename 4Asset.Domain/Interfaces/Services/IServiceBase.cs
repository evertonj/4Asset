using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FourAsset.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void AddRange(ICollection<TEntity> entities);
        TEntity GetById(int id);
        ICollection<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        int SaveChanges();
    }
}
