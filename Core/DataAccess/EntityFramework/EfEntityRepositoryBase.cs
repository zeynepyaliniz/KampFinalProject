using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContextEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContextEntity : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //garbage collector'da siliniyor. IDisposable pattern implementation.
            using (TContextEntity context = new TContextEntity())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }


        }

        public void Delete(TEntity entity)
        {
            using (TContextEntity context = new TContextEntity())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContextEntity context = new TContextEntity())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContextEntity context = new TContextEntity())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }

        }

        public List<TEntity> GetAllByCategory(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContextEntity context = new TContextEntity())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContextEntity context = new TContextEntity())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
