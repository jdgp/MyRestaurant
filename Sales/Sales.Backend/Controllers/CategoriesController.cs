using Sales.Backend.Interfaces;
using Sales.Shared.Entities;

namespace Sales.Backend.Controllers
{
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
        {
        }
    }
}