 using Lawyer.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.Generic.Repository
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : BaseClass
    {
        IQueryable<TEntity> GetEntitiesQuery();

        Task<TEntity> GetEntityById(Guid entityId);

        Task AddEntity(TEntity entity);

        void UpdateEntity(TEntity entity);

        void RemoveEntity(TEntity entity);

        Task RemoveEntityById(Guid entityId);

        Task SaveChanges();


    }
}
