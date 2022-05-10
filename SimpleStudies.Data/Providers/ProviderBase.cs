using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleStudies.Data.Entities;

namespace SimpleStudies.Data.Providers
{
    public abstract class ProviderBase<TEntity>
        where TEntity : class, IEntity
    {
        public virtual void Add(TEntity entry)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                context.Set<TEntity>().Add(entry);
                context.SaveChanges();
            }
        }

        public virtual void Delete(int id)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                context.Set<TEntity>().Remove(context.Set<TEntity>().FirstOrDefault(f => f.Id == id));

                context.SaveChanges();
            }
        }

        public virtual TEntity Get(int id)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                return context.Set<TEntity>().FirstOrDefault(f => f.Id == id);
            }
        }
    }
}
