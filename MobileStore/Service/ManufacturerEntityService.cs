using System.Data.Objects;
using System.Linq;
using MobileStore.Models;
using MobileStore.Service.Abstract;

namespace MobileStore.Service
{
    public class ManufacturerEntityService : BaseEntityService<Manufacturer>
    {
        private readonly MobileDbEntities _entities = new MobileDbEntities();

        protected override ObjectSet<Manufacturer> EntitySet
        {
            get { return _entities.Manufacturers; }
        }
    }
}