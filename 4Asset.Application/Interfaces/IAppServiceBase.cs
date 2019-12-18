using System.Collections.Generic;

namespace _4Asset.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
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
