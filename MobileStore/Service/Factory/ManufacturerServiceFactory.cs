using MobileStore.Models;
using MobileStore.Service.Interfaces;

namespace MobileStore.Service.Factory
{
    public static class ManufacturerServiceFactory
    {
        public static IBaseService<Manufacturer> Create()
        {
            return new ManufacturerEntityService();
        }
    }
}