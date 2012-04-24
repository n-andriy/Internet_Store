using MobileStore.Models;
using MobileStore.Service.Interfaces;
using MobileStore.Service.Factory;
using MobileStore.Controllers.Abstract;

namespace MobileStore.Controllers
{
    public class ManufacturerController : BaseController<Manufacturer>
    {
        public ManufacturerController(IBaseService<Manufacturer> _service) : base(_service)
        {
        }

        public ManufacturerController() : this(ManufacturerServiceFactory.Create())
        {
        }
    }
}
