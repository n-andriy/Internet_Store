using System.Linq;
using MobileStore.Models.Interfaces;

namespace MobileStore.Service.Interfaces
{
    public interface IBaseService<T> where T : class, IBase, new()
    {
        // Get all records from DB
        IQueryable<T> Get();

        // Get one record using ID
        T Get(int id);

        // Get several records
        IQueryable<T> Get(int skip, int take);

        // Add record 
        void Add(T dataObject);

        // Delete record
        void Delete(T dataObject);

        // Save changes
        void Save();
    }
}