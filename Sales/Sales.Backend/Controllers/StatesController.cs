using Sales.Backend.Interfaces;
using Sales.Shared.Entities;

namespace Sales.Backend.Controllers
{
    public class StatesController : GenericController<State>
    {
        public StatesController(IGenericUnitOfWork<State> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
