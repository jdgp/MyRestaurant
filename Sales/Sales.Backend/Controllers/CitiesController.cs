using Sales.Backend.Interfaces;
using Sales.Shared.Entities;

namespace Sales.Backend.Controllers
{
    public class CitiesController : GenericController<City>
    {
        public CitiesController(IGenericUnitOfWork<City> unitOfWork) : base(unitOfWork)
        {
        }
    }
}