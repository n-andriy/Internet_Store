using System.Data.Objects;
using System.Linq;
using MobileStore.Service.Interfaces;
using MobileStore.Models.Interfaces;

namespace MobileStore.Service.Abstract
{
    public abstract class BaseEntityService<T> : IBaseService<T> where T : class, IBase, new()
    {
        // Entity Framework object
        protected abstract ObjectSet<T> EntitySet { get; }
        
        public virtual IQueryable<T> Get()
        {
            return from obj in EntitySet select obj;
        }

        public virtual T Get(int id)
        {
            return (from obj in EntitySet where obj.ID == id select obj).FirstOrDefault();
        }

        public virtual IQueryable<T> Get(int skip, int take)
        {
            return Get().Skip(skip).Take(take);
        }

        public virtual void Add(T dataObject)
        {
            EntitySet.AddObject(dataObject);
        }

        public virtual void Delete(T dataObject)
        {
            EntitySet.DeleteObject(dataObject);
        }

        public void Save()
        {
            EntitySet.Context.SaveChanges();
        }
    }
}