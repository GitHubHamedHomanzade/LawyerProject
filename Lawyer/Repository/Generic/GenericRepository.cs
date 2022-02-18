
using Lawyer.Context;
using Lawyer.Models.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer.Generic.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseClass
    {



        #region constractor

        private MyContext _context;
        private DbSet<TEntity> dbSet;

        public GenericRepository(MyContext context)
        {
            _context = context;
            this.dbSet = this._context.Set<TEntity>();
        }
        #endregion
        public async Task AddEntity(TEntity entity)
        {
            entity.LastUpDate = DateTime.Now;
            await dbSet.AddAsync(entity);
        }


        public IQueryable<TEntity> GetEntitiesQuery()
        {
            return dbSet.AsQueryable();
        }

        public async Task<TEntity> GetEntityById(Guid entityId)
        {
            return await dbSet.SingleOrDefaultAsync(e => e.Id == entityId);
        }

        public void RemoveEntity(TEntity entity)
        {
            entity.IsActive = false;
            UpdateEntity(entity);
        }

        public async Task RemoveEntityById(Guid entityId)
        {
            var entity = await GetEntityById(entityId);
            RemoveEntity(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateEntity(TEntity entity)
        {
            entity.LastUpDate = DateTime.Now;
            dbSet.Update(entity);
        }




        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}
