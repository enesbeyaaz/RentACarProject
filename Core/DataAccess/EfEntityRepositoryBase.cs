using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity,Tcontext>
        where TEntity:class, IEntity, new()
        where Tcontext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addedCar = context.Entry(entity);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);


            }
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
