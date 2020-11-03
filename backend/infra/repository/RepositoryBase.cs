using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain.interfaces.irepository;
using infra.context;

namespace infra.repository
{
    public abstract class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected RepositoryContext Context { get; set; }
        public RepositoryBase(RepositoryContext Context)
        {
            this.Context = Context;
        }

        public async Task<T> AddAsync(T obj)
        {
            Context.Set<T>().Add(obj);
            await Context.SaveChangesAsync();

            return obj;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public virtual T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }
    }
}